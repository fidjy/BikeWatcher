# BikeWatcher

#Sujet BikeWatcher

Nous allons développer ensemble une application web en utilisant la technologie ASP.Net Core de Microsoft.
Cette application aura pour but de vous permettre de consulter en temps réel, la disponibilité des vélos et places dans les stations VeloV de Lyon et son agglomération.

Dans ce TP, vous allez pouvoir vous confronter aux points suivants :

    Créer une application web
    Enregistrer votre code sur une plateforme Git telle que Github ou Bitbucket
    Lire et enregistrer des données depuis une base SQL
    Consommer des données temps réel issues d'une API publique
    Afficher les données sous forme de tableau et de carte interactive
    Déployer votre application sur un serveur accessible en ligne


#Objectifs (1 point par objectif minimum) :

    1. Avoir une application ASP.Net Core de base nommée "BikeWatcher" qui tourne sur sa machine
    Démarrer un site avec asp dotnet core :  https://docs.microsoft.com/fr-fr/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-3.1&tabs=visual-studio

    2. Créer un repository public sur github, bitbucket ou gitlab pour héberger votre code.
    gitignore de base pour .NET Core :  https://gist.github.com/vmandic/ac2ecc9c24f6899ee0ec46e4ce444a0e

    3. Publier votre code sur le repository à chaque avancée

    4. Supprimer du menu les pages de bases pour 2 liens de menu fonctionnels vers les pages vides suivantes : "Accueil", "Liste des stations", "Carte", "Mes favoris"

    5. Compléter la pages "Accueil" pour présenter votre travail, votre nom/prenom, cette liste d'objectifs (que vous rayerez au fur et à mesure) et l'URL où votre code source est visible

    6. Se brancher sur l'API VeloV du grand Lyon pour récupérer les données en temps réel
    API OpenData du Grand Lyon : https://public.opendatasoft.com/explore/dataset/station-velov-grand-lyon/api/?flg=fr
    Lire des données issues d'un flux JSON :  https://docs.microsoft.com/fr-fr/dotnet/csharp/tutorials/console-webapiclient

    7. Afficher les données de l'API sous forme de tableau sur la page "Liste des stations" (les stations sont triées par ordre alphabétique)
    Razor Cheat sheet : https://gist.github.com/jonlabelle/8738373

    8. Afficher les données de l'API sous forme de carte sur la page "Carte" (chaque station sera représentée par une épingle à son emplacement)
    Intégrer une carte openstreet map sur un site : https://nouvelle-techno.fr/actualites/2018/05/11/pas-a-pas-inserer-une-carte-openstreetmap-sur-votre-site

    9. Ajouter sur caque épingle de la carte la possibilité de cliquer pour afficher une infobulle qui indiquera le nombre de vélos et de places à la station en question

    10. Ajouter la possibilité de créer un compte utilisateur sur votre application
    https://docs.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-3.1&tabs=visual-studio

    11. Ajouter sur la page "Liste des stations" et/ou "Carte" la possibilité de rajouter des stations en favoris

    12. Compléter la page "Mes favoris" pour n'afficher sous forme de tableau que les stations marquées en favoris

    14. Stocker les stations favorites dans une base SQL
    Prise en main d'EF Core dans une application web MVC ASP.Net https://docs.microsoft.com/fr-fr/aspnet/core/data/ef-mvc/intro?view=aspnetcore-3.1

    15. Centrer automatiquement la carte par rapport à la position de l'utilisateur
    Récupérer la position de l'utilisateur : https://developer.mozilla.org/fr/docs/Web/API/Geolocation_API

    16. Trier automatiquement la liste des stations par rapport à la position de l'utilisateur

    17. Rendre votre application bilingue Français / Anglais
    https://docs.microsoft.com/fr-fr/aspnet/core/fundamentals/localization?view=aspnetcore-3.1

    18. Rendre votre application utilisable à la fois pour la ville de Lyon et la ville de Bordeaux (par exemple un bouton permettra de passer de l'un à l'autre dans le menu)
    Une API affichant les données pour la ville de Bordeaux : https://api.alexandredubois.com/vcub-backend/vcub.php

    19. Déployer votre code sur un serveur accessible publiquement en consultation
    Déployer une application ASP.Net Core sur un serveur Debian : https://medium.com/@setu677/how-to-host-asp-net-core-on-linux-using-nginx-85339560e929
    Déployer une application ASP.Net Core sur Azure : https://docs.microsoft.com/fr-fr/aspnet/core/tutorials/publish-to-azure-webapp-using-vs?view=aspnetcore-3.1

    20. Permettre aux utilisateurs de signaler un vélo en panne

    21. Faire en sorte que votre site soit agréable à utiliser sur mobile (il ne doit pas comporter ascenseur horizontal)

    22. BONUS : toute fonctionnalité supplémentaire sera valorisée, pensez-juste à l'indiquer sur votre page d'accueil que je puisse la comptabiliser

##Ressources utiles :

    Un outil pour visualiser facilement votre fux JSON : https://jsonlint.com/
