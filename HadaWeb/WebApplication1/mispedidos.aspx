<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="mispedidos.aspx.cs" Inherits="WebApplication1.mispedidos" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="extra">
						<div class="container">
                            <ul class="style">
								<h3>Mis pedidos</h3>
                                <hr size="4px" width="100%" align="center" color="white"/>
							</ul>
                            
							<div class="row no-collapse-1">
                            

                            <style>
                            .box-white {
                            margin:20 20 20px;
                            overflow:hidden;
                            padding:30px;
                            background: white;
                            -webkit-border-radius: 100px;
                            border-radius: 5px;
                            align: middle;
                            }</style>
                            
                             <p></p> <p></p><p></p> 
                            <div class="box-white"> 
                            <fieldset class="box"> 
                            
								<ul align="left"><h2>LISTA DE PEDIDOS</h2>
                                <hr size="4px" width="100%" align="center" color="gray"/>
									<input type="hidden" name="accountType" value="private" />
								

                                <style>
                                  tr{
                                    /* Todas las filas blancas */
                                    background-color: #CEE3F6;
                                  }
                                  tr:nth-child(2n+1){
                                    /* Filas impares grises */
                                    background-color: white;
                                  }
                                  tr:hover{
                                    /* Filas celeste al pasar el mouse */
                                    background-color: #76DAFB;
                                  }
                                </style>

                                 <table>
                                <tr>
                                  <td><strong>ID Pedido&nbsp&nbsp</strong></td>
                                  <td><strong>&nbsp Descripción&nbsp</strong></td>
                                  <td><strong>&nbsp&nbsp Fecha de compra&nbsp</strong></td>
                                  <td><strong>&nbsp&nbsp Importe total&nbsp</strong></td>
                                  <td><strong>&nbsp&nbsp Puntos&nbsp</strong></td>
                                  <td><strong>&nbsp&nbsp Estado pago&nbsp</strong></td>
                                  <td><strong>&nbsp&nbsp Forma pago&nbsp</strong></td>
                                  <td><strong>&nbsp&nbsp Estado pedido</strong></td>
                                </tr>
                                
                                <!-- <tr style="background-color:#CEE3F6; padding:3px;"> -->
                                <tr>
                                  <td>1222222</td>
                                  <td>&nbsp Curso photoshop</td>
                                  <td>&nbsp&nbsp 2014-04-12</td>
                                  <td>&nbsp&nbsp 24,00</td>
                                  <td>&nbsp&nbsp 300</td>
                                  <td>&nbsp&nbsp Pagado</td>
                                  <td>&nbsp&nbsp Paypal</td>
                                  <td>&nbsp&nbsp Finalizado</td>
                                </tr>

                                <tr>
                                  <td>1222222</td>
                                  <td>&nbsp Curso photoshop</td>
                                  <td>&nbsp&nbsp 2014-04-12</td>
                                  <td>&nbsp&nbsp 24,00</td>
                                  <td>&nbsp&nbsp 300</td>
                                  <td>&nbsp&nbsp Pagado</td>
                                  <td>&nbsp&nbsp Paypal</td>
                                  <td>&nbsp&nbsp Finalizado</td>
                                </tr>

                                <tr>
                                  <td>1222222</td>
                                  <td>&nbsp Curso photoshop</td>
                                  <td>&nbsp&nbsp 2014-04-12</td>
                                  <td>&nbsp&nbsp 24,00</td>
                                  <td>&nbsp&nbsp 300</td>
                                  <td>&nbsp&nbsp Pagado</td>
                                  <td>&nbsp&nbsp Paypal</td>
                                  <td>&nbsp&nbsp Finalizado</td>
                                </tr>

                                </table>


 
								</ul>
								

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
