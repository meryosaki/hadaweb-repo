<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" 
    CodeBehind="misdatos.aspx.cs" Inherits="WebApplication1.misdatos" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="extra">
						<div class="container">
                            <ul class="style">
								<h3>Mi perfil</h3>
                                <hr size="4px" width="100%" align="center" color="white"/>
							</ul>
							<div class="row no-collapse-1">
                            <p></p>
<style>
.box-white {
margin:20 20 20px;
overflow:hidden;
padding:30px;
background: white;
-webkit-border-radius: 100px;
border-radius: 5px;
}</style>
                            <p></p><p></p>
                            <div align="center">
                            <img src="images/avatar02.png.jpg" alt="" />
                            <p></p>
                            <form enctype="multipart/form-data" action="" method="POST">
<input class="button nopopup" type="file" name="uploadedfile" value="Seleccione imagen"/>
</form>
                            <p></p>
                            </div>
                            <p></p>
                            <div class="box-white">
                            <fieldset class="box">
                            
								<ul align="left"><h2>MIS DATOS</h2><p></p>
                                <hr size="4px" width="100%" align="center" color="gray"/>
									<input type="hidden" name="accountType" value="private" />
									<li>
										<span><strong>Género</strong></span>
										<p>
											<label>
												Mujer
											</label>
										</p>
									</li>
                                    <li>
										<span><strong>Nick</strong></span>
                                       <p> <asp:Label ID="Label1" runat="server" ></asp:Label></p>
									
									</li><li>
										<span><strong>Nombre completo</strong></span>
                                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
									</li>
                                    <li>
										<span><strong>Dirección de E-mail</strong></span>
                                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
									</li>
                                <a href="misdatoseditar.aspx" class="button">Editar mis datos</a>
                                <a href="mipasseditar.aspx" class="button">Cambiar contraseña</a>

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
