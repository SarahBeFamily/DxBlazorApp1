export function renderAI() {
    var aiContent = document.querySelector(".isys-ai-content");
    var aiText = aiContent.getAttribute("data-ai");
    var aiResult = aiContent.getAttribute("data-ai-result");
    var label = aiContent.querySelector("label");

    label.classList.add(aiResult);
    label.setAttribute("data-ai", aiText);
}

