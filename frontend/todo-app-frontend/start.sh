#!/bin/sh
# Erstelle runtime-config.js basierend auf Environment-Variablen
cat > /app/public/runtime-config.js << EOL
window.__env__ = {
  NEXT_PUBLIC_API_BASE_URL: "${NEXT_PUBLIC_API_BASE_URL}"
};
EOL

# Starte die Next.js App
exec node server.js