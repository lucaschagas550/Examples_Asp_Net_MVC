$(function () { // = document.ready
	selecaoItensExercicioAte();
});

function selecaoItensExercicioAte() {
	var exercicioDeSelect = document.getElementById('exercicio-De-Filtro');
	var exercicioAteSelect = document.getElementById('exercicio-Ate-Filtro');
	var valorSelecionadoAte = exercicioAteSelect.value;
	console.log(valorSelecionadoAte);

	exercicioAteSelect.innerHTML = '';

	// Pega os anos da ViewBag já renderizados no primeiro select
	var todosOsAnos = Array.from(exercicioDeSelect.options)
		.filter(opt => opt.value !== "")
		.map(opt => parseInt(opt.value));

	var anoSelecionado = parseInt(exercicioDeSelect.value);

	var anoMax = Math.min(anoSelecionado + 10, Math.max(...todosOsAnos));

	var opcoesFiltradas = todosOsAnos
		.filter(ano => ano > anoSelecionado && ano <= anoMax);

	console.log('opcoes filtradas => ' + opcoesFiltradas);

	if (opcoesFiltradas.length > 0) {
		var optionsHtml = '<option value="">Selecione o Exercício Até</option>';

		opcoesFiltradas.forEach(function (ano) {
			if (ano == valorSelecionadoAte) {
				optionsHtml += `<option value="${ano}" selected>${ano}</option>`;
			} else {
				optionsHtml += `<option value="${ano}">${ano}</option>`;
			}
		});

		exercicioAteSelect.innerHTML = optionsHtml;
	} else {
		exercicioAteSelect.innerHTML = '<option value="">Selecione o Exercício Até</option>'
	}

}