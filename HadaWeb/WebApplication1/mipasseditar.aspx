<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="mipasseditar.aspx.cs" Inherits="WebApplication1.mipasseditar" EnableEventValidation="false"%>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="extra">
						<div class="container">
                            <ul class="style">
								<h3>Cambiar contraseña</h3>
                                <hr size="4px" width="100%" align="center" color="white"/>
							</ul>
							<div class="row no-collapse-1">
                            <p></p>

                            <style>
                            .box-white {
                            margin:20 20 20px;
                            overflow:hidden;
                            padding:30px;
                            background: white;
                            -webkit-border-radius: 100px;
                            border-radius: 5px;
                            }</style>

                            <p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p>
                            
                            <div class="box-white">
                            <fieldset class="box">
                            
								<ul align="left"><h2>MI CONTRASEÑA</h2><p></p><font-size = "400">
                                <hr size="4px" width="100%" align="center" color="gray"/>
									<input type="hidden" name="accountType" value="private" />
									<li>
                                       <li class="password">
                                         <asp:Label ID="contrasenya" runat="server" Text="Contraseña actual" Font-Bold="true" ></asp:Label>
                                          <asp:TextBox ID="TextBoxContrasenya" runat="server" TextMode="Password" > </asp:TextBox>
                                        <asp:CustomValidator ID="CustomValidatorPass" 
                                            runat="server" 
                                            ErrorMessage="La contraseña actual no coincide"
                                            ControlToValidate ="TextBoxContrasenya" 
                                            ForeColor ="Red"
                                            OnServerValidate="ComprobarPass" >
                                       </asp:CustomValidator>
                                            

                                          
										</li>
                                       <li class="password-repeat">
										<asp:Label ID="contrasenyanueva1" runat="server" Text="Nueva contraseña" Font-Bold="true"></asp:Label>
                                          <asp:TextBox ID="TextBoxContrasenyaNueva1" runat="server" TextMode="Password"> </asp:TextBox>

                                           <asp:PasswordStrength ID="PasswordStrength1" runat="server" TargetControlID="TextBoxContrasenyaNueva1" 
                                               DisplayPosition="RightSide" StrengthIndicatorType="Text" PreferredPasswordLength="10" PrefixText="Nivel Seguridad :"
                                               TextStrengthDescriptions="Poco Seguro;Débilmente ;Medio ;Alto ;Excelente" BarBorderCssClass="style">

                                           </asp:PasswordStrength>

									   </li>
                                       <li class="password-repeat">
									<asp:Label ID="contrasenyanueva2" runat="server" Text="Nueva contraseña" Font-Bold="true"> </asp:Label>
                                          <asp:TextBox ID="TextBoxContrasenyaNueva2" runat="server" TextMode="Password"> </asp:TextBox>
									   </li>

                                        <asp:CompareValidator ID="ComparaContrasenya" runat="server" 
                                            ErrorMessage="Las contraseñas no coinciden"
                                            ControlToValidate="TextBoxContrasenyaNueva2"
                                            ControlToCompare="TextBoxContrasenyaNueva1"
                                            Operator="Equal"
                                            ForeColor ="Red">
                                        </asp:CompareValidator>
                                </ul>
                                <asp:Button ID="ButtonAceptar" runat="server" Text="Aceptar"  OnClick="Aceptar_OnClick" />
                                <asp:Button ID="ButtonCancelar" runat="server" Text="Cancelar" OnClick="Cancelar_OnClick" />

							</fieldset></div>

                           
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
												<h3><a href="avisolegal.aspx">Aviso legal y privacidad</a></h3>
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
