//criando a função validar
function validar() {
    //declarando as variaveis

    let usuario = document.getElementById('idUser').value;
    let senha = document.getElementById('idSenha').value;

    //se o usuario e senha forem com os dados abaixo

    if (usuario === 'Admin' && senha === '12345') {
        //chama a pagina dashboard
        window.open('/Carro/Carro');
        //caso o usuario ou senha estiverem errados
    } else {
        //apresente uma mensgem de alerta
        window.close('Index');
        alert('usuario ou senha inválidos');
    }
}
