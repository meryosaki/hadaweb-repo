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
                            
								<ul><h2>LISTA DE PEDIDOS</h2>
                                <hr size="4px" width="100%" align="center" color="gray"/>
									<input type="hidden" name="accountType" value="private" />
								
                                <style>
                                  tr{
                                    /* Todas las filas blancas */
                                    background-color: white;
                                    align-items: center;
                                    align-content:center;
                                    border: double;
                                    border-color: black;
                                    }
                                  tr:nth-child(2n+1){
                                    /* Filas impares grises */ 
                                    background-color: grey;
                                    color: white;
                                  }
                                  tr:hover{
                                    /* Filas celeste al pasar el mouse */
                                    background-color: #76DAFB;
                                  }
                                </style>
                                    <asp:Label id="NoPedidos" runat="server" Text="No hay pedidos" Width="1000px" Visible="false"></asp:Label>
                                    <!--Gridview de pedidos-->  
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="idPedido" Width="1000px">
                                        <Columns>
                                            <asp:BoundField DataField="idPedido" HeaderText="idPedido" SortExpression="idPedido" FooterStyle-HorizontalAlign="Center" FooterStyle-VerticalAlign="Middle" HtmlEncode="false">
                                            </asp:BoundField>
                                            <asp:BoundField DataField="descripcion" HeaderText="descripcion" SortExpression="descripcion" FooterStyle-HorizontalAlign="Center" FooterStyle-VerticalAlign="Middle" HtmlEncode="false">
                                            </asp:BoundField>
                                            <asp:BoundField DataField="f_compra" DataFormatString="{0:dd-M-yyyy}"  HeaderText="f_compra" SortExpression="f_compra" FooterStyle-HorizontalAlign="Center" FooterStyle-VerticalAlign="Middle" HtmlEncode="false"/>
                                            <asp:BoundField DataField="importe_total" HeaderText="importe_total" SortExpression="importe_total" FooterStyle-HorizontalAlign="Center" FooterStyle-VerticalAlign="Middle" HtmlEncode="false"/>
                                            <asp:BoundField DataField="puntos" HeaderText="puntos" SortExpression="puntos" FooterStyle-HorizontalAlign="Center" FooterStyle-VerticalAlign="Middle" HtmlEncode="false"/>
                                            <asp:BoundField DataField="estadoPago" HeaderText="estadoPago" SortExpression="estadoPago" FooterStyle-HorizontalAlign="Center" FooterStyle-VerticalAlign="Middle" HtmlEncode="false"/>
                                            <asp:BoundField DataField="formaPago" HeaderText="formaPago" SortExpression="formaPago" FooterStyle-HorizontalAlign="Center" FooterStyle-VerticalAlign="Middle" HtmlEncode="false"/>
                                            <asp:BoundField DataField="estadoPedido" HeaderText="estadoPedido" SortExpression="estadoPedido" FooterStyle-HorizontalAlign="Center" FooterStyle-VerticalAlign="Middle" HtmlEncode="false"/>
                                        </Columns>
                                    </asp:GridView>   
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseConnection %>" SelectCommand="SELECT [idPedido], [descripcion], [f_compra], [importe_total], [puntos], [estadoPago], [formaPago], [estadoPedido] FROM [pedido] WHERE ([cliente] LIKE '%' + @cliente + '%')">
                                        <SelectParameters>
                                            <asp:SessionParameter Name="cliente" SessionField="USER" Type="String" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>
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
