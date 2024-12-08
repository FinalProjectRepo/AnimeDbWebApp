# AnimeDbWebApp
## Database
All project constants are in AnimeDbWebApp.Data.Common project library\
Database Information:\
    Database is created and managed with EntityFramework in AnimeDbWebApp.Data and consists of 2 main tables -> anime and manga.\
    Anime table has relations with following tables:\
        -Producers - represents companies that make the anime happend. They have 3 roles: studios that produce the anime, licensors that work on legal actions around the anime and pruducers that takes care of anime production as whole(distribution, connecting production parts, etc.). Companies sometimes are responsable for more then one role, but can do each one of them. Thats why the database has 3 mapping tables, but one producer table.
        -GenreForAnime - table consisting of genre specific to animes.\
        -TypeForAnime - table consisting types of anime (TV, Movie, OVA, etc.).\
        -AnimeRelations - consists of mapping relations between animes (side story, sequel, prequel, etc.)\

    Manga table has relations with following tables:\
        -Authors - people that has worked on producing the manga.\
        -Magazines - magazines that publish the manga.\
        -GenreForManga - table consisting of genre specific to mangas(its close to anime genres, but still separated).\
        -TypeForManga - table consisting types of mangas (Light novel, Manga, One shot, etc.).\
        -MangaRelations - consists of mapping relations between mangas (side story, sequel, prequel, etc.)\

    AnimeManga - mapping table that corespond to manga being adapted as anime (anime is produced based on manga's story)\

    Seeding of the database comes from files in AnimeDbWebApp.Data.Datasets with help of Extension Method, Seed, in SeedModelBuilderExtension class. The method uses reflection and custom naming convention. Mapping between entity and DTO is managed by CustomMapping class in AnimeDbWebApp.Data.Mapping. Also DTOs are separated in 3 folders so that the correct order of seeding is preserved -> Non-Dependant tables(primal), General and Mappings.\
    Custom naming convention for seeding consists of:\
        -Seeding DTO naming is formed from entity with 'ImportModel' (11 symbols) added -> Anime => AnimeImportModel.\
        -Files constants are formed like DTO naming, but with 'DatasetFileName'\

    Database also has an abstraction layer Repository. A non-generic class, that uses generic methods to make CRUD operations between the database and services.\

## Infrastructure
Folder Infrastructure consist of Library projects that are connecting(adding layer of abstraction) and expandinding Database and Web.\
    -Extensions has 3 classes:\
        -AppBuilderServicesExtensions - has method that seeds database with roles and assigns some to users.\
        -BuilderServicesExtensions - consist of methods that adds database, identity and services to builder.\
        -UserPrincipalExtensions - extension that returns userId as GUID\
    -Mapping has static class CustomMapping that is used for mapping. \
        -MapAll method recieves collections and type of mapping and uses the other methods to map items inside colections.\
        -Map - used for maping between entitiesmodels.\
        -MapView - used for mapping for viewsmodel.\
        -MapInner - used to map when values has to bu taken from inner property - for example mapping table.\
        -MapInnerString - private method when output collection is string collection that need only "Name" property of inner property.\
        -MapDifferentPropType - private method for mapping when properties has different property types.\
        -MapAppUserMapping - used directly for mapping userMapping types.\
    -Services consist of classes that implement methods used by controller to exchange information with database(Repository). It uses naming convention: controllername(withpout 'controller') + Service, as interfaces add "I" infront.\

## MVC
Web uses MVC structure for generating of the web content. It need connection to internet, because bootstrap, jquery and css are loaded from respective links not physical files(it uses some local files, but as generel needs active internet connection).\
Key points in web are:\
    -The five presented entities have index and details view. Index has paging, search by name of entity, and items per page. For anime and manga there is additional colmn for adding and tracking user status fore anime/manga. Details shows all info for entities.\
    -Added mvc is visible only for logged user and is collection of user list of added anime/manga with status. Can be filtered by status and also pagging and items per page.\
    -There is additional api contoller called when user adds to his list. It created with purpose of not reloading the page and calling database again.\
There is also admin panel for users with admin role, that is used for managing the entities.\

## SignalR
SignalR functionality is on home controller. If user is not logged, he can't write messages, but can see them(up to 10 messages). If he is logged, username is filled automaticly from claims.\