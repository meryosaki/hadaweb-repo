<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="mipasseditar.aspx.cs" Inherits="WebApplication1.mipasseditar" EnableEventValidation="false"%>
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
                                       <strong>Actualmente tu contraseña tienes una contraseña asignada.</strong><p></p>
                                       <li class="password">
										<label><strong>Introduce tu contraseña actual</strong><em>*</em></label>
										<input type="password" name="logonPassword" id="register-password" maxLength="15" />
									   </li>
                                       <li class="password-repeat">
										<label><strong>Introduce tu nueva contraseña</strong><em>*</em></label>
										<input type="password" name="logonPasswordVerify"  id="register-password-confirm" maxLength="15" />
									   </li>
                                       <li class="password-repeat">
										<label><strong>Repite tu nueva contraseña</strong><em>*</em></label>
										<input type="password" name="logonPasswordVerify"  id="Password1" maxLength="15" />
									   </li>
								</ul>
								<a href="misdatos.aspx" class="button">Aceptar</a>   <a href="misdatos.aspx" class="button">Cancelar</a>

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
