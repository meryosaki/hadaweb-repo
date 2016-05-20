<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" 
    CodeBehind="identificarse.aspx.cs" Inherits="WebApplication1.identificarse" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="extra">
						<div class="container">
                            <ul class="style">
								<h3>Regístrate / Inicia Sesión</h3>
                                <hr size="4px" width="100%" align="center" color="white"/>
							</ul>
							<div class="row no-collapse-1">
                            <p></p><p></p>
                            <style>
.box-white {
margin:20 20 20px;
overflow:hidden;
padding:30px;
border:3px solid #afcde3;
-webkit-border-radius: 1px;
border-radius: 5px;
}</style>
<img src="img/iden6.png"/><p></p>
                        <div class="box-white">
                         <div class="form">
	<div class="caja-modal">      
<ul class="style">
<h3>Registro</h3><p></p>
             <label for="LoginForm_username" class="required"><span class="required">Nombre de usuario</span></label>			<div class="inputtext-fancy">
				<input name="LoginForm[username]" id="Text1" type="text" />							</div>
            <p></p>
			<label for="LoginForm_email" class="required"><span class="required">Email</span></label>			<div class="inputtext-fancy">
				<input name="LoginForm[email]" id="Text2" type="text" />							</div>
                <p></p>
            <a href="registro.aspx" class="button">Registrarse</a>
		</form>	</div></ul>

</div></div> <p></p>
								<div class="box-white"><div class="form">
	<div class="caja-modal">      
<ul class="style">
    <h3>ENTRAR</h3><p></p>
              <asp:TextBox ID="login" runat="server" Text=""></asp:TextBox>
    			<div class="inputtext-fancy"></div>
    <asp:RegularExpressionValidator ID="RegularLoginNick" runat="server" 
        ControlToValidate="login" 
        ValidationExpression="[\w]{4,10}"
        ErrorMessage="Nombre de usuario incorrecto"
        ForeColor="Red">

    </asp:RegularExpressionValidator>
    <p></p>
            <asp:TextBox ID="password" runat="server" type="password" Text=""></asp:TextBox>
						<div class="inputtext-fancy">
                            <asp:Button ID="Entrar" runat="server" Text="Entrar" onclick="crearCliente"/>
           
            <a href="/site/forgot" class="defaultPopup noinhome forgotLink">He olvidado la contraseña</a>

            
          
		</form>	<p></p></div></ul>
        
</div></div><!-- form -->
  </ul>  <p></p>
						</div> <p></p> <hr size="4px" width="100%" align="center" color="white"/>
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
