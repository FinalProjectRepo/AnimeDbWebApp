function AddSimpleMapping(e) {
    let parent = e.parentElement;
    let first = parent.querySelector('select[name=first]').value;
    let second = parent.querySelector('select[name=second]').value;
    let firstId = parent.querySelector('input[name=firstId]').value;
    let secondId = parent.querySelector('input[name=secondId]').value;

    fetch('https://localhost:7292/Admin/MappingAdmin/Add', {
        method: "POST",
        credentials: 'include',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({
            "first": Number(first),
            "second": Number(second),
            "firstId": Number(firstId),
            "secondId": Number(secondId)
        })
    })
    .then()
    .catch(err => {
        console.error("Error:", err);
        alert("An error occured with adding simple mapping");
    })    
}

function RemoveSimpleMapping(e) {
    let parent = e.parentElement;
    let first = parent.querySelector('select[name=first]').value;
    let second = parent.querySelector('select[name=second]').value;
    let firstId = parent.querySelector('input[name=firstId]').value;
    let secondId = parent.querySelector('input[name=secondId]').value;

    fetch('https://localhost:7292/Admin/MappingAdmin/Remove', {
        method: "POST",
        credentials: 'include',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({
            "first": Number(first),
            "second": Number(second),
            "firstId": Number(firstId),
            "secondId": Number(secondId)
        })
    })
    .then()
    .catch(err => {
        console.error("Error:", err);
        alert("An error occured with adding simple mapping");
    })
}

function AddRelationMapping(e) {
    let parent = e.parentElement;
    let first = parent.querySelector('select[name=first]').value;
    let firstId = parent.querySelector('input[name=firstId]').value;
    let secondId = parent.querySelector('input[name=secondId]').value;
    let relation = parent.querySelector('input[name=relation]').value;

    fetch('https://localhost:7292/Admin/MappingAdmin/AddOrEditRelation', {
        method: "POST",
        credentials: 'include',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({
            "first": Number(first),
            "firstId": Number(firstId),
            "secondId": Number(secondId),
            "relation": relation
        })
    })
    .then()
    .catch(err => {
        console.error("Error:", err);
        alert("An error occured with adding relation mapping");
    })
}

function RemoveRelationMapping(e) {
    let parent = e.parentElement;
    let first = parent.querySelector('select[name=first]').value;
    let firstId = parent.querySelector('input[name=firstId]').value;
    let secondId = parent.querySelector('input[name=secondId]').value;

    fetch('https://localhost:7292/Admin/MappingAdmin/RemoveRelation', {
        method: "POST",
        credentials: 'include',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({
            "first": Number(first),
            "firstId": Number(firstId),
            "secondId": Number(secondId),
            "relation": "none"
        })
    })
    .then()
    .catch(err => {
        console.error("Error:", err);
        alert("An error occured with adding relation mapping");
    })
}