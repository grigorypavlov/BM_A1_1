export {};

declare global {
    interface Window {
        __env__: {
            NEXT_PUBLIC_API_BASE_URL: string;
        };
    }
}