#!/usr/bin/env bash
set -euo pipefail

# Generate Graphviz .gv and Cairo SVG for one or more diagram names.
# Example: ./render-cairo.sh proposedCurrentSideBySide upstreamConsumers

if [[ $# -lt 1 ]]; then
  echo "Usage: $0 <diagram-name> [diagram-name ...]"
  echo "Example: $0 proposedCurrentSideBySide"
  exit 1
fi

script_dir="$(cd "$(dirname "$0")" && pwd)"
cd "$script_dir"

for diagram in "$@"; do
  echo "[1/2] Generating ${diagram}.gv"
  python status-graphviz.cs -i ngProcess --format="gv" "$diagram"

  if [[ ! -f "${diagram}.gv" ]]; then
    echo "Error: ${diagram}.gv was not generated"
    exit 2
  fi

  echo "[2/2] Generating ${diagram}.cairo.svg"
  dot -Tsvg:cairo "${diagram}.gv" -o "${diagram}.cairo.svg"
  echo "Done: ${diagram}.cairo.svg"
  echo
 done
