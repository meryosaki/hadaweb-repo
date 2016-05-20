<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="profesoradd.aspx.cs" Inherits="WebApplication1.profesoradd" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="extra">
						<div class="container">
                            <ul class="style">
								<h3>Nuevo curso</h3>
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
                            <p></p>
                            <div align="center">
                            <img src="images/avatar.png" alt="" />
                            <p></p>
                            <button class="button nopopup">Añadir imagen</button>
                            <p></p>
                            </div>
                            <p></p>
                            <div class="box-white">
                            <fieldset class="box">
                            
								<ul align="left"><h2>NUEVO CURSO</h2><p></p>
                                <hr size="4px" width="100%" align="center" color="gray"/>
									<input type="hidden" name="accountType" value="private" />
									<li>
										<span><strong>Categoría</strong> <em></em></span>
										<div class="cf">
											<label>
												<input type="radio" id="tqa_register_personTitleMr" name="personTitle" value="Mr"  /> Estudios
											</label>
											<label>
												<input type="radio" id="tqa_register_personTitleMrs" name="personTitle" value="Mrs"  /> Ocio y cultura
											</label>
                                            <label>
												<input type="radio" id="Radio1" name="personTitle" value="Mrs"  /> Deportes
											</label>
                                            <label>
												<input type="radio" id="Radio2" name="personTitle" value="Mrs"  /> Cocina
											</label>
                                            <label>
												<input type="radio" id="Radio3" name="personTitle" value="Mrs"  /> Gabinete psicológico
											</label>
                                            <label>
												<input type="radio" id="Radio4" name="personTitle" value="Mrs"  /> Otros
											</label>
										</div>
									</li><p></p><li>
										<label><strong>Nombre del curso</strong><em>*</em></label>
										<input type="text" name="firstName" id="Text1" value="" maxLength="50" />
									</li><li>
										<label><strong>Precio</strong><em>*</em></label>
										<input type="text" name="firstName" id="register-firstname" value="" maxLength="50" />
									</li><li>
										<label><strong>Duración</strong><em>*</em></label>
										<input type="text" name="firstName" id="Text2" value="" maxLength="50" />
									</li><li>
										<label><strong>Plazas totales</strong><em>*</em></label>
										<input type="text" name="firstName" id="Text3" value="" maxLength="50" />
									</li><li>
										<label><strong>Descripción</strong><em>*</em></label>
										<div class="row half">
							                <div class="12u">
								                <textarea name="message" id="Textarea1" placeholder="Escribe una descripción"></textarea>
							                </div>
						                </div>
									</li>
                                <button align="middle" class="button nopopup">Registrar</button>

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
