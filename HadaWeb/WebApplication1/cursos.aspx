<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="cursos.aspx.cs" Inherits="WebApplication1.cursos" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="extra">
						<div class="container">
                        <strong>Selecciona una categoría:</strong>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Selected="True" Value="Estudios"></asp:ListItem>
                            <asp:ListItem Value="Cocina"></asp:ListItem>
                            <asp:ListItem Value="Ocio y cultura"></asp:ListItem>
                            <asp:ListItem Value="Deportes"></asp:ListItem>
                            <asp:ListItem Value="Gabinete psicológico"></asp:ListItem>
                            <asp:ListItem Value="Otros"></asp:ListItem>
                        </asp:DropDownList>


                        <asp:Button ID="Button1" runat="server" Text="Mostrar" Onclick="mostrar_Click"/>
                             <columns>
                                    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" GroupItemCount="3">
                                        <AlternatingItemTemplate>
                                            <td runat="server" style="" aling="center">
                                                
                                                <asp:Image id="avatar" runat="server" ImageUrl='<%#"~/images/" + Eval("avatar") %>' Width="300px" />
                                                <br />
                                                <asp:Button id="boton" runat="server" Text='<%# Bind("nombre") %>' OnClick="boton_Click"/>
                                                    
                                                <br />
                                            </td>
                                        </AlternatingItemTemplate>
                                        <EditItemTemplate>
                                            <td runat="server" style="">
                                                
                                                <asp:TextBox ID="avatarTextBox" runat="server" Text='<%# Bind("avatar") %>' />
                                                <br />
                                                
                                                <asp:TextBox ID="nombreTextBox" runat="server" Text='<%# Bind("nombre") %>' />
                                                <br />
                                                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Actualizar" />
                                                <br />
                                                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancelar" />
                                                <br /></td>
                                        </EditItemTemplate>
                                        <EmptyDataTemplate>
                                            <table runat="server" style="">
                                                <tr>
                                                    <td>No se han devuelto datos.</td>
                                                </tr>
                                            </table>
                                        </EmptyDataTemplate>
                                        <EmptyItemTemplate>
                                        <td runat="server" />
                                        </EmptyItemTemplate>
                                        <GroupTemplate>
                                            <tr id="itemPlaceholderContainer" runat="server">
                                                <td id="itemPlaceholder" runat="server"></td>
                                            </tr>
                                        </GroupTemplate>
                                        <InsertItemTemplate>
                                            <td runat="server" style="">
                                                
                                                <asp:TextBox ID="avatarTextBox" runat="server" Text='<%# Bind("avatar") %>' />
                                                <br />
                                                
                                                <asp:TextBox ID="nombreTextBox" runat="server" Text='<%# Bind("nombre") %>' />
                                                <br />
                                                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insertar" />
                                                <br />
                                                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Borrar" />
                                                <br /></td>
                                        </InsertItemTemplate>
                                        <ItemTemplate>
                                            <td runat="server" style="">
                                                 
                                                 <asp:Image ID="avatar" runat="server" ImageUrl='<%#"~/images/" + Eval("avatar") %>' Width="300px" />
                                                <br />
                                                 <asp:Button ID="boton" runat="server" Text='<%# Bind("nombre") %>' OnClick="boton_Click"/>
                                                 <br />
                                            </td>
                                        </ItemTemplate>
                                        <LayoutTemplate>
                                            <table runat="server">
                                                <tr runat="server">
                                                    <td runat="server">
                                                        <table id="groupPlaceholderContainer" runat="server" border="0" style="">
                                                            <tr id="groupPlaceholder" runat="server">
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                                <tr runat="server">
                                                    <td runat="server" style=""></td>
                                                </tr>
                                            </table>
                                        </LayoutTemplate>
                                        <SelectedItemTemplate>
                                            <td runat="server" style="">
                                                
                                                <asp:Image ID="avatar" runat="server" ImageUrl='<%#"~/images/" + Eval("avatar") %>' Width="300px" />
                                                <br />
                                                <asp:Label ID="nombreLabel" runat="server" Text='<%# Eval("nombre") %>' />
                                                <br />
                                            </td>
                                        </SelectedItemTemplate>
                            </asp:ListView>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseConnection %>" SelectCommand="SELECT avatar, nombre FROM curso WHERE (@nombre LIKE '%' + nombre + '%')">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="prueba" Name="nombre" PropertyName="Text" Type="String" />
                                    </SelectParameters>
                            </asp:SqlDataSource>
                            </columns>

                            <asp:Label ID ="prueba" Text="" runat="server"></asp:Label>
       
                            <div>
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
