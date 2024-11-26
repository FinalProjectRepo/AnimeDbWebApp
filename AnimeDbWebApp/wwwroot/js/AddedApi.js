function AddAnime(e) {
    let parent = e.parentElement;
    let status = parent.querySelector('select[name=status]').value;
    let id = parent.querySelector('input[name=id]').value;

    fetch(`https://localhost:7292/Api/AddAnime?id=${id}&status=${status}`, {
        method: "GET",
        credentials: 'include',
    })
}

function AddManga(e) {
    let parent = e.parentElement;
    let status = parent.querySelector('select[name=status]').value;
    let id = parent.querySelector('input[name=id]').value;

    fetch(`https://localhost:7292/Api/AddManga?id=${id}&status=${status}`, {
        method: "GET",
        credentials: 'include',
    })
}