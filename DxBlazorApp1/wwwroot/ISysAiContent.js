export function renderAI() {

        document.querySelectorAll(".isys-ai-content").forEach(function (item) {
            var aiText = item.getAttribute("data-ai");
            var aiResult = item.getAttribute("data-ai-result");
            var label = item.querySelector("label");

            label.classList.add(aiResult);
            label.setAttribute("data-ai", aiText);
        });
}
