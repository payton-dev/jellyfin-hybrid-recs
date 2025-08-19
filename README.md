# Jellyfin Hybrid Recommendations Plugin

This repository contains a Jellyfin plugin that provides:
- Advanced, hybrid recommendations (rule-based + optional ML)
- Trending & social-like feeds
- Seasonal mode (calendar-aware)
- Admin weights and toggles per-feature
- Background scheduled job to refresh suggestion indices
- REST endpoints and a simple admin web UI (IHasWebPages)

## Quick Start

1. Push this repo to GitHub.
2. Enable GitHub Pages on the `gh-pages` branch (workflow creates it).
3. Create a new release (tag like `v0.1.0`). The workflow will:
   - build the plugin
   - upload a ZIP to the release
   - generate/update `manifest.json` on `gh-pages`
4. In Jellyfin: **Dashboard → Plugins → Repositories → +** and paste:
   `https://<your-user>.github.io/jellyfin-hybrid-recs/manifest.json`
5. Go to **Catalog**, find **Hybrid Recommendations**, and install.

> Target ABI set to **10.9.0.0**. Adjust as needed for your server.
