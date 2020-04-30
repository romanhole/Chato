var connection = new signalR.HubConnectionBuilder()
  .withUrl("/home/Index")
  .build();

connection.on("receiveMessage", adicionarMensagemAoChat);

connection.start().catch(error => {
  console.error(error.message);
});

function sendMessageToHub(message) {
  connection.invoke("sendMessage", message);
}
