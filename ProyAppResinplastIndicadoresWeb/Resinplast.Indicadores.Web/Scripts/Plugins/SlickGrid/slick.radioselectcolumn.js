(function ($) {
    // register namespace
    $.extend(true, window, {
        "Slick": {
            "RadioSelectColumn": RadioSelectColumn
        }
    });

    function RadioSelectColumn(options) {
        var _grid;
        var _self = this;
        var _handler = new Slick.EventHandler();
        var _selectedRowsLookup = {};
        var _defaults = {
            columnId: "_checkbox_selector",
            cssClass: null,
            toolTip: "Select/Deselect All",
            width: 30
        };
        var htmlRadioSuccess = "<label class='css-control css-control-sm css-control-success css-radio'><input type='radio' class='css-control-input' name='{0}'><span class='css-control-indicator'></span></label>";
        var htmlRadioSuccessChecked = "<label class='css-control css-control-sm css-control-success css-radio'><input type='radio' class='css-control-input' name='{0}' checked><span class='css-control-indicator'></span></label>";

        var _options = $.extend(true, {}, _defaults, options);

        function init(grid) {
            _grid = grid;
            _handler
              .subscribe(_grid.onSelectedRowsChanged, handleSelectedRowsChanged)
              .subscribe(_grid.onClick, handleClick)
              //.subscribe(_grid.onHeaderClick, handleHeaderClick)
              .subscribe(_grid.onKeyDown, handleKeyDown);
        }

        function destroy() {
            _handler.unsubscribeAll();
        }

        function handleSelectedRowsChanged(e, args) {
            var selectedRows = _grid.getSelectedRows();
            var lookup = {}, row, i;
            for (i = 0; i < selectedRows.length; i++) {
                row = selectedRows[i];
                lookup[row] = true;
                if (lookup[row] !== _selectedRowsLookup[row]) {
                    _grid.invalidateRow(row);
                    delete _selectedRowsLookup[row];
                }
            }

            for (i in _selectedRowsLookup) {
                _grid.invalidateRow(i);
            }

            _selectedRowsLookup = lookup;
            _grid.render();

            // if (selectedRows.length && selectedRows.length == _grid.getDataLength()) {
            //   _grid.updateColumnHeader(_options.columnId, "<input type='radio' name='row-select' checked='checked'>", _options.toolTip);
            // } else {
            //   _grid.updateColumnHeader(_options.columnId, "<input type='radio' name='row-select'>", _options.toolTip);
            // }
        }

        function handleKeyDown(e, args) {
            if (e.which == 32) {
                if (_grid.getColumns()[args.cell].id === _options.columnId) {
                    // if editing, try to commit
                    if (!_grid.getEditorLock().isActive() || _grid.getEditorLock().commitCurrentEdit()) {
                        toggleRowSelection(args.row);
                    }

                    e.preventDefault();
                    e.stopImmediatePropagation();
                }
            }
        }

        function handleClick(e, args) {
            // clicking on a row select checkbox
            if (_grid.getColumns()[args.cell].id === _options.columnId && $(e.target).is(":radio")) {
                // if editing, try to commit
                if (_grid.getEditorLock().isActive() && !_grid.getEditorLock().commitCurrentEdit()) {
                    e.preventDefault();
                    e.stopImmediatePropagation();
                    return;
                }

                toggleRowSelection(args.row);
                e.stopPropagation();
                e.stopImmediatePropagation();
            }
        }

        function toggleRowSelection(row) {
            _grid.setSelectedRows([row]);
            return true;
            // if (_selectedRowsLookup[row]) {
            //   _grid.setSelectedRows($.grep(_grid.getSelectedRows(), function (n) {
            //     return n != row
            //   }));
            // } else {
            //   _grid.setSelectedRows(_grid.getSelectedRows().concat(row));
            // }
        }

        function handleHeaderClick(e, args) {
            if (args.column.id == _options.columnId && $(e.target).is(":radio")) {
                // if editing, try to commit
                if (_grid.getEditorLock().isActive() && !_grid.getEditorLock().commitCurrentEdit()) {
                    e.preventDefault();
                    e.stopImmediatePropagation();
                    return;
                }

                if ($(e.target).is(":checked")) {
                    var rows = [];
                    for (var i = 0; i < _grid.getDataLength() ; i++) {
                        rows.push(i);
                    }
                    _grid.setSelectedRows(rows);
                } else {
                    _grid.setSelectedRows([]);
                }

                e.stopPropagation();
                e.stopImmediatePropagation();
            }
        }

        function getColumnDefinition() {
            return {
                id: _options.columnId,
                name: "",
                toolTip: _options.toolTip,
                field: "sel",
                width: _options.width,
                resizable: false,
                sortable: false,
                cssClass: _options.cssClass,
                formatter: checkboxSelectionFormatter
            };
        }

        function checkboxSelectionFormatter(row, cell, value, columnDef, dataContext) {
            if (dataContext) {
                var name = 'row-select-' + _grid.getContainerNode().id;
                //return _selectedRowsLookup[row]
                //    ? "<input style='cursor:pointer' type='radio' name='" + name + "' checked='checked'>"
                //    : "<input  style='cursor:pointer' type='radio' name='" + name + "'>";
                return _selectedRowsLookup[row] ? htmlRadioSuccessChecked.replace('{0}', name) : htmlRadioSuccess.replace('{0}', name)
            }
            return null;
        }

        $.extend(this, {
            "init": init,
            "destroy": destroy,
            "getColumnDefinition": getColumnDefinition
        });
    }
})(jQuery);