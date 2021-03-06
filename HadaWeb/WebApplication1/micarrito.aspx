﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" 
    CodeBehind="micarrito.aspx.cs" Inherits="WebApplication1.micarrito" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="extra">
						<div class="container">
                            <ul class="style">
								<h3><img src="images\iconos\carrito09.png"/> Mi carrito</h3>
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
                            
                            <p></p> <p></p><p></p> <p></p> <p></p>  <p></p> <p></p> <p></p> <p></p>
                           
                            <div class="box-white"> 
                            <fieldset class="box"> 
                            
								<ul align="left"><h2>LISTA DE COMPRA</h2>
                                <hr size="4px" width="100%" align="center" color="gray"/>
									<input type="hidden" name="accountType" value="private" />
								

                                <style>
                                  tr{
                                    /* Todas las filas blancas */
                                    background-color: white;
                                  }
                                  tr:nth-child(2n+1){
                                    /* Filas impares grises */
                                    background-color: #CEE3F6;
                                  }
                                  tr:hover{
                                    /* Filas celeste al pasar el mouse */
                                    background-color: #76DAFB;
                                  }
                                </style>
                                    <asp:Label id="NoArticulos" runat="server" Text="No hay articulos en el carrito" ></asp:Label>
                                    <!--Gridview de pedidos-->
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" onrowcommand="EliminarArticulo">
                                        <Columns>
                                            <asp:ImageField DataImageUrlField="avatar" DataImageUrlFormatString="~/images/{0}" HeaderText=" Imagen " ControlStyle-Width="100px" FooterStyle-HorizontalAlign="Center" FooterStyle-VerticalAlign="Middle">
<ControlStyle Width="100px"></ControlStyle>

<FooterStyle HorizontalAlign="Center" VerticalAlign="Middle"></FooterStyle>
                                            </asp:ImageField>
                                            <asp:BoundField DataField="nombre" HeaderText=" Nombre del artículo " SortExpression="nombre" FooterStyle-HorizontalAlign="Center" FooterStyle-VerticalAlign="Middle">
<FooterStyle HorizontalAlign="Center" VerticalAlign="Middle"></FooterStyle>
                                            </asp:BoundField>
                                            <asp:BoundField DataField="importe_total" HeaderText=" Precio " SortExpression="precio" FooterStyle-HorizontalAlign="Center" FooterStyle-VerticalAlign="Middle">
<FooterStyle HorizontalAlign="Center" VerticalAlign="Middle"></FooterStyle>
                                            </asp:BoundField>
                                            <asp:ButtonField  Text="Eliminar artículo" ControlStyle-Font-Bold="true" CommandName="eliminar" />
                                        </Columns>
                                    </asp:GridView>   
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseConnection %>" SelectCommand="SELECT [avatar], [nombre], [importe_total] FROM [pedido], [curso] WHERE ([cliente] LIKE '%' + @cliente + '%') AND ([curso] = [idCurso]) AND ([estadoPedido] like 'Activo')
                                                                                                                                                                        UNION
                                                                                                                                                                       SELECT [avatar], [nombre], [importe_total] FROM [pedido], [oferta] WHERE ([cliente] LIKE '%' + @cliente + '%') AND ([oferta] = [idOferta]) AND ([estadoPedido] like 'Activo') ">
                                        <SelectParameters>
                                            <asp:SessionParameter Name="cliente" SessionField="USER" Type="String" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>
                                
                                <asp:Label ID="Label1" runat="server" Text="Importe total sin descuento por puntos: " Font-Bold="true" Font-Names="arial" ></asp:Label>
                                <asp:Label ID="Importe" runat="server" Text=""></asp:Label>
                                <asp:Label ID="Label3" runat="server" Text=" €" Font-Bold="true" Font-Names="arial" ></asp:Label>
                                <br />
                                <asp:Label ID="Label2" runat="server" Text="Importe total con descuento por puntos: " Font-Bold="true" Font-Names="arial" ></asp:Label>
                                <asp:Label ID="ImportePuntos" runat="server" Text=""></asp:Label>  
                                <asp:Label ID="Label4" runat="server" Text=" €" Font-Bold="true" Font-Names="arial" ></asp:Label>
                                <table>
                                                                  
                                </table>
 
								</ul>
                                <asp:Button ID="ConfirmarPedido" runat="server" Text="Confirmar pedido" Onclick="confirmarP"/>
								<asp:Button ID="BorrarPedido" runat="server" Text="Borrar pedido" Onclick="borrarP"/>

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
