# AnimeDbWebApp
All project constants are in AnimeDbWebApp.Data.Common project library
Database Information(Seeding the database may take more then 20 min):
    Database is created and managed with EntityFramework in AnimeDbWebApp.Data and consists of 2 main tables -> anime and manga.
    Anime table has relations with following tables:
        -Producers - represents companies that make the anime happend. They have 3 roles: studios that produce the anime, licensors that work on legal actions around the anime and pruducers that takes care of anime production as whole(distribution, connecting production parts, etc.). Companies sometimes are responsable for more then one role, but can do each one of them. Thats why the database has 3 mapping tables, but one producer table.
        -GenreForAnime - table consisting of genre specific to animes.
        -TypeForAnime - table consisting types of anime (TV, Movie, OVA, etc.).
        -AnimeRelations - consists of mapping relations between animes (side story, sequel, prequel, etc.)

    Manga table has relations with following tables:
        -Authors - people that has worked on producing the manga.
        -Magazines - magazines that publish the manga.
        -GenreForManga - table consisting of genre specific to mangas(its close to anime genres, but still separated).
        -TypeForManga - table consisting types of mangas (Light novel, Manga, One shot, etc.).
        -MangaRelations - consists of mapping relations between mangas (side story, sequel, prequel, etc.)

    AnimeManga - mapping table that corespond to manga being adapted as anime (anime is produced based on manga's story)

    Seeding of the database comes from files in AnimeDbWebApp.Data.Datasets with help of Extension Method, Seed, in SeedModelBuilderExtension class. The method uses reflection and custom naming convention. Mapping between entity and DTO is managed by CustomMapping class in AnimeDbWebApp.Data.Mapping. Also DTOs are separated in 3 folders so that the correct order of seeding is preserved -> Non-Dependant tables(primal), General and Mappings.
    Custom naming convention for seeding consists of:
        -Seeding DTO naming is formed from entity with 'ImportModel' (11 symbols) added -> Anime => AnimeImportModel.
        -Files constants are formed like DTO naming, but with 'DatasetFileName'

    Database also has an abstraction layer Repository. A non-generic class, that uses generic methods to make CRUD operations between the database and services.

Folder Infrastructure consist of Library projects that are connecting(adding layer of abstraction) and expandinding Database and Web.
    -Extensions currently has only 1 extension method to IServiceCollection that registers all the services with help of reflection and naming convention for Services.
    -Mapping has static class CustomMapping that is used for mapping. Mapping is done with help of methods Map: DTO -> Entity, when bool value 'view' is false, and MapView: Entity -> Views when bool value 'view' is true. It also has method MapAll for mapping of collections.
    -Services consist of classes that implement methods used by controller to exchange information with database(Repository). It uses naming convention: controllername(withpout 'controller') + Service, as interfaces add "I" infront.

Web uses MVC structure for generating of the web content. It need connection to internet, because bootstrap, jquery and css are loaded from respective links not physical files(it uses some local files, but as generel needs active internet connection).
Planned web functionality: Different controllers for Anime, Manga, Producer, Author, Magazine. With each having Index and Details page. Index has pagination and search. Also each user have added UserStatus of anime and manga. Also adnim panel for administrators that add, edits, and removes entries.