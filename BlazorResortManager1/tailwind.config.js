/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        './**/*.{html,razor}',
        './Components/Pages/Home.{html,razor}'
    ],
    theme: {
        screens: {
            'rz-mdSize': '1024px'
        },
        extend: {
            colors: {
                'rz-bg-dark': '#376387',
            }
        }
    },
    plugins: [],
}

