using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A083699
{
public static readonly long[] Value={ 1L,1L,2L,5L,12L,53L,330L,2693L,11102L,69305L,2644692L,26516225L,373871842L,6008465697L,36424666024L,78857797745L,982718238964L,23664095532881L,2367392271527064L,85249785870507185L,6310851546689058754L };
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
public class A083699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083699Inst : IEnumerable<long>
{
public static readonly long[] Value=A083699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083699.Bytes);
public long this[int i]=>Value[i];

public static A083699Inst Instance=new A083699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083732
{
public static readonly long[] Value={ 561L,1729L,2821L,5461L,6601L,8911L,12801L,13981L,15841L,29341L,41041L,46657L,52633L,63973L,68101L,75361L,101101L,113201L,115921L,126217L,137149L,162401L,172081L,188461L,252601L,294409L,314821L,334153L,340561L,399001L,401401L,410041L,488881L };
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
public class A083732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083732Inst : IEnumerable<long>
{
public static readonly long[] Value=A083732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083732.Bytes);
public long this[int i]=>Value[i];

public static A083732Inst Instance=new A083732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083733
{
public static readonly long[] Value={ 561L,1105L,2465L,3277L,8321L,10585L,18721L,29341L,46657L,62745L,75361L,104653L,115921L,162401L,219781L,226801L,252601L,278545L,294409L,314821L,334153L,340561L,399001L,410041L,449065L,488881L,512461L,530881L,534061L,552721L,574561L,587861L };
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
public class A083733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083733Inst : IEnumerable<long>
{
public static readonly long[] Value=A083733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083733.Bytes);
public long this[int i]=>Value[i];

public static A083733Inst Instance=new A083733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083734
{
public static readonly long[] Value={ 1541L,1729L,1891L,2821L,6601L,8911L,15841L,29341L,41041L,46657L,52633L,63973L,75361L,88831L,101101L,112141L,115921L,126217L,146611L,162401L,172081L,188461L,218791L,252601L,294409L,314821L,334153L,340561L,342271L,399001L,410041L,416641L };
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
public class A083734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083734Inst : IEnumerable<long>
{
public static readonly long[] Value=A083734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083734.Bytes);
public long this[int i]=>Value[i];

public static A083734Inst Instance=new A083734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083735
{
public static readonly long[] Value={ 703L,1105L,2465L,10585L,18721L,19345L,29341L,38503L,46657L,50881L,75361L,76627L,88831L,104653L,115921L,146611L,162401L,188191L,213265L,226801L,252601L,278545L,286903L,294409L,314821L,334153L,340561L,359341L,385003L,385201L,399001L,410041L };
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
public class A083735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083735Inst : IEnumerable<long>
{
public static readonly long[] Value=A083735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083735.Bytes);
public long this[int i]=>Value[i];

public static A083735Inst Instance=new A083735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083736
{
public static readonly long[] Value={ 561L,29341L,46657L,75361L,115921L,162401L,252601L,294409L,314821L,334153L,340561L,399001L,410041L,488881L,512461L,530881L,552721L,656601L,658801L,710533L,721801L,852841L,1024651L,1141141L,1152271L,1168513L,1193221L,1461241L,1569457L,1615681L };
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
public class A083736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083736Inst : IEnumerable<long>
{
public static readonly long[] Value=A083736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083736.Bytes);
public long this[int i]=>Value[i];

public static A083736Inst Instance=new A083736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083737
{
public static readonly long[] Value={ 1729L,2821L,6601L,8911L,15841L,29341L,41041L,46657L,52633L,63973L,75361L,101101L,115921L,126217L,162401L,172081L,188461L,252601L,294409L,314821L,334153L,340561L,399001L,410041L,488881L,512461L,530881L,552721L,658801L,670033L,721801L,748657L };
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
public class A083737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083737Inst : IEnumerable<long>
{
public static readonly long[] Value=A083737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083737.Bytes);
public long this[int i]=>Value[i];

public static A083737Inst Instance=new A083737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083738
{
public static readonly long[] Value={ 1105L,2465L,10585L,18721L,29341L,46657L,75361L,104653L,115921L,162401L,226801L,252601L,278545L,294409L,314821L,334153L,340561L,399001L,410041L,449065L,488881L,512461L,530881L,534061L,552721L,574561L,658801L,721801L,852841L,1024651L };
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
public class A083738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083738Inst : IEnumerable<long>
{
public static readonly long[] Value=A083738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083738.Bytes);
public long this[int i]=>Value[i];

public static A083738Inst Instance=new A083738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083739
{
public static readonly long[] Value={ 29341L,46657L,75361L,115921L,162401L,252601L,294409L,314821L,334153L,340561L,399001L,410041L,488881L,512461L,530881L,552721L,658801L,721801L,852841L,1024651L,1152271L,1193221L,1461241L,1569457L,1615681L,1857241L,1909001L,2100901L };
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
public class A083739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083739Inst : IEnumerable<long>
{
public static readonly long[] Value=A083739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083739.Bytes);
public long this[int i]=>Value[i];

public static A083739Inst Instance=new A083739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083740
{
public static readonly long[] Value={ 29341L,46657L,75361L,88831L,115921L,146611L,162401L,252601L,294409L,314821L,334153L,340561L,399001L,410041L,488881L,512461L,530881L,552721L,658801L,721801L,852841L,954271L,1024651L,1152271L,1193221L,1314631L,1461241L,1569457L,1615681L };
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
public class A083740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083740Inst : IEnumerable<long>
{
public static readonly long[] Value=A083740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083740.Bytes);
public long this[int i]=>Value[i];

public static A083740Inst Instance=new A083740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083741
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,2L,4L,0L,1L,2L,4L,4L,6L,8L,11L,0L,1L,2L,4L,4L,6L,8L,11L,8L,10L,12L,15L,16L,19L,22L,26L,0L,1L,2L,4L,4L,6L,8L,11L,8L,10L,12L,15L,16L,19L,22L,26L,16L,18L,20L,23L,24L,27L,30L,34L,32L,35L,38L,42L,44L,48L,52L,57L,0L,1L,2L,4L,4L,6L,8L,11L,8L,10L,12L,15L,16L,19L,22L,26L,16L,18L,20L };
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
public class A083741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083741Inst : IEnumerable<long>
{
public static readonly long[] Value=A083741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083741.Bytes);
public long this[int i]=>Value[i];

public static A083741Inst Instance=new A083741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083742
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,3L,4L,3L,7L,5L,6L,4L,7L,5L,6L,4L,11L,8L,9L,6L,10L,7L,8L,5L,11L,8L,9L,6L,10L,7L,8L,5L,16L,12L,13L,9L,14L,10L,11L,7L,15L,11L,12L,8L,13L,9L,10L,6L,16L,12L,13L,9L,14L,10L,11L,7L,15L,11L,12L,8L,13L,9L,10L,6L,22L,17L,18L,13L,19L,14L,15L,10L,20L,15L,16L,11L,17L };
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
public class A083742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083742Inst : IEnumerable<long>
{
public static readonly long[] Value=A083742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083742.Bytes);
public long this[int i]=>Value[i];

public static A083742Inst Instance=new A083742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083743
{
public static readonly long[] Value={ 1L,3L,3L,7L,7L,13L,13L,13L,13L,23L,23L,23L,23L,37L,37L,53L,53L,71L,71L,71L,71L,71L,71L,71L,71L,97L,97L,97L,97L,127L,127L,127L,127L,127L,127L,163L,163L,163L,163L,163L,163L,163L,163L,163L,163L,163L,163L,211L,211L,211L,211L,263L,263L,317L,317L,373L,373L,431L,431L,491L };
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
public class A083743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083743Inst : IEnumerable<long>
{
public static readonly long[] Value=A083743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083743.Bytes);
public long this[int i]=>Value[i];

public static A083743Inst Instance=new A083743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083744
{
public static readonly long[] Value={ 1L,1L,4L,8L,8L,14L,21L,21L,30L,40L,51L,63L,76L,90L,105L,121L,138L,156L,175L,195L,216L,238L,261L,285L,310L,336L,363L,391L,420L,450L,481L,513L,546L,580L,615L,651L,688L,726L,765L,805L,846L,888L,931L,975L,1020L,1066L,1113L,1161L,1210L,1260L,1311L,1363L,1416L,1470L };
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
public class A083744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083744Inst : IEnumerable<long>
{
public static readonly long[] Value=A083744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083744.Bytes);
public long this[int i]=>Value[i];

public static A083744Inst Instance=new A083744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083745
{
public static readonly long[] Value={ 1L,-1L,-4L,0L,-5L,1L,8L,16L,25L,35L,46L,58L,45L,31L,46L,62L,45L,63L,82L,102L,123L,145L,168L,192L,217L,243L,270L,298L,327L,357L,388L,420L,453L,419L,454L,490L,527L,565L,604L,644L,685L,643L,686L,730L,775L,729L,776L,824L,873L,923L,974L,1026L,1079L,1133L,1188L,1244L,1187L,1245L,1304L };
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
public class A083745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083745Inst : IEnumerable<long>
{
public static readonly long[] Value=A083745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083745.Bytes);
public long this[int i]=>Value[i];

public static A083745Inst Instance=new A083745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083746
{
public static readonly long[] Value={ 1L,2L,3L,12L,54L,288L,1800L,12960L,105840L,967680L,9797760L,108864000L,1317254400L,17244057600L,242853811200L,3661488230400L,58845346560000L,1004293914624000L,18140058832896000L,345728180109312000L,6933770723303424000L };
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
public class A083746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083746Inst : IEnumerable<long>
{
public static readonly long[] Value=A083746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083746.Bytes);
public long this[int i]=>Value[i];

public static A083746Inst Instance=new A083746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083747
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,0L,2L,2L,1L,0L,136L,0L,9L,1L,3L,0L,1L,0L,2L,1L,3L,0L,1L,1L,3L,1L,1L,0L,2L,0L,35L,1L,6L,2L,4L,0L,-1L,2L,1L,0L,1L,0L,3L,772L,1L,0L,5L,1L,2L,4L,1L,0L,1L,31L,18470L,1L,3L,0L,1L,0L,2L,1L,1L,3L,1L,0L,3L,1L,1L,0L,2L,0L,2L,1L,1L,9L,4L,0L,2L,1L,1L,0L,5L,6L,3L,149L,1L,0L,2L,1L,3L,2L,1L,2L,7L,0L,2L,1L,10L,0L,1L,0L,44L,1L,1L,0L,5L,0L,17L,16L,3L,0L,2L,1L,9L,1L,1L,5L,1L };
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
public class A083747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083747Inst : IEnumerable<long>
{
public static readonly long[] Value=A083747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083747.Bytes);
public long this[int i]=>Value[i];

public static A083747Inst Instance=new A083747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083780
{
public static readonly BigInteger[] Value={ 2L,4L,8L,16L,16L,64L,1822L,5564L,88712L,855574L,74266102L,179590045294L,1418575498354L,186460616596064L,79287805466243902L,14777669568340323098UL,BigInteger.Parse("348214184662549960154") };
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
public class A083780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083780Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A083780.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083780.Bytes);
public BigInteger this[int i]=>Value[i];

public static A083780Inst Instance=new A083780Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083781
{
public static readonly long[] Value={ 1L,5L,3L,13L,11L,7L,31L,29L,23L,17L,43L,41L,37L,31L,29L,109L,107L,103L,101L,89L,47L,1879L,1877L,1873L,1871L,1867L,1861L,59L,5659L,5657L,5653L,5651L,5647L,5641L,5623L,97L,88819L,88817L,88813L,88811L,88807L,88801L,88799L,88793L,109L,855739L,855737L };
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
public class A083781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083781Inst : IEnumerable<long>
{
public static readonly long[] Value=A083781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083781.Bytes);
public long this[int i]=>Value[i];

public static A083781Inst Instance=new A083781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083782
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,9L,2L,4L,6L,16L };
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
public class A083782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083782Inst : IEnumerable<long>
{
public static readonly long[] Value=A083782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083782.Bytes);
public long this[int i]=>Value[i];

public static A083782Inst Instance=new A083782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083783
{
public static readonly long[] Value={ 1L,2L,9L,16L };
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
public class A083783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083783Inst : IEnumerable<long>
{
public static readonly long[] Value=A083783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083783.Bytes);
public long this[int i]=>Value[i];

public static A083783Inst Instance=new A083783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083784
{
public static readonly long[] Value={ 2L,3L,2L,13L,11L,5L,31L,29L,23L,17L };
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
public class A083784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083784Inst : IEnumerable<long>
{
public static readonly long[] Value=A083784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083784.Bytes);
public long this[int i]=>Value[i];

public static A083784Inst Instance=new A083784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083785
{
public static readonly long[] Value={ 1L,2L,3L,33L,34L,35L,19940L,19941L,19942L,19943L,204323L,204324L,204325L,204326L,204327L,380480345L,380480346L,380480347L,380480348L,380480349L,380480350L,440738966073L,440738966074L,440738966075L,440738966076L,440738966077L,440738966078L,440738966079L };
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
public class A083785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083785Inst : IEnumerable<long>
{
public static readonly long[] Value=A083785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083785.Bytes);
public long this[int i]=>Value[i];

public static A083785Inst Instance=new A083785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083786
{
public static readonly long[] Value={ 4L,6L,8L,9L,0L,2L,4L,5L,6L,8L,0L,1L,2L,4L,5L,6L,7L,8L,0L,2L,3L,4L,5L,6L,8L,9L,0L,2L,4L,5L,6L,8L,9L,0L,1L,2L,4L,5L,6L,7L,8L,0L,2L,3L,4L,5L,6L,8L,9L,0L,2L,4L,5L,6L,7L,8L,0L,1L,2L,4L,5L,6L,7L,8L,0L,1L,2L,3L,4L,5L,6L,8L,9L,0L,2L,4L,5L,6L,8L,0L,1L,2L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,8L,9L,0L,2L,3L,4L,5L,6L,8L,0L };
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
public class A083786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083786Inst : IEnumerable<long>
{
public static readonly long[] Value=A083786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083786.Bytes);
public long this[int i]=>Value[i];

public static A083786Inst Instance=new A083786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083787
{
public static readonly long[] Value={ 1L,2L,6L,60L,60L };
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
public class A083787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083787Inst : IEnumerable<long>
{
public static readonly long[] Value=A083787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083787.Bytes);
public long this[int i]=>Value[i];

public static A083787Inst Instance=new A083787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083788
{
public static readonly long[] Value={ 1L,1L,2L,4L,5L,6L,6L,7L,8L,9L,8L,9L,10L,11L,12L,23L,24L,25L,26L,27L,28L,24L,25L,26L,27L,28L,29L,30L,1804L,1805L,1806L,1807L,1808L,1809L,1810L,1811L,1968L,1969L,1970L,1971L,1972L,1973L,1974L,1975L,1976L,8375L,8376L,8377L,8378L,8379L,8380L,8381L,8382L,8383L,8384L };
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
public class A083788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083788Inst : IEnumerable<long>
{
public static readonly long[] Value=A083788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083788.Bytes);
public long this[int i]=>Value[i];

public static A083788Inst Instance=new A083788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083789
{
public static readonly long[] Value={ 1L,2L,6L,9L,12L,28L,30L,1811L,1976L,8384L,53760L,243875L,639336L,41381633L,102621357L,7802708751L,7802708752L,178874468632L,1133934949386L };
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
public class A083789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083789Inst : IEnumerable<long>
{
public static readonly long[] Value=A083789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083789.Bytes);
public long this[int i]=>Value[i];

public static A083789Inst Instance=new A083789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083790
{
public static readonly long[] Value={ 1L,1L,4L,6L,8L,23L,24L,1804L,1968L,8375L,53750L,243864L,639324L,41381620L,102621343L,7802708736L,7802708736L,178874468615L,1133934949368L };
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
public class A083790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083790Inst : IEnumerable<long>
{
public static readonly long[] Value=A083790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083790.Bytes);
public long this[int i]=>Value[i];

public static A083790Inst Instance=new A083790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083791
{
public static readonly long[] Value={ 1L,1L,2L,4L,2L,6L,6L,2L,8L,4L,8L,4L,6L,2L,12L,2L,24L,4L,6L,8L,12L,24L,4L,6L,8L,12L,2L,30L,60L,12L,210L,6L,48L,24L,30L,2L,240L,6L,30L,24L,60L,2L,210L,12L,120L,24L,120L,2L,30L,180L,60L,12L,210L,6L,192L,240L,210L,24L,12L,420L,30L,60L,120L,6L,2L,53760L };
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
public class A083791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083791Inst : IEnumerable<long>
{
public static readonly long[] Value=A083791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083791.Bytes);
public long this[int i]=>Value[i];

public static A083791Inst Instance=new A083791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083792
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,16L,17L,18L,19L,20L,21L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,36L,37L,38L,40L,41L,42L,43L,44L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L };
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
public class A083792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083792Inst : IEnumerable<long>
{
public static readonly long[] Value=A083792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083792.Bytes);
public long this[int i]=>Value[i];

public static A083792Inst Instance=new A083792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083793
{
public static readonly long[] Value={ 3L,15L,22L,34L,35L,39L,45L,58L,86L,87L,94L,95L,117L,119L,123L,134L,136L,142L,143L,146L,159L,172L,178L,202L,203L,206L,214L,215L,218L,219L,231L,254L,286L,297L,299L,302L,303L,327L,333L,335L,382L,388L,394L,395L,430L,435L,446L,447L,454L,482L,502L,515L,527L,538L,543L };
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
public class A083793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083793Inst : IEnumerable<long>
{
public static readonly long[] Value=A083793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083793.Bytes);
public long this[int i]=>Value[i];

public static A083793Inst Instance=new A083793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083794
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,16L,17L,18L,19L,20L,21L,23L,24L,25L,26L,28L,29L,30L,31L,32L,33L,36L,37L,38L,40L,41L,42L,43L,44L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,77L,78L,79L,80L,81L,82L };
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
public class A083794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083794Inst : IEnumerable<long>
{
public static readonly long[] Value=A083794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083794.Bytes);
public long this[int i]=>Value[i];

public static A083794Inst Instance=new A083794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083795
{
public static readonly long[] Value={ 3L,15L,22L,27L,34L,35L,39L,45L,58L,76L,86L,87L,94L,95L,99L,105L,117L,119L,123L,134L,136L,142L,143L,146L,148L,159L,172L,178L,190L,202L,203L,206L,214L,215L,218L,219L,231L,232L,243L,244L,245L,254L,286L,297L,299L,302L,303L,327L,333L,335L,345L,375L,376L,382L,388L };
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
public class A083795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083795Inst : IEnumerable<long>
{
public static readonly long[] Value=A083795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083795.Bytes);
public long this[int i]=>Value[i];

public static A083795Inst Instance=new A083795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083828
{
public static readonly BigInteger[] Value={ 0L,91L,19802L,3086913L,419758024L,53086469135L,6419753580246L,753086424691357L,86419753135802468L,BigInteger.Parse("-13580245898641975411"),BigInteger.Parse("-123580236689876419763310"),BigInteger.Parse("-234580144678997654198553209"),BigInteger.Parse("7754320775431099224567922456892") };
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
public class A083828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083828Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A083828.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083828.Bytes);
public BigInteger this[int i]=>Value[i];

public static A083828Inst Instance=new A083828Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083829
{
public static readonly long[] Value={ 1L,2L,7L,77L,141L,151L,161L,242L,252L,262L,777L,7777L,14041L,14141L,14241L,15051L,15151L,15251L,16061L,16161L,16261L,24042L,24142L,24242L,25052L,25152L,25252L,26062L,26162L,26262L,77777L,777777L,1404041L,1405041L,1406041L,1414141L,1415141L };
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
public class A083829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083829Inst : IEnumerable<long>
{
public static readonly long[] Value=A083829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083829.Bytes);
public long this[int i]=>Value[i];

public static A083829Inst Instance=new A083829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083830
{
public static readonly long[] Value={ 4L,7L,22L,232L,424L,454L,484L,727L,757L,787L,2332L,23332L,42124L,42424L,42724L,45154L,45454L,45754L,48184L,48484L,48784L,72127L,72427L,72727L,75157L,75457L,75757L,78187L,78487L,78787L,233332L,2333332L,4212124L,4215124L,4218124L,4242424L };
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
public class A083830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083830Inst : IEnumerable<long>
{
public static readonly long[] Value=A083830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083830.Bytes);
public long this[int i]=>Value[i];

public static A083830Inst Instance=new A083830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083831
{
public static readonly long[] Value={ 1L,2L,8L,88L,131L,141L,232L,242L,888L,8888L,13031L,13131L,13231L,14041L,14141L,14241L,23032L,23132L,23232L,24042L,24142L,24242L,88888L,888888L,1303031L,1304031L,1313131L,1314131L,1323231L,1324231L,1403041L,1404041L,1413141L,1414141L };
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
public class A083831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083831Inst : IEnumerable<long>
{
public static readonly long[] Value=A083831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083831.Bytes);
public long this[int i]=>Value[i];

public static A083831Inst Instance=new A083831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083832
{
public static readonly long[] Value={ 5L,9L,33L,353L,525L,565L,929L,969L,3553L,35553L,52125L,52525L,52925L,56165L,56565L,56965L,92129L,92529L,92929L,96169L,96569L,96969L,355553L,3555553L,5212125L,5216125L,5252525L,5256525L,5292925L,5296925L,5612165L,5616165L,5652565L };
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
public class A083832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083832Inst : IEnumerable<long>
{
public static readonly long[] Value=A083832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083832.Bytes);
public long this[int i]=>Value[i];

public static A083832Inst Instance=new A083832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083833
{
public static readonly long[] Value={ 1L,2L,22L,121L,131L,222L,2222L,12021L,12121L,13031L,13131L,22222L,222222L,1202021L,1203021L,1212121L,1213121L,1302031L,1303031L,1312131L,1313131L,2222222L,22222222L,120202021L,120212021L,120303021L,120313021L,121202121L,121212121L };
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
public class A083833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083833Inst : IEnumerable<long>
{
public static readonly long[] Value=A083833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083833.Bytes);
public long this[int i]=>Value[i];

public static A083833Inst Instance=new A083833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083834
{
public static readonly long[] Value={ 6L,11L,111L,606L,656L,1111L,11111L,60106L,60606L,65156L,65656L,111111L,1111111L,6010106L,6015106L,6060606L,6065606L,6510156L,6515156L,6560656L,6565656L,11111111L,111111111L,601010106L,601060106L,601515106L,601565106L,606010606L };
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
public class A083834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083834Inst : IEnumerable<long>
{
public static readonly long[] Value=A083834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083834.Bytes);
public long this[int i]=>Value[i];

public static A083834Inst Instance=new A083834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083835
{
public static readonly long[] Value={ 1L,9L,99L,121L,131L,999L,9999L,12021L,12121L,13031L,13131L,99999L,999999L,1202021L,1203021L,1212121L,1213121L,1302031L,1303031L,1312131L,1313131L,9999999L,99999999L,120202021L,120212021L,120303021L,120313021L,121202121L,121212121L };
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
public class A083835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083835Inst : IEnumerable<long>
{
public static readonly long[] Value=A083835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083835.Bytes);
public long this[int i]=>Value[i];

public static A083835Inst Instance=new A083835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083836
{
public static readonly long[] Value={ 7L,55L,595L,727L,787L,5995L,59995L,72127L,72727L,78187L,78787L,599995L,5999995L,7212127L,7218127L,7272727L,7278727L,7812187L,7818187L,7872787L,7878787L,59999995L,599999995L,721212127L,721272127L,721818127L,721878127L,727212727L };
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
public class A083836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083836Inst : IEnumerable<long>
{
public static readonly long[] Value=A083836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083836.Bytes);
public long this[int i]=>Value[i];

public static A083836Inst Instance=new A083836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083837
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,6L,1L,55L,0L,5L,7L,8L,2L,0L,3L,4L,5L,1L,5L,0L,5L,4L,5L,2L,5L,3L,4L,0L,1L,7L,5L,4L,5L,0L,2L,8L,3L,0L,0L,1L,8L,4L,7L,9L,0L,2L,2L,0L,6L,0L,1L,2L,7L,6L,161L,7L,2L,0L,6L,8L,0L,1L,9L,3L,8L,7L,2L,0L,7L,8L,0L,2L,1L,3L,4L,0L,2L,0L,7L,4L,6L,2L,0L,1L,4L,6L,2L,0L,8L,4L,6L,2L,0L,3L,1L,6L,1L,0L,9L,0L,3L };
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
public class A083837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083837Inst : IEnumerable<long>
{
public static readonly long[] Value=A083837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083837.Bytes);
public long this[int i]=>Value[i];

public static A083837Inst Instance=new A083837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083838
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,55L,11L,606L,0L,66L,99L,121L,33L,0L,55L,77L,101L,22L,111L,0L,121L,101L,131L,55L,141L,88L,121L,0L,33L,232L,171L,141L,181L,0L,77L,313L,121L,0L,0L,44L,353L,181L,323L,424L,0L,99L,101L,0L,313L,0L,55L,111L,393L,343L,9339L,414L,121L,0L,373L,505L,0L,66L,595L };
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
public class A083838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083838Inst : IEnumerable<long>
{
public static readonly long[] Value=A083838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083838.Bytes);
public long this[int i]=>Value[i];

public static A083838Inst Instance=new A083838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083839
{
public static readonly long[] Value={ 0L,1L,1L,4L,7L,11L,19L,36L,67L,121L,216L,386L,691L,1236L,2206L,3929L,6987L,12411L,22024L,39046L,69162L,122406L,216481L,382606L,675811L,1193061L,2105156L,3712864L,6545672L,11535476L,20322024L,35789966L,63012987L,110913356L,195178616L,343387111L,604014136L };
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
public class A083839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083839Inst : IEnumerable<long>
{
public static readonly long[] Value=A083839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083839.Bytes);
public long this[int i]=>Value[i];

public static A083839Inst Instance=new A083839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083840
{
public static readonly long[] Value={ 3L,5L,7L,11L,101L,151L,181L,191L,313L,10301L,10501L,12821L,13831L,13931L,16061L,16361L,19891L,19991L,31513L,32323L,34843L,35053L,37573L,72227L,73037L,76367L,77477L,78887L,79397L,79697L,79997L,93239L,94349L,94649L,94849L,94949L,95959L,97379L };
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
public class A083840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083840Inst : IEnumerable<long>
{
public static readonly long[] Value=A083840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083840.Bytes);
public long this[int i]=>Value[i];

public static A083840Inst Instance=new A083840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083841
{
public static readonly long[] Value={ 3L,5L,11L,101L,191L,10301L,12821L,13931L,16061L,16361L,19991L,72227L,73037L,76367L,77477L,78887L,79397L,79697L,79997L,93239L,94349L,94649L,94949L,97379L,1003001L,1055501L,1129211L,1134311L,1183811L,1186811L,1208021L,1221221L,1262621L };
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
public class A083841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083841Inst : IEnumerable<long>
{
public static readonly long[] Value=A083841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083841.Bytes);
public long this[int i]=>Value[i];

public static A083841Inst Instance=new A083841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083842
{
public static readonly long[] Value={ 5L,7L,151L,181L,313L,10501L,13831L,19891L,31513L,32323L,34843L,35053L,37573L,94849L,95959L,97579L,98389L,1062601L,1163611L,1193911L,1201021L,1212121L,1242421L,1250521L,1253521L,1286821L,1362631L,1496941L,1572751L,1580851L,1589851L };
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
public class A083842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083842Inst : IEnumerable<long>
{
public static readonly long[] Value=A083842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083842.Bytes);
public long this[int i]=>Value[i];

public static A083842Inst Instance=new A083842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083843
{
public static readonly long[] Value={ 4L,1L,6L,10L,10L,1L,40L,46L,34L,70L,66L,298L,1112L,1L,4404L,4708L,514L,5486L,16680L,16930L,2050L,8230L,16406L,133186L,131368L,599338L,16386L,8948956L,34636834L,1L,138547336L,143172148L,4195388L,153394108L,786436L,672340450L,67158288L,178959726L };
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
public class A083843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083843Inst : IEnumerable<long>
{
public static readonly long[] Value=A083843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083843.Bytes);
public long this[int i]=>Value[i];

public static A083843Inst Instance=new A083843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083892
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,2L,0L,0L,0L,0L,1L,0L,0L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,0L,0L,1L,0L,0L,0L,0L,3L,0L,0L,0L,0L,3L,1L,1L,1L,1L,2L,0L,0L,0L,0L,2L,0L,0L,0L,0L,1L,0L,0L,0L,0L,2L,0L,0L,0L,0L,3L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,3L,0L,0L,0L,0L,1L,0L,0L,0L,0L,3L,0L,1L,0L,1L,4L };
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
public class A083892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083892Inst : IEnumerable<long>
{
public static readonly long[] Value=A083892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083892.Bytes);
public long this[int i]=>Value[i];

public static A083892Inst Instance=new A083892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083893
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,2L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,2L,1L,1L,1L,2L,1L,2L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,1L,0L,1L,0L };
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
public class A083893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083893Inst : IEnumerable<long>
{
public static readonly long[] Value=A083893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083893.Bytes);
public long this[int i]=>Value[i];

public static A083893Inst Instance=new A083893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083894
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,2L,1L,1L,1L,2L,1L,1L,2L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L };
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
public class A083894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083894Inst : IEnumerable<long>
{
public static readonly long[] Value=A083894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083894.Bytes);
public long this[int i]=>Value[i];

public static A083894Inst Instance=new A083894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083895
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,1L,0L,2L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,1L,0L,1L,0L,2L,1L,1L,1L,2L,1L,1L,1L,2L,0L,1L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,1L,0L };
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
public class A083895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083895Inst : IEnumerable<long>
{
public static readonly long[] Value=A083895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083895.Bytes);
public long this[int i]=>Value[i];

public static A083895Inst Instance=new A083895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083896
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,2L,1L,1L,1L,1L,2L,1L,1L,2L,2L,0L,0L,0L,0L,0L,0L };
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
public class A083896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083896Inst : IEnumerable<long>
{
public static readonly long[] Value=A083896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083896.Bytes);
public long this[int i]=>Value[i];

public static A083896Inst Instance=new A083896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083897
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,2L,1L,2L,1L,3L,2L,3L,1L,2L,1L,2L,1L,2L,1L,4L,2L,4L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,2L,2L,1L,3L,1L,2L,1L,4L,1L,3L,1L,4L,1L,2L,1L,3L,1L,3L,1L,2L,1L,2L,2L,2L,1L,2L,1L,5L,1L,2L,2L,2L,1L,4L,1L,2L,1L,3L,1L,3L,1L,2L,1L,2L,2L,2L,1L,4L,1L,2L,1L,4L,1L,2L,1L,4L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,2L,5L,2L,3L,1L,2L,2L };
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
public class A083897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083897Inst : IEnumerable<long>
{
public static readonly long[] Value=A083897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083897.Bytes);
public long this[int i]=>Value[i];

public static A083897Inst Instance=new A083897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083898
{
public static readonly long[] Value={ 1L,2L,2L,2L,1L,3L,1L,2L,2L,3L,2L,4L,2L,2L,2L,2L,1L,3L,1L,4L,3L,4L,2L,4L,1L,3L,2L,2L,1L,5L,2L,3L,4L,2L,1L,4L,1L,2L,3L,4L,1L,4L,1L,4L,2L,3L,1L,4L,1L,3L,2L,3L,1L,3L,2L,2L,2L,2L,1L,7L,1L,3L,3L,3L,2L,6L,1L,2L,3L,3L,1L,4L,1L,2L,2L,2L,2L,4L,1L,4L,2L,2L,1L,5L,1L,2L,2L,4L,1L,5L,2L,3L,3L,2L,1L,5L,1L,2L,4L,5L,2L,4L,2L,3L,3L };
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
public class A083898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083898Inst : IEnumerable<long>
{
public static readonly long[] Value=A083898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083898.Bytes);
public long this[int i]=>Value[i];

public static A083898Inst Instance=new A083898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083899
{
public static readonly long[] Value={ 1L,2L,2L,3L,1L,3L,1L,3L,2L,3L,2L,5L,2L,3L,2L,3L,1L,3L,1L,5L,3L,4L,2L,6L,1L,3L,2L,4L,1L,5L,2L,4L,4L,3L,1L,5L,1L,2L,3L,6L,2L,6L,2L,6L,2L,3L,1L,6L,1L,3L,2L,4L,1L,3L,2L,4L,2L,2L,1L,8L,1L,3L,3L,4L,2L,6L,1L,4L,3L,4L,1L,6L,1L,2L,2L,3L,2L,4L,1L,6L,2L,3L,1L,8L,1L,3L,2L,6L,1L,5L,2L,4L,3L,2L,1L,7L,1L,3L,4L,6L,2L,5L,2L,5L,3L };
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
public class A083899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083899Inst : IEnumerable<long>
{
public static readonly long[] Value=A083899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083899.Bytes);
public long this[int i]=>Value[i];

public static A083899Inst Instance=new A083899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083900
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,3L,1L,3L,2L,4L,2L,5L,2L,3L,4L,3L,1L,3L,1L,6L,3L,4L,2L,6L,3L,3L,2L,4L,1L,7L,2L,4L,4L,3L,3L,5L,1L,2L,3L,7L,2L,6L,2L,6L,5L,3L,1L,6L,1L,6L,3L,5L,2L,4L,4L,4L,2L,2L,1L,10L,1L,3L,3L,4L,3L,6L,1L,4L,3L,6L,1L,6L,1L,2L,5L,3L,2L,4L,1L,7L,2L,3L,1L,8L,2L,3L,2L,6L,1L,8L,2L,4L,3L,2L,2L,7L,1L,3L,4L,9L,2L,6L,2L,6L,7L };
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
public class A083900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083900Inst : IEnumerable<long>
{
public static readonly long[] Value=A083900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083900.Bytes);
public long this[int i]=>Value[i];

public static A083900Inst Instance=new A083900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083901
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,1L,3L,2L,4L,2L,6L,2L,3L,4L,4L,1L,4L,1L,6L,3L,4L,2L,7L,3L,4L,2L,4L,1L,8L,2L,5L,4L,3L,3L,7L,1L,2L,3L,7L,2L,7L,2L,6L,5L,4L,1L,8L,1L,6L,3L,6L,2L,5L,4L,5L,2L,2L,1L,12L,2L,4L,4L,6L,4L,8L,1L,4L,3L,6L,1L,8L,1L,2L,5L,3L,2L,6L,1L,8L,2L,3L,1L,9L,2L,3L,2L,6L,1L,9L,2L,5L,3L,2L,2L,9L,1L,3L,4L,9L,2L,7L,2L,7L,7L };
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
public class A083901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083901Inst : IEnumerable<long>
{
public static readonly long[] Value=A083901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083901.Bytes);
public long this[int i]=>Value[i];

public static A083901Inst Instance=new A083901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083902
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,2L,3L,2L,4L,2L,6L,2L,4L,4L,4L,2L,4L,1L,6L,4L,4L,2L,7L,3L,4L,3L,5L,1L,8L,2L,5L,4L,4L,4L,7L,2L,2L,3L,7L,2L,8L,2L,6L,5L,4L,2L,8L,2L,6L,4L,6L,2L,6L,4L,6L,3L,2L,1L,12L,2L,4L,5L,6L,4L,8L,2L,5L,3L,8L,2L,9L,2L,4L,6L,4L,4L,6L,1L,8L,3L,3L,1L,10L,3L,3L,2L,6L,1L,9L,3L,5L,3L,3L,2L,9L,1L,4L,4L,9L,2L,8L,2L,7L,8L };
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
public class A083902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083902Inst : IEnumerable<long>
{
public static readonly long[] Value=A083902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083902.Bytes);
public long this[int i]=>Value[i];

public static A083902Inst Instance=new A083902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083903
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,2L,4L,2L,4L,2L,6L,2L,4L,4L,5L,2L,5L,1L,6L,4L,4L,2L,8L,3L,4L,3L,6L,1L,8L,2L,6L,4L,4L,4L,8L,2L,3L,3L,8L,2L,8L,2L,6L,5L,4L,2L,10L,2L,6L,4L,6L,2L,7L,4L,8L,3L,3L,1L,12L,2L,4L,5L,7L,4L,8L,2L,6L,3L,8L,2L,11L,2L,4L,6L,5L,4L,7L,1L,10L,4L,4L,2L,12L,4L,4L,3L,8L,1L,10L,3L,5L,3L,3L,2L,11L,1L,4L,4L,9L,2L,8L };
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
public class A083903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083903Inst : IEnumerable<long>
{
public static readonly long[] Value=A083903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083903.Bytes);
public long this[int i]=>Value[i];

public static A083903Inst Instance=new A083903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083904
{
public static readonly long[] Value={ 0L,1L,0L,4L,3L,1L,0L,13L,12L,10L,9L,4L,3L,1L,0L,40L,39L,37L,36L,31L,30L,28L,27L,13L,12L,10L,9L,4L,3L,1L,0L,121L,120L,118L,117L,112L,111L,109L,108L,94L,93L,91L,90L,85L,84L,82L,81L,40L,39L,37L,36L,31L,30L,28L,27L,13L,12L,10L,9L,4L,3L,1L,0L,364L,363L,361L,360L };
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
public class A083904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083904Inst : IEnumerable<long>
{
public static readonly long[] Value=A083904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083904.Bytes);
public long this[int i]=>Value[i];

public static A083904Inst Instance=new A083904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083905
{
public static readonly long[] Value={ 0L,1L,0L,0L,-1L,1L,0L,1L,0L,2L,1L,0L,-1L,1L,0L,0L,-1L,1L,0L,-1L,-2L,0L,-1L,1L,0L,2L,1L,0L,-1L,1L,0L,1L,0L,2L,1L,0L,-1L,1L,0L,2L,1L,3L,2L,1L,0L,2L,1L,0L,-1L,1L,0L,-1L,-2L,0L,-1L,1L,0L,2L,1L,0L,-1L,1L,0L,0L,-1L,1L,0L,-1L,-2L,0L,-1L,1L,0L,2L,1L,0L,-1L,1L,0L,-1L,-2L,0L,-1L,-2L,-3L,-1L };
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
public class A083905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083905Inst : IEnumerable<long>
{
public static readonly long[] Value=A083905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083905.Bytes);
public long this[int i]=>Value[i];

public static A083905Inst Instance=new A083905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083906
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,2L,2L,5L,3L,4L,3L,1L,6L,4L,6L,6L,6L,2L,2L,7L,5L,8L,9L,11L,9L,7L,4L,3L,1L,8L,6L,10L,12L,16L,16L,18L,12L,12L,8L,6L,2L,2L,9L,7L,12L,15L,21L,23L,29L,27L,26L,23L,21L,15L,13L,7L,4L,3L,1L,10L,8L,14L,18L,26L,30L,40L,42L,48L,44L,46L,40L };
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
public class A083906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083906Inst : IEnumerable<long>
{
public static readonly long[] Value=A083906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083906.Bytes);
public long this[int i]=>Value[i];

public static A083906Inst Instance=new A083906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083907
{
public static readonly long[] Value={ 1L,2L,6L,6L,30L,30L,420L,420L,420L,420L,4620L,4620L,60060L,60060L,60060L,60060L,1021020L,1021020L,19399380L,19399380L,19399380L,19399380L,446185740L,446185740L,446185740L,446185740L,446185740L,446185740L,12939386460L };
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
public class A083907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083907Inst : IEnumerable<long>
{
public static readonly long[] Value=A083907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083907.Bytes);
public long this[int i]=>Value[i];

public static A083907Inst Instance=new A083907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083956
{
public static readonly BigInteger[] Value={ 1L,33L,666L,11110L,166665L,2333331L,31111108L,399999996L,4999999995L,509876543215L,52098641976336L,5331076296399558L,546238942849832881L,BigInteger.Parse("56038035699304276305"),BigInteger.Parse("5755318721445859729830"),BigInteger.Parse("591693488306202516193456") };
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
public class A083956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083956Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A083956.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083956.Bytes);
public BigInteger this[int i]=>Value[i];

public static A083956Inst Instance=new A083956Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083957
{
public static readonly BigInteger[] Value={ 1L,252L,8864856L,40638618022744L,BigInteger.Parse("23098236228791472696480"),BigInteger.Parse("1568841035670687222903484318855680"),BigInteger.Parse("12397389650957442295025809189993580551236444160") };
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
public class A083957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083957Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A083957.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083957.Bytes);
public BigInteger this[int i]=>Value[i];

public static A083957Inst Instance=new A083957Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083958
{
public static readonly BigInteger[] Value={ 0L,0L,222L,0L,0L,0L,666666L,0L,888888888L,0L,110L,0L,221L,0L,0L,0L,1666L,0L,1881L,0L,20202L,1122L,BigInteger.Parse("2222222222222222222222"),2232L,0L,52L,22626L,2772L,82882L,0L,333033L,0L,23232L,0L,0L,0L,3663L,0L,38883L,0L,444440L,114114L,24444L,333344L,0L,4554L,66646L };
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
public class A083958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083958Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A083958.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083958.Bytes);
public BigInteger this[int i]=>Value[i];

public static A083958Inst Instance=new A083958Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083959
{
public static readonly BigInteger[] Value={ 0L,0L,222L,0L,0L,0L,666666L,0L,888888888L,0L,1001L,0L,121212L,0L,0L,0L,666111L,0L,1881L,0L,202020L,1122L,BigInteger.Parse("2222222222222222222222"),233232L,0L,52L,222222226266666666L,2772L,228288L,0L,30300330L,0L,222222333333L,0L,0L,0L,3663L,0L,383838L,0L,4000004444L };
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
public class A083959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083959Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A083959.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083959.Bytes);
public BigInteger this[int i]=>Value[i];

public static A083959Inst Instance=new A083959Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083960
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,11L,2112L,131131L,414414L,5115L,61616L,7111117L,8118L,99199L,2L,1121211L,22L,32223L,4224L,525L,262262L,22222722222L,828828L,922229L,3L,133331L,23232L,33L,4333334L,535535L,6336L,333777333L,88388L,393393L,4L };
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
public class A083960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083960Inst : IEnumerable<long>
{
public static readonly long[] Value=A083960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083960.Bytes);
public long this[int i]=>Value[i];

public static A083960Inst Instance=new A083960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083961
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,176L,10087L,29601L,341L,3851L,418301L,451L,5221L,2L,53391L,1L,1401L,176L,21L,10087L,823063786L,29601L,31801L,3L,4301L,726L,1L,127451L,15301L,176L,9021009L,2326L,10087L,4L,279051571L,53391L,801L,1L,121L,1401L,952L,176L,203051L };
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
public class A083961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083961Inst : IEnumerable<long>
{
public static readonly long[] Value=A083961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083961.Bytes);
public long this[int i]=>Value[i];

public static A083961Inst Instance=new A083961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083962
{
public static readonly BigInteger[] Value={ 1L,212L,22122L,4221224L,542212245L,65422122456L,3654221224563L,236542212245632L,72365422122456327L,0L,1001L,210012L,200210012002L,200210012002L,5220021001200225L,652200210012002256L,BigInteger.Parse("96522002100120022569") };
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
public class A083962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083962Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A083962.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083962.Bytes);
public BigInteger this[int i]=>Value[i];

public static A083962Inst Instance=new A083962Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083963
{
public static readonly BigInteger[] Value={ 1L,106L,7374L,1055306L,108442449L,10903687076L,522031603509L,29567776530704L,8040602458050703L,0L,91L,17501L,15400770154L,14300715143L,348001400080015L,40762513125750141L,5677764829418824857L,BigInteger.Parse("15536233345000666792054") };
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
public class A083963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083963Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A083963.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A083963.Bytes);
public BigInteger this[int i]=>Value[i];

public static A083963Inst Instance=new A083963Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083964
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,131131L,0L,174471L,1911191L,219912L,238832L,0L,27972L,2930392L,31713L,33L,0L,3701073L,393393L,412214L,4357534L,0L,476674L,49294L,513315L,5305035L,55L,579975L,59295L,6188816L,6317136L,0L,6735376L,6933396L,7109017L,7305037L,0L,77L,793397L };
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
public class A083964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083964Inst : IEnumerable<long>
{
public static readonly long[] Value=A083964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083964.Bytes);
public long this[int i]=>Value[i];

public static A083964Inst Instance=new A083964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083965
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,10087L,0L,10263L,100589L,10472L,10384L,0L,1036L,101048L,1023L,1L,0L,100029L,10087L,10054L,101338L,0L,10142L,1006L,10065L,100095L,1L,10175L,1005L,101456L,100272L,0L,100528L,100484L,100127L,100069L,0L,1L,10043L,1012345678L,100986L,0L,100894L };
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
public class A083965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083965Inst : IEnumerable<long>
{
public static readonly long[] Value=A083965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083965.Bytes);
public long this[int i]=>Value[i];

public static A083965Inst Instance=new A083965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083966
{
public static readonly long[] Value={ 1L,6L,8L,9L,16L,17L,18L,21L,23L,24L,29L,32L,39L,64L,70L,78L,84L,85L,98L,1000L,1005L,1013L,1033L,1038L,1041L,1047L,1056L,1065L,1066L,1076L,1087L,1091L,1102L,1107L,1109L,1115L,1118L,1121L,1137L,1139L,1152L,1156L,1164L,1167L,1171L,1173L,1185L,1199L,1220L,1241L };
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
public class A083966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083966Inst : IEnumerable<long>
{
public static readonly long[] Value=A083966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083966.Bytes);
public long this[int i]=>Value[i];

public static A083966Inst Instance=new A083966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083967
{
public static readonly long[] Value={ 11L,22L,33L,44L,55L,66L,77L,88L,99L,101L,110L,112L,123L,134L,145L,156L,167L,178L,189L,202L,211L,213L,220L,224L,235L,246L,257L,268L,279L,303L,312L,314L,321L,325L,330L,336L,347L,358L,369L,404L,413L,415L,422L,426L,431L,437L,440L,448L,459L,505L,514L,516L,523L,527L };
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
public class A083967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083967Inst : IEnumerable<long>
{
public static readonly long[] Value=A083967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083967.Bytes);
public long this[int i]=>Value[i];

public static A083967Inst Instance=new A083967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083968
{
public static readonly long[] Value={ 11L,3L,7L,919L,101L,11L,12421L,131L,14341L,151L,16061L,17471L,181L,191L,30103L,313L,32323L,33533L,34543L,353L,36263L,373L,383L,39293L,70207L,71317L,727L };
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
public class A083968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083968Inst : IEnumerable<long>
{
public static readonly long[] Value=A083968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083968.Bytes);
public long this[int i]=>Value[i];

public static A083968Inst Instance=new A083968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083969
{
public static readonly long[] Value={ 4L,18L,33L,42L,43L,57L,73L,76L,78L,87L,91L,93L,97L,102L,112L,114L,120L,141L,151L,177L,186L,193L,196L,219L,261L,267L,276L,280L,300L,307L,318L,322L,342L,352L,364L,366L,402L,435L,438L,445L,457L,462L,468L,484L,511L,580L,582L,633L,646L,651L,679L,706L,745L,774L,783L };
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
public class A083969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083969Inst : IEnumerable<long>
{
public static readonly long[] Value=A083969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083969.Bytes);
public long this[int i]=>Value[i];

public static A083969Inst Instance=new A083969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083970
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,15L,18L,20L,22L,24L,25L,30L,33L,36L,40L,44L,45L,48L,50L,55L,60L,66L,70L,75L,77L,80L,88L,90L,99L,100L,101L,110L,111L,120L,121L,125L,131L,132L,141L,150L,151L,161L,165L,168L,171L,180L,181L,191L,198L,200L,202L,212L,220L,222L,225L,232L };
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
public class A083970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083970Inst : IEnumerable<long>
{
public static readonly long[] Value=A083970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083970.Bytes);
public long this[int i]=>Value[i];

public static A083970Inst Instance=new A083970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A083971
{
public static readonly long[] Value={ 11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,101L,176L,341L,451L,11L,101L,176L,209L,11L,101L,176L,11L,101L,121L,176L,11L,101L,11L,101L,11L,77L,101L,11L,101L,11L,101L,11L,1001L,101L,1001L,176L,1001L,4169L,1001L,1751L,1001L,341L,1001L,1001L,3401L,5126L,1001L,451L,1001L,1001L,4501L,11L,1001L,1001L };
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
public class A083971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A083971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A083971Inst : IEnumerable<long>
{
public static readonly long[] Value=A083971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A083971.Bytes);
public long this[int i]=>Value[i];

public static A083971Inst Instance=new A083971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A084004
{
public static readonly long[] Value={ 64L,7921L,9604L,164836L,351649L,996004L,19758025L,20647936L,29757025L,30846916L,97990201L,99960004L,1203187969L,1975180249L,3086469136L,4265657344L,8143618564L,9999600004L,115644884356L,131504868496L,132231867769L };
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
public class A084004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A084004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A084004Inst : IEnumerable<long>
{
public static readonly long[] Value=A084004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A084004.Bytes);
public long this[int i]=>Value[i];

public static A084004Inst Instance=new A084004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A084005
{
public static readonly long[] Value={ 8L,89L,98L,406L,593L,998L,4445L,4544L,5455L,5554L,9899L,9998L,34687L,44443L,55556L,65312L,90242L,99998L,340066L,362636L,363637L,374219L,416989L,583010L,625780L,636362L,637363L,659933L,702703L,703702L,713285L,714286L,780625L,922076L,923077L };
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
public class A084005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A084005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A084005Inst : IEnumerable<long>
{
public static readonly long[] Value=A084005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A084005.Bytes);
public long this[int i]=>Value[i];

public static A084005Inst Instance=new A084005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A084006
{
public static readonly long[] Value={ 36L,81L,1089L,4356L,9801L,110889L,443556L,998001L,11108889L,44435556L,99980001L,1111088889L,4444355556L,9999800001L,111110888889L,444443555556L,999998000001L,11111108888889L,44444435555556L,99999980000001L };
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
public class A084006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A084006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A084006Inst : IEnumerable<long>
{
public static readonly long[] Value=A084006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A084006.Bytes);
public long this[int i]=>Value[i];

public static A084006Inst Instance=new A084006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A084007
{
public static readonly long[] Value={ 6L,9L,33L,66L,99L,333L,666L,999L,3333L,6666L,9999L,33333L,66666L,99999L,333333L,666666L,999999L,3333333L,6666666L,9999999L,33333333L,66666666L,99999999L,333333333L,444444444L,555555555L,666666666L,777777777L,888888888L,999999999L };
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
public class A084007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A084007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A084007Inst : IEnumerable<long>
{
public static readonly long[] Value=A084007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A084007.Bytes);
public long this[int i]=>Value[i];

public static A084007Inst Instance=new A084007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A084008
{
public static readonly long[] Value={ 0L,1L,3L,6L,91L,141L,192L,262L,333L,414L,505L,606L,717L,829L,9591L,10911L,12421L,13941L,15561L,17281L,19092L,21012L,23032L,25152L,27273L,29593L,31923L,34443L,36964L,39594L,42324L,45154L,48075L,51015L,54145L,57276L,60606L,63937L,67377L,70917L };
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
public class A084008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A084008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A084008Inst : IEnumerable<long>
{
public static readonly long[] Value=A084008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A084008.Bytes);
public long this[int i]=>Value[i];

public static A084008Inst Instance=new A084008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A084009
{
public static readonly long[] Value={ 0L,1L,4L,9L,151L,232L,333L,454L,586L,738L,9091L,11011L,13131L,15451L,17881L,20502L,23332L,26362L,29493L,32833L,36364L,40104L,44044L,48175L,52425L,56866L,61516L,66357L,71317L,76468L,81819L,87379L,931291L,990891L,1051501L,1114111L,1178811L };
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
public class A084009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A084009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A084009Inst : IEnumerable<long>
{
public static readonly long[] Value=A084009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A084009.Bytes);
public long this[int i]=>Value[i];

public static A084009Inst Instance=new A084009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A084010
{
public static readonly long[] Value={ 1L,2L,4L,8L,151L,293L,586L,11711L,23332L,46565L,931291L,1862582L,3724264L,7447538L,148949851L,297898793L,595787596L,11915660921L,23831312842L,47662625675L,953251523491L,1906502047082L,3813004003174L,7626008006258L,152520151025251L };
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
public class A084010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A084010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A084010Inst : IEnumerable<long>
{
public static readonly long[] Value=A084010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A084010.Bytes);
public long this[int i]=>Value[i];

public static A084010Inst Instance=new A084010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A084011
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,11L,21L,31L,41L,51L,61L,71L,81L,82L,2L,12L,22L,32L,42L,52L,62L,72L,73L,83L,3L,13L,23L,33L,43L,53L,63L,64L,74L,84L,4L,14L,24L,34L,44L,54L,55L,65L,75L,85L,5L,15L,25L,35L,45L,46L,56L,66L,76L,86L,6L,16L,26L,36L,37L,47L,57L,67L,77L,87L,7L,17L,27L,28L,38L,48L,58L };
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
public class A084011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A084011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A084011Inst : IEnumerable<long>
{
public static readonly long[] Value=A084011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A084011.Bytes);
public long this[int i]=>Value[i];

public static A084011Inst Instance=new A084011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A084012
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,120L,720L,5040L,40320L,362880L,362880L,3991680L,83825280L };
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
public class A084012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A084012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A084012Inst : IEnumerable<long>
{
public static readonly long[] Value=A084012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A084012.Bytes);
public long this[int i]=>Value[i];

public static A084012Inst Instance=new A084012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A084013
{
public static readonly long[] Value={ 1L,22L,111L,2112L,50005L,201102L,1002001L,21100112L,100070001L,1000000010L,10000200001L,400002200004L,1000029200001L,20000055000002L,500000020000005L,2110000000000112L,10000000200000001L,200000007700000002L };
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
public class A084013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A084013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A084013Inst : IEnumerable<long>
{
public static readonly long[] Value=A084013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A084013.Bytes);
public long this[int i]=>Value[i];

public static A084013Inst Instance=new A084013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A084014
{
public static readonly long[] Value={ 1L,11L,37L,528L,10001L,33517L,143143L,2637514L,11118889L,100000001L,909109091L,33333516667L,76925323077L,1428575357143L,33333334666667L,131875000000007L,588235305882353L,11111111538888889L,52631579052631579L };
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
public class A084014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A084014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A084014Inst : IEnumerable<long>
{
public static readonly long[] Value=A084014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A084014.Bytes);
public long this[int i]=>Value[i];

public static A084014Inst Instance=new A084014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A084015
{
public static readonly long[] Value={ 9L,88L,999L,8888L,59995L,897798L,9994999L,88899888L,999999999L,9999999990L,99999799999L,889998899988L,9999990999999L,89999988999998L,599999989999995L,8889999999999888L,99999998689999999L,899999991199999998L };
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
public class A084015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A084015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A084015Inst : IEnumerable<long>
{
public static readonly long[] Value=A084015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A084015.Bytes);
public long this[int i]=>Value[i];

public static A084015Inst Instance=new A084015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A084016
{
public static readonly long[] Value={ 9L,44L,333L,2222L,11999L,149633L,1427857L,11112486L,111111111L,999999999L,9090890909L,74166574999L,769230076923L,6428570642857L,39999999333333L,555624999999993L,5882352864117647L,49999999511111111L,526315788147368421L };
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
public class A084016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A084016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A084016Inst : IEnumerable<long>
{
public static readonly long[] Value=A084016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A084016.Bytes);
public long this[int i]=>Value[i];

public static A084016Inst Instance=new A084016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A084017
{
public static readonly long[] Value={ 1L,22L,111L,4004L,50005L,201102L,1103011L,21100112L,100070001L,1000800010L,20009090002L,210003300012L,1000276720001L,20000055000002L,500000050000005L,2110000440000112L,10000007170000001L,200000007700000002L };
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
public class A084017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A084017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A084017Inst : IEnumerable<long>
{
public static readonly long[] Value=A084017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A084017.Bytes);
public long this[int i]=>Value[i];

public static A084017Inst Instance=new A084017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A084018
{
public static readonly long[] Value={ 1L,11L,37L,1001L,10001L,33517L,157573L,2637514L,11118889L,100080001L,1819008182L,17500275001L,76944363077L,1428575357143L,33333336666667L,131875027500007L,588235715882353L,11111111538888889L,52631583252631579L };
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
public class A084018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A084018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A084018Inst : IEnumerable<long>
{
public static readonly long[] Value=A084018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A084018.Bytes);
public long this[int i]=>Value[i];

public static A084018Inst Instance=new A084018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A084019
{
public static readonly long[] Value={ 9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,88L,77L,66L,55L,44L,33L,22L,11L,0L,898L,888L,878L,868L,858L,848L,838L,828L,818L,808L,797L,787L,777L,767L,757L,747L,737L,727L,717L,707L,696L,686L,676L,666L,656L,646L,636L,626L,616L };
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
public class A084019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A084019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A084019Inst : IEnumerable<long>
{
public static readonly long[] Value=A084019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A084019.Bytes);
public long this[int i]=>Value[i];

public static A084019Inst Instance=new A084019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A084068
{
public static readonly long[] Value={ 1L,2L,7L,12L,41L,70L,239L,408L,1393L,2378L,8119L,13860L,47321L,80782L,275807L,470832L,1607521L,2744210L,9369319L,15994428L,54608393L,93222358L,318281039L,543339720L,1855077841L,3166815962L,10812186007L,18457556052L,63018038201L,107578520350L };
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
public class A084068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A084068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A084068Inst : IEnumerable<long>
{
public static readonly long[] Value=A084068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A084068.Bytes);
public long this[int i]=>Value[i];

public static A084068Inst Instance=new A084068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A084069
{
public static readonly long[] Value={ 1L,3L,17L,48L,271L,765L,4319L,12192L,68833L,194307L,1097009L,3096720L,17483311L,49353213L,278635967L,786554688L,4440692161L,12535521795L,70772438609L,199781794032L,1127918325583L,3183973182717L,17975920770719L,50743789129440L };
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
public class A084069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A084069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A084069Inst : IEnumerable<long>
{
public static readonly long[] Value=A084069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A084069.Bytes);
public long this[int i]=>Value[i];

public static A084069Inst Instance=new A084069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A084070
{
public static readonly BigInteger[] Value={ 0L,6L,228L,8658L,328776L,12484830L,474094764L,18003116202L,683644320912L,25960481078454L,985814636660340L,37434995712014466L,1421544022419889368L,BigInteger.Parse("53981237856243781518"),BigInteger.Parse("2049865494514843808316"),BigInteger.Parse("77840907553707820934490"),BigInteger.Parse("2955904621546382351702304") };
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
public class A084070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A084070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A084070Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A084070.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A084070.Bytes);
public BigInteger this[int i]=>Value[i];

public static A084070Inst Instance=new A084070Inst();

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