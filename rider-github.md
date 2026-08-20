Preparing a detailed guide on the most elegant and efficient workflow for working with GitHub repositories in JetBrains Rider, covering initial setup, tool windows, branch and commit management, pull request review, merge resolution, and productivity tips.**Overview of GitHub Integration in JetBrains Rider**

JetBrains Rider provides a deep, native integration with Git and GitHub. Instead of switching back and forth between the IDE, terminal, and browser, you can handle the entire development cycle—from cloning and branching to staging hunks, conducting code reviews, resolving conflicts, and merging Pull Requests—directly inside Rider.

---

**1. Initial Setup & Authentication**

The most elegant workflow starts with linking your GitHub account so Rider can handle repository discovery, SSH/HTTPS authentication, and PR access automatically.

**Adding Your GitHub Account**
1. Open `Settings` / `Preferences` (`Ctrl+Alt+S` on Windows/Linux, `Cmd+,` on macOS).
2. Navigate to `Version Control` | `GitHub`.
3. Click `+` and select `Log In via GitHub...` (browser OAuth) or `Log In with Token...` (Personal Access Token).
4. Once authenticated, Rider syncs with your personal account and any associated organizations.

**Cloning Directly from GitHub**
1. On the Welcome Screen or via `Git` | `Clone...`, click the `GitHub` tab on the left.
2. Search or select any repository directly from the list without manually copying URLs.
3. Select your local directory and click `Clone`.

---

**2. Streamlined Daily Git Workflow**

**A. Non-Modal Commit Tool Window**  
Rider features a dedicated **Commit Tool Window** (`Alt+0` or `Cmd+0` / `Ctrl+K` or `Cmd+K`) docked on the left side:
- **Side-by-side Diff**: Click any modified file to view diffs right inside the editor area or in a floating window.
- **Line & Hunk Staging**: Check or uncheck individual checkboxes next to lines or hunks in the diff viewer to stage only specific changes.
- **Git Staging Support**: Enable the staging area under `Settings` | `Version Control` | `Git` | `Enable staging area` if you prefer explicit `git add` semantics.
- **Commit Checks**: Configure automatic code cleanup, formatting, TODO checking, or tests to run before commit right from the commit panel gear icon.
- **Amend & Commit**: Easily amend previous unpushed commits with a single toggle.

**B. Branches Widget**  
Located in the status bar (bottom right) or the navigation bar:
- **Instant Branch Operations**: Switch branches, create new feature branches, rename, or delete local and remote branches.
- **Checkout and Rebase/Merge**: Click a remote branch to perform `Checkout as...`, `Pull into Current Using Merge`, or `Rebase onto Current`.
- **Compare with Current**: Compare any local or remote branch with your active working branch to see the exact commit diff.

**C. Git Log & Visual History (`Alt+9` / `Cmd+9`)**  
The `Git` tool window provides a multi-branch visual graph:
- Filter history by `Branch`, `User`, `Date`, or `Path`.
- Right-click any commit to `Cherry-Pick`, `Revert Commit`, `Drop Commit`, `Create Tag`, or `Interactively Rebase from Here`.
- Search commits by message, author, or commit hash.

---

**3. Native GitHub Pull Requests & Code Review**

Rider includes a fully integrated **Pull Requests** tool window (`View` | `Tool Windows` | `Pull Requests`):

**Creating Pull Requests**
1. Push your branch using `Ctrl+Shift+K` / `Cmd+Shift+K`.
2. Go to `Git` | `GitHub` | `Create Pull Request` or open the `Pull Requests` tool window.
3. Select the target branch, title, description, reviewers, assignees, and labels.
4. Click `Create Pull Request`.

**Reviewing Pull Requests Inside Rider**
- **List & Filter**: View all open, closed, or assigned PRs directly in the tool window.
- **Timeline & Discussions**: Read the PR description, conversation comments, and checks/CI statuses.
- **Diff View & Inline Comments**: Browse changed files, click on lines in the diff viewer to leave line-specific comments, start a review, approve, or request changes.
- **One-Click Merge**: Merge the PR from Rider choosing `Merge Commit`, `Squash and Merge`, or `Rebase and Merge`.

---

**4. Advanced Power Features**

**Interactive Rebase**
- In the `Git Log` (`Alt+9` / `Cmd+9`), right-click the base commit and choose `Interactively Rebase from Here`.
- Rider opens a visual rebase dialog where you can reorder, squash, edit, reword, or drop commits using drag-and-drop or simple keyboard actions.

**Three-Way Merge Conflict Resolver**
- When merge or rebase conflicts occur, Rider opens a 3-pane merge tool (`Yours` on the left, `Theirs` on the right, `Result` in the center).
- Click the `Magic Wand` (`Apply Non-Conflicting Changes`) to automatically resolve trivial diffs.
- Click `<<` or `>>` arrows to accept or discard specific conflicting hunks.

**Annotate with Git Blame**
- Right-click the editor gutter on any file and select `Annotate with Git Blame`.
- Hover over the gutter to see author, commit date, commit message, and hash.
- Click `Open on GitHub` or `Copy Link to GitHub` from the context menu to jump directly to the code permalink in your browser.

**Shelve Changes vs. Stash**
- While standard `git stash` is supported, Rider offers `Shelve Changes` (`Ctrl+Shift+H` / context menu):
    - Shelves are stored locally in the IDE and persist across branches.
    - You can inspect, rename, selectively unshelve, or apply diffs from shelves at any time without Git index interference.

---

**5. Summary of Recommended Keybindings & Shortcuts**

| Action | Windows / Linux | macOS |
| :--- | :--- | :--- |
| **Commit Tool Window** | `Alt+0` / `Ctrl+K` | `Cmd+0` / `Cmd+K` |
| **Push Commits** | `Ctrl+Shift+K` | `Cmd+Shift+K` |
| **Update / Pull Project** | `Ctrl+T` | `Cmd+T` |
| **Git Tool Window (Log/History)** | `Alt+9` | `Cmd+9` |
| **VCS Operations Quick Popup** | `Alt+\`` | `Ctrl+V` |
| **Show Diff** | `Ctrl+D` | `Cmd+D` |
| **Open on GitHub** | Right-click -> `Open In` | Right-click -> `Open In` |

Finalizing the proposal and structured delivery plan for adopting the GitHub workflow in JetBrains Rider.

**Requirements**

**Overview & Goals**  
Establish an efficient, keyboard-driven, and fully integrated GitHub workflow inside JetBrains Rider without relying on external context switching between terminal, browser, and IDE.

**Scope**
- **In Scope**:
    - GitHub account authentication and repository discovery.
    - Non-modal commit window, visual diff, and partial hunk staging.
    - Branch switching, remote fetching, and visual log analysis.
    - Native Pull Request creation, review, inline commenting, and merging.
    - Visual 3-way conflict resolution and interactive rebase.
- **Out of Scope**:
    - External CI/CD server maintenance (outside of viewing GitHub Actions / checks status).
    - Third-party Git GUI tools (e.g., GitKraken, SourceTree).

**User Stories**
- As a developer, I want to create and review GitHub Pull Requests directly in Rider so that I can provide line comments without leaving my editor.
- As a developer, I want to stage individual code hunks and run pre-commit inspections so that my commits remain clean and atomic.
- As a developer, I want a visual 3-way merge tool so that complex merge conflicts can be resolved safely and quickly.

**Technical Design**

**Current Implementation & Architecture**  
JetBrains Rider integrates Git via its IntelliJ platform VCS subsystem with native GitHub plugin extensions.

**Key Decisions**
- **Non-Modal Commit Interface**: Use the docked Commit Tool Window rather than modal dialogs for uninterrupted coding and diff inspection.
- **Native PR Tool Window**: Leverage Rider's built-in Pull Requests tool window for full code review cycles (inline comments, approvals, merges).
- **Visual Merge Resolver**: Rely on Rider's 3-way visual merge tool with automatic non-conflicting change resolution.

**Workflow Components**
- **Version Control Settings**: `Settings | Version Control | GitHub` & `Git`.
- **Commit Window**: `Alt+0` / `Cmd+0` for diffing, partial staging, and amending.
- **Git Log Window**: `Alt+9` / `Cmd+9` for commit graphs, branch comparison, cherry-picking, and interactive rebasing.
- **Pull Requests Window**: Dedicated tool window for reviewing, discussing, and merging GitHub PRs.

**Delivery Steps**

**Step 1: Configure GitHub integration and authentication in Rider**  
GitHub account authentication and repository linking are established within JetBrains Rider.

- Open `Settings` / `Preferences` and navigate to `Version Control | GitHub`.
- Link GitHub credentials via OAuth or Personal Access Token with necessary repository and workflow scopes.
- Verify repository discovery and clone capabilities via `Get from VCS` GitHub integration.

**Step 2: Establish streamlined commit, branching, and staging practices**  
The IDE is configured for non-modal commits, selective hunk staging, and streamlined branch management.

- Dock and configure the `Commit` tool window (`Alt+0` / `Cmd+0`) with optional Git staging area support.
- Set up automated pre-commit actions such as code cleanup, formatting, and test execution.
- Utilize the status bar `Branches` widget for branch switching, remote tracking, and fast rebasing/merging.

**Step 3: Adopt native Pull Request review and visual merge resolution workflows**  
Full in-IDE code review, Pull Request lifecycle, and 3-way merge conflict handling are integrated into the daily developer routine.

- Activate the `Pull Requests` tool window (`View | Tool Windows | Pull Requests`) for listing, diffing, and commenting on PRs.
- Test creating and submitting Pull Requests directly from Rider with target branch selection and reviewer assignment.
- Utilize Rider's 3-way merge tool and interactive visual rebase for conflict resolution and history cleanup.

