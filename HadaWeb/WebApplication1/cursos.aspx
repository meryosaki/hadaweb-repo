<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="cursos.aspx.cs" Inherits="WebApplication1.cursos" EnableEventValidation="false"%>
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


                             <columns>
                                <itemtemplate>
                                    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" GroupItemCount="3">
                                        <AlternatingItemTemplate>
                                            <td runat="server" style="" aling="center">
                                                
                                                <asp:Image ID="avatar" runat="server" ImageUrl='<%#"~/images/" + Eval("avatar") %>' Width="300px" />
                                                <br />
                                                <asp:Button ID="boton" runat="server" Text='<%# Bind("nombre") %>' />
                                                    
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
                                                 <asp:Button ID="boton" runat="server" Text='<%# Bind("nombre") %>' />
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
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseConnection %>" SelectCommand="SELECT [avatar], [nombre] FROM [curso]"></asp:SqlDataSource>
                                </itemtemplate>
                            </columns>


       
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
