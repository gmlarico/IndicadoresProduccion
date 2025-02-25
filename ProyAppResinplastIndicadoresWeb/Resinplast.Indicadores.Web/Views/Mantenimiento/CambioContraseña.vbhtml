@Code
    Layout = "~/Views/Shared/_MantenimientoLayout.vbhtml"
    'Layout = Nothing
End Code
<div class="bg-gd-emerald">
    <div class="hero-static content content-full bg-white invisible" data-toggle="appear">
        <!-- Header -->
        <div class="py-30 px-5 text-center">
            <a class="font-w700">
                <img class="img-avatar img-avatar96" src="@Url.Content("~/Imagenes/General/LOGO_RESI.png")" alt="" style="border-radius:11%">
              
            </a>
            <h1 class="h2 font-w700 mt-50 mb-10">Crear nueva contraseña</h1>
            <h2 class="h4 font-w400 text-muted mb-0">Por favor agregar detalles</h2>
        </div>
        <!-- END Header -->
        <!-- Sign Up Form -->
        <div class="row justify-content-center px-5">
            <div class="col-sm-8 col-md-6 col-xl-4">
      
                <form class="js-validation-signup" action="be_pages_auth_all.html" method="post">
                    
                    
                    <div class="form-group row">
                        <div class="col-12">
                            <div class="form-material floating">
                                <input type="password" class="form-control" id="txtPassword_1" name="signup-password" maxlength="15">
                                <label for="signup-password">Contraseña nueva</label>
                            </div>
                        </div>
                    </div>
                    <div class="form-group row">
                        <div class="col-12">
                            <div class="form-material floating">
                                <input type="password" class="form-control" id="txtPassword_2" name="signup-password-confirm" maxlength="15">
                                <label for="signup-password-confirm">Confirmar contraseña</label>
                            </div>
                        </div>
                    </div>
                    <div class="form-group row text-center">
                        <div class="col-12">
                            <label class="css-control css-control-primary css-checkbox">
                                <input type="checkbox" class="css-control-input" id="signup-terms" name="signup-terms" required>
                                <span class="css-control-indicator"></span>
                                Acepto los terminos y condiciones
                            </label>
                        </div>
                    </div>
                    
                    <div class="form-group row ">
                        <div class="col-12 mb-10">   
                                                
                            <button type="button" id="btnActualizar" class="btn btn-block btn-hero btn-noborder btn-rounded btn-alt-success">
                                <i class="si si-user-follow mr-10"></i> Procesar cambio de contraseña
                            </button>
                          
                        </div>
                        
                        
                    </div>
                </form>
            </div>
        </div>
        <!-- END Sign Up Form -->
    </div>
</div>

<script src="~/Scripts/View/Mantenimiento/CambioContraseña.js"></script>
