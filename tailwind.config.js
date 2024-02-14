module.exports = {
    content: ["Pages/**/*.razor",  "./node_modules/flowbite/**/*.js"],
    theme: {
        extend: {},
    },
    // enable dark mode via class strategy
    darkMode: 'class',
    daisyui: {
        themes: ["dark"],
    },
    plugins: [require("@tailwindcss/typography"), require("daisyui"), require('flowbite/plugin')]
}

