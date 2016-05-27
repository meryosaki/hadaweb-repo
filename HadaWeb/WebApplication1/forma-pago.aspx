<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="forma-pago.aspx.cs" Inherits="WebApplication1.Formulario_web1" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="extra">
						<div class="container">
                            <ul class="style">
								<asp:Label Text="FORMA DE PAGO" ID="formaPago" Font-Bold="true" Font-Size="XX-Large" runat="server"></asp:Label>
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
                            
                            <p></p> <p></p><p></p> <p></p> <p></p>  <p></p> <p></p>
                           
                            <div class="box-white"> 
                            <fieldset class="box"> 
                            
								<ul align="left"><asp:Label Text="SELECCIONA UNA FORMA DE PAGO" runat="server" Font-Bold="true" Font-Size="XX-Large"></asp:Label>
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
                                <asp:RadioButton ID="tarjeta" runat="server" Text="Tarjeta" Font-Bold="true" OnCheckedChanged="tarjeta_CheckedChanged" AutoPostBack="true" GroupName="pago"/>
                                <asp:RadioButton ID="transferencia" runat="server" Font-Bold="true" Text="Transferencia" OnCheckedChanged="transferencia_CheckedChanged" AutoPostBack="true" GroupName="pago"/>
                                <asp:RadioButton ID="paysafecard" runat="server" Font-Bold="true" Text="Paysafecard" OnCheckedChanged="paysafecard_CheckedChanged" AutoPostBack="true" GroupName="pago"/>
                                <asp:RadioButton ID="western" runat="server" Font-Bold="true" Text="Western Union" OnCheckedChanged="western_CheckedChanged" AutoPostBack="true" GroupName="pago"/><br />
                                <!--  Tarjeta  -->
                                <asp:Label ID="t1" Text="Selecciona el tipo de tarjeta de credito" runat="server"></asp:Label><br />
                                <asp:ImageButton ID="t2" ImageUrl="~/images/visa.png" runat="server" Width="100px" OnClick="visa_Click"/>
                                <asp:ImageButton ID="t3" ImageUrl="~/images/masterCard.png" runat="server" Width="100px" OnClick="master_Click"/>
                                <asp:ImageButton ID="t4" ImageUrl="~/images/maestro.png" runat="server" Width="100px" OnClick="maestro_Click"/>
                                <asp:ImageButton ID="t5" ImageUrl="~/images/amex.jpg" runat="server" Width="100px" OnClick="amex_Click"/><br /><br />
                                <asp:Label ID="t6" Text="Numero de tarjeta" runat="server" Font-Bold="true"></asp:Label>
                                <asp:TextBox ID="t7" Text="" runat="server" Width="400px" BorderColor="Black" BorderWidth="1px"></asp:TextBox><br /><br />
                                <asp:Label ID="t8" Text="Fecha de caducidad" runat="server" Font-Bold="true"></asp:Label>           
                                <asp:TextBox ID="t9" Text="" runat="server" Width="60px" BorderColor="Black" BorderWidth="1px" placeholder="MM"/>
                                <asp:TextBox ID="t10" Text="" runat="server" Width="60px" BorderColor="Black" BorderWidth="1px" placeholder="AA"/>
                                <asp:Label ID="t11" Text="Número de seguridad" runat="server" Font-Bold="true"></asp:Label>
                                <asp:TextBox ID="t12" Text="" runat="server" Width="60px" BorderColor="Black" BorderWidth="1px" placeholder="MM"></asp:TextBox><br /><br />
                                <asp:Label ID="t13" Text="Nombre del titular" runat="server" Font-Bold="true"></asp:Label>
                                <asp:TextBox ID="t14" Text="" runat="server" Width="200px" BorderColor="Black" BorderWidth="1px" placeholder="Nombre"></asp:TextBox>
                                <asp:TextBox ID="t15" Text="" runat="server" Width="200px" BorderColor="Black" BorderWidth="1px" placeholder="Apellidos"></asp:TextBox><br />
                                <asp:Button ID="pagarTarjeta" runat="server" Text="Pagar ahora" Width="200px" OnClick="pagarTarjeta_Click" />
                                 
                                <!-- Transferencia -->
                                <asp:Label ID="Tr6" Text="A continuación se le redirigira a la pagina de su entidad donde ingresara la cantidad en la cuenta siguiente: 2121-4872-17-7249873298" runat="server" Font-Bold="true"></asp:Label><br /><br />
                                <asp:Label ID="Tr1" Text="Selecciona el tipo de tarjeta de credito" runat="server"></asp:Label><br />
                                <asp:Button ID="caixa" runat="server" Text="La caixa" Width="200px" OnClick="caixa_Click"/>
                                <asp:Button ID="sabadell" runat="server" Text="Sabadell" Width="200px" OnClick="sabadell_Click"/>
                                <asp:Button ID="BBVA" runat="server" Text="BBVA" Width="200px" OnClick="BBVA_Click"/>
                                <asp:Button ID="santander" runat="server" Text="Santander" Width="200px" OnClick="Santander_Click"/><br /><br />
                                <!-- Paysafecard -->
                                <asp:Label ID="P1" runat="server" Text="Introduce el PIN de la paysafecard"></asp:Label>
                                <asp:TextBox ID="P2" runat="server" Text="" Width="400px" BorderColor="Black" BorderWidth="1px" align="center"></asp:TextBox><br />
                                <asp:Button runat="server" ID="P3" Width="200px" OnClick="pay_Click" Text="Pagar ahora"/>
                                <!-- Western Union -->
                                <asp:Label ID="W1" Text="A continuación se le redirigira a la pagina de Western Union donde ingresara la cantidad en la cuenta siguiente: 2121-4872-17-7249873298" runat="server" Font-Bold="true"></asp:Label><br /><br />
                                <asp:Button ID="W3" runat="server" Text="Western Union" Width="200px" OnClick="W3_Click"/>

                                <asp:Button ID="factura" Width="260px" Text="Generar factura" OnClick="factura_Click" runat="server" />
                                    
                                <table>
                                                                  
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
