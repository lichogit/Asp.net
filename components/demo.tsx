import { Footer } from '@/components/ui/footer-section';
import { createRoot } from 'react-dom/client';

export default function DemoOne() {
	return (
		<div className="relative flex min-h-svh flex-col">
			<div className="min-h-screen flex items-center justify-center">
				<h1 className='font-mono text-2xl font-bold'>Scroll Down!</h1>
			</div>
			<Footer />
		</div>
	);
}

// Auto-mount if a root element exists
if (typeof document !== 'undefined') {
	const mount = () => {
		console.log('[ReactFooter] Attempting to mount...');
		const rootElement = document.getElementById('react-footer-root');
		if (rootElement) {
			console.log('[ReactFooter] Found root element, creating React root...');
			try {
				const root = createRoot(rootElement);
				root.render(<Footer />);
				console.log('[ReactFooter] Render called successfully!');
			} catch (err) {
				console.error('[ReactFooter] Error rendering Footer:', err);
			}
		} else {
			console.warn('[ReactFooter] Could not find #react-footer-root element!');
		}
	};

	if (document.readyState === 'loading') {
		document.addEventListener('DOMContentLoaded', mount);
	} else {
		mount();
	}
}
