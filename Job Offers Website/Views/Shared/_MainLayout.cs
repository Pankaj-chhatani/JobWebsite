<!DOCTYPE html>
<html>
	<head>
        <meta name="viewport" content="width=device-width,initial scale=1" />
		<title>@Page.Title</title>
		<link href="~/Content/bootstrap.min.css" rel="stylesheet" />
        <link href="~/Content/style.css" rel="stylesheet" />
	</head>
	<body>
		<!--Navbar-->
        <nav class="navbar navbar-default navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button class="navbar-toggle collapsed" data-toggle="collapse"
                            data-target="#navbar">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a href="#" class="navbar-brand">
                        <img src="~/images/mini-site-logo-pe.png" class="logo-size"/>
                    </a>
                </div>
                <div id="navbar" class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li>
                            <a href="/home">
                                <i class="glyphicon glyphicon-home"></i>
                                Accueil
                            </a>
                        </li>

                        <li>
                            <a href="#">
                                <i class="	glyphicon glyphicon-folder-open"></i>
                                Type d'offres'
                            </a>
                        </li>

                        <li>
                            <a href="#">
                                <i class="	glyphicon glyphicon-info-sign"></i>
                                A propos
                            </a>
                        </li>

                        <li>
                            <a href="#">
                                <i class="glyphicon glyphicon-envelope"></i>
                                Contactez nous
                            </a>
                        </li>
                    </ul> 

                    <!--Partial login-->
                    @Html.Partial("_Login")

                </div>
            </div>
        </nav>

        <div class="container">
            <div class="row">
                @RenderBody()

            </div>
        </div>

		<!--Footer-->
        <footer class="myfooter">
            <div class="container">
                <div class="row">
                    <div class="col-md-4">
                        <h3>
                            <i class="glyphicon glyphicon-info-sign"></i>

                            Qui somme nous ?
                        </h3>
                        <p>
                            Poids et poids est se rapprochent ; on n'a tant parlé. Gagnons, amassons, faisons rafle de manière ou d'une grille travaillée avec le même plaisir. Dominant les hautes falaises qui cerclent l'île, est, vous pensez bien que ce soit cette après-midi ? Veut on savoir de quels terribles lendemains de jeûne était payé tout ce qui fut fait à dix heures.
                        </p>
                    </div>

                    <div class="col-md-4">
                        <h3>
                            <i class=" glyphicon glyphicon-globe"></i>
                            Liens importants
                        </h3>
                        <ul>
                            <li><a href="#">Fonctions publique</a></li>
                            <li><a href="#">Fonctions privées</a></li>
                            <li><a href="#">Fonctions à l'international</a></li>
                            <li><a href="#">Fonctions divers</a></li>
                        </ul>
                    </div>

                    <div class="col-md-4">
                        <h3>
                            <i class="glyphicon glyphicon-envelope"></i>
                            Contactez nous!
                        </h3>
                        <ul>
                            <li><a href="#">Page Facebook</a></li>
                            <li><a href="#">Suivez nous sur tewtter</a></li>
                            <li><a href="#">Regardez nous sr youtube</a></li>
                            <li><a href="#">Laissez nous un mail</a></li>
                        </ul>



                    </div>
                </div>

            </div>
            <div class="subfooter">
                <span>Tous les drois réserver - 2020</span>
            </div>
        </footer>


		<script src="~/Scripts/jquery.js"></script>
		<script src="~/Scripts/bootstrap.min.js"></script>

        @RenderSection("scripts",required:false)
	</body>
</html>