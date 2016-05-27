<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="comocomprar.aspx.cs" EnableEventValidation="false" Inherits="WebApplication1.comocomprar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<p></p>
            <div id="page" class="container">
                <div class="row">

                    <!-- Content -->
                    <div id="content" align="justify" class="8u skel-cell-important">
                        <section>
                            <header class="major">
                                <!-- Comienza la explicacion de como utilizar nuestra pagina web-->
                                <h2>Cómo comprar</h2>
                            </header><strong>
                            <p> Comprar en Servirent es muy sencillo. 
                            En primer lugar, para poder realizar cualquier compra en nuestra web, deberás estar registrado.
                            Para ello, debes hacer clic en el botón "Identifícate" que encontrarás en la parte 
                            superior derecha, menú en el cual podrás registrarte o bien, si ya eres usuario de nuestra página,
                            iniciar sesión.
                            <p><img width = "100%" align="middle" src="images/tutorial/04.png"/></p>
                            
                            Una vez creada tu cuenta, podrás hacer todos los pedidos 
                            que desees sin tener que introducir los datos cada vez. 
                            
                            Además, en tu panel 
                            tendrás acceso a tus facturas, a la tramitación de incidencias, devoluciones y 
                            atención al cliente.
                            
                            Así pues, para realizar cualquier compra procederíamos de la siguiente manera:
                            <p></p>
                            1) En primer lugar, iniciaremos sesión en nuestra cuenta, tal y como se ha especificado
                            anteriormente.
                            <p></p>
                            <p><img width="100%" align="middle" src="images/tutorial/03.png" width="600" height="300"/></p>
                           
                            2) En segundo lugar, el usuario navegará hasta el apartado web en donde se encuentra el artículo
                            que deseamos comprar y, una vez en él, seleccionaremos el botón "comprar" tal 
                            y como se muestra en la siguiente imagen.
                            <p></p>
                            <img width = "100%" align="middle" src="images/tutorial/01.png"/>
                            <br /><br />3) Por último, para visualizar la correcta adhesión de nuestro artículo
                            al carrito, procederemos a comprobar nuestro carrito. Para ello, seleccionaremos el icono
                            situado en la esquina superior derecha de nuestra página.
                            <p></p>
                            <img width = "100%" align="middle" src="images/tutorial/05.png"/>
                            <p></p>
                            4) Tras ello, se desplegará el siguiente menú donde, tal y como se muestra en la imagen, aparece el 
                            artículo recién añadido a nuestra lista de compra.
                            Así pues, para finalizar nuestro pedido y proceder al pago, simplemente seleccionaremos la opción 
                            situada más abajo "Confirmar pedido".
                            <p></p>
                            <img width = "100%" align="middle" src="images/tutorial/02.png"/>
                            <p></p>
                            En ese momento te enviaremos 
                            un correo electrónico con todos los datos de tu pedido y podrás hacer 
                            seguimiento en todo momento.
                            Cualquier duda que tenga no dude en contactarnos
                            ¡ Comprar en nuestra web es muy fácil !</p>
                            
                            
                            <p align="right">Atentamente, el equivo de Servirent.</p></strong>
                            <!-- Termina la explicacion -->
                        </section>
                    </div>

                </div>
            </div>
            <!-- /Page -->
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
				<!-- /Main --> 

	</div>
</asp:Content>
