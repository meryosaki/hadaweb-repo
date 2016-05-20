﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="ofertas.aspx.cs" Inherits="WebApplication1.ofertas" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="extra">
						<div class="container">
                        <strong>Selecciona una categoría:</strong>
                        <select name="OS">
                           <option value="1">Estudios</option> 
                           <option value="2">Cocina</option> 
                           <option value="3">Ocio y cultura</option>
                           <option value="10">Deportes</option> 
                           <option value="11">Gabinete psicológico</option> 
                           <option value="12">Otros</option> 
                        </select>
                            <ul class="style">
								<h3>Ofertas</h3>
                                <hr size="4px" width="100%" align="center" color="white"/>
							</ul>
							<div class="row no-collapse-1">
								<section class="4u"> <a href="#" class="image featured"><img src="images/pack01.png" alt=""></a>
									<div class="box">
										<a href="oferta-buceonatacion.aspx" class="button">Buceo + Natación</a> </div>
								</section>
								<section class="4u"> <a href="#" class="image featured"><img src="images/pack02.png" alt=""></a>
									<div class="box">
										<a href="oferta-badminbalon.aspx" class="button">Bádminton + Balonmano</a> </div>
								</section>
								<section class="4u"> <a href="#" class="image featured"><img src="images/pack03.png" alt=""></a>
									<div class="box">
										<a href="oferta-matefisica.aspx" class="button">Matemáticas + Física</a> </div>
								</section>
							</div>
							<div class="row no-collapse-1">
								<section class="4u"> <a href="#" class="image featured"><img src="images/pack04.png" alt=""></a>
									<div class="box">
										<a href="oferta-biologiaquimica.aspx" class="button">Biología + Química</a> </div>
								</section>
								<section class="4u"> <a href="#" class="image featured"><img src="images/pack05.png" alt=""></a>
									<div class="box">
										<a href="oferta-ajedrezdamas.aspx" class="button">Ajedrez + Damas</a> </div>
								</section>
								<section class="4u"> <a href="#" class="image featured"><img src="images/pack06.png" alt=""></a>
									<div class="box">
										<a href="oferta-fotophotoshop.aspx" class="button">Photoshop + Fotografía</a> </div>
								</section>
							</div>
                            <p></p>
                            <hr size="4px" width="100%" align="center" color="white"/>
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
