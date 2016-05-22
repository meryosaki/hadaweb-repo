<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" 
    CodeBehind="misdatoseditar.aspx.cs" Inherits="WebApplication1.misdatoseditar" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="extra">
						<div class="container">
                            <ul class="style">
								<h3>Editar mis datos</h3>
                                <hr size="4px" width="100%" align="center" color="white"/>
							</ul>
							<div class="row no-collapse-1">
                            <p></p><p></p>
<style>
.box-white {
margin:20 20 20px;
overflow:hidden;
padding:30px;
background: white;
-webkit-border-radius: 100px;
border-radius: 5px;
}</style>
                            <p></p>
                            <div align="center">
                            <img src="images/avatar.png" alt="" />
                            <p></p>
                              
                            <form enctype="multipart/form-data" action="" method="POST">
                            <asp:FileUpload ID="SubirArchivo" runat="server" />
                                <br />
                                <asp:Button ID="BotonSubir" runat="server" Text="Subir Archivo!" OnClick="ConfirmarArchivo" />
                              
</form>
                                  <asp:Label ID="ArchivoSubido" runat="server" visible="False"></asp:Label>
                            <p></p>
                            </div>
                            <p></p>
                            <div class="box-white">
                            <fieldset class="box">
                            
								<ul align="left"><h2>MIS DATOS</h2><p></p>
                                <hr size="4px" width="100%" align="center" color="gray"/>
									<input type="hidden" name="accountType" value="private" />
									<li>
										<span><strong>Género</strong></span>
                                        <p>
										<label>
											<input type="radio" id="tqa_register_personTitleMr" name="personTitle" value="Mr"  /> Hombre
										</label>
										<label>
											<input type="radio" id="tqa_register_personTitleMrs" name="personTitle" value="Mrs"  /> Mujer
										</label></p>
									</li><p></p><li>
										<label><strong>Nick</strong></label>
                                        <asp:TextBox ID="Nick" runat="server"></asp:TextBox>
                                        <asp:CustomValidator  ID="CustomValidatorNick"  
                                            ControlToValidate = "Nick" 
                                            OnServerValidate="ComprobarUsuario" runat="server"          
                                            ErrorMessage="Este nick ya existe"
                                            ForeColor ="Red">         
                                        </asp:CustomValidator>
									</li><li>
										<label><strong>Nombre completo</strong></label>
                                        <asp:TextBox ID="Nombre" runat="server"></asp:TextBox>
									</li><li>
										<label><strong>Dirección de E-mail</strong></label>
                                        <asp:TextBox ID="Email" runat="server"></asp:TextBox>
									</li>
								</ul>
            
                                <asp:Button ID="Button1" runat="server" Text="Confirmar cambios" OnClick ="Confirmar" />



							</fieldset></div>

             <p></p>
                           
						</div> <p></p> <div><hr size="4px" width="100%" align="center" color="white"/></div>
					</div>
			</div>

								<!-- Main -->
					<div align="justify" id="main">
						<div class="container">
							<div class="row"> 
								
								<!-- Content -->
								<div class="6u">
									<section>
										<ul class="style">
											<li class="fa fa-question-circle">
												<h3><a href="quienes.aspx">Quiénes somos</a></h3>
												<span>Descubre a los creadores de esta website.</span> </li>
											<li class="fa fa-shopping-cart">
												<h3><a href="comocomprar.aspx">Cómo comprar</a></h3>
												<span>¿Dudas de como comprar? ¡Aquí te enseñamos como!</span> </li>
										</ul>
									</section>
								</div>
								<div class="6u">
									<section>
										<ul class="style">
											<li class="fa fa-mobile-phone">
												<h3><a href="contacto.aspx">Aviso legal y privacidad</a></h3>
												<span>Infórmate sobre nuestro aviso legal y la privacidad de nuestra web.</span> </li>
											<li class="fa fa-star">
												<h3><a href="ofertas.aspx">Ofertas</a></h3>
												<span>¿Buscas ofertas?¡Aquí encontrarás los mejores packs!</span> </li>
										</ul>
									</section>
								</div>
							</div>
						</div>
					</div>

	</div>

	
</asp:Content>
