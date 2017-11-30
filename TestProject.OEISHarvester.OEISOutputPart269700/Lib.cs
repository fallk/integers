using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A040136
{
public static readonly long[] Value={ 13L,17L,19L,23L,29L,31L,37L,41L,47L,73L,79L,83L,89L,97L,101L,107L,139L,149L,151L,157L,167L,173L,193L,197L,199L,211L,227L,229L,233L,263L,269L,271L,277L,281L,293L,313L,331L,337L,347L,353L,373L,379L,383L,389L,397L };
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
public class A040136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040136Inst : IEnumerable<long>
{
public static readonly long[] Value=A040136.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040136.Bytes);
public long this[int i]=>Value[i];

public static A040136Inst Instance=new A040136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040137
{
public static readonly long[] Value={ 12L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L,24L,4L };
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
public class A040137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040137Inst : IEnumerable<long>
{
public static readonly long[] Value=A040137.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040137.Bytes);
public long this[int i]=>Value[i];

public static A040137Inst Instance=new A040137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040138
{
public static readonly long[] Value={ 2L,17L,19L,43L,47L,59L,67L,83L,103L,127L,149L,151L,157L,179L,191L,223L,229L,239L,251L,257L,263L,271L,293L,307L,331L,353L,359L,383L,389L,409L,433L,443L,457L,463L,467L,491L,509L,523L,563L,587L,599L,613L,631L,647L };
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
public class A040138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040138Inst : IEnumerable<long>
{
public static readonly long[] Value=A040138.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040138.Bytes);
public long this[int i]=>Value[i];

public static A040138Inst Instance=new A040138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040139
{
public static readonly long[] Value={ 12L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L,24L,3L };
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
public class A040139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040139Inst : IEnumerable<long>
{
public static readonly long[] Value=A040139.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040139.Bytes);
public long this[int i]=>Value[i];

public static A040139Inst Instance=new A040139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040140
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,23L,29L,31L,37L,41L,53L,61L,71L,73L,79L,89L,97L,101L,107L,109L,113L,131L,137L,139L,163L,167L,173L,181L,193L,197L,199L,211L,227L,233L,241L,269L,277L,281L,283L,311L,313L,317L,337L,347L,349L,367L,373L };
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
public class A040140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040140Inst : IEnumerable<long>
{
public static readonly long[] Value=A040140.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040140.Bytes);
public long this[int i]=>Value[i];

public static A040140Inst Instance=new A040140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040141
{
public static readonly long[] Value={ 2L,3L,7L,17L,23L,31L,41L,47L,71L,73L,79L,103L,127L,137L,151L,167L,191L,199L,223L,239L,263L,271L,311L,337L,359L,367L,383L,401L,431L,439L,449L,463L,479L,487L,503L,521L,569L,577L,599L,601L,607L,631L,641L,647L,719L };
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
public class A040141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040141Inst : IEnumerable<long>
{
public static readonly long[] Value=A040141.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040141.Bytes);
public long this[int i]=>Value[i];

public static A040141Inst Instance=new A040141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040142
{
public static readonly long[] Value={ 12L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L };
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
public class A040142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040142Inst : IEnumerable<long>
{
public static readonly long[] Value=A040142.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040142.Bytes);
public long this[int i]=>Value[i];

public static A040142Inst Instance=new A040142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040143
{
public static readonly long[] Value={ 12L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L };
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
public class A040143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040143Inst : IEnumerable<long>
{
public static readonly long[] Value=A040143.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040143.Bytes);
public long this[int i]=>Value[i];

public static A040143Inst Instance=new A040143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040144
{
public static readonly long[] Value={ 5L,11L,13L,19L,29L,37L,43L,53L,59L,61L,67L,83L,89L,97L,101L,107L,109L,113L,131L,139L,149L,157L,163L,173L,179L,181L,193L,197L,211L,227L,229L,233L,241L,251L,257L,269L,277L,281L,283L,293L,307L,313L,317L,331L,347L,349L };
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
public class A040144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040144Inst : IEnumerable<long>
{
public static readonly long[] Value=A040144.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040144.Bytes);
public long this[int i]=>Value[i];

public static A040144Inst Instance=new A040144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040145
{
public static readonly long[] Value={ 2L,3L,19L,31L,59L,67L,71L,79L,101L,103L,107L,127L,149L,151L,157L,167L,179L,211L,223L,227L,229L,233L,277L,307L,313L,331L,349L,379L,383L,397L,431L,439L,457L,461L,487L,523L,547L,557L,563L,577L,593L,599L,607L,613L };
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
public class A040145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040145Inst : IEnumerable<long>
{
public static readonly long[] Value=A040145.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040145.Bytes);
public long this[int i]=>Value[i];

public static A040145Inst Instance=new A040145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040146
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,23L,29L,37L,41L,43L,47L,53L,61L,73L,83L,89L,97L,109L,113L,131L,137L,139L,163L,173L,181L,191L,193L,197L,199L,239L,241L,251L,257L,263L,269L,271L,281L,283L,293L,311L,317L,337L,347L,353L,359L,367L,373L };
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
public class A040146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040146Inst : IEnumerable<long>
{
public static readonly long[] Value=A040146.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040146.Bytes);
public long this[int i]=>Value[i];

public static A040146Inst Instance=new A040146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040147
{
public static readonly long[] Value={ 2L,5L,11L,19L,29L,31L,59L,61L,71L,79L,131L,139L,151L,179L,191L,199L,211L,229L,239L,251L,271L,311L,331L,349L,359L,379L,401L,409L,419L,421L,431L,439L,449L,479L,491L,499L,509L,521L,569L,571L,599L,619L,631L,659L,661L };
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
public class A040147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040147Inst : IEnumerable<long>
{
public static readonly long[] Value=A040147.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040147.Bytes);
public long this[int i]=>Value[i];

public static A040147Inst Instance=new A040147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040148
{
public static readonly long[] Value={ 3L,7L,13L,17L,23L,37L,41L,43L,47L,53L,67L,73L,83L,89L,97L,101L,103L,107L,109L,113L,127L,137L,149L,157L,163L,167L,173L,181L,193L,197L,223L,227L,233L,241L,257L,263L,269L,277L,281L,283L,293L,307L,313L,317L,337L,347L };
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
public class A040148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040148Inst : IEnumerable<long>
{
public static readonly long[] Value=A040148.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040148.Bytes);
public long this[int i]=>Value[i];

public static A040148Inst Instance=new A040148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040149
{
public static readonly long[] Value={ 2L,3L,5L,7L,17L,43L,47L,59L,67L,79L,83L,109L,127L,131L,151L,163L,167L,193L,211L,227L,251L,269L,311L,331L,337L,353L,373L,379L,383L,419L,463L,467L,479L,487L,499L,503L,509L,521L,547L,563L,571L,587L,593L,631L,647L,709L };
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
public class A040149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040149Inst : IEnumerable<long>
{
public static readonly long[] Value=A040149.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040149.Bytes);
public long this[int i]=>Value[i];

public static A040149Inst Instance=new A040149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040150
{
public static readonly long[] Value={ 11L,13L,19L,23L,29L,31L,37L,41L,53L,61L,71L,73L,89L,97L,101L,103L,107L,113L,137L,139L,149L,157L,173L,179L,181L,191L,197L,199L,223L,229L,233L,239L,241L,257L,263L,271L,277L,281L,283L,293L,307L,313L,317L,347L,349L };
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
public class A040150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040150Inst : IEnumerable<long>
{
public static readonly long[] Value=A040150.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040150.Bytes);
public long this[int i]=>Value[i];

public static A040150Inst Instance=new A040150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040151
{
public static readonly long[] Value={ 12L,1L,4L,6L,4L,1L,24L,1L,4L,6L,4L,1L,24L,1L,4L,6L,4L,1L,24L,1L,4L,6L,4L,1L,24L,1L,4L,6L,4L,1L,24L,1L,4L,6L,4L,1L,24L,1L,4L,6L,4L,1L,24L,1L,4L,6L,4L,1L,24L,1L,4L,6L,4L,1L,24L,1L,4L,6L,4L,1L,24L,1L,4L,6L,4L,1L,24L,1L,4L,6L,4L,1L,24L,1L,4L };
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
public class A040151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040151Inst : IEnumerable<long>
{
public static readonly long[] Value=A040151.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040151.Bytes);
public long this[int i]=>Value[i];

public static A040151Inst Instance=new A040151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040152
{
public static readonly long[] Value={ 2L,3L,7L,11L,13L,59L,61L,67L,79L,89L,97L,109L,127L,137L,151L,163L,167L,173L,179L,239L,251L,257L,263L,271L,293L,331L,353L,359L,379L,401L,419L,431L,433L,439L,443L,467L,479L,499L,503L,521L,541L,587L,607L,613L,619L };
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
public class A040152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040152Inst : IEnumerable<long>
{
public static readonly long[] Value=A040152.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040152.Bytes);
public long this[int i]=>Value[i];

public static A040152Inst Instance=new A040152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040153
{
public static readonly long[] Value={ 5L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,71L,73L,83L,101L,103L,107L,113L,131L,139L,149L,157L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,241L,269L,277L,281L,283L,307L,311L,313L,317L,337L,347L,349L,367L,373L };
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
public class A040153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040153Inst : IEnumerable<long>
{
public static readonly long[] Value=A040153.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040153.Bytes);
public long this[int i]=>Value[i];

public static A040153Inst Instance=new A040153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040154
{
public static readonly long[] Value={ 2L,7L,11L,19L,23L,29L,41L,43L,67L,79L,83L,103L,107L,173L,191L,197L,199L,227L,233L,251L,257L,263L,269L,277L,283L,317L,349L,359L,367L,379L,383L,419L,431L,449L,461L,467L,479L,503L,509L,523L,541L,563L,571L,593L,619L };
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
public class A040154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040154Inst : IEnumerable<long>
{
public static readonly long[] Value=A040154.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040154.Bytes);
public long this[int i]=>Value[i];

public static A040154Inst Instance=new A040154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040155
{
public static readonly long[] Value={ 12L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L };
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
public class A040155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040155Inst : IEnumerable<long>
{
public static readonly long[] Value=A040155.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040155.Bytes);
public long this[int i]=>Value[i];

public static A040155Inst Instance=new A040155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040156
{
public static readonly long[] Value={ 13L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L };
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
public class A040156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040156Inst : IEnumerable<long>
{
public static readonly long[] Value=A040156.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040156.Bytes);
public long this[int i]=>Value[i];

public static A040156Inst Instance=new A040156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040157
{
public static readonly long[] Value={ 13L,13L,26L,13L,26L,13L,26L,13L,26L,13L,26L,13L,26L,13L,26L,13L,26L,13L,26L,13L,26L,13L,26L,13L,26L,13L,26L,13L,26L,13L,26L,13L,26L,13L,26L,13L,26L,13L,26L,13L,26L,13L,26L,13L,26L,13L,26L,13L,26L,13L,26L,13L,26L,13L };
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
public class A040157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040157Inst : IEnumerable<long>
{
public static readonly long[] Value=A040157.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040157.Bytes);
public long this[int i]=>Value[i];

public static A040157Inst Instance=new A040157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040158
{
public static readonly long[] Value={ 3L,5L,13L,17L,31L,37L,47L,53L,59L,61L,71L,73L,89L,97L,101L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,179L,181L,193L,211L,223L,229L,239L,241L,271L,281L,293L,307L,311L,313L,331L,337L,347L,353L,373L,389L };
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
public class A040158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040158Inst : IEnumerable<long>
{
public static readonly long[] Value=A040158.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040158.Bytes);
public long this[int i]=>Value[i];

public static A040158Inst Instance=new A040158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040159
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,19L,23L,29L,37L,43L,47L,53L,59L,67L,73L,79L,83L,89L,97L,103L,107L,109L,113L,127L,137L,139L,149L,151L,157L,163L,167L,173L,179L,193L,197L,199L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,277L,283L,293L,307L,313L,317L,337L,347L,349L,353L };
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
public class A040159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040159Inst : IEnumerable<long>
{
public static readonly long[] Value=A040159.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040159.Bytes);
public long this[int i]=>Value[i];

public static A040159Inst Instance=new A040159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040160
{
public static readonly long[] Value={ 11L,31L,41L,61L,71L,101L,131L,181L,191L,211L,271L,281L,311L,331L,401L,421L,461L,491L,521L,541L,601L,631L,661L,691L,701L,751L,761L,811L,821L,881L,941L,991L,1021L,1031L,1051L,1061L,1091L,1151L,1171L,1201L,1231L,1291L,1301L,1321L,1361L,1381L,1451L,1471L,1481L,1511L,1531L,1571L };
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
public class A040160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040160Inst : IEnumerable<long>
{
public static readonly long[] Value=A040160.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040160.Bytes);
public long this[int i]=>Value[i];

public static A040160Inst Instance=new A040160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040161
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,19L,23L,29L,37L,41L,43L,47L,53L,59L,67L,73L,79L,83L,89L,97L,103L,107L,109L,113L,127L,137L,139L,149L,157L,163L,167L,173L,179L,193L,197L,199L,223L,227L,229L,233L,239L,257L,263L,269L,277L,283L,293L,307L,313L,317L,337L,347L,349L,353L,359L,367L,373L };
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
public class A040161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040161Inst : IEnumerable<long>
{
public static readonly long[] Value=A040161.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040161.Bytes);
public long this[int i]=>Value[i];

public static A040161Inst Instance=new A040161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040162
{
public static readonly long[] Value={ 11L,31L,61L,71L,101L,131L,151L,181L,191L,211L,241L,251L,271L,281L,311L,331L,401L,421L,461L,521L,541L,571L,601L,631L,641L,691L,701L,751L,811L,821L,881L,911L,941L,971L,991L,1031L,1061L,1151L,1181L,1201L,1231L,1291L,1301L,1321L,1361L,1381L,1451L,1481L,1531L };
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
public class A040162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040162Inst : IEnumerable<long>
{
public static readonly long[] Value=A040162.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040162.Bytes);
public long this[int i]=>Value[i];

public static A040162Inst Instance=new A040162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040163
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,2L,3L,4L,5L,6L,7L,8L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,8L,7L,6L,5L,4L,3L,2L,1L,0L,1L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,1L,0L,1L,2L,3L,4L,5L };
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
public class A040163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040163Inst : IEnumerable<long>
{
public static readonly long[] Value=A040163.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040163.Bytes);
public long this[int i]=>Value[i];

public static A040163Inst Instance=new A040163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040164
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,6L,8L,1L,7L,2L,4L,3L,1L,3L,2L,4L,5L,1L,6L,4L,2L,5L,1L,2L,0L,2L,6L,8L,2L,6L,0L,6L,8L,8L,0L,6L,2L,6L,2L,8L,0L,0L,2L,6L,8L,1L,1L,5L,7L,1L,7L,1L,1L,5L,1L,7L,1L,5L,1L,1L,1L,4L,2L,0L,4L,2L,4L,4L,6L,0L,6L,4L,0L,6L,0L,6L,4L,3L,5L,5L,3L,3L,1L,5L,1L,5L,3L,3L,1L,3L,5L,3L,3L,5L,2L,4L,4L,2L,4L,2L,2L,2L,4L,4L };
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
public class A040164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040164Inst : IEnumerable<long>
{
public static readonly long[] Value=A040164.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040164.Bytes);
public long this[int i]=>Value[i];

public static A040164Inst Instance=new A040164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040165
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,19L,23L,29L,31L,37L,43L,47L,53L,59L,67L,73L,79L,83L,89L,97L,103L,107L,109L,113L,127L,137L,139L,149L,157L,163L,167L,173L,179L,191L,193L,197L,199L,223L,227L,229L,233L,239L,251L,257L,263L,269L,271L };
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
public class A040165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040165Inst : IEnumerable<long>
{
public static readonly long[] Value=A040165.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040165.Bytes);
public long this[int i]=>Value[i];

public static A040165Inst Instance=new A040165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040166
{
public static readonly long[] Value={ 13L,2L,2L,2L,26L,2L,2L,2L,26L,2L,2L,2L,26L,2L,2L,2L,26L,2L,2L,2L,26L,2L,2L,2L,26L,2L,2L,2L,26L,2L,2L,2L,26L,2L,2L,2L,26L,2L,2L,2L,26L,2L,2L,2L,26L,2L,2L,2L,26L,2L,2L,2L,26L,2L,2L,2L,26L,2L,2L,2L,26L,2L,2L,2L,26L,2L,2L,2L,26L,2L,2L,2L };
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
public class A040166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040166Inst : IEnumerable<long>
{
public static readonly long[] Value=A040166.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040166.Bytes);
public long this[int i]=>Value[i];

public static A040166Inst Instance=new A040166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040167
{
public static readonly long[] Value={ 11L,41L,61L,71L,101L,131L,151L,181L,211L,241L,281L,311L,331L,401L,421L,431L,461L,491L,521L,541L,571L,631L,661L,691L,701L,751L,811L,821L,881L,911L,941L,971L,991L,1021L,1031L,1051L,1061L,1151L,1171L,1181L,1201L };
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
public class A040167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040167Inst : IEnumerable<long>
{
public static readonly long[] Value=A040167.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040167.Bytes);
public long this[int i]=>Value[i];

public static A040167Inst Instance=new A040167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040168
{
public static readonly long[] Value={ 13L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L,26L,2L };
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
public class A040168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040168Inst : IEnumerable<long>
{
public static readonly long[] Value=A040168.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040168.Bytes);
public long this[int i]=>Value[i];

public static A040168Inst Instance=new A040168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040169
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,19L,23L,29L,31L,37L,43L,47L,53L,59L,67L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,137L,139L,149L,157L,163L,167L,173L,179L,191L,193L,197L,199L,223L,227L,229L,233L,239L,257L,263L,269L,277L };
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
public class A040169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040169Inst : IEnumerable<long>
{
public static readonly long[] Value=A040169.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040169.Bytes);
public long this[int i]=>Value[i];

public static A040169Inst Instance=new A040169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040170
{
public static readonly long[] Value={ 11L,41L,61L,71L,131L,151L,181L,211L,241L,251L,271L,311L,331L,401L,461L,491L,521L,571L,601L,631L,641L,661L,691L,751L,761L,811L,821L,881L,911L,941L,971L,991L,1021L,1031L,1051L,1061L,1091L,1171L,1181L,1291L,1301L };
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
public class A040170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040170Inst : IEnumerable<long>
{
public static readonly long[] Value=A040170.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040170.Bytes);
public long this[int i]=>Value[i];

public static A040170Inst Instance=new A040170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040171
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,19L,23L,29L,37L,43L,47L,53L,59L,67L,73L,79L,83L,89L,97L,103L,107L,109L,113L,127L,137L,139L,149L,157L,163L,167L,173L,179L,181L,193L,197L,199L,223L,227L,229L,233L,239L,257L,263L,269L,277L,283L,293L };
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
public class A040171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040171Inst : IEnumerable<long>
{
public static readonly long[] Value=A040171.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040171.Bytes);
public long this[int i]=>Value[i];

public static A040171Inst Instance=new A040171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040172
{
public static readonly long[] Value={ 11L,31L,41L,61L,71L,101L,131L,151L,191L,211L,241L,251L,271L,281L,331L,401L,421L,431L,461L,491L,521L,541L,571L,601L,631L,641L,691L,701L,751L,761L,821L,881L,941L,991L,1021L,1051L,1061L,1091L,1181L,1231L,1291L };
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
public class A040172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040172Inst : IEnumerable<long>
{
public static readonly long[] Value=A040172.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040172.Bytes);
public long this[int i]=>Value[i];

public static A040172Inst Instance=new A040172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040173
{
public static readonly long[] Value={ 1L,3L,1L,3L,19L,53L,103L,4111L,78293L,29401L,4462987L,9830941L,284397779L };
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
public class A040173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040173Inst : IEnumerable<long>
{
public static readonly long[] Value=A040173.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040173.Bytes);
public long this[int i]=>Value[i];

public static A040173Inst Instance=new A040173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040174
{
public static readonly long[] Value={ 1L,4L,2L,8L,40L,120L,168L,6720L,120960L,44800L,6652800L,14515200L,415134720L };
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
public class A040174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040174Inst : IEnumerable<long>
{
public static readonly long[] Value=A040174.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040174.Bytes);
public long this[int i]=>Value[i];

public static A040174Inst Instance=new A040174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040175
{
public static readonly long[] Value={ 3L,9L,57L,318L,3090L,24666L,234879L,2381481L,26777922L,324421053L,4265966685L };
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
public class A040175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040175Inst : IEnumerable<long>
{
public static readonly long[] Value=A040175.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040175.Bytes);
public long this[int i]=>Value[i];

public static A040175Inst Instance=new A040175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040176
{
public static readonly long[] Value={ 1L,3L,5L,11L,17L,41L,83L,137L,257L,641L,1097L,2329L,4369L,10537L,17477L,35209L,65537L };
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
public class A040176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040176Inst : IEnumerable<long>
{
public static readonly long[] Value=A040176.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040176.Bytes);
public long this[int i]=>Value[i];

public static A040176Inst Instance=new A040176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040177
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,37L,43L,47L,53L,59L,67L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,137L,139L,149L,157L,163L,167L,173L,179L,193L,197L,199L,223L,227L,229L,233L,239L,251L,257L,263L,269L,277L };
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
public class A040177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040177Inst : IEnumerable<long>
{
public static readonly long[] Value=A040177.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040177.Bytes);
public long this[int i]=>Value[i];

public static A040177Inst Instance=new A040177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040178
{
public static readonly long[] Value={ 31L,41L,61L,71L,131L,151L,181L,191L,211L,241L,271L,311L,331L,401L,421L,431L,461L,491L,541L,571L,601L,631L,661L,691L,701L,751L,761L,811L,821L,881L,911L,941L,971L,991L,1021L,1051L,1091L,1151L,1171L,1181L,1201L };
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
public class A040178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040178Inst : IEnumerable<long>
{
public static readonly long[] Value=A040178.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040178.Bytes);
public long this[int i]=>Value[i];

public static A040178Inst Instance=new A040178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040179
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,37L,43L,47L,53L,59L,61L,67L,73L,79L,83L,89L,97L,103L,107L,109L,113L,127L,137L,139L,149L,157L,163L,167L,173L,179L,191L,193L,197L,199L,223L,227L,229L,233L,239L,241L,257L,263L,269L };
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
public class A040179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040179Inst : IEnumerable<long>
{
public static readonly long[] Value=A040179.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040179.Bytes);
public long this[int i]=>Value[i];

public static A040179Inst Instance=new A040179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040180
{
public static readonly long[] Value={ 31L,41L,71L,101L,131L,151L,181L,211L,251L,271L,281L,331L,401L,421L,431L,461L,491L,521L,571L,601L,631L,641L,701L,761L,811L,821L,881L,941L,971L,991L,1021L,1031L,1051L,1061L,1091L,1151L,1171L,1201L,1321L,1361L };
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
public class A040180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040180Inst : IEnumerable<long>
{
public static readonly long[] Value=A040180.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040180.Bytes);
public long this[int i]=>Value[i];

public static A040180Inst Instance=new A040180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040181
{
public static readonly long[] Value={ 13L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L,26L,1L };
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
public class A040181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040181Inst : IEnumerable<long>
{
public static readonly long[] Value=A040181.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040181.Bytes);
public long this[int i]=>Value[i];

public static A040181Inst Instance=new A040181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040182
{
public static readonly long[] Value={ 14L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L,28L };
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
public class A040182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040182Inst : IEnumerable<long>
{
public static readonly long[] Value=A040182.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040182.Bytes);
public long this[int i]=>Value[i];

public static A040182Inst Instance=new A040182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040183
{
public static readonly long[] Value={ 14L,14L,28L,14L,28L,14L,28L,14L,28L,14L,28L,14L,28L,14L,28L,14L,28L,14L,28L,14L,28L,14L,28L,14L,28L,14L,28L,14L,28L,14L,28L,14L,28L,14L,28L,14L,28L,14L,28L,14L,28L,14L,28L,14L,28L,14L,28L,14L,28L,14L,28L,14L,28L,14L };
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
public class A040183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040183Inst : IEnumerable<long>
{
public static readonly long[] Value=A040183.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040183.Bytes);
public long this[int i]=>Value[i];

public static A040183Inst Instance=new A040183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040184
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,37L,43L,47L,53L,59L,67L,73L,79L,83L,89L,97L,103L,107L,109L,113L,127L,137L,139L,149L,157L,163L,167L,173L,179L,193L,197L,199L,211L,223L,227L,229L,233L,239L,257L,263L,269L,271L,277L };
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
public class A040184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040184Inst : IEnumerable<long>
{
public static readonly long[] Value=A040184.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040184.Bytes);
public long this[int i]=>Value[i];

public static A040184Inst Instance=new A040184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040185
{
public static readonly long[] Value={ 14L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L,7L,28L };
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
public class A040185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040185Inst : IEnumerable<long>
{
public static readonly long[] Value=A040185.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040185.Bytes);
public long this[int i]=>Value[i];

public static A040185Inst Instance=new A040185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040186
{
public static readonly long[] Value={ 14L,5L,1L,1L,1L,2L,1L,8L,1L,2L,1L,1L,1L,5L,28L,5L,1L,1L,1L,2L,1L,8L,1L,2L,1L,1L,1L,5L,28L,5L,1L,1L,1L,2L,1L,8L,1L,2L,1L,1L,1L,5L,28L,5L,1L,1L,1L,2L,1L,8L,1L,2L,1L,1L,1L,5L,28L,5L,1L,1L,1L,2L,1L,8L,1L,2L,1L,1L,1L,5L,28L,5L,1L,1L,1L,2L,1L,8L,1L,2L,1L,1L,1L,5L,28L,5L,1L,1L,1L,2L };
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
public class A040186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040186Inst : IEnumerable<long>
{
public static readonly long[] Value=A040186.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040186.Bytes);
public long this[int i]=>Value[i];

public static A040186Inst Instance=new A040186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040187
{
public static readonly long[] Value={ 14L,4L,1L,2L,2L,1L,4L,28L,4L,1L,2L,2L,1L,4L,28L,4L,1L,2L,2L,1L,4L,28L,4L,1L,2L,2L,1L,4L,28L,4L,1L,2L,2L,1L,4L,28L,4L,1L,2L,2L,1L,4L,28L,4L,1L,2L,2L,1L,4L,28L,4L,1L,2L,2L,1L,4L,28L,4L,1L,2L,2L,1L,4L,28L,4L,1L,2L,2L,1L,4L,28L,4L,1L,2L,2L,1L,4L,28L,4L,1L,2L,2L,1L,4L,28L,4L,1L };
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
public class A040187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040187Inst : IEnumerable<long>
{
public static readonly long[] Value=A040187.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040187.Bytes);
public long this[int i]=>Value[i];

public static A040187Inst Instance=new A040187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040188
{
public static readonly long[] Value={ 14L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L,4L,28L };
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
public class A040188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040188Inst : IEnumerable<long>
{
public static readonly long[] Value=A040188.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040188.Bytes);
public long this[int i]=>Value[i];

public static A040188Inst Instance=new A040188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040189
{
public static readonly long[] Value={ 14L,3L,1L,1L,6L,1L,1L,3L,28L,3L,1L,1L,6L,1L,1L,3L,28L,3L,1L,1L,6L,1L,1L,3L,28L,3L,1L,1L,6L,1L,1L,3L,28L,3L,1L,1L,6L,1L,1L,3L,28L,3L,1L,1L,6L,1L,1L,3L,28L,3L,1L,1L,6L,1L,1L,3L,28L,3L,1L,1L,6L,1L,1L,3L,28L,3L,1L,1L,6L,1L,1L,3L,28L,3L,1L,1L,6L,1L,1L,3L,28L,3L,1L,1L,6L,1L,1L,3L };
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
public class A040189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040189Inst : IEnumerable<long>
{
public static readonly long[] Value=A040189.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040189.Bytes);
public long this[int i]=>Value[i];

public static A040189Inst Instance=new A040189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040190
{
public static readonly long[] Value={ 14L,3L,6L,1L,4L,1L,6L,3L,28L,3L,6L,1L,4L,1L,6L,3L,28L,3L,6L,1L,4L,1L,6L,3L,28L,3L,6L,1L,4L,1L,6L,3L,28L,3L,6L,1L,4L,1L,6L,3L,28L,3L,6L,1L,4L,1L,6L,3L,28L,3L,6L,1L,4L,1L,6L,3L,28L,3L,6L,1L,4L,1L,6L,3L,28L,3L,6L,1L,4L,1L,6L,3L,28L,3L,6L,1L,4L,1L,6L,3L,28L,3L,6L,1L,4L,1L,6L,3L };
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
public class A040190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040190Inst : IEnumerable<long>
{
public static readonly long[] Value=A040190.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040190.Bytes);
public long this[int i]=>Value[i];

public static A040190Inst Instance=new A040190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040191
{
public static readonly long[] Value={ 14L,2L,1L,5L,14L,5L,1L,2L,28L,2L,1L,5L,14L,5L,1L,2L,28L,2L,1L,5L,14L,5L,1L,2L,28L,2L,1L,5L,14L,5L,1L,2L,28L,2L,1L,5L,14L,5L,1L,2L,28L,2L,1L,5L,14L,5L,1L,2L,28L,2L,1L,5L,14L,5L,1L,2L,28L,2L,1L,5L,14L,5L,1L,2L,28L,2L,1L,5L,14L,5L,1L,2L,28L,2L,1L,5L,14L,5L,1L,2L,28L,2L,1L,5L };
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
public class A040191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040191Inst : IEnumerable<long>
{
public static readonly long[] Value=A040191.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040191.Bytes);
public long this[int i]=>Value[i];

public static A040191Inst Instance=new A040191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040192
{
public static readonly long[] Value={ 14L,2L,1L,1L,2L,1L,1L,2L,28L,2L,1L,1L,2L,1L,1L,2L,28L,2L,1L,1L,2L,1L,1L,2L,28L,2L,1L,1L,2L,1L,1L,2L,28L,2L,1L,1L,2L,1L,1L,2L,28L,2L,1L,1L,2L,1L,1L,2L,28L,2L,1L,1L,2L,1L,1L,2L,28L,2L,1L,1L,2L,1L,1L,2L,28L,2L,1L,1L,2L,1L,1L,2L,28L,2L,1L,1L,2L,1L,1L,2L,28L,2L,1L,1L,2L,1L,1L,2L };
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
public class A040192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040192Inst : IEnumerable<long>
{
public static readonly long[] Value=A040192.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040192.Bytes);
public long this[int i]=>Value[i];

public static A040192Inst Instance=new A040192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040193
{
public static readonly long[] Value={ 14L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L };
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
public class A040193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040193Inst : IEnumerable<long>
{
public static readonly long[] Value=A040193.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040193.Bytes);
public long this[int i]=>Value[i];

public static A040193Inst Instance=new A040193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040194
{
public static readonly long[] Value={ 14L,2L,5L,3L,2L,3L,5L,2L,28L,2L,5L,3L,2L,3L,5L,2L,28L,2L,5L,3L,2L,3L,5L,2L,28L,2L,5L,3L,2L,3L,5L,2L,28L,2L,5L,3L,2L,3L,5L,2L,28L,2L,5L,3L,2L,3L,5L,2L,28L,2L,5L,3L,2L,3L,5L,2L,28L,2L,5L,3L,2L,3L,5L,2L,28L,2L,5L,3L,2L,3L,5L,2L,28L,2L,5L,3L,2L,3L,5L,2L,28L,2L,5L,3L,2L,3L,5L,2L };
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
public class A040194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040194Inst : IEnumerable<long>
{
public static readonly long[] Value=A040194.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040194.Bytes);
public long this[int i]=>Value[i];

public static A040194Inst Instance=new A040194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040195
{
public static readonly long[] Value={ 14L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L };
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
public class A040195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040195Inst : IEnumerable<long>
{
public static readonly long[] Value=A040195.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040195.Bytes);
public long this[int i]=>Value[i];

public static A040195Inst Instance=new A040195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040196
{
public static readonly long[] Value={ 14L,1L,1L,9L,5L,1L,2L,2L,1L,1L,4L,3L,1L,13L,1L,3L,4L,1L,1L,2L,2L,1L,5L,9L,1L,1L,28L,1L,1L,9L,5L,1L,2L,2L,1L,1L,4L,3L,1L,13L,1L,3L,4L,1L,1L,2L,2L,1L,5L,9L,1L,1L,28L,1L,1L,9L,5L,1L,2L,2L,1L,1L,4L,3L,1L,13L,1L,3L,4L,1L,1L,2L,2L,1L,5L,9L,1L,1L,28L,1L,1L,9L,5L,1L,2L,2L,1L,1L,4L,3L };
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
public class A040196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040196Inst : IEnumerable<long>
{
public static readonly long[] Value=A040196.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040196.Bytes);
public long this[int i]=>Value[i];

public static A040196Inst Instance=new A040196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040197
{
public static readonly long[] Value={ 14L,1L,1L,3L,1L,1L,1L,6L,1L,1L,1L,3L,1L,1L,28L,1L,1L,3L,1L,1L,1L,6L,1L,1L,1L,3L,1L,1L,28L,1L,1L,3L,1L,1L,1L,6L,1L,1L,1L,3L,1L,1L,28L,1L,1L,3L,1L,1L,1L,6L,1L,1L,1L,3L,1L,1L,28L,1L,1L,3L,1L,1L,1L,6L,1L,1L,1L,3L,1L,1L,28L,1L,1L,3L,1L,1L,1L,6L,1L,1L,1L,3L,1L,1L,28L,1L,1L,3L,1L,1L };
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
public class A040197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040197Inst : IEnumerable<long>
{
public static readonly long[] Value=A040197.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040197.Bytes);
public long this[int i]=>Value[i];

public static A040197Inst Instance=new A040197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040198
{
public static readonly long[] Value={ 14L,1L,1L,2L,6L,1L,8L,1L,6L,2L,1L,1L,28L,1L,1L,2L,6L,1L,8L,1L,6L,2L,1L,1L,28L,1L,1L,2L,6L,1L,8L,1L,6L,2L,1L,1L,28L,1L,1L,2L,6L,1L,8L,1L,6L,2L,1L,1L,28L,1L,1L,2L,6L,1L,8L,1L,6L,2L,1L,1L,28L,1L,1L,2L,6L,1L,8L,1L,6L,2L,1L,1L,28L,1L,1L,2L,6L,1L,8L,1L,6L,2L,1L,1L,28L,1L,1L,2L,6L,1L };
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
public class A040198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040198Inst : IEnumerable<long>
{
public static readonly long[] Value=A040198.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040198.Bytes);
public long this[int i]=>Value[i];

public static A040198Inst Instance=new A040198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040199
{
public static readonly long[] Value={ 14L,1L,1L,1L,2L,3L,1L,4L,9L,1L,1L,5L,3L,14L,3L,5L,1L,1L,9L,4L,1L,3L,2L,1L,1L,1L,28L,1L,1L,1L,2L,3L,1L,4L,9L,1L,1L,5L,3L,14L,3L,5L,1L,1L,9L,4L,1L,3L,2L,1L,1L,1L,28L,1L,1L,1L,2L,3L,1L,4L,9L,1L,1L,5L,3L,14L,3L,5L,1L,1L,9L,4L,1L,3L,2L,1L,1L,1L,28L,1L,1L,1L,2L,3L,1L,4L,9L,1L,1L,5L };
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
public class A040199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040199Inst : IEnumerable<long>
{
public static readonly long[] Value=A040199.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040199.Bytes);
public long this[int i]=>Value[i];

public static A040199Inst Instance=new A040199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040200
{
public static readonly long[] Value={ 14L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L };
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
public class A040200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040200Inst : IEnumerable<long>
{
public static readonly long[] Value=A040200.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040200.Bytes);
public long this[int i]=>Value[i];

public static A040200Inst Instance=new A040200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040201
{
public static readonly long[] Value={ 14L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L };
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
public class A040201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040201Inst : IEnumerable<long>
{
public static readonly long[] Value=A040201.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040201.Bytes);
public long this[int i]=>Value[i];

public static A040201Inst Instance=new A040201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040202
{
public static readonly long[] Value={ 14L,1L,2L,1L,2L,1L,1L,9L,4L,9L,1L,1L,2L,1L,2L,1L,28L,1L,2L,1L,2L,1L,1L,9L,4L,9L,1L,1L,2L,1L,2L,1L,28L,1L,2L,1L,2L,1L,1L,9L,4L,9L,1L,1L,2L,1L,2L,1L,28L,1L,2L,1L,2L,1L,1L,9L,4L,9L,1L,1L,2L,1L,2L,1L,28L,1L,2L,1L,2L,1L,1L,9L,4L,9L,1L,1L,2L,1L,2L,1L,28L,1L,2L,1L,2L,1L,1L,9L,4L,9L };
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
public class A040202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040202Inst : IEnumerable<long>
{
public static readonly long[] Value=A040202.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040202.Bytes);
public long this[int i]=>Value[i];

public static A040202Inst Instance=new A040202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040203
{
public static readonly long[] Value={ 14L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L };
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
public class A040203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040203Inst : IEnumerable<long>
{
public static readonly long[] Value=A040203.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040203.Bytes);
public long this[int i]=>Value[i];

public static A040203Inst Instance=new A040203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040204
{
public static readonly long[] Value={ 14L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L };
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
public class A040204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040204Inst : IEnumerable<long>
{
public static readonly long[] Value=A040204.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040204.Bytes);
public long this[int i]=>Value[i];

public static A040204Inst Instance=new A040204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040205
{
public static readonly long[] Value={ 14L,1L,4L,1L,28L,1L,4L,1L,28L,1L,4L,1L,28L,1L,4L,1L,28L,1L,4L,1L,28L,1L,4L,1L,28L,1L,4L,1L,28L,1L,4L,1L,28L,1L,4L,1L,28L,1L,4L,1L,28L,1L,4L,1L,28L,1L,4L,1L,28L,1L,4L,1L,28L,1L,4L,1L,28L,1L,4L,1L,28L,1L,4L,1L,28L,1L,4L,1L,28L,1L,4L,1L,28L,1L,4L,1L,28L,1L,4L,1L,28L,1L,4L,1L };
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
public class A040205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040205Inst : IEnumerable<long>
{
public static readonly long[] Value=A040205.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040205.Bytes);
public long this[int i]=>Value[i];

public static A040205Inst Instance=new A040205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040206
{
public static readonly long[] Value={ 14L,1L,6L,2L,6L,1L,28L,1L,6L,2L,6L,1L,28L,1L,6L,2L,6L,1L,28L,1L,6L,2L,6L,1L,28L,1L,6L,2L,6L,1L,28L,1L,6L,2L,6L,1L,28L,1L,6L,2L,6L,1L,28L,1L,6L,2L,6L,1L,28L,1L,6L,2L,6L,1L,28L,1L,6L,2L,6L,1L,28L,1L,6L,2L,6L,1L,28L,1L,6L,2L,6L,1L,28L,1L,6L,2L,6L,1L,28L,1L,6L,2L,6L,1L,28L,1L,6L };
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
public class A040206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040206Inst : IEnumerable<long>
{
public static readonly long[] Value=A040206.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040206.Bytes);
public long this[int i]=>Value[i];

public static A040206Inst Instance=new A040206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040207
{
public static readonly long[] Value={ 14L,1L,8L,1L,28L,1L,8L,1L,28L,1L,8L,1L,28L,1L,8L,1L,28L,1L,8L,1L,28L,1L,8L,1L,28L,1L,8L,1L,28L,1L,8L,1L,28L,1L,8L,1L,28L,1L,8L,1L,28L,1L,8L,1L,28L,1L,8L,1L,28L,1L,8L,1L,28L,1L,8L,1L,28L,1L,8L,1L,28L,1L,8L,1L,28L,1L,8L,1L,28L,1L,8L,1L,28L,1L,8L,1L,28L,1L,8L,1L,28L,1L,8L,1L };
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
public class A040207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040207Inst : IEnumerable<long>
{
public static readonly long[] Value=A040207.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040207.Bytes);
public long this[int i]=>Value[i];

public static A040207Inst Instance=new A040207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040208
{
public static readonly long[] Value={ 14L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L,1L,28L,1L,13L };
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
public class A040208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040208Inst : IEnumerable<long>
{
public static readonly long[] Value=A040208.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040208.Bytes);
public long this[int i]=>Value[i];

public static A040208Inst Instance=new A040208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040209
{
public static readonly long[] Value={ 14L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L,1L,28L };
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
public class A040209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040209Inst : IEnumerable<long>
{
public static readonly long[] Value=A040209.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040209.Bytes);
public long this[int i]=>Value[i];

public static A040209Inst Instance=new A040209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040210
{
public static readonly long[] Value={ 15L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L };
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
public class A040210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040210Inst : IEnumerable<long>
{
public static readonly long[] Value=A040210.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040210.Bytes);
public long this[int i]=>Value[i];

public static A040210Inst Instance=new A040210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040211
{
public static readonly long[] Value={ 15L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L,15L,30L };
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
public class A040211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040211Inst : IEnumerable<long>
{
public static readonly long[] Value=A040211.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040211.Bytes);
public long this[int i]=>Value[i];

public static A040211Inst Instance=new A040211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040212
{
public static readonly long[] Value={ 15L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L,10L,30L };
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
public class A040212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040212Inst : IEnumerable<long>
{
public static readonly long[] Value=A040212.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040212.Bytes);
public long this[int i]=>Value[i];

public static A040212Inst Instance=new A040212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040213
{
public static readonly long[] Value={ 15L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L,30L,7L,1L,1L,7L };
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
public class A040213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040213Inst : IEnumerable<long>
{
public static readonly long[] Value=A040213.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040213.Bytes);
public long this[int i]=>Value[i];

public static A040213Inst Instance=new A040213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040214
{
public static readonly long[] Value={ 15L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L,6L,30L };
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
public class A040214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040214Inst : IEnumerable<long>
{
public static readonly long[] Value=A040214.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040214.Bytes);
public long this[int i]=>Value[i];

public static A040214Inst Instance=new A040214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040215
{
public static readonly long[] Value={ 15L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L,5L,30L };
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
public class A040215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040215Inst : IEnumerable<long>
{
public static readonly long[] Value=A040215.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040215.Bytes);
public long this[int i]=>Value[i];

public static A040215Inst Instance=new A040215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040216
{
public static readonly long[] Value={ 15L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L,7L,3L,4L,30L,4L,3L };
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
public class A040216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040216Inst : IEnumerable<long>
{
public static readonly long[] Value=A040216.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040216.Bytes);
public long this[int i]=>Value[i];

public static A040216Inst Instance=new A040216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040217
{
public static readonly long[] Value={ 15L,3L,1L,3L,1L,1L,1L,1L,3L,1L,3L,30L,3L,1L,3L,1L,1L,1L,1L,3L,1L,3L,30L,3L,1L,3L,1L,1L,1L,1L,3L,1L,3L,30L,3L,1L,3L,1L,1L,1L,1L,3L,1L,3L,30L,3L,1L,3L,1L,1L,1L,1L,3L,1L,3L,30L,3L,1L,3L,1L,1L,1L,1L,3L,1L,3L,30L,3L,1L,3L,1L,1L,1L,1L,3L,1L,3L,30L,3L,1L,3L,1L,1L,1L,1L,3L,1L,3L,30L,3L };
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
public class A040217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040217Inst : IEnumerable<long>
{
public static readonly long[] Value=A040217.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040217.Bytes);
public long this[int i]=>Value[i];

public static A040217Inst Instance=new A040217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040218
{
public static readonly long[] Value={ 15L,3L,2L,1L,2L,1L,2L,3L,30L,3L,2L,1L,2L,1L,2L,3L,30L,3L,2L,1L,2L,1L,2L,3L,30L,3L,2L,1L,2L,1L,2L,3L,30L,3L,2L,1L,2L,1L,2L,3L,30L,3L,2L,1L,2L,1L,2L,3L,30L,3L,2L,1L,2L,1L,2L,3L,30L,3L,2L,1L,2L,1L,2L,3L,30L,3L,2L,1L,2L,1L,2L,3L,30L,3L,2L,1L,2L,1L,2L,3L,30L,3L,2L,1L,2L,1L,2L,3L };
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
public class A040218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040218Inst : IEnumerable<long>
{
public static readonly long[] Value=A040218.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040218.Bytes);
public long this[int i]=>Value[i];

public static A040218Inst Instance=new A040218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040219
{
public static readonly long[] Value={ 15L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L,3L,30L };
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
public class A040219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040219Inst : IEnumerable<long>
{
public static readonly long[] Value=A040219.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040219.Bytes);
public long this[int i]=>Value[i];

public static A040219Inst Instance=new A040219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040220
{
public static readonly long[] Value={ 15L,2L,1L,3L,5L,1L,6L,1L,5L,3L,1L,2L,30L,2L,1L,3L,5L,1L,6L,1L,5L,3L,1L,2L,30L,2L,1L,3L,5L,1L,6L,1L,5L,3L,1L,2L,30L,2L,1L,3L,5L,1L,6L,1L,5L,3L,1L,2L,30L,2L,1L,3L,5L,1L,6L,1L,5L,3L,1L,2L,30L,2L,1L,3L,5L,1L,6L,1L,5L,3L,1L,2L,30L,2L,1L,3L,5L,1L,6L,1L,5L,3L,1L,2L,30L,2L,1L,3L,5L,1L };
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
public class A040220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040220Inst : IEnumerable<long>
{
public static readonly long[] Value=A040220.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040220.Bytes);
public long this[int i]=>Value[i];

public static A040220Inst Instance=new A040220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040237
{
public static readonly long[] Value={ 15L,1L,9L,1L,1L,1L,2L,1L,7L,4L,2L,2L,2L,4L,7L,1L,2L,1L,1L,1L,9L,1L,30L,1L,9L,1L,1L,1L,2L,1L,7L,4L,2L,2L,2L,4L,7L,1L,2L,1L,1L,1L,9L,1L,30L,1L,9L,1L,1L,1L,2L,1L,7L,4L,2L,2L,2L,4L,7L,1L,2L,1L,1L,1L,9L,1L,30L,1L,9L,1L,1L,1L,2L,1L,7L,4L,2L,2L,2L,4L,7L,1L,2L,1L,1L,1L,9L,1L,30L,1L,9L };
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
public class A040237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040237Inst : IEnumerable<long>
{
public static readonly long[] Value=A040237.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040237.Bytes);
public long this[int i]=>Value[i];

public static A040237Inst Instance=new A040237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040238
{
public static readonly long[] Value={ 15L,1L,14L,1L,30L,1L,14L,1L,30L,1L,14L,1L,30L,1L,14L,1L,30L,1L,14L,1L,30L,1L,14L,1L,30L,1L,14L,1L,30L,1L,14L,1L,30L,1L,14L,1L,30L,1L,14L,1L,30L,1L,14L,1L,30L,1L,14L,1L,30L,1L,14L,1L,30L,1L,14L,1L,30L,1L,14L,1L,30L,1L,14L,1L,30L,1L,14L,1L,30L,1L,14L,1L,30L,1L,14L };
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
public class A040238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040238Inst : IEnumerable<long>
{
public static readonly long[] Value=A040238.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040238.Bytes);
public long this[int i]=>Value[i];

public static A040238Inst Instance=new A040238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040239
{
public static readonly long[] Value={ 15L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L,1L,30L };
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
public class A040239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040239Inst : IEnumerable<long>
{
public static readonly long[] Value=A040239.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040239.Bytes);
public long this[int i]=>Value[i];

public static A040239Inst Instance=new A040239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040240
{
public static readonly long[] Value={ 16L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L };
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
public class A040240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040240Inst : IEnumerable<long>
{
public static readonly long[] Value=A040240.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040240.Bytes);
public long this[int i]=>Value[i];

public static A040240Inst Instance=new A040240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040241
{
public static readonly long[] Value={ 16L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L,16L,32L };
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
public class A040241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040241Inst : IEnumerable<long>
{
public static readonly long[] Value=A040241.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040241.Bytes);
public long this[int i]=>Value[i];

public static A040241Inst Instance=new A040241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040242
{
public static readonly long[] Value={ 16L,10L,1L,2L,3L,4L,3L,2L,1L,10L,32L,10L,1L,2L,3L,4L,3L,2L,1L,10L,32L,10L,1L,2L,3L,4L,3L,2L,1L,10L,32L,10L,1L,2L,3L,4L,3L,2L,1L,10L,32L,10L,1L,2L,3L,4L,3L,2L,1L,10L,32L,10L,1L,2L,3L,4L,3L,2L,1L,10L,32L,10L,1L,2L,3L,4L,3L,2L,1L,10L,32L,10L,1L,2L,3L,4L,3L,2L,1L,10L,32L };
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
public class A040242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040242Inst : IEnumerable<long>
{
public static readonly long[] Value=A040242.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040242.Bytes);
public long this[int i]=>Value[i];

public static A040242Inst Instance=new A040242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040243
{
public static readonly long[] Value={ 16L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L,8L,32L };
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
public class A040243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040243Inst : IEnumerable<long>
{
public static readonly long[] Value=A040243.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040243.Bytes);
public long this[int i]=>Value[i];

public static A040243Inst Instance=new A040243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040244
{
public static readonly long[] Value={ 16L,6L,2L,3L,7L,1L,3L,1L,2L,1L,3L,1L,7L,3L,2L,6L,32L,6L,2L,3L,7L,1L,3L,1L,2L,1L,3L,1L,7L,3L,2L,6L,32L,6L,2L,3L,7L,1L,3L,1L,2L,1L,3L,1L,7L,3L,2L,6L,32L,6L,2L,3L,7L,1L,3L,1L,2L,1L,3L,1L,7L,3L,2L,6L,32L,6L,2L,3L,7L,1L,3L,1L,2L,1L,3L,1L,7L,3L,2L,6L,32L,6L,2L,3L,7L,1L,3L,1L,2L,1L };
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
public class A040244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040244Inst : IEnumerable<long>
{
public static readonly long[] Value=A040244.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040244.Bytes);
public long this[int i]=>Value[i];

public static A040244Inst Instance=new A040244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040245
{
public static readonly long[] Value={ 16L,5L,2L,1L,2L,1L,10L,16L,10L,1L,2L,1L,2L,5L,32L,5L,2L,1L,2L,1L,10L,16L,10L,1L,2L,1L,2L,5L,32L,5L,2L,1L,2L,1L,10L,16L,10L,1L,2L,1L,2L,5L,32L,5L,2L,1L,2L,1L,10L,16L,10L,1L,2L,1L,2L,5L,32L,5L,2L,1L,2L,1L,10L,16L,10L,1L,2L,1L,2L,5L,32L,5L,2L,1L,2L,1L,10L,16L,10L,1L,2L };
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
public class A040245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040245Inst : IEnumerable<long>
{
public static readonly long[] Value=A040245.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040245.Bytes);
public long this[int i]=>Value[i];

public static A040245Inst Instance=new A040245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040246
{
public static readonly long[] Value={ 16L,4L,1L,1L,1L,1L,15L,1L,1L,1L,1L,4L,32L,4L,1L,1L,1L,1L,15L,1L,1L,1L,1L,4L,32L,4L,1L,1L,1L,1L,15L,1L,1L,1L,1L,4L,32L,4L,1L,1L,1L,1L,15L,1L,1L,1L,1L,4L,32L,4L,1L,1L,1L,1L,15L,1L,1L,1L,1L,4L,32L,4L,1L,1L,1L,1L,15L,1L,1L,1L,1L,4L,32L,4L,1L,1L,1L,1L,15L,1L,1L,1L,1L,4L,32L,4L,1L };
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
public class A040246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040246Inst : IEnumerable<long>
{
public static readonly long[] Value=A040246.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040246.Bytes);
public long this[int i]=>Value[i];

public static A040246Inst Instance=new A040246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040247
{
public static readonly long[] Value={ 16L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L,4L,32L };
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
public class A040247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040247Inst : IEnumerable<long>
{
public static readonly long[] Value=A040247.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040247.Bytes);
public long this[int i]=>Value[i];

public static A040247Inst Instance=new A040247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040248
{
public static readonly long[] Value={ 16L,3L,1L,1L,2L,2L,1L,1L,3L,32L,3L,1L,1L,2L,2L,1L,1L,3L,32L,3L,1L,1L,2L,2L,1L,1L,3L,32L,3L,1L,1L,2L,2L,1L,1L,3L,32L,3L,1L,1L,2L,2L,1L,1L,3L,32L,3L,1L,1L,2L,2L,1L,1L,3L,32L,3L,1L,1L,2L,2L,1L,1L,3L,32L,3L,1L,1L,2L,2L,1L,1L,3L,32L,3L,1L,1L,2L,2L,1L,1L,3L,32L,3L,1L,1L,2L,2L,1L,1L };
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
public class A040248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040248Inst : IEnumerable<long>
{
public static readonly long[] Value=A040248.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040248.Bytes);
public long this[int i]=>Value[i];

public static A040248Inst Instance=new A040248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040249
{
public static readonly long[] Value={ 16L,3L,4L,3L,32L,3L,4L,3L,32L,3L,4L,3L,32L,3L,4L,3L,32L,3L,4L,3L,32L,3L,4L,3L,32L,3L,4L,3L,32L,3L,4L,3L,32L,3L,4L,3L,32L,3L,4L,3L,32L,3L,4L,3L,32L,3L,4L,3L,32L,3L,4L,3L,32L,3L,4L,3L,32L,3L,4L,3L,32L,3L,4L,3L,32L,3L,4L,3L,32L,3L,4L,3L,32L,3L,4L,3L,32L,3L,4L,3L,32L,3L,4L,3L };
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
public class A040249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040249Inst : IEnumerable<long>
{
public static readonly long[] Value=A040249.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040249.Bytes);
public long this[int i]=>Value[i];

public static A040249Inst Instance=new A040249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040250
{
public static readonly long[] Value={ 16L,2L,1L,15L,1L,2L,32L,2L,1L,15L,1L,2L,32L,2L,1L,15L,1L,2L,32L,2L,1L,15L,1L,2L,32L,2L,1L,15L,1L,2L,32L,2L,1L,15L,1L,2L,32L,2L,1L,15L,1L,2L,32L,2L,1L,15L,1L,2L,32L,2L,1L,15L,1L,2L,32L,2L,1L,15L,1L,2L,32L,2L,1L,15L,1L,2L,32L,2L,1L,15L,1L,2L,32L,2L,1L,15L,1L,2L,32L,2L,1L };
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
public class A040250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040250Inst : IEnumerable<long>
{
public static readonly long[] Value=A040250.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040250.Bytes);
public long this[int i]=>Value[i];

public static A040250Inst Instance=new A040250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040251
{
public static readonly long[] Value={ 16L,2L,1L,2L,3L,3L,1L,3L,1L,10L,8L,10L,1L,3L,1L,3L,3L,2L,1L,2L,32L,2L,1L,2L,3L,3L,1L,3L,1L,10L,8L,10L,1L,3L,1L,3L,3L,2L,1L,2L,32L,2L,1L,2L,3L,3L,1L,3L,1L,10L,8L,10L,1L,3L,1L,3L,3L,2L,1L,2L,32L,2L,1L,2L,3L,3L,1L,3L,1L,10L,8L,10L,1L,3L,1L,3L,3L,2L,1L,2L,32L,2L,1L,2L,3L,3L,1L };
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
public class A040251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040251Inst : IEnumerable<long>
{
public static readonly long[] Value=A040251.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040251.Bytes);
public long this[int i]=>Value[i];

public static A040251Inst Instance=new A040251Inst();

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