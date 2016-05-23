<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="WebApplication1.inicio" EnableEventValidation="false"%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="banner" class="container">
						<section align=left>

                                <p align=left>
					            <img src="images/meditation.png" width="150" height="150"/><h0>SERVIRENT</h0> 
                              
						</section>
					</div>

				<!-- Extra -->
					<div id="extra"></p>
						<div class="container">
                        <ul class="style">
                            </p>
								<h3>Buscador</h3>
							</ul>
                            <hr size="4px" width="100%" align="center" color="white"/>
                            <!-- <img src="images/separador01.png" alt="" /> -->
                            <p></p>
                            <style>
                            .resaltar{background-color:#FF0;}
                            </style> 
                            <!--Buscador-->
                            <asp:TextBox id="buscador" Text="" Width="1200px" runat="server" placeholder="Buscar"></asp:TextBox><p></p>                              
                            
                                <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem Selected="True" Value="Cursos"></asp:ListItem>
                                <asp:ListItem Value="Ofertas"></asp:ListItem>
                                </asp:DropDownList>
                                <p align="right">
                            <asp:Button runat="server" ID="Buton" Text="Buscar" OnClick="Buton_Click"/>
                                </p>
                            
                            <!-- hasta aqui-->
                            <!-- <img src="images/separador01.png" alt="" /> -->
                            <hr size="4px" width="100%" align="center" color="white"/>

                            <p></p>
							<ul class="style">
								<h3>Cursos</h3>
                                <hr size="4px" width="100%" align="center" color="white"/>
							</ul>
                            <!-- <img src="images/separador01.png" alt="" /> -->
                            <p></p>
							<div class="row no-collapse-1">
								<section class="4u"> <a href="curso-ajedrez.aspx" class="image featured"><img src="images/imagen01.jpg" alt=""></a>
									<div class="box">
										<a href="curso-ajedrez.aspx" class="button">Ajedrez</a> </div>
								</section>
								<section class="4u"> <a href="curso-photoshop.aspx" class="image featured"><img src="images/imagen02.jpg" alt=""></a>
									<div class="box">
										<a href="curso-photoshop.aspx" class="button">Photoshop</a> </div>
								</section>
								<section class="4u"> <a href="curso-balonmano.aspx" class="image featured"><img src="images/imagen03.jpg" alt=""></a>
									<div class="box">
										<a href="curso-balonmano.aspx" class="button">Balonmano</a> </div>
								</section>
							</div>
                            <p></p>
                            <p ALIGN=right>
                                <a href="cursos.aspx" class="button medium">Ver más</a>
                                <hr size="4px" width="100%" align="center" color="white"/>
                            </p>
                            <!-- <img src="images/separador01.png" alt="" /> -->
                            <p></p>
                            
							<ul class="style">
								<h3>Ofertas destacadas</h3>
                                <hr size="4px" width="100%" align="center" color="white"/>
							</ul>
                            
                            <!-- <img src="images/separador01.png" alt="" /> -->
                            
                            <p></p>
							<div class="row no-collapse-1">
								<section class="4u"> <a href="oferta-buceonatacion.aspx" class="image featured"><img src="images/pack01.png" alt=""></a>
									<div class="box">
										<a href="oferta-buceonatacion.aspx" class="button">Buceo + Natación</a> </div>
								</section>
								<section class="4u"> <a href="oferta-badminbalon.aspx" class="image featured"><img src="images/pack02.png" alt=""></a>
									<div class="box">
										<a href="oferta-badminbalon.aspx" class="button">Bádminton + Balonmano</a> </div>
								</section>
								<section class="4u"> <a href="oferta-matesfisica.aspx" class="image featured"><img src="images/pack03.png" alt=""></a>
									<div class="box">
										<a href="oferta-matesfisica.aspx" class="button">Matemáticas + Física</a> </div>
								</section>
							</div>
                            <p></p>
                           <p ALIGN=right>
                                <a href="ofertas.aspx" class="button medium">Ver más</a>
                                <hr size="4px" width="100%" align="center" color="white"/>
                            </p>
                            <!-- <img src="images/separador01.png" alt="" /> -->
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
