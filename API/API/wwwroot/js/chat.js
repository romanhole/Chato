class Mensagem {
  constructor(nomeUsuario, texto, horario) {
    this.NomeUsuario = nomeUsuario;
    this.texto = texto;
    this.horario = horario;
  }
}

const NomeUsuario = nomeUsuario;
const textoInput = document.getElementById('textoMensagem');
const chat = document.getElementById('chat');
const mensagensEmEspera = [];

document.getElementById('btnSubmit').addEventListener('click', () => {
  var horarioAtual = new Date();
  horario.innerHTML =
    (horarioAtual.getDate() + 1) + "/"
    + horarioAtual.getMonth() + "/"
    + horarioAtual.getFullYear() + " "
    + horarioAtual.toLocaleString('pt-BR', { hora: 'numeric', minuto: 'numeric', segundo: 'numeric' });
});

function limparCampoInput() {
  mensagensEmEspera.push(textoInput.value);
  textoInput.value = "";
}

function enviarMensagem() {
  let texto = mensagensEmEspera.shift() || "";
  if (texto.trim() === "") return;

  let horario = new Date();
  let mensagem = new Mensagem(nomeUsuario, texto);
  sendMessageToHub(mensagem);
}

function adicionarMensagemAoChat(mensagem) {
  let isMensagemDoUsuarioAtual = mensagem.nomeUsuario == nomeUsuario;

  let container = document.createElement('div');
  container.className = isMensagemDoUsuarioAtual ? "container escuro" : "container";

  let remetente = document.createElement('p');
  remetente.className = "remetente";
  remetente.innerHTML = mensagem.nomeUsuario;
  let texto = document.createElement('p');
  texto.innerHTML = mensagem.texto;

  let horario = document.createElement('span');
  horario.className = isMensagemDoUsuarioAtual ? "tempo-esquerda" : "tempo-direita";
  var horarioAtual = new Date();
  horario.innerHTML(horarioAtual.getDate() + 1) + "/"
    + horarioAtual.getMonth() + "/"
    + horarioAtual.getFullYear() + " "
    + horarioAtual.toLocaleString('pt-BR', { hora: 'numeric', minuto: 'numeric', segundo: 'numeric' });

  container.appendChild(remetente);
  container.appendChild(texto);
  container.appendChild(horario);
  chat.appendChild(container);
}
