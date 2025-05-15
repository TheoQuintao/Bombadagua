# Bombadagua

Este projeto simula o funcionamento de um sistema de controle de bomba d'água, caixa d'água e reservatório, utilizando sensores e atuadores virtuais.

## Funcionamento do Código

O programa principal está em [`Program.cs`](bomba/bomba/Program.cs). Ele simula, em um loop infinito, o consumo e o reabastecimento de água em uma caixa d'água e um reservatório, controlando automaticamente a bomba e a torneira com base em sensores virtuais.

### Variáveis principais

- `caixa`: representa o nível da caixa d'água (em %).
- `reservatorio`: representa o nível do reservatório (em %).
- Sensores virtuais: `sa`, `sb`, `sc` (ligados/desligados conforme o nível de água).
- Atuadores: `bomba` (liga/desliga a bomba), `torneira` (liga/desliga a torneira).

### Lógica dos sensores e atuadores!


- O nível da caixa d'água diminui a cada ciclo.
- Se o reservatório está abaixo de 30%, ambos sensores `sa` e `sb` desligam.
- Entre 30% e 80%, apenas `sa` liga.
- Acima de 80%, ambos sensores ligam.
- O sensor `sc` liga apenas se a caixa d'água estiver acima de 80%.
- A torneira liga quando ambos sensores `sa` e `sb` estão desligados, e desliga quando ambos estão ligados.
- A bomba liga quando o sensor `sc` está desligado e desliga quando está ligado.

### Atualização dos níveis

- Quando a torneira está ligada, o reservatório recebe água.
- Quando a bomba está ligada, transfere água do reservatório para a caixa d'água.

### Saída

O programa exibe no console o status dos sensores, da bomba, da torneira, e os níveis de água, atualizando a cada ciclo.

[Design sem nome](https://github.com/user-attachments/assets/9b222d23-b33c-4390-bb93-983aecfa0c8f)

---

**Autor:** Théo Oliveira Quintão  
**Curso:** Técnico de Informática para a Internet
