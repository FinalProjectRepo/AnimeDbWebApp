async function AddAnimeSite(e) {
    await new Promise(r => setTimeout(r, 3000));
    let source = await fetch('https://localhost:7292/Admin/SiteFetch/Sources').then(r => r.json());
    let types = await fetch('https://localhost:7292/Admin/SiteFetch/AnimeTypes').then(r => r.json());

    let id = e.parentElement.querySelector('input[name=mal_id]').value;
    let data = (await fetch(`https://api.jikan.moe/v4/anime/${id}/full`).then(r => r.json())).data;
    if (!data) return;

    let sourceDict = {};
    for (let s of source) {
        sourceDict[s.name] = s.id;
    }

    let typeDict = {};
    for (let t of types) {
        typeDict[t.name] = t.id;
    }

    let statusDict = {
        "Finished Airing": 1,
        "Currently Airing": 2,
        "Not yet aired": 3
    }

    let seasonDict = {
        "spring": 1,
        "summer": 2,
        "fall": 3,
        "winter": 4
    }

    let obj = {
        "Url": data.url,
        "PosterUrl": ((data.images).jpg).image_url,
        "TrailerUrl": data.trailer.url,
        "Title": data.title,
        "TitleEnglish": data.title_english,
        "TitleJapanese": data.title_japanese,
        "Episodes": data.episodes,
        "Status": statusDict[data.status],
        "StartDate": (data.aired).from,
        "EndDate": data.aired.to,
        "Duration": data.duration,
        "Rating": data.rating,
        "Score": data.score,
        "Rank": data.rank,
        "Synopsis": data.synopsis,
        "Background": data.background,
        "Season": seasonDict[data.season],
        "SourceId": sourceDict[data.source],
        "TypeId": typeDict[data.type]
    }

    let json = JSON.stringify(obj, null, 2);
    fetch(`https://localhost:7292/Admin/SiteFetch/AddAnime`, {
        method: "POST",
        credentials: 'include',
        headers: { 'Content-Type': 'application/json' },
        body: json
    })
    .then(_ => {
        alert("Anime added")
    })
    .catch(err => {
        alert(err)
    })
}
async function AddMangaSite(e) {
    await new Promise(r => setTimeout(r, 3000));
    let types = await fetch('https://localhost:7292/Admin/SiteFetch/MangaTypes').then(r => r.json());

    let id = e.parentElement.querySelector('input[name=mal_id]').value;
    let data = (await fetch(`https://api.jikan.moe/v4/manga/${id}/full`).then(r => r.json())).data;
    if (!data) return;

    let typeDict = {};
    for (let t of types) {
        typeDict[t.name] = t.id;
    }

    let statusDict = {
        "Discontinued": 1,
        "Finished": 2,
        "On Hiatus": 3,
        "Publishing": 4
    }

    let obj = {
        "Url": data.url,
        "PosterUrl": data.images.jpg.image_url,
        "Title": data.title,
        "TitleEnglish": data.title_english,
        "TitleJapanese": data.title_japanese,
        "Chapters": data.chapters,
        "Volumes": data.volumes,
        "Status": statusDict[data.status],
        "StartDate": data.published.from,
        "EndDate": data.published.to,
        "Score": data.score,
        "Rank": data.rank,
        "Synopsis": data.synopsis,
        "Background": data.background,
        "TypeId": typeDict[data.type]
    }

    let json = JSON.stringify(obj, null, 2);
    fetch(`https://localhost:7292/Admin/SiteFetch/AddManga`, {
        method: "POST",
        credentials: 'include',
        headers: { 'Content-Type': 'application/json' },
        body: json
    })
    .then(_ => {
        alert("Manga added")
    })
    .catch(err => {
        alert(err)
    })
}

async function AddAuthorSite(e) {
    await new Promise(r => setTimeout(r, 3000));
    let id = e.parentElement.querySelector('input[name=mal_id]').value;
    let data = (await fetch(`https://api.jikan.moe/v4/people/${id}`).then(r => r.json())).data;
    if (!data) return;

    let obj = {
        "Url": data.url,
        "Website": data.website_url,
        "PosterUrl": data.images.jpg.image_url,
        "Name": data.name,
        "GivenName": data.given_name,
        "FamilyName": data.family_name,
        "Birthdate": data.birthday,
        "About": data.about,
    }

    let json = JSON.stringify(obj, null, 2);
    fetch(`https://localhost:7292/Admin/SiteFetch/AddAuthor`, {
        method: "POST",
        credentials: 'include',
        headers: { 'Content-Type': 'application/json' },
        body: json
    })
    .then(_ => {
        alert("Author added")
    })
    .catch(err => {
        alert(err)
    })
}
async function AddProducerSite(e) {
    await new Promise(r => setTimeout(r, 3000));
    let id = e.parentElement.querySelector('input[name=mal_id]').value;
    let data = (await fetch(`https://api.jikan.moe/v4/producers/${id}`).then(r => r.json())).data;
    if (!data) return;

    let obj = {
        "Url": data.url,
        "Name": data.titles[0].title,
        "JpName": data.titles[1].title,
        "ImgUrl": data.images.jpg.image_url,
        "Established": data.established,
        "About": data.about,
    }

    let json = JSON.stringify(obj, null, 2);
    fetch(`https://localhost:7292/Admin/SiteFetch/AddProducer`, {
        method: "POST",
        credentials: 'include',
        headers: { 'Content-Type': 'application/json' },
        body: json
    })
        .then(_ => {
            alert("Producer added")
        })
        .catch(err => {
            alert(err)
        })
}
async function AddMagazineSite(e) {
    await new Promise(r => setTimeout(r, 3000));
    let id = Number(e.parentElement.querySelector('input[name=mal_id]').value);
    let str = await fetch(`https://myanimelist.net/manga/magazine/${id}`);
    let str2 = await str.text();
    if (!str) return;

    let first = str.indexOf("<title>") + 8;
    let second = str.indexOf("</title>");
    let title = str.substring(first, second).split(" - ")[0];

    first = str.indexOf('<link rel="canonical" href=', second) + 28;
    second = str.indexOf('" />', first);
    let link = str.substring(first, second);

    let obj = {
        "Name": title,
        "Url": link
    }

    let json = JSON.stringify(obj, null, 2);
    fetch(`https://localhost:7292/Admin/SiteFetch/AddMagazine`, {
        method: "POST",
        credentials: 'include',
        headers: { 'Content-Type': 'application/json' },
        body: json
    })
    .then(_ => {
        alert("Magazine added")
    })
    .catch(err => {
        alert(err)
    })
}