using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A160205
{
public static readonly long[] Value={ 2L,6L,4L,4L,1L,8L,5L,1L,0L,3L,7L,1L,9L,7L,1L,6L,7L,0L,9L,4L,2L,1L,0L,2L,1L,9L,4L,2L,9L,9L,7L,0L,6L,8L,9L,3L,1L,1L,3L,9L,4L,2L,8L,9L,7L,0L,1L,1L,7L,3L,8L,7L,9L,7L,4L,2L,7L,7L,8L,0L,7L,7L,5L,9L,8L,2L,5L,8L,5L,3L,8L,9L,9L,9L,4L,7L,9L,9L,5L,8L,6L,3L,1L,9L,0L,4L,2L,7L,9L,8L,6L,4L,1L,1L,0L,4L,4L,6L,7L,0L,4L,5L,6L,0L,2L };
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
public class A160205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160205Inst : IEnumerable<long>
{
public static readonly long[] Value=A160205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160205.Bytes);
public long this[int i]=>Value[i];

public static A160205Inst Instance=new A160205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160206
{
public static readonly long[] Value={ 697L,857L,1117L,3065L,4285L,6005L,17693L,24853L,34913L,103093L,144833L,203473L,600865L,844145L,1185925L,3502097L,4920037L,6912077L,20411717L,28676077L,40286537L,118968205L,167136425L,234807145L,693397513L,974142473L,1368556333L };
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
public class A160206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160206Inst : IEnumerable<long>
{
public static readonly long[] Value=A160206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160206.Bytes);
public long this[int i]=>Value[i];

public static A160206Inst Instance=new A160206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160207
{
public static readonly long[] Value={ 1L,4L,0L,4L,8L,8L,3L,1L,3L,6L,6L,3L,7L,5L,1L,4L,5L,3L,9L,3L,7L,9L,6L,4L,3L,6L,7L,8L,0L,4L,4L,3L,8L,3L,4L,2L,6L,4L,8L,7L,3L,1L,7L,4L,9L,5L,7L,1L,6L,6L,3L,8L,3L,8L,4L,3L,2L,5L,6L,7L,4L,1L,4L,8L,1L,6L,5L,7L,5L,7L,0L,8L,3L,4L,0L,3L,7L,8L,3L,5L,2L,1L,7L,7L,1L,9L,7L,3L,6L,0L,8L,1L,7L,8L,3L,0L,1L,9L,0L,2L,3L,0L,3L,7L,9L };
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
public class A160207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160207Inst : IEnumerable<long>
{
public static readonly long[] Value=A160207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160207.Bytes);
public long this[int i]=>Value[i];

public static A160207Inst Instance=new A160207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160208
{
public static readonly long[] Value={ 2L,9L,5L,3L,0L,5L,1L,1L,6L,4L,6L,1L,0L,0L,9L,8L,2L,1L,0L,4L,1L,4L,0L,5L,5L,7L,5L,8L,4L,1L,7L,5L,7L,7L,5L,4L,7L,4L,9L,9L,1L,7L,5L,1L,6L,8L,6L,1L,2L,3L,2L,2L,6L,4L,4L,6L,2L,4L,7L,9L,7L,6L,1L,9L,9L,4L,0L,4L,8L,9L,3L,7L,8L,4L,5L,0L,2L,3L,7L,2L,5L,5L,8L,4L,8L,4L,9L,7L,8L,3L,7L,8L,7L,4L,7L,6L,1L,4L,2L,7L,4L,3L,0L,9L,0L };
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
public class A160208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160208Inst : IEnumerable<long>
{
public static readonly long[] Value=A160208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160208.Bytes);
public long this[int i]=>Value[i];

public static A160208Inst Instance=new A160208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160209
{
public static readonly long[] Value={ 673L,937L,1685L,2353L,4685L,9437L,13445L,27173L,54937L,78317L,158353L,320185L,456457L,922945L,1866173L,2660425L,5379317L,10876853L,15506093L,31352957L,63394945L,90376133L,182738425L,369492817L,526750705L,1065077593L,2153561957L };
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
public class A160209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160209Inst : IEnumerable<long>
{
public static readonly long[] Value=A160209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160209.Bytes);
public long this[int i]=>Value[i];

public static A160209Inst Instance=new A160209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160210
{
public static readonly long[] Value={ 2L,0L,2L,1L,9L,7L,6L,5L,8L,7L,5L,7L,8L,2L,1L,3L,5L,4L,8L,2L,3L,2L,2L,8L,8L,6L,8L,1L,3L,7L,6L,8L,4L,8L,6L,9L,5L,5L,7L,7L,6L,4L,5L,6L,4L,4L,5L,4L,7L,2L,0L,9L,9L,5L,2L,0L,0L,3L,6L,2L,8L,5L,4L,5L,8L,0L,9L,2L,9L,6L,3L,0L,1L,0L,6L,9L,1L,8L,4L,8L,0L,4L,3L,3L,1L,1L,5L,9L,1L,1L,6L,7L,2L,3L,3L,5L,8L,2L,0L,2L,5L,6L,5L,5L,4L };
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
public class A160210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160210Inst : IEnumerable<long>
{
public static readonly long[] Value=A160210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160210.Bytes);
public long this[int i]=>Value[i];

public static A160210Inst Instance=new A160210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160211
{
public static readonly long[] Value={ 1L,4L,2L,5L,6L,0L,4L,7L,2L,2L,9L,1L,9L,9L,9L,9L,5L,1L,1L,6L,6L,8L,1L,1L,2L,6L,4L,9L,5L,4L,1L,5L,0L,3L,5L,7L,6L,4L,3L,2L,7L,0L,7L,7L,4L,1L,9L,4L,8L,7L,2L,6L,1L,4L,1L,5L,6L,6L,2L,7L,4L,4L,6L,3L,9L,7L,8L,8L,3L,3L,9L,0L,8L,6L,8L,4L,3L,2L,6L,3L,7L,6L,4L,5L,1L,6L,3L,7L,5L,9L,8L,5L,2L,7L,0L,9L,5L,9L,7L,7L,1L,9L,5L,6L,8L };
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
public class A160211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160211Inst : IEnumerable<long>
{
public static readonly long[] Value=A160211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160211.Bytes);
public long this[int i]=>Value[i];

public static A160211Inst Instance=new A160211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160212
{
public static readonly long[] Value={ 845L,953L,1093L,3977L,4765L,5713L,23017L,27637L,33185L,134125L,161057L,193397L,781733L,938705L,1127197L,4556273L,5471173L,6569785L,26555905L,31888333L,38291513L,154779157L,185858825L,223179293L,902119037L,1083264617L,1300784245L };
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
public class A160212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160212Inst : IEnumerable<long>
{
public static readonly long[] Value=A160212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160212.Bytes);
public long this[int i]=>Value[i];

public static A160212Inst Instance=new A160212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160213
{
public static readonly long[] Value={ 1L,2L,0L,0L,8L,0L,0L,0L,8L,5L,7L,6L,5L,2L,2L,9L,5L,7L,6L,1L,2L,9L,4L,9L,5L,6L,9L,9L,6L,8L,7L,3L,0L,5L,9L,4L,0L,9L,6L,8L,1L,4L,1L,9L,8L,5L,8L,8L,3L,2L,5L,4L,5L,2L,3L,6L,8L,7L,2L,0L,7L,0L,1L,7L,3L,2L,5L,1L,3L,2L,0L,3L,2L,8L,7L,4L,3L,9L,7L,9L,7L,7L,7L,7L,2L,7L,6L,8L,1L,5L,7L,6L,6L,6L,9L,7L,5L,3L,9L,8L,7L,6L,0L,9L,0L };
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
public class A160213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160213Inst : IEnumerable<long>
{
public static readonly long[] Value=A160213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160213.Bytes);
public long this[int i]=>Value[i];

public static A160213Inst Instance=new A160213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160214
{
public static readonly long[] Value={ 4L,0L,4L,2L,1L,2L,6L,9L,5L,9L,3L,4L,0L,8L,4L,8L,4L,0L,1L,6L,5L,0L,2L,4L,7L,5L,6L,8L,0L,8L,4L,3L,0L,1L,0L,9L,3L,4L,2L,2L,7L,2L,4L,8L,1L,7L,1L,1L,5L,9L,4L,7L,3L,8L,4L,0L,1L,0L,7L,8L,6L,6L,0L,7L,4L,2L,6L,6L,2L,4L,9L,4L,8L,3L,1L,1L,7L,7L,9L,3L,4L,3L,4L,8L,6L,8L,0L,6L,1L,2L,7L,9L,9L,7L,9L,4L,7L,5L,8L,6L,9L,1L,2L,1L,3L };
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
public class A160214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160214Inst : IEnumerable<long>
{
public static readonly long[] Value=A160214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160214.Bytes);
public long this[int i]=>Value[i];

public static A160214Inst Instance=new A160214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160215
{
public static readonly long[] Value={ 2L,5L,13L,17L,29L,37L,53L,61L,101L,109L,113L,149L,157L,173L,181L,193L,197L,229L,241L,257L,269L,277L,293L,317L,337L,349L,373L,389L,397L,401L,421L,433L,449L,461L,509L,541L,557L,577L,593L,613L,653L,661L,677L,701L,709L,733L,757L,769L,773L,797L,821L,829L,853L,877L };
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
public class A160215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160215Inst : IEnumerable<long>
{
public static readonly long[] Value=A160215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160215.Bytes);
public long this[int i]=>Value[i];

public static A160215Inst Instance=new A160215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160216
{
public static readonly long[] Value={ 3L,7L,11L,19L,23L,31L,41L,43L,47L,59L,67L,71L,73L,79L,83L,89L,97L,103L,107L,127L,131L,137L,139L,151L,163L,167L,179L,191L,199L,211L,223L,227L,233L,239L,251L,263L,271L,281L,283L,307L,311L,313L,331L,347L,353L,359L,367L,379L,383L,409L,419L,431L,439L,443L,457L,463L };
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
public class A160216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160216Inst : IEnumerable<long>
{
public static readonly long[] Value=A160216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160216.Bytes);
public long this[int i]=>Value[i];

public static A160216Inst Instance=new A160216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160217
{
public static readonly long[] Value={ 3L,6L,7L,9L,11L,14L,15L,18L,19L,22L,23L,25L,27L,30L,31L,33L,35L,38L,39L,41L,43L,46L,47L,50L,51L,54L,55L,57L,59L,62L,63L,66L,67L,70L,71L,73L,75L,78L,79L,82L,83L,86L,87L,89L,91L,94L,95L,97L,99L,102L,103L,105L,107L,110L,111L,114L,115L,118L,119L,121L,123L,126L,127L,129L,131L,134L };
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
public class A160217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160217Inst : IEnumerable<long>
{
public static readonly long[] Value=A160217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160217.Bytes);
public long this[int i]=>Value[i];

public static A160217Inst Instance=new A160217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160218
{
public static readonly long[] Value={ 2L,3L,14L,20L,32L,301L,1065L };
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
public class A160218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160218Inst : IEnumerable<long>
{
public static readonly long[] Value=A160218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160218.Bytes);
public long this[int i]=>Value[i];

public static A160218Inst Instance=new A160218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160219
{
public static readonly BigInteger[] Value={ 1L,17L,-103L,-15079L,-135215L,21345217L,627890089L,-39529818871L,-2394937325023L,83251577454065L,9864615699400249L,-158647716730130567L,BigInteger.Parse("-45233234080226093327"),BigInteger.Parse("-22686119865309399391"),BigInteger.Parse("230122896835121911804745"),BigInteger.Parse("4036590672017890484538473") };
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
public class A160219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160219Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160219.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160219.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160219Inst Instance=new A160219Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160220
{
public static readonly BigInteger[] Value={ 1L,19L,-31L,-15485L,-257759L,19383059L,873485761L,-28992725309L,-2947706709055L,34914759096979L,11062889692388641L,73329048495226499L,BigInteger.Parse("-46309928432170516511"),BigInteger.Parse("-1224828484332785265005"),BigInteger.Parse("212723654088018032104961"),BigInteger.Parse("10763608149690668144341699"),BigInteger.Parse("-1046306531193423334034678399") };
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
public class A160220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160220Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160220.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160220.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160220Inst Instance=new A160220Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160221
{
public static readonly BigInteger[] Value={ 1L,23L,137L,-14881L,-503375L,11755783L,1256998009L,1261352591L,-3420191427103L,-82620004548745L,10166175250198249L,557692448585640127L,BigInteger.Parse("-31009621361385126767"),BigInteger.Parse("-3336606569458709073049"),BigInteger.Parse("81283079360068297324505"),BigInteger.Parse("20180807678470966231356527"),BigInteger.Parse("-13785930032369364946889279") };
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
public class A160221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160221Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160221.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160221.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160221Inst Instance=new A160221Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160222
{
public static readonly BigInteger[] Value={ 1L,25L,233L,-13775L,-618383L,6139625L,1365521305L,19697634625L,-3254549595295L,-143135522066375L,7903662920541385L,758682819513724625L,BigInteger.Parse("-15113524025531336495"),BigInteger.Parse("-3946682083630844048375"),BigInteger.Parse("-21648533656663410430855"),BigInteger.Parse("21118177933549486876710625") };
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
public class A160222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160222Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160222.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160222.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160222Inst Instance=new A160222Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160223
{
public static readonly BigInteger[] Value={ 1L,27L,337L,-12069L,-722175L,-574533L,1399950609L,39149968059L,-2784415333503L,-197953513837605L,4478672422983249L,896901929663959323L,4904316613023132033L,BigInteger.Parse("-4086610128587640090501"),BigInteger.Parse("-135330870931832163283695"),BigInteger.Parse("18773382870529500408009723") };
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
public class A160223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160223Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160223.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160223.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160223Inst Instance=new A160223Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160224
{
public static readonly BigInteger[] Value={ 1L,2L,-1678L,-10084L,8447020L,84739192L,-70869959816L,-996927845296L,832429051182992L,15079519188668960L,BigInteger.Parse("-12571151938430794976"),BigInteger.Parse("-278779816630273497152"),BigInteger.Parse("232033893531586021651648"),BigInteger.Parse("6090959605928612309819264"),BigInteger.Parse("-5061471196749802724815296640") };
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
public class A160224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160224Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160224.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160224.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160224Inst Instance=new A160224Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160225
{
public static readonly BigInteger[] Value={ 1L,4L,-1666L,-20120L,8326156L,168671984L,-69348284024L,-1979630798624L,808588172904080L,29872264717900864L,BigInteger.Parse("-12120918702550359584"),BigInteger.Parse("-550935167365293970816"),BigInteger.Parse("222057497165125577139904"),BigInteger.Parse("12008305406761595815509760"),BigInteger.Parse("-4807476011385589486479101824") };
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
public class A160225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160225Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160225.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160225.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160225Inst Instance=new A160225Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160226
{
public static readonly BigInteger[] Value={ 1L,6L,-1646L,-30060L,8125356L,250995816L,-66828269064L,-2934019389456L,769231923622800L,44095556446256736L,BigInteger.Parse("-11380059521124405984"),BigInteger.Parse("-809967616552784735424"),BigInteger.Parse("205694055560527051103424"),BigInteger.Parse("17582550705864569406418560"),BigInteger.Parse("-4392210914651297082988957824") };
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
public class A160226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160226Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160226.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160226.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160226Inst Instance=new A160226Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160227
{
public static readonly long[] Value={ 3L,7L,11L,19L,23L,25L,31L,41L,43L,47L,59L,67L,71L,73L,79L,83L,89L,97L,103L,107L,127L,131L,137L,139L,151L,163L,167L,169L,179L };
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
public class A160227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160227Inst : IEnumerable<long>
{
public static readonly long[] Value=A160227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160227.Bytes);
public long this[int i]=>Value[i];

public static A160227Inst Instance=new A160227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160228
{
public static readonly long[] Value={ 8L,60L,512L,5015L,49923L,500279L,4997393L,49999921L };
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
public class A160228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160228Inst : IEnumerable<long>
{
public static readonly long[] Value=A160228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160228.Bytes);
public long this[int i]=>Value[i];

public static A160228Inst Instance=new A160228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160229
{
public static readonly long[] Value={ 2L,40L,488L,4985L,50077L,499721L,5002607L,5000079L };
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
public class A160229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160229Inst : IEnumerable<long>
{
public static readonly long[] Value=A160229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160229.Bytes);
public long this[int i]=>Value[i];

public static A160229Inst Instance=new A160229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160230
{
public static readonly long[] Value={ 0L,0L,0L,3L,2L,0L,0L,6L,6L,4L,4L,3L,2L,0L,0L,15L,14L,12L,12L,11L,10L,8L,8L,6L,6L,4L,4L,3L,2L,0L,0L,30L };
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
public class A160230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160230Inst : IEnumerable<long>
{
public static readonly long[] Value=A160230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160230.Bytes);
public long this[int i]=>Value[i];

public static A160230Inst Instance=new A160230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160231
{
public static readonly BigInteger[] Value={ 1L,8L,-1618L,-39856L,7845580L,330915808L,-63334001336L,-3846274345024L,714924336969872L,57474862282401920L,BigInteger.Parse("-10362725714790706976"),BigInteger.Parse("-1049628989308325950208"),BigInteger.Parse("183334119260591052868288"),BigInteger.Parse("22652384474283979401944576"),BigInteger.Parse("-3827564775957812126802428800") };
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
public class A160231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160231Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160231.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160231.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160231Inst Instance=new A160231Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160232
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,3L,5L,4L,1L,4L,9L,12L,8L,1L,5L,14L,25L,28L,16L,1L,6L,20L,44L,66L,64L,32L,1L,7L,27L,70L,129L,168L,144L,64L,1L,8L,35L,104L,225L,360L,416L,320L,128L,1L,9L,44L,147L,363L,681L,968L,1008L,704L,256L,1L,10L,54L,200L,553L,1182L,1970L,2528L,2400L,1536L,512L,1L,11L,65L };
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
public class A160232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160232Inst : IEnumerable<long>
{
public static readonly long[] Value=A160232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160232.Bytes);
public long this[int i]=>Value[i];

public static A160232Inst Instance=new A160232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160233
{
public static readonly long[] Value={ 1280L,1600L,4800L,28672L,131072L,688128L,6881280L,7864320L,39321600L,43253760L,94371840L,201326592L,528482304L,9663676416L,115964116992L,241591910400L,265751101440L,347892350976L,811748818944L,3522410053632L,4174708211712L };
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
public class A160233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160233Inst : IEnumerable<long>
{
public static readonly long[] Value=A160233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160233.Bytes);
public long this[int i]=>Value[i];

public static A160233Inst Instance=new A160233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160234
{
public static readonly long[] Value={ 0L,45L,630L,6896L,73059L };
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
public class A160234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160234Inst : IEnumerable<long>
{
public static readonly long[] Value=A160234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160234.Bytes);
public long this[int i]=>Value[i];

public static A160234Inst Instance=new A160234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160235
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,3L,5L,6L,9L,14L,21L,32L,54L,87L,144L,230L,383L,671L,1158L,1981L,3408L,6246L,10925L,19463L,34624L,63941L,114954L,208429L,380130L,707194L,1298600L,2379842L,4398644L,8253618L,15303057L,28453809L,53091455L,100061278L,187446097L };
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
public class A160235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160235Inst : IEnumerable<long>
{
public static readonly long[] Value=A160235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160235.Bytes);
public long this[int i]=>Value[i];

public static A160235Inst Instance=new A160235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160236
{
public static readonly BigInteger[] Value={ 1L,10L,-1582L,-49460L,7488172L,407648600L,-58899040520L,-4702980076400L,646447502318480L,69747774931223200L,-9088444540784918240L,BigInteger.Parse("-1264042019751023406400"),BigInteger.Parse("155513980696092323212480"),BigInteger.Parse("27068563933615579666902400"),BigInteger.Parse("-3129783062564598942695063680") };
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
public class A160236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160236Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160236.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160236.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160236Inst Instance=new A160236Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160237
{
public static readonly BigInteger[] Value={ 1L,12L,-1538L,-58824L,7054860L,480426192L,-53566258296L,-5491256229216L,564794050426512L,80667872425448640L,-7581837866251154976L,BigInteger.Parse("-1447815668591059984512"),BigInteger.Parse("122905376178286149551808"),BigInteger.Parse("30697575968981388522011904"),BigInteger.Parse("-2319078043886628283835690880") };
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
public class A160237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160237Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160237.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160237.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160237Inst Instance=new A160237Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160238
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,8L,9L,10L,12L,16L,17L,18L,20L,23L,24L,25L,32L,33L,35L,37L,40L,47L,57L,86L,112L,123L,139L,216L,322L,843L,1161L,1476L,2207L,3864L,4999L,5778L,15127L,39603L,103682L,271443L,710647L,1244196L,1860498L,4870847L,12752043L };
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
public class A160238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160238Inst : IEnumerable<long>
{
public static readonly long[] Value=A160238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160238.Bytes);
public long this[int i]=>Value[i];

public static A160238Inst Instance=new A160238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160239
{
public static readonly long[] Value={ 1L,8L,8L,24L,8L,64L,24L,112L,8L,64L,64L,192L,24L,192L,112L,416L,8L,64L,64L,192L,64L,512L,192L,896L,24L,192L,192L,576L,112L,896L,416L,1728L,8L,64L,64L,192L,64L,512L,192L,896L,64L,512L,512L,1536L,192L,1536L,896L,3328L,24L,192L,192L,576L,192L,1536L,576L,2688L,112L,896L,896L,2688L,416L,3328L,1728L,6784L };
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
public class A160239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160239Inst : IEnumerable<long>
{
public static readonly long[] Value=A160239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160239.Bytes);
public long this[int i]=>Value[i];

public static A160239Inst Instance=new A160239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160240
{
public static readonly BigInteger[] Value={ 1L,6L,78L,469L,3501L,22144L,144476L,899432L,5585508L,34092855L,206571444L,1241016042L,7407467656L,43975776229L,259779839242L,1528563721468L,8960651209082L,52368047294410L,305173796833144L,1774059940879290L,10289839706255591L,59564855651625602L,344177608427972004L,1985502681113986836L,11437008315770485918UL,BigInteger.Parse("65791536638478271291"),BigInteger.Parse("377999748832914166324"),BigInteger.Parse("2169320756101096085597"),BigInteger.Parse("12436728915873118081588"),BigInteger.Parse("71232070407411735554025") };
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
public class A160240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160240Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160240.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160240.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160240Inst Instance=new A160240Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160241
{
public static readonly BigInteger[] Value={ 1L,7L,164L,1337L,16262L,144476L,1510446L,13506023L,132712481L,1185979605L,11264671456L,100572103736L,935551716239L,8347069749600L,76604373779441L,683160282998544L,6213169249692192L,55392188422262591L,500676083630457127L,4462726297606450762L,BigInteger.Parse("40165465812088131228"),BigInteger.Parse("357958181000067374304"),BigInteger.Parse("3212099862174948821718"),BigInteger.Parse("28623565473267451344466"),BigInteger.Parse("256312533945178149983147"),BigInteger.Parse("2283878397650977479239903"),BigInteger.Parse("20420964710002966369773032"),BigInteger.Parse("181952098315164452547737813"),BigInteger.Parse("1625193628709305194920610168"),BigInteger.Parse("14480051230931926406392771755") };
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
public class A160241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160241Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160241.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160241.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160241Inst Instance=new A160241Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160242
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
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
public class A160242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160242Inst : IEnumerable<long>
{
public static readonly long[] Value=A160242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160242.Bytes);
public long this[int i]=>Value[i];

public static A160242Inst Instance=new A160242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160243
{
public static readonly long[] Value={ 5L,7L,12L,18L,29L,42L,64L,95L,146L,228L,353L,558L,884L,1407L,2254L,3624L,5837L,9410L,15194L,24547L,39676L,64158L,103765L,167850L,271540L,439305L,710750L,1149958L,1860607L,3010462L,4870974L,7881327L,12752180L,30633378L,33385431L,54018672L };
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
public class A160243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160243Inst : IEnumerable<long>
{
public static readonly long[] Value=A160243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160243.Bytes);
public long this[int i]=>Value[i];

public static A160243Inst Instance=new A160243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160244
{
public static readonly long[] Value={ 6L,8L,14L,21L,34L,50L,77L,116L,180L,283L,442L,702L,1117L,1784L,2864L,4611L,7434L,11994L,19375L,31312L,50622L,81869L,132422L,214218L,346565L,560698L,907168L,1467769L,2374836L,3842502L,6217243L,10059636L,16276758L,26336265L,42612896L,68949024L };
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
public class A160244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160244Inst : IEnumerable<long>
{
public static readonly long[] Value=A160244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160244.Bytes);
public long this[int i]=>Value[i];

public static A160244Inst Instance=new A160244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160245
{
public static readonly long[] Value={ 2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,1L,3L,2L,2L,6L,1L,3L,3L,1L,1L,1L,1L,1L,2L,1L,1L,2L,3L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,4L,1L,2L,1L,1L,3L,3L,2L,2L,3L,1L,1L,1L,5L,3L,2L,1L,2L,1L,1L,2L,1L,1L,2L,2L,1L,2L,4L,2L,2L,5L,1L,2L,1L,2L,1L,1L,2L,2L,1L,2L,3L,3L,3L,1L,2L,1L,3L,1L,1L,2L,1L,1L,2L,4L,2L,4L };
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
public class A160245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160245Inst : IEnumerable<long>
{
public static readonly long[] Value=A160245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160245.Bytes);
public long this[int i]=>Value[i];

public static A160245Inst Instance=new A160245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160246
{
public static readonly BigInteger[] Value={ 1L,14L,-1486L,-67900L,6547756L,548499784L,-47387630984L,-6198886653904L,471157554050960L,90008424571645664L,-5872265109220393184L,BigInteger.Parse("-1596153412824165573056"),BigInteger.Parse("86302501271257396667584"),BigInteger.Parse("33424995502240561479908480"),BigInteger.Parse("-1419140555765946374814673024") };
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
public class A160246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160246Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160246.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160246.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160246Inst Instance=new A160246Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160247
{
public static readonly long[] Value={ 1L,13L,6L,55L,38L,19L,147L,116L,79L,44L,309L,260L,201L,140L,85L,561L,490L,405L,314L,225L,146L,923L,826L,711L,586L,459L,338L,231L,1415L,1288L,1139L,976L,807L,640L,483L,344L };
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
public class A160247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160247Inst : IEnumerable<long>
{
public static readonly long[] Value=A160247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160247.Bytes);
public long this[int i]=>Value[i];

public static A160247Inst Instance=new A160247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160248
{
public static readonly long[] Value={ 1L,6L,4L,19L,16L,10L,44L,40L,31L,20L,85L,80L,68L,52L,35L,146L,140L,125L,104L,80L,56L,231L,224L,206L,180L,149L,116L,84L,344L,336L,315L,284L,246L,204L,161L,120L,489L,480L,456L,420L,375L,324L,270L,216L,165L };
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
public class A160248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160248Inst : IEnumerable<long>
{
public static readonly long[] Value=A160248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160248.Bytes);
public long this[int i]=>Value[i];

public static A160248Inst Instance=new A160248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160249
{
public static readonly long[] Value={ 1L,4L,13L,10L,28L,55L,20L,50L,92L,147L,35L,80L,140L,216L,309L,56L,119L,200L,300L,420L,561L,84L,168L,273L,400L,550L,724L,923L,120L,228L,360L,517L,700L,910L,1148L,1415L,165L,300L,462L,652L,871L,1120L,1400L,1712L,2057L };
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
public class A160249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160249Inst : IEnumerable<long>
{
public static readonly long[] Value=A160249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160249.Bytes);
public long this[int i]=>Value[i];

public static A160249Inst Instance=new A160249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160250
{
public static readonly long[] Value={ 1L,93L,617L,1957L,4497L,8621L,14713L,23157L,34337L,48637L,66441L,88133L,114097L,144717L,180377L,221461L,268353L,321437L,381097L,447717L,521681L,603373L,693177L,791477L,898657L,1015101L,1141193L };
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
public class A160250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160250Inst : IEnumerable<long>
{
public static readonly long[] Value=A160250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160250.Bytes);
public long this[int i]=>Value[i];

public static A160250Inst Instance=new A160250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160251
{
public static readonly BigInteger[] Value={ 1L,16L,-1426L,-76640L,5969356L,611143616L,-40423986104L,-6814445150336L,366920889983120L,97565908182651136L,-3993393901642052384L,BigInteger.Parse("-1704952878058464945664"),BigInteger.Parse("46606527919245814078144"),BigInteger.Parse("35158473337439989488532480"),BigInteger.Parse("-456562766083189138816177024") };
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
public class A160251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160251Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160251.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160251.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160251Inst Instance=new A160251Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160252
{
public static readonly BigInteger[] Value={ 1L,18L,-1358L,-84996L,5322540L,667658808L,-32744702856L,-7327417341744L,253642619275152L,103163294897460000L,-1982702662432970976L,BigInteger.Parse("-1770895268099070677568"),BigInteger.Parse("4807849834551556801728"),BigInteger.Parse("35830291388333570578463616"),BigInteger.Parse("539816800507699929385760640") };
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
public class A160252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160252Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160252.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160252.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160252Inst Instance=new A160252Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160253
{
public static readonly BigInteger[] Value={ 1L,20L,-1282L,-92920L,4610572L,717377200L,-24427366520L,-7728318032800L,133041452750480L,106653076504366400L,119080018350561760L,BigInteger.Parse("-1791523146436431612800"),BigInteger.Parse("-38033681428250725939520"),BigInteger.Parse("35399429559107921153964800"),BigInteger.Parse("1539633069292288796472840320") };
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
public class A160253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160253Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160253.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160253.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160253Inst Instance=new A160253Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160254
{
public static readonly long[] Value={ 1L,2L,4L,7L,13L,24L,44L,81L,151L,280L,525L,984L,1859L,3511L,6682L,12709L,24334L,46565L,89626L,172381L,333262L,643733L,1249147L,2421592L,4713715L,9165792L,17888456L,34873456L,68212220L,133269997L,261167821L,511211652L,1003436520L,1967293902L };
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
public class A160254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160254Inst : IEnumerable<long>
{
public static readonly long[] Value=A160254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160254.Bytes);
public long this[int i]=>Value[i];

public static A160254Inst Instance=new A160254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160255
{
public static readonly long[] Value={ 0L,1L,6L,16L,40L,63L,126L,176L,270L,365L,550L,624L,936L,1099L,1350L,1664L,2176L,2349L,3078L,3280L,3948L,4631L,5566L,5712L,7000L,7813L,8748L,9520L,11368L,11475L,13950L,14592L,16236L,17969L,19390L,20304L,23976L,25327L,27222L,28400L,32800L,32949L,37926L,38896L };
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
public class A160255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160255Inst : IEnumerable<long>
{
public static readonly long[] Value=A160255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160255.Bytes);
public long this[int i]=>Value[i];

public static A160255Inst Instance=new A160255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160256
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,16L,18L,24L,12L,10L,30L,5L,36L,15L,48L,20L,60L,7L,120L,14L,180L,21L,240L,28L,300L,35L,360L,42L,420L,11L,840L,22L,1260L,33L,1680L,44L,2100L,55L,2520L,66L,2940L,77L,3360L,88L,3780L,110L,378L,165L,126L,220L,63L,440L,189L,880L,567L,1760L };
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
public class A160256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160256Inst : IEnumerable<long>
{
public static readonly long[] Value=A160256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160256.Bytes);
public long this[int i]=>Value[i];

public static A160256Inst Instance=new A160256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160257
{
public static readonly long[] Value={ 6L,6L,8L,12L,12L,18L,32L,27L,16L,5L,25L,15L,6L,108L,20L,64L,25L,21L,14L,240L,21L,270L,28L,320L,35L,375L,42L,432L,49L,110L,22L,1680L,33L,1890L,44L,2240L,55L,2625L,66L,3024L,77L,3430L,88L,3840L,99L,4725L,11L,567L,55L,168L,110L,126L,1320L,378L,2640L,1134L,3520L,1701L };
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
public class A160257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160257Inst : IEnumerable<long>
{
public static readonly long[] Value=A160257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160257.Bytes);
public long this[int i]=>Value[i];

public static A160257Inst Instance=new A160257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160258
{
public static readonly long[] Value={ 8L,12L,16L,18L,20L,24L,24L,27L,28L,30L,32L,32L,36L,36L,36L,40L,40L,42L,44L,45L,48L,48L,48L,48L,50L,52L,54L,54L,56L,56L,60L,60L,60L,60L,63L,64L,64L,64L,66L,68L,70L,72L,72L,72L,72L,72L,72L,75L,76L,78L,80L,80L,80L,80L,81L,84L,84L,84L,84L,88L,88L,90L,90L,90L,90L,92L,96L,96L,96L,96L,96L,96L };
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
public class A160258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160258Inst : IEnumerable<long>
{
public static readonly long[] Value=A160258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160258.Bytes);
public long this[int i]=>Value[i];

public static A160258Inst Instance=new A160258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160259
{
public static readonly BigInteger[] Value={ 1L,22L,-1198L,-100364L,3837100L,759665192L,-15557376776L,-8008803406736L,6978879212432L,107919993983713120L,2268593594123893024L,BigInteger.Parse("-1765305239735329031872"),BigInteger.Parse("-80810233952657507431232"),BigInteger.Parse("33853095811859416015817344"),BigInteger.Parse("2511764683469716209839300480") };
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
public class A160259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160259Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160259.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160259.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160259Inst Instance=new A160259Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160260
{
public static readonly BigInteger[] Value={ 1L,24L,-1106L,-107280L,3006156L,793927584L,-6227509944L,-8161777416384L,-122559955912560L,106883437972961664L,4420515123955413216L,BigInteger.Parse("-1691687063730285271296"),BigInteger.Parse("-122388860352949901833536"),BigInteger.Parse("31207679045861280271833600"),BigInteger.Parse("3425139117578273280016104576") };
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
public class A160260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160260Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160260.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160260.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160260Inst Instance=new A160260Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160261
{
public static readonly BigInteger[] Value={ 1L,26L,-1006L,-113620L,2122156L,819611416L,3462564856L,-8181491724016L,-253487023438960L,103499490028946336L,6528273301571581216L,BigInteger.Parse("-1571126316446016259904"),BigInteger.Parse("-161635396853273818415936"),BigInteger.Parse("27509093252961272911088000"),BigInteger.Parse("4249556012170678409171144576") };
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
public class A160261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160261Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160261.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160261.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160261Inst Instance=new A160261Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160262
{
public static readonly long[] Value={ 1L,9L,2L,6L,5L,3L,8L,7L,9L,3L,3L,4L,6L,2L,4L,3L,3L,8L,3L,7L,5L,0L,2L,8L,8L,1L,9L,7L,6L,3L,9L,9L,7L,5L,1L,0L,5L,2L,0L,9L,7L,4L,4L,5L,9L,2L,3L,0L,8L,1L,6L,0L,2L,8L,6L,2L,0L,9L,9L,8L,2L,8L,0L,3L,4L,2L,5L,3L,4L,2L,1L,1L,0L,6L,7L,8L,1L,4L,8L,8L,5L,1L,3L,8L,2L,3L,0L,6L,6L,4L,7L,0L,9L,3L,8L };
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
public class A160262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160262Inst : IEnumerable<long>
{
public static readonly long[] Value=A160262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160262.Bytes);
public long this[int i]=>Value[i];

public static A160262Inst Instance=new A160262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160263
{
public static readonly BigInteger[] Value={ 1L,28L,-898L,-119336L,1189900L,836209808L,13406815624L,-8063638544864L,-383633726413168L,97762575920121280L,8544799476205933024L,BigInteger.Parse("-1405112141642673804928"),BigInteger.Parse("-197439019874757039348032"),BigInteger.Parse("22832490910422530976921856"),BigInteger.Parse("4956511354073268289737879680") };
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
public class A160263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160263Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160263.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160263.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160263Inst Instance=new A160263Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160264
{
public static readonly long[] Value={ 11L,1481L,1861L,5641L,88801L,165701L,266671L,284731L,326141L,402751L,626611L,661091L,855721L,959461L,1022501L,1068241L,1068701L,1118851L,1146781L,1155601L,1246361L,1461401L,1573921L,1830331L,1917731L,2674531L,2683771L,3058871L };
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
public class A160264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160264Inst : IEnumerable<long>
{
public static readonly long[] Value=A160264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160264.Bytes);
public long this[int i]=>Value[i];

public static A160264Inst Instance=new A160264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160265
{
public static readonly long[] Value={ 1L,11L,12L,1121L,1321L,123121L };
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
public class A160265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160265Inst : IEnumerable<long>
{
public static readonly long[] Value=A160265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160265.Bytes);
public long this[int i]=>Value[i];

public static A160265Inst Instance=new A160265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160266
{
public static readonly long[] Value={ 2L,1L,1L,2L,4L,2L,1L,1L,6L,1L,2L,1L,1L,5L,1L,1L,1L,6L,1L,4L,3L,1L,2L,1L,1L,2L,1L,1L,10L,5L,1L,1L,8L,1L,1L,1L,1L,1L,2L,1L,40L,1L,1L,1L,1L,1L,6L,3L,1L,7L,17L,1L,36L,1L,1L,2L,1L,1L,1L,20L,1L,1L,1L,1L,8L,1L,1L,18L,13L,1L,5L,1L,2L,6L,1L,1L,1L,1L,1L,1L,6L,1L,9L,11L,2L,9L,1L,2L,9L,4L,6L,1L,1L,1L,9L,7L,1L,7L,29L,2L,2L,1L };
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
public class A160266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160266Inst : IEnumerable<long>
{
public static readonly long[] Value=A160266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160266.Bytes);
public long this[int i]=>Value[i];

public static A160266Inst Instance=new A160266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160267
{
public static readonly long[] Value={ 2L,1L,1L,1L,3L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,2L,1L,1L,1L,1L,1L,4L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,5L,1L,1L,1L,17L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,1L,4L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,9L,1L,2L,1L,1L,1L,2L,1L,3L,1L,1L,1L,8L,1L,1L,1L,5L,1L,2L,1L,1L,1L,2L,1L };
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
public class A160267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160267Inst : IEnumerable<long>
{
public static readonly long[] Value=A160267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160267.Bytes);
public long this[int i]=>Value[i];

public static A160267Inst Instance=new A160267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160268
{
public static readonly long[] Value={ 11L,23L,37L,41L,43L,59L,61L,79L,83L,97L,103L,107L,113L,121L,139L,143L,147L,149L,163L,167L,169L,171L,173L,177L,181L,183L,191L,193L,199L,201L,203L,227L,237L,243L,249L,251L,263L,271L,283L,287L,289L,293L,303L,313L,317L,321L,323L,347L,351L,353L,355L,359L,363L,367L,373L,379L };
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
public class A160268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160268Inst : IEnumerable<long>
{
public static readonly long[] Value=A160268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160268.Bytes);
public long this[int i]=>Value[i];

public static A160268Inst Instance=new A160268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160269
{
public static readonly BigInteger[] Value={ 1L,30L,-782L,-124380L,214572L,843265800L,23493423480L,-7805435749200L,-510774640529520L,89706704225349600L,10423307635096361760UL,BigInteger.Parse("-1196167536017489419200"),BigInteger.Parse("-228737063945077567859520"),BigInteger.Parse("17281333628624679401347200"),BigInteger.Parse("5520004649081806480856680320") };
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
public class A160269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160269Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160269.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160269.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160269Inst Instance=new A160269Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160270
{
public static readonly BigInteger[] Value={ 1L,32L,-658L,-128704L,-798260L,840376192L,33605404744L,-7405703577856L,-632652549947248L,79406265745318400L,12118094804951629024UL,BigInteger.Parse("-947834356077803359232"),BigInteger.Parse("-254539689475704747697472"),BigInteger.Parse("10985818579851831076419584"),BigInteger.Parse("5917311044631018607598349440") };
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
public class A160270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160270Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160270.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160270.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160270Inst Instance=new A160270Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160271
{
public static readonly long[] Value={ 1L,2L,0L,3L,0L,1L,2L,0L,2L,1L,4L,1L,3L,2L,2L,3L,0L,3L,3L,4L,3L,5L,1L,4L,4L,6L,6L,5L,4L,0L,4L,4L,7L,9L,10L,8L,6L,1L,5L,5L,8L,11L,15L,16L,13L,3L,0L,5L,5L,9L,12L,18L,24L,26L,21L,5L,2L,6L,6L,10L,14L,20L,29L,39L,42L,34L,7L,1L,5L,6L,11L,15L,23L,32L,47L,63L,68L,55L,4L,0L,6L,7L,12L,17L,25L,37L,52L,76L,102L };
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
public class A160271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160271Inst : IEnumerable<long>
{
public static readonly long[] Value=A160271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160271.Bytes);
public long this[int i]=>Value[i];

public static A160271Inst Instance=new A160271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160272
{
public static readonly long[] Value={ 0L,11L,22L,27L,16L,5L,6L,17L,28L,21L,10L,1L,12L,23L,26L,15L,4L,7L,18L,29L,20L,9L,2L,13L,24L,25L,14L,3L,8L,19L,30L,19L,8L,3L,14L,25L,24L,13L,2L,9L,20L,29L,18L,7L,4L,15L,26L,23L,12L,1L,10L,21L,28L,17L,6L,5L,16L,27L,22L,11L };
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
public class A160272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160272Inst : IEnumerable<long>
{
public static readonly long[] Value=A160272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160272.Bytes);
public long this[int i]=>Value[i];

public static A160272Inst Instance=new A160272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160273
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,5L,1L,5L,2L,5L,2L,1L,5L,2L,5L,2L,5L,6L,12L,2L,5L,10L,8L,5L,3L,4L,3L,25L,2L,1L,5L,4L,23L,2L,3L,2L,5L,10L,13L,8L,2L,2L,3L,18L,4L,5L,1L,20L,2L,8L,5L,4L,11L,14L,1L,9L,3L,8L,5L,9L,1L,4L,3L };
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
public class A160273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160273Inst : IEnumerable<long>
{
public static readonly long[] Value=A160273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160273.Bytes);
public long this[int i]=>Value[i];

public static A160273Inst Instance=new A160273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160274
{
public static readonly long[] Value={ 1L,2L,6L,12L,60L,360L,2520L };
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
public class A160274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160274Inst : IEnumerable<long>
{
public static readonly long[] Value=A160274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160274.Bytes);
public long this[int i]=>Value[i];

public static A160274Inst Instance=new A160274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160275
{
public static readonly BigInteger[] Value={ 1L,5L,15L,15L,30L,210L,1050L,6300L,1045800L,13756453200L,67826316310678800L,BigInteger.Parse("8622353329220210792550912000"),BigInteger.Parse("92206830102396929163916671718833533307592704000") };
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
public class A160275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160275Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160275.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160275.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160275Inst Instance=new A160275Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160276
{
public static readonly BigInteger[] Value={ 5L,3L,1L,2L,7L,5L,6L,166L,13154L,4930509L,127124010240L,10693928511363374992UL,BigInteger.Parse("137968261463122599313575510368212"),BigInteger.Parse("39152821738115568671532031705958771665111819590244323355597268791") };
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
public class A160276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160276Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160276.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160276.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160276Inst Instance=new A160276Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160277
{
public static readonly BigInteger[] Value={ 1L,3L,6L,8L,11L,23L,51L,123L,1451L,165876L,368310548L,131319102413076L,BigInteger.Parse("429434116256258636749076"),BigInteger.Parse("5044128476605888967010031050325156534548"),BigInteger.Parse("998085332225053172931293515663565518940387354129475684145085443611977451") };
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
public class A160277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160277Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160277.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160277.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160277Inst Instance=new A160277Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160278
{
public static readonly long[] Value={ 0L,66L,132L,162L,96L,30L,36L,102L,168L,126L,60L,6L,72L,138L,156L,90L,24L,42L,108L,174L,120L,54L,12L,78L,144L,150L,84L,18L,48L,114L,180L,114L,48L,18L,84L,150L,144L,78L,12L,54L,120L,174L,108L,42L,24L,90L,156L,138L,72L,6L,60L,126L,168L,102L,36L,30L,96L,162L,132L,66L };
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
public class A160278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160278Inst : IEnumerable<long>
{
public static readonly long[] Value=A160278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160278.Bytes);
public long this[int i]=>Value[i];

public static A160278Inst Instance=new A160278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160279
{
public static readonly BigInteger[] Value={ 1L,34L,-526L,-132260L,-1842644L,827195384L,43621279096L,-6864932326064L,-747004639162480L,66976371647992864L,13585352863673379616UL,BigInteger.Parse("-664640573754345065536"),BigInteger.Parse("-273953978191332601883456"),BigInteger.Parse("4100670082152392338741120"),BigInteger.Parse("6129700469924860012300846976") };
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
public class A160279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160279Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160279.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160279.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160279Inst Instance=new A160279Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160280
{
public static readonly BigInteger[] Value={ 1L,36L,-386L,-135000L,-2912244L,803439216L,53415783816L,-6185340350496L,-851589691267440L,52572710870646336L,14783982337749774816UL,BigInteger.Parse("-352049632685279478144"),BigInteger.Parse("-286207027989716394858816"),BigInteger.Parse("-3197683221510109228058880"),BigInteger.Parse("6143086278048774757772750976") };
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
public class A160280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160280Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160280.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160280.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160280Inst Instance=new A160280Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160281
{
public static readonly BigInteger[] Value={ 1L,38L,-238L,-136876L,-4000340L,768888808L,62860634104L,-5370921754384L,-944216132607088L,36390910087921760L,15676398398747125024UL,BigInteger.Parse("-16391968526453252288"),BigInteger.Parse("-290667617977624530780992"),BigInteger.Parse("-10714513990411799725496704"),BigInteger.Parse("5948586603063089600488296320") };
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
public class A160281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160281Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160281.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160281.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160281Inst Instance=new A160281Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160282
{
public static readonly BigInteger[] Value={ 1L,40L,-82L,-137840L,-5099828L,723394400L,71825329480L,-4427483105600L,-1022770753521520L,18665382528092800L,16229318967932481760UL,BigInteger.Parse("335221024594778374400"),BigInteger.Parse("-286866018560895642547520"),BigInteger.Parse("-18240741902856832410790400"),BigInteger.Parse("5542982685738270823512456320") };
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
public class A160282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160282Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160282.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160282.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160282Inst Instance=new A160282Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160283
{
public static readonly BigInteger[] Value={ 1L,42L,82L,-137844L,-6203220L,666879192L,80178006264L,-3362668542576L,-1085247924540528L,-332344921799520L,16414524594978933024UL,BigInteger.Parse("695000074573783113408"),BigInteger.Parse("-274511530924201328046912"),BigInteger.Parse("-25557365804013694138997376"),BigInteger.Parse("4929059771420011085235888000") };
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
public class A160283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160283Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160283.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160283.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160283Inst Instance=new A160283Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160284
{
public static readonly BigInteger[] Value={ 1L,44L,254L,-136840L,-7302644L,599343184L,87786336136L,-2185972622944L,-1129779117074800L,-20295833536956736L,16209579598652226016UL,BigInteger.Parse("1054597422432310244224"),BigInteger.Parse("-253507355147241835002176"),BigInteger.Parse("-32440318000852390709512960"),BigInteger.Parse("4115817835612084772939010176") };
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
public class A160284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160284Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160284.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160284.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160284Inst Instance=new A160284Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160285
{
public static readonly BigInteger[] Value={ 1L,46L,434L,-134780L,-8389844L,520867016L,94518470776L,-908740269776L,-1154662527326320L,-40886467186904864L,15598503848068208416UL,BigInteger.Parse("1405241555094877399616"),BigInteger.Parse("-223962406662593631730496"),BigInteger.Parse("-38665666254514312493452160"),BigInteger.Parse("3118541336376613976720226176") };
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
public class A160285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160285Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160285.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160285.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160285Inst Instance=new A160285Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160286
{
public static readonly BigInteger[] Value={ 1L,48L,622L,-131616L,-9456180L,431615808L,100244032584L,455846829696L,-1158392591818608L,-61736719347682560L,14572384526261325024UL,BigInteger.Parse("1737886076688564260352"),BigInteger.Parse("-186199726823835951097152"),BigInteger.Parse("-44015079459426106683608064"),BigInteger.Parse("1958719412677543785877138560") };
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
public class A160286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160286Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160286.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160286.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160286Inst Instance=new A160286Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160287
{
public static readonly BigInteger[] Value={ 1L,50L,818L,-127300L,-10492628L,331843000L,104835151480L,1892798018000L,-1139689172625520L,-82453948761484000L,13129917257130921760UL,BigInteger.Parse("2043371281024706968000"),BigInteger.Parse("-140761165040200966003520"),BigInteger.Parse("-48281464188212733742288000"),BigInteger.Parse("663810425358397635518568320") };
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
public class A160287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160287Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160287.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160287.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160287Inst Instance=new A160287Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160288
{
public static readonly BigInteger[] Value={ 1L,52L,1022L,-121784L,-11489780L,221894192L,108167547784L,3385356299104L,-1097526180055408L,-102624715723624640L,11277866096050285024UL,BigInteger.Parse("2312596755465981266048"),BigInteger.Parse("-88408047224891347679552"),BigInteger.Parse("-51274671368019715953249536"),BigInteger.Parse("-733152550517551021207891840") };
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
public class A160288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160288Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160288.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160288.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160288Inst Instance=new A160288Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160289
{
public static readonly BigInteger[] Value={ 1L,54L,1234L,-115020L,-12437844L,102210984L,110121661176L,4915056452976L,-1031159390225520L,-121819606703423136L,9031432087249072416L,BigInteger.Parse("2536703117463027057984"),BigInteger.Parse("-30117588135278876709696"),BigInteger.Parse("-52827165482178797480672640"),BigInteger.Parse("-2194115753871647145822109824") };
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
public class A160289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160289Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160289.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160289.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160289Inst Instance=new A160289Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160290
{
public static readonly BigInteger[] Value={ 1L,56L,1454L,-106960L,-13326644L,-26665184L,110583825736L,6461799278144L,-940153204639600L,-139598550546523264L,6414520381228962016L,BigInteger.Parse("2707260761541343173376"),BigInteger.Parse("32925146552816962489024"),BigInteger.Parse("-52799543003992720712035840"),BigInteger.Parse("-3676715662747488061659005824") };
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
public class A160290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160290Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160290.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160290.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160290Inst Instance=new A160290Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160291
{
public static readonly BigInteger[] Value={ 1L,1L,-449L,-1349L,604801L,3033001L,-1357769249L,-9546871949L,4267426262401L,38636165278801L,-17244440197445249L,-191107183952049749L,BigInteger.Parse("85168871793401932801"),BigInteger.Parse("1117147665134470577401"),BigInteger.Parse("-497120752326266836308449"),BigInteger.Parse("-7535151042673431473934749"),BigInteger.Parse("3348029927159627713608096001") };
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
public class A160291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160291Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160291.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160291.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160291Inst Instance=new A160291Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160292
{
public static readonly BigInteger[] Value={ 1L,7L,-401L,-9107L,477601L,19735807L,-936451601L,-59841840107L,2530929662401L,233147132022007L,-8618235208570001L,-1109489740559021507L,BigInteger.Parse("34893836098508354401"),BigInteger.Parse("6235501451708274618607"),BigInteger.Parse("-160480431014315950915601"),BigInteger.Parse("-40407022162862341753633307"),BigInteger.Parse("800393754206596276404873601") };
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
public class A160292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160292Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160292.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160292.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160292Inst Instance=new A160292Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160293
{
public static readonly BigInteger[] Value={ 1L,11L,-329L,-13519L,295441L,27584051L,-361317689L,-78451432279L,275184965281L,285452190822491L,2025474989659351L,-1262254633814956639L,BigInteger.Parse("-23910902170778310479"),BigInteger.Parse("6553155098722204435331"),BigInteger.Parse("211963483784997365090791"),BigInteger.Parse("-38953278800314916926586599"),BigInteger.Parse("-1859239582352196300555291839") };
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
public class A160293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160293Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160293.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160293.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160293Inst Instance=new A160293Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160294
{
public static readonly BigInteger[] Value={ 1L,13L,-281L,-15353L,179761L,29972293L,-14822441L,-81117882833L,-1007841787679L,278922434958973L,7707750894566599L,-1154950195686012713L,BigInteger.Parse("-53167719472022830319"),BigInteger.Parse("5545550703568171856053"),BigInteger.Parse("383123318057719791494839"),BigInteger.Parse("-29956366297729125403700993") };
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
public class A160294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160294Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160294.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160294.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160294Inst Instance=new A160294Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160295
{
public static readonly BigInteger[] Value={ 1L,17L,-161L,-18037L,-89279L,30948857L,727008319L,-71202772477L,-3500523336959L,196821084188897L,17523077945895199L,-587802553769818117L,BigInteger.Parse("-96731879246268143039"),BigInteger.Parse("1529691843170459400137"),BigInteger.Parse("591886254924566446580479"),BigInteger.Parse("425007721743735371005043") };
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
public class A160295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160295Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160295.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160295.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160295Inst Instance=new A160295Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160296
{
public static readonly BigInteger[] Value={ 1L,19L,-89L,-18791L,-236879L,29323099L,1090116631L,-58460151311L,-4544610262559L,124108949730979L,20763741608252551L,-163979183232607031L,BigInteger.Parse("-105896125442269661039"),BigInteger.Parse("-1126538793947045592341"),BigInteger.Parse("598088096752283650823671"),BigInteger.Parse("18460868240159776597398049") };
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
public class A160296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160296Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160296.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160296.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160296Inst Instance=new A160296Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160297
{
public static readonly BigInteger[] Value={ 1L,23L,79L,-18883L,-540959L,21547343L,1712746639L,-18784653403L,-5827198941119L,-66400823394937L,22072936773448399L,806481251066529677L,BigInteger.Parse("-90711968254039392479"),BigInteger.Parse("-6441374025602166282817"),BigInteger.Parse("382513411697280621497359"),BigInteger.Parse("49378464830331101876186357") };
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
public class A160297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160297Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160297.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160297.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160297Inst Instance=new A160297Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160298
{
public static readonly BigInteger[] Value={ 1L,29L,391L,-14761L,-955919L,-1151851L,2117414071L,64515005759L,-4798919156639L,-371422676274931L,8664364972414951L,1922668627437223079L,12868783582225461841UL,BigInteger.Parse("-10009215864276466233211"),BigInteger.Parse("-365549644020036472532969"),BigInteger.Parse("52457120268360679565773199") };
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
public class A160298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160298Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160298.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160298.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160298Inst Instance=new A160298Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160299
{
public static readonly BigInteger[] Value={ 1L,2L,-1918L,-11524L,11036140L,110668792L,-105835967816L,-1487904444976L,1420941302106512L,25719901350164000L,BigInteger.Parse("-24528002841138116576"),BigInteger.Parse("-543392509632428313152"),BigInteger.Parse("517484251048077204023488"),BigInteger.Parse("13567773344258481022584704"),BigInteger.Parse("-12902725949998740057685701760") };
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
public class A160299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160299Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160299.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160299.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160299Inst Instance=new A160299Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160300
{
public static readonly BigInteger[] Value={ 1L,4L,-1906L,-23000L,10897996L,220415984L,-103848077624L,-2957229437984L,1385343118601360L,51011732312847424L,BigInteger.Parse("-23759618336314935584"),BigInteger.Parse("-1075483968398187231616"),BigInteger.Parse("498023914992777619190464"),BigInteger.Parse("26797057907106900786753280"),BigInteger.Parse("-12336437308381113989945920384") };
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
public class A160300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160300Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160300.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160300.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160300Inst Instance=new A160300Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160301
{
public static readonly BigInteger[] Value={ 1L,6L,-1886L,-34380L,10668396L,328323816L,-100553342664L,-4389550302096L,1326507370388880L,75452769667361376L,BigInteger.Parse("-22493207874982677984"),BigInteger.Parse("-1585161480256581714624"),BigInteger.Parse("466040432011344287649984"),BigInteger.Parse("39356406972705866391987840"),BigInteger.Parse("-11408347792399213172870573184") };
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
public class A160301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160301Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160301.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160301.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160301Inst Instance=new A160301Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160302
{
public static readonly BigInteger[] Value={ 1L,8L,-1858L,-45616L,10348300L,433482208L,-95979305336L,-5766751265344L,1245171563867792L,98630939966871680L,BigInteger.Parse("-20749930192050092576"),BigInteger.Parse("-2061686107699674430208"),BigInteger.Parse("422201535258725661800128"),BigInteger.Parse("50928340670055096352718336"),BigInteger.Parse("-10141700834614078614916251520") };
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
public class A160302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160302Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160302.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160302.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160302Inst Instance=new A160302Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160303
{
public static readonly BigInteger[] Value={ 1L,10L,-1822L,-56660L,9939052L,534992600L,-90164363720L,-7071178300400L,1142359566484880L,120150033211799200L,BigInteger.Parse("-18559035448937462240"),BigInteger.Parse("-2494873992820155246400"),BigInteger.Parse("367426387533234274214080"),BigInteger.Parse("61216037645736403345110400"),BigInteger.Parse("-8568355342448027542061898880") };
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
public class A160303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160303Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160303.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160303.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160303Inst Instance=new A160303Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160304
{
public static readonly BigInteger[] Value={ 1L,12L,-1778L,-67464L,9442380L,631971792L,-83157610296L,-8285790028896L,1019373008575632L,139634783587212480L,BigInteger.Parse("-15957496899294732576"),BigInteger.Parse("-2875270503337760656512"),BigInteger.Parse("302870153404836108243648"),BigInteger.Parse("69949680729840145080716544"),BigInteger.Parse("-6728117484215153259607190400") };
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
public class A160304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160304Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160304.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A160304.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160304Inst Instance=new A160304Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}