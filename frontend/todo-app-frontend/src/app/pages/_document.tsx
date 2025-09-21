import { Html, Head, Main, NextScript } from 'next/document';

export default function Document() {
    return (
        <Html>
            <Head />
            <body>
            <Main />
            <NextScript />
            <script src="/runtime-config.js"
            async
            />
            </body>
        </Html>
    );
}