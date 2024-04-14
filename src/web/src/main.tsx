import React from 'react'
import ReactDOM from 'react-dom/client'
import { Auth0Provider } from '@auth0/auth0-react'
import App from './App.tsx'
import './index.css'

ReactDOM.createRoot(document.getElementById('root')!).render(
  <Auth0Provider
    domain="dev-uzzrp67rzhx2mm8n.us.auth0.com"
    clientId="k07Sf0W04o5U0N2O2VCukPfM3BthdWvf"
    authorizationParams={{
      redirect_uri: window.location.origin
    }}
  >
    <React.StrictMode>
      <App />
    </React.StrictMode>
  </Auth0Provider>,
)
