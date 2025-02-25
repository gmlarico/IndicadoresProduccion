Imports System.Web
Imports System.Web.Optimization


Public Class BundleConfig
    ' For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
    Public Shared Sub RegisterBundles(ByVal bundles As BundleCollection)
        bundles.IgnoreList.Clear()

        '************************************ CSS ************************************/
        ' Specials
        bundles.Add(New StyleBundle("~/content/specials/css").Include(
                    "~/Content/Specials/Select2/select2.css",
                    "~/Content/Specials/Select2/select2Bootstrap.css",
                    "~/Content/Specials/Dropzone/basic.css",
                    "~/Content/Specials/Dropzone/dropzone.css"))

        ' Base
        bundles.Add(New StyleBundle("~/content/css").Include(
                    "~/Content/codebase.css",
                    "~/Content/main.css",
                    "~/Content/jquery-ui.css"))

        ' Plugins
        bundles.Add(New StyleBundle("~/content/plugins/css").Include(
                    "~/Content/Plugins/Datepicker3.css",
                    "~/Content/Plugins/Datetimepicker.css",
                    "~/Content/plugins/dataTables.bootstrap4.css",
                    "~/Content/Plugins/Dialog.css",
                    "~/Content/Plugins/ProgressBar.css",
                    "~/Content/Plugins/SlickGrid.css",
                    "~/Content/Plugins/Sweetalert2.css",
                    "~/Content/Plugins/Nestable.css"))

        'bundles.Add(New StyleBundle("~/content/plugins/css").Include(
        '            "~/Content/Plugins/Datepicker3.css",
        '            "~/Content/Plugins/Datetimepicker.css",
        '            "~/Content/Plugins/Dialog.css",
        '            "~/Content/Plugins/ProgressBar.css",
        '            "~/Content/Plugins/SlickGrid.css",
        '            "~/Content/Plugins/Sweetalert2.css"
        '            ))
        '"~/Content/Plugins/jquery.nestable.min.css"

        '************************************ JQUERY ************************************/

        ' Core
        bundles.Add(New ScriptBundle("~/bundles/core").Include(
                    "~/Scripts/Core/jquery.js",
                    "~/Scripts/Core/jquery-ui.js",
                    "~/Scripts/Core/bootstrap.bundle.js",
                    "~/Scripts/Core/jquery.slimscroll.js",
                    "~/Scripts/Core/jquery.scrollLock.js",
                    "~/Scripts/Core/jquery.appear.js",
                    "~/Scripts/Core/jquery.countTo.js",
                    "~/Scripts/Core/jquery.event.drag-2.3.0.js",
                    "~/Scripts/Core/js.cookie.js",
                    "~/Scripts/Core/jquery.browser.js",
                    "~/Scripts/Core/codebase.js",
                    "~/Scripts/Core/moment.js",
                    "~/Scripts/master.js",
                    "~/Scripts/ns.js"))

        ' Plugins
        bundles.Add(New ScriptBundle("~/bundles/plugins").Include(
                    "~/Scripts/Plugins/Datepicker/jquery.bootstrap.datepicker.js",
                    "~/Scripts/Plugins/Datepicker/jquery.bootstrap.datetimepicker.js",
                    "~/Scripts/Plugins/Datepicker/locales/*.js",
                    "~/Scripts/Plugins/Dropzone/dropzone.js",
                    "~/Scripts/Plugins/Knockout/knockout.js",
                    "~/Scripts/Plugins/Select2/select2.full.js",
                    "~/Scripts/Plugins/Select2/i18n/*.js",
                    "~/Scripts/Plugins/SlickGrid/firebugx.js",
                    "~/Scripts/Plugins/SlickGrid/slick.*",
                    "~/Scripts/Plugins/Sweetalert2/sweetalert2.js",
                    "~/Scripts/Plugins/Validation/jquery.validate.js",
                    "~/Scripts/Plugins/Validation/localization/*.js",
                    "~/Scripts/Plugins/Wizard/jquery.bootstrap.wizard.js",
                    "~/Scripts/pages/be_comp_nestable.min.js"
                    ))

        ' Components
        bundles.Add(New ScriptBundle("~/bundles/components").Include(
                    "~/Scripts/Components/AjaxUtil/ajaxUtil.js",
                    "~/Scripts/Components/Calendar/calendar.js",
                    "~/Scripts/Components/Dialog/dialog.js",
                    "~/Scripts/Components/Grid/grid.js",
                    "~/Scripts/Components/Message/message.js",
                    "~/Scripts/Components/ProgressBar/progressBar.js",
                    "~/Scripts/Components/Storage/storage.js",
                    "~/Scripts/Components/Date/moment.js",
                    "~/Scripts/Components/Validator/validator.js"))

        '"~/Scripts/Components/Grid2/be_tables_datatables.js",
        '            "~/Scripts/Components/Grid2/be_tables_datatables.min.js",

        ' Components externos
        bundles.Add(New ScriptBundle("~/bundles/componentsExtern").Include(
                      "~/Scripts/Plugins/datatables/jquery.dataTables.min.js",
                      "~/Scripts/Plugins/datatables/dataTables.bootstrap4.min.js",
                      "~/Scripts/Plugins/nestable2/jquery.nestable.js",
                      "~/Scripts/Plugins/datatables/be_tables_datatables.min.js"))

        '----------------------------------------------------------------------------

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                   "~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryui").Include(
                    "~/Scripts/jquery-ui-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.unobtrusive*",
                    "~/Scripts/jquery.validate*"))

        ' Use the development version of Modernizr to develop with and learn from. Then, when you're
        ' ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))

        'bundles.Add(New StyleBundle("~/Content/css").Include("~/Content/site.css"))

        'bundles.Add(New StyleBundle("~/Content/themes/base/css").Include(
        '            "~/Content/themes/base/jquery.ui.core.css",
        '            "~/Content/themes/base/jquery.ui.resizable.css",
        '            "~/Content/themes/base/jquery.ui.selectable.css",
        '            "~/Content/themes/base/jquery.ui.accordion.css",
        '            "~/Content/themes/base/jquery.ui.autocomplete.css",
        '            "~/Content/themes/base/jquery.ui.button.css",
        '            "~/Content/themes/base/jquery.ui.dialog.css",
        '            "~/Content/themes/base/jquery.ui.slider.css",
        '            "~/Content/themes/base/jquery.ui.tabs.css",
        '            "~/Content/themes/base/jquery.ui.datepicker.css",
        '            "~/Content/themes/base/jquery.ui.progressbar.css",
        '            "~/Content/themes/base/jquery.ui.theme.css"))
    End Sub
End Class

