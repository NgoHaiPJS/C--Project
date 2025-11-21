// Site-wide JavaScript functionality

// Add smooth scrolling to all links
document.querySelectorAll('a[href^="#"]').forEach(anchor => {
    anchor.addEventListener('click', function (e) {
        e.preventDefault();
        document.querySelector(this.getAttribute('href')).scrollIntoView({
            behavior: 'smooth'
        });
    });
});

// Initialize tooltips
document.addEventListener('DOMContentLoaded', function () {
    var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'));
    var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
        return new bootstrap.Tooltip(tooltipTriggerEl);
    });
});

// Helper function to format dates
function formatDate(date) {
    const options = { year: 'numeric', month: 'long', day: 'numeric' };
    return new Date(date).toLocaleDateString('vi-VN', options);
}

// Add accessibility features
function improveAccessibility() {
    // Add aria-labels to links without text
    document.querySelectorAll('a').forEach(link => {
        if (!link.textContent.trim()) {
            const img = link.querySelector('img');
            if (img && img.alt) {
                link.setAttribute('aria-label', img.alt);
            }
        }
    });

    // Ensure all form inputs have associated labels
    document.querySelectorAll('input').forEach(input => {
        if (!input.id) return;
        const label = document.querySelector(`label[for="${input.id}"]`);
        if (!label) {
            console.warn(`Input with id ${input.id} has no associated label`);
        }
    });
}

// Call accessibility improvements when DOM is loaded
document.addEventListener('DOMContentLoaded', improveAccessibility);