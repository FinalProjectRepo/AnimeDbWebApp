let connection = new signalR.HubConnectionBuilder().withUrl("/chatHub", { accessTokenFactory: () => this.loginToken }).build()
let sendBtn = document.getElementById("sendButton");
sendBtn.setAttribute("disabled", true);

connection.on("ReceiveMessage", function (user, message, count) {
    let messageDiv = document.getElementById("messages");

    let h4User = document.createElement("h4");
    h4User.textContent = `${user}:\u00A0`;

    let h4Message = document.createElement("h4");
    h4Message.textContent = message;

    let div = document.createElement("div");
    div.classList.add("d-flex")
    div.append(h4User, h4Message);
    messageDiv.append(div);

    if (count >= 10) {
        let firstChild = messageDiv.children[0];
        messageDiv.removeChild(firstChild);
    }
});

connection.start().then(function () {
    sendBtn.removeAttribute("disabled");
}).catch(function () { alert("Connection was not successful! Please try again") })

sendBtn.addEventListener("click", async function (e) {
    let user = await fetch("https://localhost:7292/Api/GetUserName").then(r => r.text());
    let message = document.getElementById("message").value;
    connection.invoke("SendMessage", user, message).catch(function (err) { console.error(err); });

    e.preventDefault();
});