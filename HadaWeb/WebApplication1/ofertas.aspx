<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="ofertas.aspx.cs" Inherits="WebApplication1.ofertas" EnableEventValidation="false"%>
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
                                 <asp:Label ID="AUXILIAR" runat="server" Text=""></asp:Label>
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
                                        
                            </asp:ListView>
                                 
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseConnection %>" SelectCommand="SELECT [avatar], [nombre] FROM [oferta]"></asp:SqlDataSource>
                            </columns>


       
                            <div>
                            <p></p>
                            <hr size="4px" width="100%" align="center" color="white"/>
						</div>
					</div>

	</div>

	
</asp:Content>
