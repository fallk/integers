using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A191047
{
public static readonly long[] Value={ 19L,29L,37L,41L,47L,53L,67L,71L,79L,89L,101L,103L,107L,109L,127L,131L,137L,163L,167L,173L,179L,199L,229L,239L,251L,269L,281L,307L,313L,331L,337L,347L,349L,353L,359L,367L,379L,383L,389L,397L,401L,419L,421L,431L,433L,439L,443L,449L,467L,479L,491L,499L,541L,563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191047Inst : IEnumerable<long>
{
public static readonly long[] Value=A191047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191047.Bytes);
public long this[int i]=>Value[i];

public static A191047Inst Instance=new A191047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191048
{
public static readonly long[] Value={ 2L,5L,11L,13L,19L,23L,31L,67L,73L,83L,89L,97L,101L,131L,151L,163L,167L,179L,181L,223L,239L,241L,257L,263L,269L,277L,281L,283L,313L,317L,337L,347L,367L,383L,389L,397L,421L,431L,433L,439L,457L,467L,479L,487L,499L,523L,541L,547L,557L,563L,569L,571L,593L,599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191048Inst : IEnumerable<long>
{
public static readonly long[] Value=A191048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191048.Bytes);
public long this[int i]=>Value[i];

public static A191048Inst Instance=new A191048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191049
{
public static readonly long[] Value={ 3L,11L,13L,19L,23L,29L,31L,53L,67L,73L,101L,103L,109L,113L,127L,149L,157L,179L,181L,211L,223L,227L,229L,241L,271L,293L,317L,331L,337L,347L,353L,359L,367L,397L,401L,409L,421L,431L,433L,449L,487L,499L,509L,547L,557L,563L,569L,571L,587L,599L,607L,617L,631L,643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191049Inst : IEnumerable<long>
{
public static readonly long[] Value=A191049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191049.Bytes);
public long this[int i]=>Value[i];

public static A191049Inst Instance=new A191049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191050
{
public static readonly long[] Value={ 3L,7L,11L,17L,23L,29L,31L,37L,41L,59L,61L,109L,113L,127L,131L,151L,167L,173L,191L,193L,197L,199L,227L,229L,241L,277L,293L,313L,317L,349L,353L,359L,373L,383L,397L,401L,409L,419L,431L,443L,463L,479L,499L,509L,521L,523L,547L,557L,563L,593L,607L,617L,619L,659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191050Inst : IEnumerable<long>
{
public static readonly long[] Value=A191050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191050.Bytes);
public long this[int i]=>Value[i];

public static A191050Inst Instance=new A191050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191051
{
public static readonly long[] Value={ 3L,5L,17L,19L,23L,29L,31L,37L,41L,47L,61L,79L,97L,103L,127L,131L,149L,157L,163L,167L,179L,193L,211L,227L,239L,271L,277L,281L,311L,331L,337L,347L,349L,353L,359L,367L,373L,389L,401L,419L,421L,431L,439L,467L,479L,487L,491L,499L,523L,569L,571L,587L,599L,617L,653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191051Inst : IEnumerable<long>
{
public static readonly long[] Value=A191051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191051.Bytes);
public long this[int i]=>Value[i];

public static A191051Inst Instance=new A191051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191116
{
public static readonly long[] Value={ 1L,5L,13L,21L,37L,53L,61L,85L,109L,149L,157L,181L,213L,245L,253L,325L,341L,437L,445L,469L,541L,597L,629L,637L,725L,733L,757L,853L,973L,981L,1013L,1021L,1301L,1309L,1333L,1365L,1405L,1621L,1749L,1781L,1789L,1877L,1885L,1909L,2165L,2173L,2197L,2269L,2389L,2517L,2549L,2557L,2901L,2917L,2933L,2941L,3029L,3037L,3061L,3413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191116Inst : IEnumerable<long>
{
public static readonly long[] Value=A191116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191116.Bytes);
public long this[int i]=>Value[i];

public static A191116Inst Instance=new A191116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191117
{
public static readonly long[] Value={ 1L,6L,16L,26L,46L,66L,76L,106L,136L,186L,196L,226L,266L,306L,316L,406L,426L,546L,556L,586L,676L,746L,786L,796L,906L,916L,946L,1066L,1216L,1226L,1266L,1276L,1626L,1636L,1666L,1706L,1756L,2026L,2186L,2226L,2236L,2346L,2356L,2386L,2706L,2716L,2746L,2836L,2986L,3146L,3186L,3196L,3626L,3646L,3666L,3676L,3786L,3796L,3826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191117Inst : IEnumerable<long>
{
public static readonly long[] Value=A191117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191117.Bytes);
public long this[int i]=>Value[i];

public static A191117Inst Instance=new A191117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191118
{
public static readonly long[] Value={ 1L,7L,19L,31L,55L,79L,91L,127L,163L,223L,235L,271L,319L,367L,379L,487L,511L,655L,667L,703L,811L,895L,943L,955L,1087L,1099L,1135L,1279L,1459L,1471L,1519L,1531L,1951L,1963L,1999L,2047L,2107L,2431L,2623L,2671L,2683L,2815L,2827L,2863L,3247L,3259L,3295L,3403L,3583L,3775L,3823L,3835L,4351L,4375L,4399L,4411L,4543L,4555L,4591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191118Inst : IEnumerable<long>
{
public static readonly long[] Value=A191118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191118.Bytes);
public long this[int i]=>Value[i];

public static A191118Inst Instance=new A191118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191119
{
public static readonly long[] Value={ 1L,2L,5L,14L,17L,41L,50L,53L,65L,122L,149L,158L,161L,194L,197L,209L,257L,365L,446L,473L,482L,485L,581L,590L,593L,626L,629L,641L,770L,773L,785L,833L,1025L,1094L,1337L,1418L,1445L,1454L,1457L,1742L,1769L,1778L,1781L,1877L,1886L,1889L,1922L,1925L,1937L,2309L,2318L,2321L,2354L,2357L,2369L,2498L,2501L,2513L,2561L,3074L,3077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191119Inst : IEnumerable<long>
{
public static readonly long[] Value=A191119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191119.Bytes);
public long this[int i]=>Value[i];

public static A191119Inst Instance=new A191119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191120
{
public static readonly long[] Value={ 1L,2L,5L,6L,14L,17L,18L,22L,41L,50L,53L,54L,65L,66L,70L,86L,122L,149L,158L,161L,162L,194L,197L,198L,209L,210L,214L,257L,258L,262L,278L,342L,365L,446L,473L,482L,485L,486L,581L,590L,593L,594L,626L,629L,630L,641L,642L,646L,770L,773L,774L,785L,786L,790L,833L,834L,838L,854L,1025L,1026L,1030L,1046L,1094L,1110L,1337L,1366L,1418L,1445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191120Inst : IEnumerable<long>
{
public static readonly long[] Value=A191120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191120.Bytes);
public long this[int i]=>Value[i];

public static A191120Inst Instance=new A191120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191121
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,11L,14L,19L,20L,23L,27L,31L,32L,41L,43L,55L,56L,59L,68L,75L,79L,80L,91L,92L,95L,107L,122L,123L,127L,128L,163L,164L,167L,171L,176L,203L,219L,223L,224L,235L,236L,239L,271L,272L,275L,284L,299L,315L,319L,320L,363L,365L,367L,368L,379L,380L,383L,427L,487L,488L,491L,500L,507L,511L,512L,527L,608L,651L,655L,656L,667L,668L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191121Inst : IEnumerable<long>
{
public static readonly long[] Value=A191121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191121.Bytes);
public long this[int i]=>Value[i];

public static A191121Inst Instance=new A191121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191122
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,11L,14L,16L,20L,23L,32L,41L,44L,47L,56L,59L,64L,68L,80L,92L,95L,122L,128L,131L,140L,164L,167L,176L,188L,191L,203L,224L,236L,239L,256L,272L,275L,284L,320L,365L,368L,380L,383L,392L,419L,488L,491L,500L,512L,524L,527L,560L,563L,572L,608L,656L,668L,671L,704L,707L,716L,752L,764L,767L,812L,815L,824L,851L,896L,944L,956L,959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191122Inst : IEnumerable<long>
{
public static readonly long[] Value=A191122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191122.Bytes);
public long this[int i]=>Value[i];

public static A191122Inst Instance=new A191122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191123
{
public static readonly long[] Value={ 1L,2L,5L,9L,14L,21L,26L,37L,41L,57L,62L,77L,85L,105L,110L,122L,149L,165L,170L,185L,229L,230L,249L,254L,309L,314L,329L,341L,365L,421L,441L,446L,489L,494L,509L,554L,597L,661L,681L,686L,689L,741L,746L,761L,917L,921L,926L,941L,986L,997L,1017L,1022L,1094L,1237L,1257L,1262L,1317L,1322L,1337L,1365L,1461L,1466L,1481L,1526L,1661L,1685L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191123Inst : IEnumerable<long>
{
public static readonly long[] Value=A191123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191123.Bytes);
public long this[int i]=>Value[i];

public static A191123Inst Instance=new A191123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191124
{
public static readonly long[] Value={ 1L,2L,5L,6L,10L,14L,17L,22L,26L,29L,41L,42L,50L,58L,65L,70L,77L,86L,90L,106L,118L,122L,125L,149L,166L,170L,173L,194L,202L,209L,230L,234L,257L,262L,269L,282L,310L,317L,346L,353L,362L,365L,374L,426L,446L,474L,490L,497L,502L,509L,518L,581L,598L,605L,626L,666L,682L,689L,694L,701L,770L,778L,785L,806L,810L,838L,845L,922L,929L,938L,950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191124Inst : IEnumerable<long>
{
public static readonly long[] Value=A191124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191124.Bytes);
public long this[int i]=>Value[i];

public static A191124Inst Instance=new A191124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191125
{
public static readonly long[] Value={ 1L,2L,5L,7L,11L,14L,20L,23L,31L,32L,41L,47L,59L,68L,83L,92L,95L,122L,127L,131L,140L,167L,176L,191L,203L,239L,248L,275L,284L,335L,365L,371L,380L,383L,392L,419L,491L,500L,511L,527L,563L,572L,608L,671L,707L,716L,743L,767L,815L,824L,851L,959L,995L,1004L,1094L,1103L,1112L,1139L,1148L,1175L,1256L,1343L,1463L,1472L,1487L,1499L,1523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191125Inst : IEnumerable<long>
{
public static readonly long[] Value=A191125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191125.Bytes);
public long this[int i]=>Value[i];

public static A191125Inst Instance=new A191125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191126
{
public static readonly long[] Value={ 1L,3L,9L,27L,33L,81L,99L,105L,129L,243L,297L,315L,321L,387L,393L,417L,513L,729L,891L,945L,963L,969L,1161L,1179L,1185L,1251L,1257L,1281L,1539L,1545L,1569L,1665L,2049L,2187L,2673L,2835L,2889L,2907L,2913L,3483L,3537L,3555L,3561L,3753L,3771L,3777L,3843L,3849L,3873L,4617L,4635L,4641L,4707L,4713L,4737L,4995L,5001L,5025L,5121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191126Inst : IEnumerable<long>
{
public static readonly long[] Value=A191126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191126.Bytes);
public long this[int i]=>Value[i];

public static A191126Inst Instance=new A191126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191127
{
public static readonly long[] Value={ 1L,2L,3L,6L,9L,10L,18L,22L,27L,30L,34L,38L,54L,66L,70L,81L,86L,90L,102L,106L,114L,118L,134L,150L,162L,198L,210L,214L,243L,258L,262L,270L,278L,306L,318L,322L,342L,354L,358L,402L,406L,422L,450L,454L,470L,486L,534L,594L,598L,630L,642L,646L,729L,774L,786L,790L,810L,834L,838L,854L,918L,954L,966L,970L,1026L,1030L,1046L,1062L,1074L,1078L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191127Inst : IEnumerable<long>
{
public static readonly long[] Value=A191127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191127.Bytes);
public long this[int i]=>Value[i];

public static A191127Inst Instance=new A191127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191128
{
public static readonly long[] Value={ 1L,3L,9L,11L,27L,33L,35L,43L,81L,99L,105L,107L,129L,131L,139L,171L,243L,297L,315L,321L,323L,387L,393L,395L,417L,419L,427L,513L,515L,523L,555L,683L,729L,891L,945L,963L,969L,971L,1161L,1179L,1185L,1187L,1251L,1257L,1259L,1281L,1283L,1291L,1539L,1545L,1547L,1569L,1571L,1579L,1665L,1667L,1675L,1707L,2049L,2051L,2059L,2091L,2187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191128Inst : IEnumerable<long>
{
public static readonly long[] Value=A191128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191128.Bytes);
public long this[int i]=>Value[i];

public static A191128Inst Instance=new A191128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191129
{
public static readonly long[] Value={ 1L,3L,5L,9L,13L,15L,21L,27L,37L,39L,45L,53L,61L,63L,81L,85L,109L,111L,117L,135L,149L,157L,159L,181L,183L,189L,213L,243L,245L,253L,255L,325L,327L,333L,341L,351L,405L,437L,445L,447L,469L,471L,477L,541L,543L,549L,567L,597L,629L,637L,639L,725L,729L,733L,735L,757L,759L,765L,853L,973L,975L,981L,999L,1013L,1021L,1023L,1053L,1215L,1301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191129Inst : IEnumerable<long>
{
public static readonly long[] Value=A191129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191129.Bytes);
public long this[int i]=>Value[i];

public static A191129Inst Instance=new A191129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191130
{
public static readonly long[] Value={ 1L,3L,6L,9L,14L,18L,26L,27L,38L,42L,54L,58L,74L,78L,81L,106L,110L,114L,126L,154L,162L,170L,174L,218L,222L,234L,243L,298L,314L,318L,326L,330L,342L,378L,426L,442L,458L,462L,486L,506L,510L,522L,618L,650L,654L,666L,682L,698L,702L,729L,874L,890L,894L,938L,942L,954L,974L,978L,990L,1026L,1134L,1194L,1258L,1274L,1278L,1306L,1322L,1326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191130Inst : IEnumerable<long>
{
public static readonly long[] Value=A191130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191130.Bytes);
public long this[int i]=>Value[i];

public static A191130Inst Instance=new A191130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191131
{
public static readonly long[] Value={ 1L,3L,7L,9L,15L,21L,27L,31L,39L,45L,63L,81L,87L,93L,111L,117L,127L,135L,159L,183L,189L,243L,255L,261L,279L,327L,333L,351L,375L,381L,405L,447L,471L,477L,511L,543L,549L,567L,639L,729L,735L,759L,765L,783L,837L,975L,981L,999L,1023L,1047L,1053L,1119L,1125L,1143L,1215L,1311L,1335L,1341L,1407L,1413L,1431L,1503L,1527L,1533L,1623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191131Inst : IEnumerable<long>
{
public static readonly long[] Value=A191131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191131.Bytes);
public long this[int i]=>Value[i];

public static A191131Inst Instance=new A191131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191228
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191228Inst : IEnumerable<long>
{
public static readonly long[] Value=A191228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191228.Bytes);
public long this[int i]=>Value[i];

public static A191228Inst Instance=new A191228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191229
{
public static readonly long[] Value={ 1L,2L,5L,6L,14L,17L,18L,22L,29L,41L,50L,53L,54L,65L,66L,70L,86L,93L,122L,149L,158L,161L,162L,194L,197L,198L,209L,210L,214L,257L,258L,262L,278L,285L,342L,349L,365L,446L,473L,482L,485L,486L,581L,590L,593L,594L,626L,629L,630L,641L,642L,646L,770L,773L,774L,785L,786L,790L,833L,834L,838L,854L,861L,1025L,1026L,1030L,1046L,1053L,1094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191229Inst : IEnumerable<long>
{
public static readonly long[] Value=A191229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191229.Bytes);
public long this[int i]=>Value[i];

public static A191229Inst Instance=new A191229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191230
{
public static readonly long[] Value={ 1L,3L,5L,7L,8L,10L,12L,14L,17L,19L,21L,23L,24L,26L,28L,30L,33L,35L,37L,39L,40L,42L,44L,46L,49L,51L,53L,55L,56L,58L,60L,62L,65L,67L,69L,72L,74L,76L,78L,79L,81L,83L,85L,88L,90L,92L,94L,95L,97L,99L,101L,104L,106L,108L,110L,111L,113L,115L,117L,120L,122L,124L,126L,127L,129L,131L,133L,134L,136L,138L,140L,143L,145L,147L,149L,150L,152L,154L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191230Inst : IEnumerable<long>
{
public static readonly long[] Value=A191230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191230.Bytes);
public long this[int i]=>Value[i];

public static A191230Inst Instance=new A191230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191231
{
public static readonly long[] Value={ 2L,4L,6L,9L,11L,13L,15L,16L,18L,20L,22L,25L,27L,29L,31L,32L,34L,36L,38L,41L,43L,45L,47L,48L,50L,52L,54L,57L,59L,61L,63L,64L,66L,68L,70L,71L,73L,75L,77L,80L,82L,84L,86L,87L,89L,91L,93L,96L,98L,100L,102L,103L,105L,107L,109L,112L,114L,116L,118L,119L,121L,123L,125L,128L,130L,132L,135L,137L,139L,141L,142L,144L,146L,148L,151L,153L,155L,157L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191231Inst : IEnumerable<long>
{
public static readonly long[] Value=A191231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191231.Bytes);
public long this[int i]=>Value[i];

public static A191231Inst Instance=new A191231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191232
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191232Inst : IEnumerable<long>
{
public static readonly long[] Value=A191232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191232.Bytes);
public long this[int i]=>Value[i];

public static A191232Inst Instance=new A191232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191233
{
public static readonly long[] Value={ 1L,1L,5L,8L,11L,4L,16L,19L,23L,27L,32L,14L,38L,42L,47L,51L,23L,61L,64L,31L,35L,37L,80L,84L,47L,50L,96L,101L,106L,59L,117L,120L,123L,127L,131L,136L,83L,145L,150L,155L,160L,165L,172L,175L,109L,112L,189L,116L,201L,206L,125L,218L,129L,130L,232L,236L,147L,245L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191233Inst : IEnumerable<long>
{
public static readonly long[] Value=A191233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191233.Bytes);
public long this[int i]=>Value[i];

public static A191233Inst Instance=new A191233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191234
{
public static readonly long[] Value={ 2L,2L,4L,4L,8L,6L,12L,8L,12L,10L,16L,8L,12L,10L,16L,14L,20L,12L,18L,12L,20L,18L,26L,14L,20L,8L,12L,8L,12L,6L,10L,4L,6L,2L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191234Inst : IEnumerable<long>
{
public static readonly long[] Value=A191234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191234.Bytes);
public long this[int i]=>Value[i];

public static A191234Inst Instance=new A191234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191235
{
public static readonly long[] Value={ 11L,23L,43L,83L,181L,353L,359L,383L,643L,661L,691L,709L,739L,751L,1301L,1307L,1361L,1373L,1433L,1481L,1487L,1511L,1523L,2617L,2647L,2689L,2707L,2731L,2749L,2767L,2791L,2857L,2887L,3001L,3019L,3061L,3067L,5147L,5189L,5297L,5309L,5333L,5387L,5393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191235Inst : IEnumerable<long>
{
public static readonly long[] Value=A191235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191235.Bytes);
public long this[int i]=>Value[i];

public static A191235Inst Instance=new A191235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191236
{
public static readonly BigInteger[] Value={ 1L,2L,14L,184L,3532L,89256L,2800016L,104967808L,4578528464L,227816059360L,12735645181536L,790296855912576L,53905019035510528L,4008716449677965312L,BigInteger.Parse("322807879692969879552"),BigInteger.Parse("27983800239966141382656") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191236Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191236.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191236Inst Instance=new A191236Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191237
{
public static readonly long[] Value={ 1L,1L,1L,7L,25L,181L,1201L,5251L,57457L,469225L,4340161L,50118751L,412902601L,5544552157L,69259632625L,816044592091L,12518563864801L,152563427413201L,2401979910598657L,39326158638385975L,575414895837696121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191237Inst : IEnumerable<long>
{
public static readonly long[] Value=A191237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191237.Bytes);
public long this[int i]=>Value[i];

public static A191237Inst Instance=new A191237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191238
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,2L,0L,1L,1L,0L,3L,0L,1L,0L,3L,0L,4L,0L,1L,0L,0L,6L,0L,5L,0L,1L,0L,2L,0L,10L,0L,6L,0L,1L,0L,0L,7L,0L,15L,0L,7L,0L,1L,0L,1L,0L,16L,0L,21L,0L,8L,0L,1L,0L,0L,6L,0L,30L,0L,28L,0L,9L,0L,1L,0L,0L,0L,19L,0L,50L,0L,36L,0L,10L,0L,1L,0L,0L,3L,0L,45L,0L,77L,0L,45L,0L,11L,0L,1L,0L,0L,0L,16L,0L,90L,0L,112L,0L,55L,0L,12L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191238Inst : IEnumerable<long>
{
public static readonly long[] Value=A191238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191238.Bytes);
public long this[int i]=>Value[i];

public static A191238Inst Instance=new A191238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191239
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,0L,5L,3L,1L,0L,4L,9L,4L,1L,0L,4L,13L,14L,5L,1L,0L,0L,18L,28L,20L,6L,1L,0L,0L,12L,49L,50L,27L,7L,1L,0L,0L,8L,56L,105L,80L,35L,8L,1L,0L,0L,0L,56L,161L,195L,119L,44L,9L,1L,0L,0L,0L,32L,210L,366L,329L,168L,54L,10L,1L,0L,0L,0L,16L,200L,581L,721L,518L,228L,65L,11L,1L,0L,0L,0L,0L,160L,732L,1337L,1288L,774L,300L,77L,12L,1L,0L,0L,0L,0L,80L,780L,2045L,2716L,2142L,1110L,385L,90L,13L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191239Inst : IEnumerable<long>
{
public static readonly long[] Value=A191239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191239.Bytes);
public long this[int i]=>Value[i];

public static A191239Inst Instance=new A191239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191240
{
public static readonly BigInteger[] Value={ 2L,5L,11L,23L,751L,98532121L,BigInteger.Parse("1774996909423391837779439"),BigInteger.Parse("119118026194914721260250490587027"),BigInteger.Parse("589843896109318746798137859575487687505955816477967656273093"),BigInteger.Parse("39583753805230400911526669071502500954511688078028890441229798158139") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191240Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191240.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191240Inst Instance=new A191240Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191241
{
public static readonly long[] Value={ 1L,1L,2L,5L,16L,56L,204L,759L,2880L,11132L,43732L,174122L,700952L,2847840L,11661592L,48080811L,199433880L,831649380L,3484523460L,14662036550L,61931353880L,262503848400L,1116179957160L,4759795460550L,20351410848288L,87229181620152L,374722175164232L,1613115479264852L,6957700944802160L,30064406772108544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191241Inst : IEnumerable<long>
{
public static readonly long[] Value=A191241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191241.Bytes);
public long this[int i]=>Value[i];

public static A191241Inst Instance=new A191241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191242
{
public static readonly long[] Value={ 1L,1L,3L,12L,50L,224L,1054L,5121L,25509L,129591L,668811L,3496740L,18481512L,98585788L,530068840L,2869725800L,15630429306L,85589391884L,470905310206L,2601941245750L,14432082902820L,80328808797750L,448527122885700L,2511672193514250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191242Inst : IEnumerable<long>
{
public static readonly long[] Value=A191242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191242.Bytes);
public long this[int i]=>Value[i];

public static A191242Inst Instance=new A191242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191243
{
public static readonly long[] Value={ 1L,1L,3L,11L,45L,197L,902L,4269L,20717L,102531L,515521L,2625909L,13521776L,70274194L,368131940L,1941801115L,10304601189L,54976677289L,294708283729L,1586565791533L,8574185062861L,46498569928775L,252966168370110L,1380203261726925L,7550534790990360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191243Inst : IEnumerable<long>
{
public static readonly long[] Value=A191243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191243.Bytes);
public long this[int i]=>Value[i];

public static A191243Inst Instance=new A191243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191276
{
public static readonly long[] Value={ 0L,1L,4L,5L,7L,8L,11L,12L,13L,16L,17L,19L,20L,23L,24L,25L,28L,29L,31L,32L,35L,36L,37L,40L,41L,43L,44L,47L,48L,49L,52L,53L,55L,56L,59L,60L,61L,64L,65L,67L,68L,71L,72L,73L,76L,77L,79L,80L,83L,84L,85L,88L,89L,91L,92L,95L,96L,97L,100L,101L,103L,104L,107L,108L,109L,112L,113L,115L,116L,119L,120L,121L,124L,125L,127L,128L,131L,132L,133L,136L,137L,139L,140L,143L,144L,145L,148L,149L,151L,152L,155L,156L,157L,160L,161L,163L,164L,167L,168L,169L,172L,173L,175L,176L,179L,180L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191276Inst : IEnumerable<long>
{
public static readonly long[] Value=A191276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191276.Bytes);
public long this[int i]=>Value[i];

public static A191276Inst Instance=new A191276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191277
{
public static readonly BigInteger[] Value={ 1L,1L,2L,10L,56L,376L,3152L,30640L,338816L,4226176L,58564352L,892337920L,14834994176L,267186021376L,5182147684352L,107689460377600L,2387077442011136L,56219583797886976L,1401949974947889152L,BigInteger.Parse("36902741817196871680"),BigInteger.Parse("1022494706646806429696") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191277Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191277.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191277Inst Instance=new A191277Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191278
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,1L,1L,3L,1L,6L,1L,3L,3L,1L,1L,6L,1L,6L,3L,3L,1L,10L,1L,3L,1L,6L,1L,16L,1L,1L,3L,3L,3L,20L,1L,3L,3L,10L,1L,16L,1L,6L,6L,3L,1L,15L,1L,6L,3L,6L,1L,10L,3L,10L,3L,3L,1L,50L,1L,3L,6L,1L,3L,16L,1L,6L,3L,16L,1L,50L,1L,3L,6L,6L,3L,16L,1L,15L,1L,3L,1L,50L,3L,3L,3L,10L,1L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191278Inst : IEnumerable<long>
{
public static readonly long[] Value=A191278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191278.Bytes);
public long this[int i]=>Value[i];

public static A191278Inst Instance=new A191278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191279
{
public static readonly long[] Value={ 22L,51L,87L,91L,102L,121L,145L,169L,187L,190L,212L,220L,225L,245L,247L,248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191279Inst : IEnumerable<long>
{
public static readonly long[] Value=A191279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191279.Bytes);
public long this[int i]=>Value[i];

public static A191279Inst Instance=new A191279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191280
{
public static readonly long[] Value={ 1L,1L,2L,6L,18L,60L,210L,754L,2766L,10280L,38568L,145770L,554162L,2116568L,8115660L,31220672L,120442860L,465775226L,1805074882L,7008550224L,27257398714L,106166467074L,414068416752L,1616899329454L,6320798698322L,24734167234028L,96877398455260L,379765373701964L,1489867265555382L,5849164981941642L,22979031257945948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191280Inst : IEnumerable<long>
{
public static readonly long[] Value=A191280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191280.Bytes);
public long this[int i]=>Value[i];

public static A191280Inst Instance=new A191280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191281
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,12L,13L,14L,16L,24L,26L,28L,31L,32L,43L,48L,52L,56L,57L,62L,64L,86L,96L,104L,112L,114L,124L,128L,133L,157L,172L,183L,192L,208L,224L,228L,241L,248L,256L,266L,314L,344L,366L,384L,416L,448L,456L,482L,496L,512L,532L,553L,628L,651L,688L,732L,757L,768L,832L,896L,912L,931L,964L,992L,993L,1024L,1064L,1106L,1256L,1302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191281Inst : IEnumerable<long>
{
public static readonly long[] Value=A191281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191281.Bytes);
public long this[int i]=>Value[i];

public static A191281Inst Instance=new A191281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191282
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,12L,13L,14L,16L,21L,24L,26L,28L,32L,42L,43L,48L,52L,56L,57L,64L,73L,84L,86L,96L,104L,112L,114L,128L,146L,157L,168L,172L,183L,192L,208L,211L,224L,228L,256L,273L,292L,314L,336L,344L,366L,384L,416L,422L,448L,456L,463L,512L,546L,584L,601L,628L,672L,688L,703L,732L,768L,813L,832L,844L,896L,912L,926L,1024L,1057L,1092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191282Inst : IEnumerable<long>
{
public static readonly long[] Value=A191282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191282.Bytes);
public long this[int i]=>Value[i];

public static A191282Inst Instance=new A191282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191283
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,10L,12L,16L,20L,21L,24L,32L,36L,40L,42L,48L,55L,64L,72L,78L,80L,84L,96L,110L,128L,136L,144L,156L,160L,168L,192L,210L,220L,231L,256L,272L,288L,300L,312L,320L,336L,384L,420L,440L,462L,512L,528L,544L,576L,600L,624L,640L,666L,672L,768L,820L,840L,880L,903L,924L,1024L,1056L,1088L,1152L,1176L,1200L,1248L,1280L,1332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191283Inst : IEnumerable<long>
{
public static readonly long[] Value=A191283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191283.Bytes);
public long this[int i]=>Value[i];

public static A191283Inst Instance=new A191283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191284
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,12L,13L,16L,18L,19L,24L,26L,27L,28L,32L,36L,38L,39L,40L,42L,48L,52L,54L,56L,57L,58L,60L,63L,64L,72L,76L,78L,80L,81L,84L,85L,87L,90L,94L,96L,104L,108L,112L,114L,116L,117L,120L,121L,126L,127L,128L,130L,135L,141L,144L,152L,156L,160L,162L,168L,170L,171L,174L,175L,180L,181L,188L,189L,190L,192L,195L,202L,208L,211L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191284Inst : IEnumerable<long>
{
public static readonly long[] Value=A191284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191284.Bytes);
public long this[int i]=>Value[i];

public static A191284Inst Instance=new A191284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191285
{
public static readonly long[] Value={ 0L,1L,3L,4L,8L,9L,12L,24L,27L,32L,36L,40L,72L,81L,96L,108L,120L,216L,243L,288L,324L,360L,364L,512L,648L,729L,800L,864L,972L,1080L,1092L,1536L,1944L,2187L,2400L,2592L,2916L,3240L,3276L,3280L,4608L,5832L,6561L,7200L,7776L,8748L,9720L,9828L,9840L,13824L,17496L,19683L,21600L,23328L,26244L,29160L,29484L,29520L,29524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191285Inst : IEnumerable<long>
{
public static readonly long[] Value=A191285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191285.Bytes);
public long this[int i]=>Value[i];

public static A191285Inst Instance=new A191285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191286
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,9L,10L,15L,18L,26L,27L,30L,37L,45L,54L,78L,81L,82L,90L,101L,111L,135L,162L,226L,234L,243L,246L,270L,303L,325L,333L,405L,486L,677L,678L,702L,729L,730L,738L,810L,901L,909L,975L,999L,1215L,1370L,1458L,2026L,2031L,2034L,2106L,2187L,2190L,2214L,2430L,2703L,2727L,2917L,2925L,2997L,3645L,4110L,4374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191286Inst : IEnumerable<long>
{
public static readonly long[] Value=A191286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191286.Bytes);
public long this[int i]=>Value[i];

public static A191286Inst Instance=new A191286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191287
{
public static readonly long[] Value={ 1L,3L,4L,6L,9L,12L,13L,18L,19L,27L,28L,36L,39L,40L,42L,54L,57L,58L,60L,63L,81L,84L,85L,87L,90L,94L,108L,117L,120L,121L,126L,127L,130L,135L,141L,162L,171L,174L,175L,180L,181L,189L,190L,195L,202L,211L,243L,252L,255L,256L,261L,262L,270L,271L,282L,283L,285L,292L,303L,316L,324L,351L,360L,363L,364L,378L,381L,382L,384L,390L,391L,393L,405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191287Inst : IEnumerable<long>
{
public static readonly long[] Value=A191287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191287.Bytes);
public long this[int i]=>Value[i];

public static A191287Inst Instance=new A191287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191288
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,8L,10L,16L,20L,21L,32L,33L,40L,42L,64L,66L,80L,84L,85L,128L,132L,133L,147L,160L,168L,170L,256L,264L,266L,294L,320L,336L,340L,341L,363L,512L,528L,532L,533L,588L,640L,672L,680L,682L,726L,1024L,1056L,1064L,1066L,1176L,1280L,1344L,1360L,1364L,1365L,1452L,2048L,2112L,2128L,2132L,2133L,2352L,2408L,2560L,2688L,2720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191288Inst : IEnumerable<long>
{
public static readonly long[] Value=A191288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191288.Bytes);
public long this[int i]=>Value[i];

public static A191288Inst Instance=new A191288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191289
{
public static readonly long[] Value={ 1L,2L,4L,5L,11L,14L,16L,25L,32L,41L,47L,74L,95L,121L,122L,140L,196L,221L,256L,284L,362L,365L,419L,587L,625L,662L,767L,851L,1024L,1085L,1094L,1256L,1681L,1760L,1874L,1985L,2209L,2300L,2552L,3071L,3254L,3281L,3767L,5042L,5279L,5476L,5621L,5954L,6626L,6899L,7655L,9025L,9212L,9761L,9842L,11300L,14641L,14884L,15125L,15836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191289Inst : IEnumerable<long>
{
public static readonly long[] Value=A191289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191289.Bytes);
public long this[int i]=>Value[i];

public static A191289Inst Instance=new A191289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191290
{
public static readonly long[] Value={ 1L,3L,6L,7L,13L,15L,21L,27L,28L,31L,43L,55L,57L,63L,87L,91L,111L,115L,120L,127L,175L,183L,223L,231L,241L,255L,351L,367L,378L,406L,447L,463L,483L,496L,511L,703L,735L,757L,813L,895L,927L,946L,967L,993L,1023L,1407L,1471L,1515L,1540L,1627L,1653L,1791L,1855L,1893L,1935L,1987L,2016L,2047L,2815L,2943L,3031L,3081L,3255L,3307L,3583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191290Inst : IEnumerable<long>
{
public static readonly long[] Value=A191290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191290.Bytes);
public long this[int i]=>Value[i];

public static A191290Inst Instance=new A191290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191291
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191291Inst : IEnumerable<long>
{
public static readonly long[] Value=A191291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191291.Bytes);
public long this[int i]=>Value[i];

public static A191291Inst Instance=new A191291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191388
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,14L,23L,41L,69L,125L,214L,393L,682L,1267L,2223L,4171L,7385L,13976L,24935L,47544L,85377L,163863L,295900L,571216L,1036471L,2011130L,3664548L,7143068L,13063637L,25568085L,46912433L,92152906L,169570215L,334194418L,616530391L,1218694221L,2253451666L,4466410838L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191388Inst : IEnumerable<long>
{
public static readonly long[] Value=A191388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191388.Bytes);
public long this[int i]=>Value[i];

public static A191388Inst Instance=new A191388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191389
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,7L,14L,37L,74L,176L,352L,794L,1588L,3473L,6946L,14893L,29786L,63004L,126008L,263950L,527900L,1097790L,2195580L,4540386L,9080772L,18696432L,37392864L,76717268L,153434536L,313889477L,627778954L,1281220733L,2562441466L,5219170052L,10438340104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191389Inst : IEnumerable<long>
{
public static readonly long[] Value=A191389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191389.Bytes);
public long this[int i]=>Value[i];

public static A191389Inst Instance=new A191389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191390
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,3L,2L,3L,1L,0L,8L,2L,5L,8L,7L,0L,22L,12L,1L,14L,22L,31L,3L,0L,64L,50L,12L,42L,64L,117L,28L,1L,0L,196L,184L,78L,4L,132L,196L,416L,162L,18L,0L,625L,648L,390L,52L,1L,429L,625L,1452L,762L,159L,5L,0L,2055L,2256L,1707L,392L,25L,1430L,2055L,5062L,3225L,1012L,85L,1L,0L,6917L,7868L,6954L,2280L,285L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191390Inst : IEnumerable<long>
{
public static readonly long[] Value=A191390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191390.Bytes);
public long this[int i]=>Value[i];

public static A191390Inst Instance=new A191390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191391
{
public static readonly long[] Value={ 0L,1L,1L,3L,5L,12L,22L,49L,93L,200L,386L,814L,1586L,3304L,6476L,13381L,26333L,54096L,106762L,218386L,431910L,880616L,1744436L,3547658L,7036530L,14281072L,28354132L,57451164L,114159428L,230993296L,459312152L,928319149L,1846943453L,3729244576L,7423131482L,14975907754L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191391Inst : IEnumerable<long>
{
public static readonly long[] Value=A191391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191391.Bytes);
public long this[int i]=>Value[i];

public static A191391Inst Instance=new A191391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191392
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,4L,1L,1L,6L,3L,2L,9L,8L,1L,3L,12L,16L,4L,8L,18L,30L,13L,1L,13L,26L,50L,32L,5L,31L,47L,83L,71L,19L,1L,49L,80L,132L,140L,55L,6L,109L,162L,223L,263L,140L,26L,1L,170L,292L,377L,468L,316L,86L,7L,371L,592L,693L,830L,665L,246L,34L,1L,581L,1064L,1264L,1456L,1314L,622L,126L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191392Inst : IEnumerable<long>
{
public static readonly long[] Value=A191392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191392.Bytes);
public long this[int i]=>Value[i];

public static A191392Inst Instance=new A191392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191393
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,3L,8L,13L,31L,49L,109L,170L,371L,581L,1270L,2010L,4417L,7063L,15581L,25123L,55554L,90179L,199752L,326089L,723351L,1186670L,2635764L,4342829L,9657336L,15973459L,35558165L,59017088L,131500422L,218932442L,488234057L,815127111L,1819186163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191393Inst : IEnumerable<long>
{
public static readonly long[] Value=A191393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191393.Bytes);
public long this[int i]=>Value[i];

public static A191393Inst Instance=new A191393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191394
{
public static readonly long[] Value={ 0L,0L,1L,2L,6L,12L,28L,56L,121L,242L,507L,1014L,2093L,4186L,8569L,17138L,34902L,69804L,141664L,283328L,573574L,1147148L,2318010L,4636020L,9354540L,18709080L,37708672L,75417344L,151868100L,303736200L,611180252L,1222360504L,2458123705L,4916247410L,9881255187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191394Inst : IEnumerable<long>
{
public static readonly long[] Value=A191394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191394.Bytes);
public long this[int i]=>Value[i];

public static A191394Inst Instance=new A191394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191395
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,3L,2L,1L,4L,5L,2L,5L,9L,4L,3L,6L,14L,12L,8L,9L,20L,25L,8L,13L,14L,27L,44L,28L,31L,29L,40L,70L,66L,16L,49L,54L,62L,104L,129L,64L,109L,115L,116L,159L,225L,168L,32L,170L,212L,217L,250L,363L,360L,144L,371L,430L,445L,444L,581L,681L,416L,64L,581L,772L,854L,820L,938L,1182L,968L,320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191395Inst : IEnumerable<long>
{
public static readonly long[] Value=A191395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191395.Bytes);
public long this[int i]=>Value[i];

public static A191395Inst Instance=new A191395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191396
{
public static readonly long[] Value={ 0L,0L,1L,2L,7L,14L,35L,70L,156L,312L,663L,1326L,2756L,5512L,11325L,22650L,46227L,92454L,187891L,375782L,761465L,1522930L,3079475L,6158950L,12434015L,24868030L,50142687L,100285374L,202010787L,404021574L,813191039L,1626382078L,3271314744L,6542629488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191396Inst : IEnumerable<long>
{
public static readonly long[] Value=A191396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191396.Bytes);
public long this[int i]=>Value[i];

public static A191396Inst Instance=new A191396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191397
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,9L,1L,18L,2L,28L,7L,56L,14L,89L,37L,179L,72L,1L,289L,170L,3L,585L,326L,13L,956L,726L,34L,1948L,1380L,104L,3214L,2970L,250L,1L,6591L,5616L,659L,4L,10959L,11829L,1502L,20L,22609L,22300L,3647L,64L,37833L,46306L,8019L,220L,78486L,87154L,18495L,620L,1L,132037L,179222L,39648L,1804L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191397Inst : IEnumerable<long>
{
public static readonly long[] Value=A191397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191397.Bytes);
public long this[int i]=>Value[i];

public static A191397Inst Instance=new A191397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191398
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,9L,18L,28L,56L,89L,179L,289L,585L,956L,1948L,3214L,6591L,10959L,22609L,37833L,78486L,132037L,275316L,465255L,974659L,1653418L,3478520L,5920569L,12504448L,21344348L,45240473L,77417309L,164624203L,282335973L,602163830L,1034757445L,2212959172L,3809387953L,8167344875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191398Inst : IEnumerable<long>
{
public static readonly long[] Value=A191398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191398.Bytes);
public long this[int i]=>Value[i];

public static A191398Inst Instance=new A191398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191399
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,1L,8L,2L,13L,7L,21L,14L,34L,35L,1L,55L,68L,3L,89L,149L,14L,144L,282L,36L,233L,576L,114L,1L,377L,1068L,267L,4L,610L,2088L,711L,23L,987L,3810L,1566L,72L,1597L,7229L,3771L,272L,1L,2584L,13024L,7953L,744L,5L,4181L,24179L,17922L,2304L,34L,6765L,43114L,36594L,5780L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191399Inst : IEnumerable<long>
{
public static readonly long[] Value=A191399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191399.Bytes);
public long this[int i]=>Value[i];

public static A191399Inst Instance=new A191399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191400
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,0L,0L,2L,2L,3L,1L,1L,0L,3L,0L,1L,2L,0L,2L,1L,3L,2L,1L,4L,1L,3L,0L,2L,3L,4L,0L,4L,1L,2L,2L,1L,0L,2L,2L,2L,1L,0L,3L,4L,2L,3L,1L,0L,4L,2L,1L,0L,3L,5L,0L,1L,2L,2L,3L,2L,4L,2L,0L,3L,4L,1L,1L,3L,2L,2L,2L,1L,1L,5L,0L,3L,2L,3L,2L,4L,2L,3L,1L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191400Inst : IEnumerable<long>
{
public static readonly long[] Value=A191400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191400.Bytes);
public long this[int i]=>Value[i];

public static A191400Inst Instance=new A191400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191401
{
public static readonly long[] Value={ 2L,9L,10L,42L,44L,50L,52L,135L,150L,156L,184L,198L,204L,210L,225L,228L,232L,675L,684L,696L,728L,744L,752L,920L,944L,968L,976L,2484L,2544L,2646L,2673L,2744L,2772L,2835L,2904L,2928L,2992L,3132L,3150L,3192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191401Inst : IEnumerable<long>
{
public static readonly long[] Value=A191401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191401.Bytes);
public long this[int i]=>Value[i];

public static A191401Inst Instance=new A191401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191402
{
public static readonly long[] Value={ 1L,4L,7L,10L,14L,17L,20L,23L,26L,30L,33L,36L,40L,43L,46L,49L,52L,56L,59L,62L,65L,68L,72L,75L,78L,82L,85L,88L,91L,94L,98L,101L,104L,108L,111L,114L,117L,120L,124L,127L,130L,133L,136L,140L,143L,146L,150L,153L,156L,159L,162L,166L,169L,172L,175L,178L,182L,185L,188L,192L,195L,198L,201L,204L,208L,211L,214L,218L,221L,224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191402Inst : IEnumerable<long>
{
public static readonly long[] Value=A191402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191402.Bytes);
public long this[int i]=>Value[i];

public static A191402Inst Instance=new A191402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191403
{
public static readonly long[] Value={ 3L,5L,9L,12L,15L,19L,21L,25L,28L,31L,35L,38L,41L,45L,47L,51L,54L,57L,61L,63L,67L,70L,73L,77L,80L,83L,87L,89L,93L,96L,99L,103L,106L,109L,113L,115L,119L,122L,125L,129L,131L,135L,138L,141L,145L,148L,151L,155L,157L,161L,164L,167L,171L,173L,177L,180L,183L,187L,190L,193L,197L,199L,203L,206L,209L,213L,216L,219L,223L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191403Inst : IEnumerable<long>
{
public static readonly long[] Value=A191403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191403.Bytes);
public long this[int i]=>Value[i];

public static A191403Inst Instance=new A191403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191452
{
public static readonly long[] Value={ 1L,4L,2L,16L,8L,3L,64L,32L,12L,5L,256L,128L,48L,20L,6L,1024L,512L,192L,80L,24L,7L,4096L,2048L,768L,320L,96L,28L,9L,16384L,8192L,3072L,1280L,384L,112L,36L,10L,65536L,32768L,12288L,5120L,1536L,448L,144L,40L,11L,262144L,131072L,49152L,20480L,6144L,1792L,576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191452Inst : IEnumerable<long>
{
public static readonly long[] Value=A191452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191452.Bytes);
public long this[int i]=>Value[i];

public static A191452Inst Instance=new A191452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191453
{
public static readonly long[] Value={ 1L,2L,3L,6L,8L,4L,18L,24L,12L,5L,54L,72L,36L,14L,7L,162L,216L,108L,42L,20L,9L,486L,648L,324L,126L,60L,26L,10L,1458L,1944L,972L,378L,180L,78L,30L,11L,4374L,5832L,2916L,1134L,540L,234L,90L,32L,13L,13122L,17496L,8748L,3402L,1620L,702L,270L,96L,38L,15L,39366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191453Inst : IEnumerable<long>
{
public static readonly long[] Value=A191453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191453.Bytes);
public long this[int i]=>Value[i];

public static A191453Inst Instance=new A191453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191454
{
public static readonly long[] Value={ 1L,2L,3L,6L,8L,4L,18L,24L,12L,5L,58L,76L,38L,16L,7L,186L,244L,122L,50L,22L,9L,600L,788L,394L,160L,70L,28L,10L,1940L,2550L,1274L,516L,226L,90L,32L,11L,6276L,8250L,4122L,1668L,730L,290L,102L,34L,13L,20308L,26696L,13338L,5396L,2362L,938L,330L,110L,42L,14L,65718L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191454Inst : IEnumerable<long>
{
public static readonly long[] Value=A191454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191454.Bytes);
public long this[int i]=>Value[i];

public static A191454Inst Instance=new A191454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191455
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,4L,13L,21L,10L,6L,35L,57L,27L,16L,7L,95L,154L,73L,43L,19L,9L,258L,418L,198L,116L,51L,24L,11L,701L,1136L,538L,315L,138L,65L,29L,12L,1905L,3087L,1462L,856L,375L,176L,78L,32L,14L,5178L,8391L,3974L,2326L,1019L,478L,212L,86L,38L,15L,14075L,22809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191455Inst : IEnumerable<long>
{
public static readonly long[] Value=A191455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191455.Bytes);
public long this[int i]=>Value[i];

public static A191455Inst Instance=new A191455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191456
{
public static readonly long[] Value={ 11L,17L,41L,844427L,51448361L,86966771L,122983031L,180078317L,960959381L,1278189947L,1761702947L,1829187287L,2426256797L,2911675511L,3013107257L,4778888351L,5221343711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191456Inst : IEnumerable<long>
{
public static readonly long[] Value=A191456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191456.Bytes);
public long this[int i]=>Value[i];

public static A191456Inst Instance=new A191456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191457
{
public static readonly long[] Value={ 17L,41L,180078317L,1278189947L,1761702947L,1829187287L,5862143447L,6369321857L,7226006861L,8776320587L,10102729577L,11085833111L,12412643261L,50626299797L,53039299211L,72355485857L,74621287901L,76233413141L,81948881447L,115826556611L,129077263697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191457Inst : IEnumerable<long>
{
public static readonly long[] Value=A191457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191457.Bytes);
public long this[int i]=>Value[i];

public static A191457Inst Instance=new A191457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191458
{
public static readonly long[] Value={ 17L,41L,1761702947L,8776320587L,10102729577L,11085833111L,177558051107L,273373448057L,473787509537L,557149355507L,715464238661L,1359854730821L,2131528031441L,2170341748697L,2236159108277L,2308235320997L,2751203698151L,3247566894821L,3288002848511L,3424305123047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191458Inst : IEnumerable<long>
{
public static readonly long[] Value=A191458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191458.Bytes);
public long this[int i]=>Value[i];

public static A191458Inst Instance=new A191458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191459
{
public static readonly BigInteger[] Value={ 1L,1L,4L,32L,404L,7136L,164088L,4683680L,160473988L,6437653568L,296657482888L,15467576203136L,901391710293832L,58122426582341120L,4111838048797360624L,BigInteger.Parse("316858691136196764672"),BigInteger.Parse("26432968974665127895908"),BigInteger.Parse("2374343115004631725352960") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191459Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191459.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191459Inst Instance=new A191459Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191460
{
public static readonly BigInteger[] Value={ 1L,1L,-1L,2L,6L,24L,-480L,720L,13440L,100800L,-1874880L,3628800L,22619520L,479001600L,-36739422720L,468583315200L,6345334195200L,20922789888000L,-4289844445286400L,6402373705728000L,363873320191180800L,BigInteger.Parse("18895538930171904000"),BigInteger.Parse("-350378437544239104000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191460Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191460.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191460Inst Instance=new A191460Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191461
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,18L,24L,480L,720L,23520L,100800L,1874880L,3628800L,341953920L,479001600L,36739422720L,468583315200L,8960682931200L,20922789888000L,4289844445286400L,6402373705728000L,1012647189038284800L,BigInteger.Parse("18895538930171904000"),BigInteger.Parse("350378437544239104000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191461Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191461.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191461Inst Instance=new A191461Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191462
{
public static readonly long[] Value={ 1L,1L,0L,6L,12L,100L,780L,-1092L,43344L,48816L,1264320L,24662880L,-162851040L,4327633440L,-17686783296L,275230488960L,3743721112320L,-70886371933440L,2127136959383040L,-25991855154846720L,402985066993459200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191462Inst : IEnumerable<long>
{
public static readonly long[] Value=A191462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191462.Bytes);
public long this[int i]=>Value[i];

public static A191462Inst Instance=new A191462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191463
{
public static readonly BigInteger[] Value={ 1L,0L,6L,15L,1596L,28155L,2752266L,152499165L,18328556616L,2081907926295L,342948671262246L,63036450590713545L,14410958655520684956UL,BigInteger.Parse("3796531150529363706915"),BigInteger.Parse("1173277778862573074248746"),BigInteger.Parse("415134737359852340707539405"),BigInteger.Parse("167697531024902643857808300816"),BigInteger.Parse("76517905142019788108453415876015") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191463Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191463.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191463Inst Instance=new A191463Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191464
{
public static readonly long[] Value={ 1L,0L,2L,-3L,12L,-60L,226L,-1323L,7872L,-47688L,350760L,-2677323L,21860264L,-197850276L,1885325040L,-19153887483L,208328775168L,-2386457931984L,28865395641280L,-368167396914963L,4923222534781824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191464Inst : IEnumerable<long>
{
public static readonly long[] Value=A191464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191464.Bytes);
public long this[int i]=>Value[i];

public static A191464Inst Instance=new A191464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191465
{
public static readonly long[] Value={ 0L,7L,77L,721L,6545L,59017L,531377L,4782841L,43046465L,387419977L,3486783377L,31381057561L,282429532385L,2541865820137L,22876792438577L,205891132061881L,1853020188786305L,16677181699535497L,150094635296736977L,1350851717672467801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191465Inst : IEnumerable<long>
{
public static readonly long[] Value=A191465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191465.Bytes);
public long this[int i]=>Value[i];

public static A191465Inst Instance=new A191465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191466
{
public static readonly long[] Value={ 0L,4L,56L,604L,5936L,55924L,515816L,4704844L,42656096L,385467364L,3477018776L,31332231484L,282185395856L,2540645125204L,22870688939336L,205860614516524L,1852867600961216L,16676418760213444L,150090820599733496L,1350832644186663964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191466Inst : IEnumerable<long>
{
public static readonly long[] Value=A191466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191466.Bytes);
public long this[int i]=>Value[i];

public static A191466Inst Instance=new A191466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191467
{
public static readonly long[] Value={ 0L,2L,32L,386L,4160L,42242L,413792L,3959426L,37281920L,347066882L,3204309152L,29403732866L,268588249280L,2444976817922L,22198569382112L,201143570584706L,1819787258282240L,16444551185679362L,148466221699088672L,1339452822487618946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191467Inst : IEnumerable<long>
{
public static readonly long[] Value=A191467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191467.Bytes);
public long this[int i]=>Value[i];

public static A191467Inst Instance=new A191467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191500
{
public static readonly BigInteger[] Value={ 1L,1L,-1L,-5L,17L,249L,-1489L,-27453L,237537L,6037041L,-68649441L,-2107439157L,29789919345L,1092524775081L,-18492402857265L,-781266357571053L,15425010795541185L,739391174869277025L,BigInteger.Parse("-16695627953904545985"),BigInteger.Parse("-893468264544135234405"),BigInteger.Parse("22725280358984904476625") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191500Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191500.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191500Inst Instance=new A191500Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191501
{
public static readonly long[] Value={ 1L,2L,4L,10L,28L,96L,354L,1372L,5512L,22740L,95768L,410016L,1779210L,7807724L,34589432L,154488460L,694883528L,3144917888L,14311109396L,65439770904L,300534169744L,1385612474536L,6410981989808L,29757955549888L,138534010818650L,646663905140300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191501Inst : IEnumerable<long>
{
public static readonly long[] Value=A191501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191501.Bytes);
public long this[int i]=>Value[i];

public static A191501Inst Instance=new A191501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191502
{
public static readonly long[] Value={ 1L,9L,1L,8L,7L,2L,4L,6L,6L,5L,9L,7L,7L,6L,3L,4L,5L,2L,9L,6L,6L,0L,3L,7L,8L,2L,5L,0L,7L,4L,9L,8L,1L,5L,7L,5L,3L,0L,1L,6L,9L,1L,8L,3L,1L,2L,6L,6L,3L,0L,7L,2L,5L,4L,9L,5L,6L,4L,0L,5L,7L,7L,3L,9L,9L,8L,3L,8L,1L,0L,1L,8L,1L,1L,4L,5L,0L,1L,1L,6L,9L,9L,3L,7L,1L,3L,1L,5L,6L,7L,0L,6L,6L,7L,3L,3L,6L,7L,4L,7L,3L,4L,1L,6L,8L,6L,2L,4L,8L,7L,1L,1L,6L,3L,7L,7L,5L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191502Inst : IEnumerable<long>
{
public static readonly long[] Value=A191502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191502.Bytes);
public long this[int i]=>Value[i];

public static A191502Inst Instance=new A191502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191503
{
public static readonly long[] Value={ 1L,7L,5L,2L,3L,5L,1L,5L,5L,8L,0L,8L,1L,0L,8L,0L,8L,2L,6L,7L,1L,4L,0L,8L,6L,6L,6L,4L,8L,3L,9L,3L,6L,6L,6L,5L,3L,3L,5L,5L,7L,1L,4L,0L,1L,0L,7L,4L,2L,3L,9L,3L,0L,3L,3L,0L,8L,5L,7L,4L,1L,2L,7L,8L,3L,6L,1L,8L,4L,0L,9L,6L,0L,8L,2L,2L,9L,7L,2L,8L,0L,2L,2L,9L,5L,0L,1L,8L,2L,0L,5L,2L,8L,6L,8L,3L,0L,1L,2L,6L,9L,2L,9L,4L,8L,6L,9L,4L,9L,2L,3L,9L,8L,5L,3L,1L,4L,4L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191503Inst : IEnumerable<long>
{
public static readonly long[] Value=A191503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191503.Bytes);
public long this[int i]=>Value[i];

public static A191503Inst Instance=new A191503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191504
{
public static readonly long[] Value={ 6L,6L,2L,0L,9L,4L,2L,5L,1L,7L,8L,5L,1L,0L,3L,7L,5L,8L,8L,1L,2L,3L,1L,8L,1L,0L,8L,9L,8L,4L,1L,6L,3L,6L,8L,6L,0L,7L,3L,3L,8L,5L,4L,7L,7L,0L,8L,1L,2L,4L,4L,6L,6L,3L,2L,3L,2L,0L,1L,9L,3L,1L,2L,8L,5L,5L,4L,0L,4L,3L,3L,9L,7L,6L,2L,2L,7L,7L,5L,4L,4L,4L,2L,4L,3L,0L,1L,4L,4L,7L,8L,9L,8L,2L,6L,0L,6L,5L,3L,6L,4L,9L,6L,5L,7L,8L,9L,6L,6L,2L,5L,0L,5L,5L,9L,7L,2L,7L,0L,9L,8L,8L,0L,2L,6L,5L,0L,9L,6L,6L,2L,5L,0L,4L,3L,3L,9L,0L,2L,1L,4L,6L,5L,0L,2L,1L,7L,6L,8L,7L,3L,6L,2L,5L,8L,7L,7L,5L,5L,2L,8L,4L,8L,6L,8L,5L,5L,1L,1L,9L,9L,3L,4L,9L,5L,5L,7L,6L,4L,2L,3L,2L,5L,4L,8L,2L,2L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191504Inst : IEnumerable<long>
{
public static readonly long[] Value=A191504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191504.Bytes);
public long this[int i]=>Value[i];

public static A191504Inst Instance=new A191504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191505
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,75L,7636L,4866965L,22256484426L,827473662052359L,BigInteger.Parse("280073424855627741304"),BigInteger.Parse("956136927041635596586248969"),BigInteger.Parse("36146438316110599447497305174316790"),BigInteger.Parse("16486165931975571004114967909531846539984907") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191505Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191505.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191505Inst Instance=new A191505Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191506
{
public static readonly BigInteger[] Value={ 2L,5L,25L,195L,2475L,53324L,1872113L,109037035L,10508450377L,1672058437225L,440124911303718L,191498508664286039L,BigInteger.Parse("137739615464486164780"),BigInteger.Parse("163796811382099494131871"),BigInteger.Parse("322006666961136384120723488") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191506Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191506.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191506Inst Instance=new A191506Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191507
{
public static readonly BigInteger[] Value={ 2L,8L,52L,646L,14570L,599702L,45191945L,6225542127L,1567856872728L,722008623925586L,607932060252871024L,BigInteger.Parse("935917819388424802645"),BigInteger.Parse("2634499346573878930718088"),BigInteger.Parse("13559220442178025486399949918") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191507Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191507.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191507Inst Instance=new A191507Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191508
{
public static readonly BigInteger[] Value={ 2L,8L,56L,792L,21984L,1188160L,125522112L,25932064896L,10472077118464L,8266074697979136L,12754433913314441216UL,BigInteger.Parse("38469498012053658897408"),BigInteger.Parse("226810241439860068417249280"),BigInteger.Parse("2613967215944945112514234085376") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191508Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191508.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191508Inst Instance=new A191508Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191509
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,13L,-4L,-59L,848L,1625L,-57968L,-82679L,5307072L,3378277L,-761466432L,-178851763L,155538255616L,13323839409L,-43026868334336L,-1145167641071L,15502018794828800L,110592144624061L,-7038075176027079680L,-12523284027203883L,BigInteger.Parse("3925127762389637074944"),1643266949074714633L,BigInteger.Parse("-2635567108489125092225024") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191509Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191509.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191509Inst Instance=new A191509Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191510
{
public static readonly BigInteger[] Value={ 1L,9L,648L,360000L,1518750000L,48243443062500L,11480517255997440000UL,BigInteger.Parse("20400479323264014247526400"),BigInteger.Parse("270090559531318533654528000000000"),BigInteger.Parse("26599911685677709861296622500000000000000"),BigInteger.Parse("19464564507161243794359748945629699456000000000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191510Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191510.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191510Inst Instance=new A191510Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191511
{
public static readonly BigInteger[] Value={ 3L,27L,1863L,259767L,63267723L,23850461907L,12872337567183L,9418588525038447L,8974900856105748243L,BigInteger.Parse("10799459611549296021387"),BigInteger.Parse("16014456358054037241378903"),BigInteger.Parse("28692834058049011948073522727"),BigInteger.Parse("61105982516981628849258186347163"),BigInteger.Parse("152570799245287136693700721604134467"),BigInteger.Parse("441413217492406160002632205611608461023") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191511Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191511.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191511Inst Instance=new A191511Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191512
{
public static readonly BigInteger[] Value={ 0L,1L,-5L,89L,-4717L,449073L,-69090581L,15583801609L,-4846181282685L,1987373846425697L,-1039121484066627877L,BigInteger.Parse("674707915373741222841"),BigInteger.Parse("-532627526452975709882765"),BigInteger.Parse("502375568363623615781076625"),BigInteger.Parse("-557965947638266639781208500277"),BigInteger.Parse("720767702359064719935712626879593"),BigInteger.Parse("-1071470941893105999704454019614019741") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191512Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191512.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191512Inst Instance=new A191512Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191513
{
public static readonly long[] Value={ 3L,5L,10L,11L,18L,127L,286L,560L,1025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191513Inst : IEnumerable<long>
{
public static readonly long[] Value=A191513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191513.Bytes);
public long this[int i]=>Value[i];

public static A191513Inst Instance=new A191513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191514
{
public static readonly long[] Value={ 51L,33L,13L,34L,1L,8L,7L,75L,28L,60L,93L,32L,26L,95L,44L,92L,63L,40L,71L,23L,57L,76L,85L,88L,79L,91L,49L,31L,53L,90L,69L,81L,39L,70L,89L,37L,5L,64L,41L,77L,38L,14L,47L,62L,83L,35L,3L,4L,56L,67L,2L,72L,68L,15L,87L,9L,65L,25L,80L,42L,12L,66L,21L,58L,55L,82L,59L,78L,94L,46L,61L,19L,84L,73L,43L,22L,52L,48L,20L,24L,96L,16L,98L,100L,97L,101L,99L,102L,18L,36L,10L,86L,54L,30L,45L,17L,6L,27L,29L,74L,50L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191514Inst : IEnumerable<long>
{
public static readonly long[] Value=A191514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191514.Bytes);
public long this[int i]=>Value[i];

public static A191514Inst Instance=new A191514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}