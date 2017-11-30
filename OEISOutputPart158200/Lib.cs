using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A201305
{
public static readonly long[] Value={ 7L,17L,277L,647L,7297L,10007L,21977L,33757L,68597L,106487L,138247L,156257L,196837L,359377L,466567L,506537L,640007L,795077L,973367L,1574647L,1951127L,2621447L,5314417L,5513687L,6141257L,10612087L,11910167L,12950297L,14815447L,19066247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201305Inst : IEnumerable<long>
{
public static readonly long[] Value=A201305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201305.Bytes);
public long this[int i]=>Value[i];

public static A201305Inst Instance=new A201305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201306
{
public static readonly long[] Value={ 19L,89L,1259L,10009L,27449L,49139L,156259L,219529L,327689L,428759L,640009L,689219L,795079L,1250009L,1406089L,2269819L,3007639L,3579119L,3890179L,4052249L,4389769L,6360569L,6814729L,8305849L,8573759L,11248649L,12950299L,13310009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201306Inst : IEnumerable<long>
{
public static readonly long[] Value=A201306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201306.Bytes);
public long this[int i]=>Value[i];

public static A201306Inst Instance=new A201306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201307
{
public static readonly long[] Value={ 5L,31L,347L,733L,6863L,15629L,19687L,91129L,250051L,328513L,493043L,614129L,658507L,970303L,1092731L,1295033L,1520879L,1601617L,2146693L,2352641L,3048629L,4826813L,5359379L,6128491L,7414879L,8869747L,12977879L,21253937L,21717643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201307Inst : IEnumerable<long>
{
public static readonly long[] Value=A201307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201307.Bytes);
public long this[int i]=>Value[i];

public static A201307Inst Instance=new A201307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201308
{
public static readonly long[] Value={ 7L,131L,349L,2203L,4919L,68927L,389023L,456539L,1030307L,1092733L,2352643L,2924213L,3048631L,4173287L,5177723L,5929747L,6539209L,15813257L,19902517L,22665193L,25153763L,30664303L,34328131L,59776477L,61629881L,76765631L,97972187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201308Inst : IEnumerable<long>
{
public static readonly long[] Value=A201308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201308.Bytes);
public long this[int i]=>Value[i];

public static A201308Inst Instance=new A201308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201309
{
public static readonly long[] Value={ 23L,1327L,3371L,4909L,9257L,12163L,35933L,68917L,91121L,132647L,148873L,185189L,250043L,456529L,571783L,1030297L,1157621L,1601609L,2248087L,3176519L,3723871L,4173277L,5545229L,8120597L,11697079L,16581371L,16974589L,17779577L,18191443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201309Inst : IEnumerable<long>
{
public static readonly long[] Value=A201309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201309.Bytes);
public long this[int i]=>Value[i];

public static A201309Inst Instance=new A201309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201310
{
public static readonly long[] Value={ 2L,337L,12161L,15619L,50647L,117643L,300757L,857369L,1685153L,2352631L,3723869L,8365421L,12977869L,14706119L,18191441L,20796869L,23639897L,24137563L,31855007L,40353601L,46268273L,57066619L,58863863L,65450821L,67419137L,77854477L,86938301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201310Inst : IEnumerable<long>
{
public static readonly long[] Value=A201310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201310.Bytes);
public long this[int i]=>Value[i];

public static A201310Inst Instance=new A201310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201311
{
public static readonly long[] Value={ 17L,719L,1321L,4903L,12157L,24379L,103813L,148867L,185183L,250037L,456523L,571777L,1030291L,1442887L,1860857L,3176513L,3307939L,4657453L,5000201L,5545223L,6128477L,6967861L,8120591L,8365417L,9663587L,10793851L,11697073L,13312043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201311Inst : IEnumerable<long>
{
public static readonly long[] Value=A201311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201311.Bytes);
public long this[int i]=>Value[i];

public static A201311Inst Instance=new A201311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201312
{
public static readonly long[] Value={ 11L,37L,353L,739L,2207L,6869L,117659L,132661L,226991L,250057L,328519L,389027L,493049L,804367L,1601623L,1860877L,2685629L,3176533L,4019689L,4330757L,10218323L,11089577L,12008999L,15069233L,16194287L,17373989L,19034173L,20346427L,21253943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201312Inst : IEnumerable<long>
{
public static readonly long[] Value=A201312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201312.Bytes);
public long this[int i]=>Value[i];

public static A201312Inst Instance=new A201312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201313
{
public static readonly long[] Value={ 71L,431L,719L,1511L,2591L,4751L,6551L,7559L,9791L,13679L,16631L,21599L,23399L,29231L,31319L,33479L,42839L,47951L,61991L,68111L,95471L,110879L,123191L,131759L,149759L,154439L,159191L,184031L,194471L,199799L,210671L,221831L,227519L,233279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201313Inst : IEnumerable<long>
{
public static readonly long[] Value=A201313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201313.Bytes);
public long this[int i]=>Value[i];

public static A201313Inst Instance=new A201313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201314
{
public static readonly long[] Value={ 19L,47L,83L,127L,179L,239L,307L,383L,467L,659L,883L,1279L,1427L,1583L,1747L,2099L,2287L,2687L,3119L,3347L,3583L,4079L,4339L,5167L,6067L,7039L,7727L,8447L,8819L,9199L,9587L,10799L,12527L,12979L,13907L,14867L,15359L,15859L,16883L,17939L,19583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201314Inst : IEnumerable<long>
{
public static readonly long[] Value=A201314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201314.Bytes);
public long this[int i]=>Value[i];

public static A201314Inst Instance=new A201314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201315
{
public static readonly long[] Value={ 2L,2L,7L,0L,9L,8L,7L,5L,8L,6L,4L,9L,4L,9L,9L,5L,3L,5L,7L,0L,5L,8L,2L,3L,3L,9L,8L,2L,9L,2L,0L,9L,1L,7L,1L,5L,7L,4L,5L,3L,0L,5L,1L,6L,5L,0L,9L,8L,1L,9L,1L,0L,4L,9L,3L,5L,6L,1L,5L,1L,4L,0L,4L,4L,9L,6L,7L,3L,6L,9L,7L,3L,0L,3L,5L,4L,6L,4L,3L,6L,3L,9L,9L,8L,7L,7L,8L,0L,2L,7L,9L,6L,2L,2L,3L,8L,4L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201315Inst : IEnumerable<long>
{
public static readonly long[] Value=A201315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201315.Bytes);
public long this[int i]=>Value[i];

public static A201315Inst Instance=new A201315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201316
{
public static readonly long[] Value={ 2L,4L,2L,0L,9L,9L,4L,1L,9L,8L,6L,5L,6L,6L,9L,2L,6L,6L,4L,5L,0L,3L,7L,5L,7L,3L,3L,7L,4L,3L,9L,8L,7L,9L,4L,0L,2L,0L,3L,7L,2L,5L,9L,0L,8L,5L,3L,4L,7L,2L,0L,0L,6L,4L,7L,7L,3L,4L,8L,0L,5L,3L,3L,4L,6L,7L,2L,0L,2L,6L,2L,1L,3L,0L,1L,4L,5L,7L,9L,7L,4L,7L,2L,2L,5L,9L,7L,9L,7L,8L,3L,8L,8L,4L,1L,8L,1L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201316Inst : IEnumerable<long>
{
public static readonly long[] Value=A201316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201316.Bytes);
public long this[int i]=>Value[i];

public static A201316Inst Instance=new A201316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201317
{
public static readonly long[] Value={ 2L,5L,5L,1L,0L,9L,4L,1L,5L,8L,8L,9L,3L,9L,1L,5L,8L,0L,0L,7L,3L,4L,6L,1L,6L,1L,9L,2L,9L,4L,0L,8L,1L,0L,2L,9L,1L,7L,6L,3L,5L,9L,2L,5L,8L,2L,9L,2L,3L,6L,5L,8L,6L,2L,3L,3L,8L,7L,4L,1L,4L,2L,5L,2L,7L,6L,4L,3L,8L,0L,7L,1L,4L,9L,5L,2L,2L,0L,1L,1L,8L,4L,9L,0L,5L,8L,5L,2L,5L,2L,0L,0L,2L,5L,0L,7L,5L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201317Inst : IEnumerable<long>
{
public static readonly long[] Value=A201317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201317.Bytes);
public long this[int i]=>Value[i];

public static A201317Inst Instance=new A201317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201318
{
public static readonly long[] Value={ 2L,6L,6L,1L,1L,0L,3L,4L,3L,8L,5L,8L,4L,5L,7L,3L,1L,3L,5L,5L,1L,7L,4L,2L,4L,4L,5L,0L,0L,6L,0L,0L,4L,6L,1L,1L,7L,9L,7L,2L,5L,4L,8L,7L,0L,2L,3L,2L,1L,9L,2L,5L,4L,2L,2L,6L,3L,2L,4L,5L,3L,5L,6L,2L,9L,5L,0L,0L,7L,0L,6L,8L,9L,3L,8L,0L,5L,6L,5L,2L,3L,1L,9L,8L,7L,2L,1L,3L,1L,2L,6L,5L,9L,9L,0L,5L,5L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201318Inst : IEnumerable<long>
{
public static readonly long[] Value=A201318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201318.Bytes);
public long this[int i]=>Value[i];

public static A201318Inst Instance=new A201318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201319
{
public static readonly long[] Value={ 2L,7L,5L,1L,2L,6L,8L,2L,9L,9L,0L,5L,8L,5L,7L,2L,8L,5L,5L,4L,3L,9L,0L,4L,8L,5L,7L,9L,5L,1L,5L,9L,4L,8L,8L,6L,0L,9L,7L,4L,4L,7L,5L,8L,6L,6L,2L,0L,9L,0L,5L,3L,8L,9L,8L,6L,3L,4L,0L,7L,4L,8L,8L,9L,1L,3L,5L,2L,7L,4L,5L,6L,9L,8L,4L,4L,3L,5L,4L,9L,9L,9L,5L,7L,7L,1L,4L,1L,2L,0L,7L,5L,9L,6L,4L,0L,4L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201319Inst : IEnumerable<long>
{
public static readonly long[] Value=A201319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201319.Bytes);
public long this[int i]=>Value[i];

public static A201319Inst Instance=new A201319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201320
{
public static readonly long[] Value={ 9L,3L,3L,0L,2L,7L,6L,7L,4L,6L,6L,6L,1L,7L,7L,2L,5L,5L,9L,0L,6L,8L,7L,9L,1L,3L,5L,6L,1L,3L,0L,5L,1L,0L,6L,5L,4L,1L,1L,9L,0L,4L,1L,2L,7L,1L,1L,1L,3L,6L,0L,9L,4L,0L,9L,5L,0L,9L,0L,2L,0L,6L,6L,2L,6L,0L,2L,2L,1L,7L,4L,7L,3L,3L,3L,4L,1L,4L,5L,0L,0L,9L,1L,1L,2L,2L,1L,6L,8L,9L,6L,9L,7L,3L,6L,3L,0L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201320Inst : IEnumerable<long>
{
public static readonly long[] Value=A201320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201320.Bytes);
public long this[int i]=>Value[i];

public static A201320Inst Instance=new A201320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201321
{
public static readonly long[] Value={ 8L,0L,7L,5L,8L,5L,2L,8L,1L,4L,4L,2L,2L,0L,1L,9L,9L,3L,9L,2L,6L,5L,8L,1L,6L,7L,9L,5L,3L,7L,2L,4L,0L,7L,5L,4L,2L,3L,7L,2L,5L,4L,0L,7L,9L,4L,3L,0L,3L,7L,3L,1L,8L,9L,3L,2L,9L,3L,4L,6L,3L,8L,9L,5L,5L,0L,1L,6L,9L,8L,7L,0L,9L,9L,8L,9L,7L,1L,7L,7L,8L,2L,9L,3L,7L,3L,8L,9L,2L,5L,6L,5L,5L,3L,0L,3L,7L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201321Inst : IEnumerable<long>
{
public static readonly long[] Value=A201321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201321.Bytes);
public long this[int i]=>Value[i];

public static A201321Inst Instance=new A201321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201322
{
public static readonly long[] Value={ 7L,2L,8L,2L,4L,6L,5L,3L,2L,3L,5L,5L,2L,8L,6L,1L,4L,2L,6L,5L,1L,8L,2L,0L,1L,9L,5L,7L,7L,8L,8L,3L,8L,8L,3L,3L,3L,2L,3L,2L,5L,6L,1L,1L,4L,0L,4L,2L,4L,4L,1L,4L,9L,5L,7L,0L,8L,4L,0L,7L,1L,2L,0L,2L,4L,6L,8L,1L,5L,9L,5L,6L,3L,0L,7L,6L,8L,7L,0L,7L,1L,1L,1L,2L,1L,3L,0L,1L,1L,6L,7L,8L,5L,9L,1L,4L,2L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201322Inst : IEnumerable<long>
{
public static readonly long[] Value=A201322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201322.Bytes);
public long this[int i]=>Value[i];

public static A201322Inst Instance=new A201322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201323
{
public static readonly long[] Value={ 6L,7L,1L,9L,0L,6L,2L,1L,8L,2L,4L,0L,8L,6L,6L,9L,9L,9L,5L,0L,8L,5L,8L,8L,8L,4L,7L,8L,1L,5L,2L,6L,7L,2L,0L,4L,4L,3L,8L,6L,6L,4L,4L,9L,9L,4L,5L,9L,4L,6L,9L,8L,1L,1L,4L,3L,7L,6L,5L,1L,0L,4L,6L,6L,8L,7L,3L,7L,2L,4L,7L,6L,7L,2L,9L,6L,2L,1L,4L,1L,8L,2L,7L,3L,2L,8L,1L,0L,3L,1L,9L,8L,1L,2L,6L,8L,0L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201323Inst : IEnumerable<long>
{
public static readonly long[] Value=A201323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201323.Bytes);
public long this[int i]=>Value[i];

public static A201323Inst Instance=new A201323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201324
{
public static readonly long[] Value={ 6L,2L,9L,0L,5L,4L,1L,6L,2L,9L,7L,8L,4L,0L,4L,2L,3L,0L,8L,6L,1L,8L,0L,6L,7L,8L,2L,6L,9L,4L,4L,1L,2L,3L,6L,8L,8L,4L,4L,6L,3L,2L,5L,8L,1L,7L,8L,5L,5L,5L,9L,3L,9L,5L,6L,2L,5L,2L,3L,4L,6L,6L,4L,6L,7L,5L,2L,7L,0L,6L,5L,7L,2L,9L,3L,2L,7L,1L,8L,1L,0L,4L,2L,3L,9L,8L,5L,4L,1L,5L,3L,7L,4L,3L,5L,5L,8L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201324Inst : IEnumerable<long>
{
public static readonly long[] Value=A201324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201324.Bytes);
public long this[int i]=>Value[i];

public static A201324Inst Instance=new A201324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201325
{
public static readonly long[] Value={ 5L,9L,4L,9L,4L,0L,8L,7L,6L,1L,7L,0L,1L,7L,0L,2L,0L,4L,0L,7L,2L,7L,0L,5L,0L,5L,7L,5L,1L,1L,4L,7L,1L,1L,0L,0L,9L,7L,7L,9L,5L,0L,4L,9L,7L,0L,0L,3L,7L,7L,7L,7L,0L,8L,7L,6L,6L,1L,6L,3L,2L,4L,5L,3L,9L,0L,1L,0L,3L,4L,2L,7L,4L,0L,2L,6L,6L,9L,4L,4L,1L,9L,1L,5L,1L,3L,9L,4L,7L,6L,1L,3L,1L,7L,9L,7L,6L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201325Inst : IEnumerable<long>
{
public static readonly long[] Value=A201325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201325.Bytes);
public long this[int i]=>Value[i];

public static A201325Inst Instance=new A201325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201326
{
public static readonly long[] Value={ 5L,6L,6L,8L,8L,6L,5L,4L,7L,9L,5L,8L,9L,4L,9L,0L,9L,1L,3L,7L,2L,1L,3L,3L,7L,9L,0L,0L,4L,6L,4L,1L,4L,5L,3L,3L,9L,0L,3L,2L,8L,2L,6L,9L,5L,1L,6L,0L,2L,2L,4L,2L,4L,0L,9L,6L,5L,3L,6L,5L,3L,4L,8L,1L,8L,4L,0L,8L,7L,3L,0L,2L,0L,7L,4L,7L,3L,7L,3L,1L,5L,5L,7L,0L,7L,9L,2L,2L,7L,6L,4L,7L,2L,1L,4L,3L,0L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201326Inst : IEnumerable<long>
{
public static readonly long[] Value=A201326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201326.Bytes);
public long this[int i]=>Value[i];

public static A201326Inst Instance=new A201326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201327
{
public static readonly long[] Value={ 5L,4L,3L,2L,4L,5L,4L,7L,2L,5L,1L,1L,0L,6L,5L,6L,3L,7L,1L,6L,1L,8L,0L,7L,4L,0L,0L,7L,2L,4L,2L,8L,7L,3L,5L,0L,6L,6L,4L,8L,7L,6L,2L,9L,5L,0L,9L,3L,4L,8L,9L,8L,1L,4L,5L,7L,8L,1L,9L,9L,4L,6L,1L,8L,9L,6L,6L,4L,8L,4L,9L,2L,2L,1L,7L,5L,4L,3L,4L,1L,5L,5L,2L,3L,0L,6L,7L,8L,7L,6L,5L,2L,8L,6L,3L,3L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201327Inst : IEnumerable<long>
{
public static readonly long[] Value=A201327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201327.Bytes);
public long this[int i]=>Value[i];

public static A201327Inst Instance=new A201327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201328
{
public static readonly long[] Value={ 5L,2L,2L,9L,4L,1L,8L,3L,0L,5L,6L,4L,4L,4L,6L,6L,3L,1L,5L,9L,1L,8L,6L,1L,8L,5L,6L,1L,6L,3L,9L,6L,6L,8L,9L,0L,9L,4L,0L,6L,9L,3L,6L,3L,6L,5L,8L,7L,5L,9L,3L,0L,4L,1L,0L,8L,6L,5L,6L,6L,1L,9L,9L,0L,2L,3L,3L,3L,5L,3L,0L,5L,8L,9L,4L,2L,9L,7L,8L,5L,6L,3L,9L,7L,8L,7L,6L,1L,9L,0L,7L,2L,8L,6L,4L,5L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201328Inst : IEnumerable<long>
{
public static readonly long[] Value=A201328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201328.Bytes);
public long this[int i]=>Value[i];

public static A201328Inst Instance=new A201328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201329
{
public static readonly long[] Value={ 7L,3L,9L,9L,9L,6L,6L,7L,6L,5L,4L,8L,4L,9L,3L,3L,0L,8L,3L,4L,5L,5L,4L,3L,5L,0L,3L,4L,5L,7L,9L,2L,7L,5L,6L,8L,5L,3L,7L,8L,6L,6L,5L,8L,3L,1L,9L,2L,5L,3L,8L,4L,3L,0L,8L,3L,0L,5L,8L,4L,8L,3L,3L,0L,4L,9L,3L,7L,5L,7L,9L,0L,8L,3L,8L,9L,2L,5L,2L,8L,1L,8L,6L,2L,8L,8L,0L,7L,6L,3L,6L,0L,4L,1L,9L,3L,3L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201329Inst : IEnumerable<long>
{
public static readonly long[] Value=A201329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201329.Bytes);
public long this[int i]=>Value[i];

public static A201329Inst Instance=new A201329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201330
{
public static readonly long[] Value={ 6L,5L,7L,2L,3L,4L,0L,6L,6L,2L,1L,6L,4L,9L,4L,6L,3L,5L,6L,3L,7L,7L,9L,1L,0L,9L,9L,2L,0L,6L,7L,1L,4L,7L,7L,0L,5L,7L,9L,1L,1L,3L,1L,8L,6L,8L,8L,8L,9L,7L,9L,3L,6L,2L,4L,7L,8L,9L,6L,4L,7L,3L,0L,8L,1L,7L,5L,8L,7L,4L,6L,0L,1L,5L,8L,9L,4L,7L,3L,9L,1L,2L,8L,3L,9L,3L,7L,3L,9L,4L,9L,4L,7L,6L,2L,5L,9L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201330Inst : IEnumerable<long>
{
public static readonly long[] Value=A201330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201330.Bytes);
public long this[int i]=>Value[i];

public static A201330Inst Instance=new A201330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201331
{
public static readonly long[] Value={ 6L,0L,2L,7L,3L,4L,2L,0L,3L,9L,9L,5L,6L,9L,3L,9L,9L,0L,3L,3L,0L,9L,2L,9L,2L,9L,1L,6L,5L,1L,1L,4L,3L,5L,2L,1L,4L,0L,6L,1L,2L,6L,5L,9L,2L,6L,2L,5L,6L,5L,5L,0L,4L,6L,1L,7L,2L,5L,5L,0L,8L,9L,0L,9L,3L,1L,3L,2L,8L,7L,4L,0L,9L,8L,0L,4L,6L,1L,2L,7L,1L,9L,6L,0L,0L,6L,7L,4L,3L,0L,3L,1L,1L,6L,0L,5L,2L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201331Inst : IEnumerable<long>
{
public static readonly long[] Value=A201331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201331.Bytes);
public long this[int i]=>Value[i];

public static A201331Inst Instance=new A201331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201332
{
public static readonly long[] Value={ 5L,6L,2L,9L,5L,6L,0L,1L,9L,8L,9L,2L,5L,4L,3L,7L,3L,7L,6L,6L,9L,7L,5L,3L,8L,2L,7L,3L,9L,8L,4L,9L,2L,9L,5L,9L,2L,0L,2L,4L,2L,7L,5L,2L,4L,9L,8L,2L,1L,1L,9L,8L,5L,2L,3L,6L,5L,7L,4L,7L,8L,0L,5L,7L,1L,1L,3L,3L,6L,5L,9L,9L,4L,4L,0L,8L,0L,9L,8L,5L,9L,8L,9L,2L,8L,0L,5L,5L,9L,4L,5L,7L,8L,0L,3L,8L,7L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201332Inst : IEnumerable<long>
{
public static readonly long[] Value=A201332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201332.Bytes);
public long this[int i]=>Value[i];

public static A201332Inst Instance=new A201332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201333
{
public static readonly long[] Value={ 5L,3L,2L,0L,7L,6L,2L,5L,1L,3L,5L,6L,6L,5L,0L,3L,1L,6L,8L,0L,0L,7L,3L,5L,2L,4L,8L,7L,0L,9L,5L,0L,8L,2L,9L,3L,5L,1L,1L,0L,1L,4L,9L,6L,7L,8L,7L,3L,3L,8L,4L,6L,9L,6L,8L,9L,4L,2L,2L,8L,8L,4L,4L,6L,0L,6L,3L,3L,8L,0L,9L,9L,8L,8L,6L,4L,3L,3L,0L,5L,5L,9L,0L,1L,8L,3L,9L,2L,4L,8L,7L,1L,8L,1L,5L,3L,0L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201333Inst : IEnumerable<long>
{
public static readonly long[] Value=A201333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201333.Bytes);
public long this[int i]=>Value[i];

public static A201333Inst Instance=new A201333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201334
{
public static readonly long[] Value={ 5L,0L,7L,0L,9L,4L,7L,7L,8L,2L,5L,4L,4L,5L,8L,4L,8L,8L,0L,4L,1L,0L,6L,8L,0L,5L,8L,5L,7L,6L,1L,2L,5L,8L,4L,5L,2L,7L,7L,6L,6L,2L,4L,0L,4L,6L,9L,3L,1L,9L,6L,7L,3L,7L,6L,1L,4L,2L,9L,3L,7L,2L,4L,4L,3L,5L,6L,2L,3L,9L,8L,8L,5L,2L,1L,6L,2L,7L,6L,7L,2L,7L,2L,1L,4L,6L,7L,0L,3L,8L,3L,0L,9L,7L,0L,5L,3L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201334Inst : IEnumerable<long>
{
public static readonly long[] Value=A201334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201334.Bytes);
public long this[int i]=>Value[i];

public static A201334Inst Instance=new A201334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201335
{
public static readonly long[] Value={ 4L,8L,6L,2L,7L,7L,9L,6L,7L,8L,2L,5L,0L,6L,5L,8L,6L,3L,3L,1L,3L,3L,8L,4L,3L,3L,0L,9L,6L,3L,3L,0L,0L,2L,1L,9L,9L,6L,5L,8L,9L,6L,1L,1L,8L,6L,8L,1L,0L,1L,9L,5L,6L,2L,7L,4L,4L,0L,0L,0L,8L,5L,1L,5L,1L,3L,3L,5L,1L,1L,0L,7L,2L,8L,3L,3L,0L,6L,8L,7L,9L,1L,4L,9L,0L,7L,4L,7L,8L,0L,6L,9L,0L,0L,5L,3L,6L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201335Inst : IEnumerable<long>
{
public static readonly long[] Value=A201335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201335.Bytes);
public long this[int i]=>Value[i];

public static A201335Inst Instance=new A201335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201336
{
public static readonly long[] Value={ 4L,6L,8L,5L,4L,0L,5L,4L,7L,6L,8L,9L,1L,2L,8L,6L,5L,9L,1L,2L,2L,9L,2L,7L,7L,8L,5L,7L,6L,1L,7L,4L,3L,1L,3L,1L,1L,4L,6L,0L,2L,2L,6L,7L,1L,6L,1L,4L,6L,6L,3L,0L,2L,9L,6L,7L,0L,1L,5L,9L,2L,9L,0L,6L,2L,5L,9L,5L,2L,4L,4L,9L,6L,2L,6L,5L,8L,2L,1L,2L,1L,6L,7L,2L,2L,9L,9L,2L,7L,8L,0L,1L,2L,3L,0L,1L,7L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201336Inst : IEnumerable<long>
{
public static readonly long[] Value=A201336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201336.Bytes);
public long this[int i]=>Value[i];

public static A201336Inst Instance=new A201336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201337
{
public static readonly long[] Value={ 4L,5L,3L,1L,6L,1L,6L,5L,6L,7L,7L,2L,4L,2L,4L,5L,8L,7L,6L,8L,9L,0L,6L,0L,6L,0L,1L,7L,6L,7L,4L,2L,7L,0L,6L,7L,8L,2L,0L,4L,3L,7L,5L,9L,7L,0L,7L,1L,5L,5L,4L,2L,2L,8L,6L,5L,2L,2L,3L,5L,1L,8L,5L,8L,4L,7L,5L,8L,2L,0L,9L,1L,5L,2L,6L,9L,0L,7L,5L,7L,4L,4L,4L,3L,5L,2L,4L,8L,8L,4L,2L,4L,0L,0L,8L,6L,3L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201337Inst : IEnumerable<long>
{
public static readonly long[] Value=A201337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201337.Bytes);
public long this[int i]=>Value[i];

public static A201337Inst Instance=new A201337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201338
{
public static readonly BigInteger[] Value={ 1L,4L,24L,196L,2040L,25924L,390264L,6804676L,135033720L,3007364164L,74315818104L,2018441506756L,59776933889400L,1917312391176004L,66216538949389944L,2449977966210378436L,BigInteger.Parse("96685769287005577080"),BigInteger.Parse("4053944607498740773444"),BigInteger.Parse("179973441341757042161784"),BigInteger.Parse("8433644996370680262923716") };
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
public class A201338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201338Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201338.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201338.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201338Inst Instance=new A201338Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201339
{
public static readonly BigInteger[] Value={ 1L,3L,15L,111L,1095L,13503L,199815L,3449631L,68062695L,1510769343L,37260156615L,1010843385951L,29916558512295L,959183053936383L,33118910817665415L,1225219266296167071L,BigInteger.Parse("48348200298184769895"),BigInteger.Parse("2027102674516399522623"),BigInteger.Parse("89990106205541777926215"),BigInteger.Parse("4216915299772659459872991") };
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
public class A201339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201339Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201339.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201339.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201339Inst Instance=new A201339Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201340
{
public static readonly long[] Value={ 0L,0L,15L,213L,2007L,15497L,106589L,680287L,4118949L,23981337L,135473879L,747163898L,4040984182L,21504391182L,112888169123L,585765427216L,3009175376793L,15324419276531L,77445651022458L,388752941316532L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201340Inst : IEnumerable<long>
{
public static readonly long[] Value=A201340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201340.Bytes);
public long this[int i]=>Value[i];

public static A201340Inst Instance=new A201340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201341
{
public static readonly long[] Value={ 0L,15L,295L,6304L,120750L,1977305L,28778603L,384578235L,4826582648L,57769170135L,666507302212L,7467860256482L,81701886884909L,876350926474594L,9244732890227899L,96149151282735127L,987831159810408273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201341Inst : IEnumerable<long>
{
public static readonly long[] Value=A201341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201341.Bytes);
public long this[int i]=>Value[i];

public static A201341Inst Instance=new A201341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201342
{
public static readonly long[] Value={ 0L,213L,6304L,194873L,6442039L,204185475L,6035149800L,166685904910L,4343111301270L,107811107350689L,2572353758832182L,59415299284527760L,1336167955301861214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201342Inst : IEnumerable<long>
{
public static readonly long[] Value=A201342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201342.Bytes);
public long this[int i]=>Value[i];

public static A201342Inst Instance=new A201342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201343
{
public static readonly long[] Value={ 0L,2007L,120750L,6442039L,365946958L,21233514530L,1207482454151L,66042015070636L,3456814178223675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201343Inst : IEnumerable<long>
{
public static readonly long[] Value=A201343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201343.Bytes);
public long this[int i]=>Value[i];

public static A201343Inst Instance=new A201343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201344
{
public static readonly long[] Value={ 0L,15497L,1977305L,204185475L,21233514530L,2272075034938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201344Inst : IEnumerable<long>
{
public static readonly long[] Value=A201344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201344.Bytes);
public long this[int i]=>Value[i];

public static A201344Inst Instance=new A201344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201345
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,15L,15L,0L,0L,213L,295L,213L,0L,0L,2007L,6304L,6304L,2007L,0L,0L,15497L,120750L,194873L,120750L,15497L,0L,0L,106589L,1977305L,6442039L,6442039L,1977305L,106589L,0L,0L,680287L,28778603L,204185475L,365946958L,204185475L,28778603L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201345Inst : IEnumerable<long>
{
public static readonly long[] Value=A201345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201345.Bytes);
public long this[int i]=>Value[i];

public static A201345Inst Instance=new A201345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201346
{
public static readonly long[] Value={ 0L,4L,18L,191L,4860L,310036L,53350918L,26097731070L,37211940860240L,157260419809121989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201346Inst : IEnumerable<long>
{
public static readonly long[] Value=A201346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201346.Bytes);
public long this[int i]=>Value[i];

public static A201346Inst Instance=new A201346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201347
{
public static readonly long[] Value={ 2L,4L,8L,14L,23L,36L,54L,78L,109L,148L,196L,254L,323L,404L,498L,606L,729L,868L,1024L,1198L,1391L,1604L,1838L,2094L,2373L,2676L,3004L,3358L,3739L,4148L,4586L,5054L,5553L,6084L,6648L,7246L,7879L,8548L,9254L,9998L,10781L,11604L,12468L,13374L,14323L,15316L,16354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201347Inst : IEnumerable<long>
{
public static readonly long[] Value=A201347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201347.Bytes);
public long this[int i]=>Value[i];

public static A201347Inst Instance=new A201347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201348
{
public static readonly long[] Value={ 2L,8L,18L,47L,118L,273L,585L,1174L,2228L,4030L,6992L,11697L,18950L,29839L,45807L,68736L,101044L,145796L,206830L,288899L,397830L,540701L,726037L,964026L,1266756L,1648474L,2125868L,2718373L,3448502L,4342203L,5429243L,6743620L,8324004L,10214208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201348Inst : IEnumerable<long>
{
public static readonly long[] Value=A201348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201348.Bytes);
public long this[int i]=>Value[i];

public static A201348Inst Instance=new A201348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201349
{
public static readonly long[] Value={ 3L,14L,47L,191L,752L,2732L,9111L,28011L,79918L,213153L,535318L,1274359L,2892516L,6291669L,13172108L,26642251L,52229342L,99517435L,184747946L,334871408L,593751872L,1031516926L,1758440929L,2945277335L,4852655894L,7873078897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201349Inst : IEnumerable<long>
{
public static readonly long[] Value=A201349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201349.Bytes);
public long this[int i]=>Value[i];

public static A201349Inst Instance=new A201349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201350
{
public static readonly long[] Value={ 4L,23L,118L,752L,4860L,29540L,164704L,838248L,3906802L,16781171L,66921332L,249553233L,875898271L,2910325591L,9200601794L,27796173121L,80558496898L,224724538799L,605174810816L,1577359861541L,3988423084299L,9803571070083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201350Inst : IEnumerable<long>
{
public static readonly long[] Value=A201350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201350.Bytes);
public long this[int i]=>Value[i];

public static A201350Inst Instance=new A201350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201351
{
public static readonly long[] Value={ 5L,36L,273L,2732L,29540L,310036L,3030673L,27104947L,220732437L,1641106829L,11206232481L,70771398891L,416197943012L,2293568841898L,11910310629163L,58569696365494L,273928804681607L,1223107208560736L,5231237485621038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201351Inst : IEnumerable<long>
{
public static readonly long[] Value=A201351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201351.Bytes);
public long this[int i]=>Value[i];

public static A201351Inst Instance=new A201351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201352
{
public static readonly long[] Value={ 6L,54L,585L,9111L,164704L,3030673L,53350918L,867792264L,12855063828L,173064550218L,2125820442965L,23973988256341L,249906703874274L,2423485396921085L,21992456168363649L,187733722448990317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201352Inst : IEnumerable<long>
{
public static readonly long[] Value=A201352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201352.Bytes);
public long this[int i]=>Value[i];

public static A201352Inst Instance=new A201352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201353
{
public static readonly long[] Value={ 0L,2L,2L,2L,4L,2L,3L,8L,8L,3L,4L,14L,18L,14L,4L,5L,23L,47L,47L,23L,5L,6L,36L,118L,191L,118L,36L,6L,7L,54L,273L,752L,752L,273L,54L,7L,8L,78L,585L,2732L,4860L,2732L,585L,78L,8L,9L,109L,1174L,9111L,29540L,29540L,9111L,1174L,109L,9L,10L,148L,2228L,28011L,164704L,310036L,164704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201353Inst : IEnumerable<long>
{
public static readonly long[] Value=A201353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201353.Bytes);
public long this[int i]=>Value[i];

public static A201353Inst Instance=new A201353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201354
{
public static readonly BigInteger[] Value={ 1L,4L,28L,292L,4060L,70564L,1471708L,35810212L,995827420L,31153998244L,1082931514588L,41407678132132L,1727226633730780L,78051253062575524L,3798351192214837468L,BigInteger.Parse("198049421007186054052"),BigInteger.Parse("11014905131587945490140"),BigInteger.Parse("650903915009792820650404"),BigInteger.Parse("40726453234725158535472348") };
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
public class A201354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201354Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201354.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201354.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201354Inst Instance=new A201354Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201355
{
public static readonly BigInteger[] Value={ 1L,4L,20L,132L,1140L,12324L,160020L,2424132L,41967540L,817374564L,17688328020L,421061260932L,10934334077940L,307610736087204L,9319558144624020L,302518807147502532L,10474617188712332340UL,BigInteger.Parse("385347795973248950244"),BigInteger.Parse("15010362565222418008020"),BigInteger.Parse("617178205591321673884932") };
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
public class A201355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201355Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201355.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201355.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201355Inst Instance=new A201355Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201356
{
public static readonly long[] Value={ 2L,3L,4L,5L,15L,23L,53L,57L,75L,233L,464L,671L,1431L,2021L,5861L,6056L,9063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201356Inst : IEnumerable<long>
{
public static readonly long[] Value=A201356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201356.Bytes);
public long this[int i]=>Value[i];

public static A201356Inst Instance=new A201356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201357
{
public static readonly long[] Value={ 1L,13L,1468L,2701L,2959L,3735L,8686L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201357Inst : IEnumerable<long>
{
public static readonly long[] Value=A201357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201357.Bytes);
public long this[int i]=>Value[i];

public static A201357Inst Instance=new A201357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201358
{
public static readonly long[] Value={ 1L,5L,49L,269L,2387L,2945L,5897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201358Inst : IEnumerable<long>
{
public static readonly long[] Value=A201358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201358.Bytes);
public long this[int i]=>Value[i];

public static A201358Inst Instance=new A201358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201359
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,18L,30L,48L,54L,278L,450L,464L,1425L,1428L,3029L,7314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201359Inst : IEnumerable<long>
{
public static readonly long[] Value=A201359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201359.Bytes);
public long this[int i]=>Value[i];

public static A201359Inst Instance=new A201359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201360
{
public static readonly long[] Value={ 1L,2L,39L,44L,62L,1478L,2306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201360Inst : IEnumerable<long>
{
public static readonly long[] Value=A201360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201360.Bytes);
public long this[int i]=>Value[i];

public static A201360Inst Instance=new A201360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201361
{
public static readonly long[] Value={ 1L,2L,3L,8L,14L,35L,75L,83L,89L,90L,215L,342L,753L,1452L,4578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201361Inst : IEnumerable<long>
{
public static readonly long[] Value=A201361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201361.Bytes);
public long this[int i]=>Value[i];

public static A201361Inst Instance=new A201361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201362
{
public static readonly long[] Value={ 2L,7L,11L,13L,14L,20L,37L,53L,71L,132L,140L,613L,641L,665L,757L,788L,1878L,6774L,8777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201362Inst : IEnumerable<long>
{
public static readonly long[] Value=A201362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201362.Bytes);
public long this[int i]=>Value[i];

public static A201362Inst Instance=new A201362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201363
{
public static readonly long[] Value={ 2L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201363Inst : IEnumerable<long>
{
public static readonly long[] Value=A201363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201363.Bytes);
public long this[int i]=>Value[i];

public static A201363Inst Instance=new A201363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201364
{
public static readonly long[] Value={ 1L,2L,4L,7L,8L,14L,16L,25L,39L,41L,57L,67L,75L,120L,127L,147L,209L,229L,231L,290L,302L,320L,455L,547L,558L,747L,1553L,1947L,2027L,2458L,3313L,3508L,4262L,4727L,6210L,6393L,6539L,6838L,7312L,8242L,8557L,9431L,9450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201364Inst : IEnumerable<long>
{
public static readonly long[] Value=A201364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201364.Bytes);
public long this[int i]=>Value[i];

public static A201364Inst Instance=new A201364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201365
{
public static readonly BigInteger[] Value={ 1L,5L,45L,605L,10845L,243005L,6534045L,204972605L,7348546845L,296387331005L,13282361478045L,654762261324605L,35211177242722845L,2051349014835939005L,BigInteger.Parse("128701394409842982045"),BigInteger.Parse("8651475271312083756605"),BigInteger.Parse("620334325261670875138845"),BigInteger.Parse("47259638324026516284867005") };
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
public class A201365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201365Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201365.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201365.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201365Inst Instance=new A201365Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201366
{
public static readonly BigInteger[] Value={ 1L,5L,40L,470L,7360L,144080L,3384640L,92761520L,2905461760L,102379969280L,4008411658240L,172632406008320L,8110747682652160L,412820794294292480L,BigInteger.Parse("22628039202542755840"),BigInteger.Parse("1328909797186015877120"),BigInteger.Parse("83247808119808161218560"),BigInteger.Parse("5540883903212529402183680"),BigInteger.Parse("390489065613179063896637440") };
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
public class A201366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201366Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201366.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201366.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201366Inst Instance=new A201366Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201367
{
public static readonly BigInteger[] Value={ 1L,5L,35L,345L,4515L,73905L,1451835L,33273945L,871529715L,25681042305L,840815302635L,30281769805545L,1189735610250915L,50638609760802705L,2321120945531697435L,BigInteger.Parse("113992686944812385145"),BigInteger.Parse("5971520591679167948115"),BigInteger.Parse("332369999588147180115105"),BigInteger.Parse("19587647624733292373756235") };
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
public class A201367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201367Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201367.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201367.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201367Inst Instance=new A201367Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201368
{
public static readonly BigInteger[] Value={ 1L,5L,30L,230L,2280L,28280L,421680L,7336880L,145879680L,3263031680L,81097294080L,2217097729280L,66122900014080L,2136392343342080L,74335250629908480L,2771225281718343680L,BigInteger.Parse("110198981079416340480"),BigInteger.Parse("4655992415884353044480"),BigInteger.Parse("208291013498682750074880"),BigInteger.Parse("9835804726301090178990080") };
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
public class A201368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201368Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201368.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201368.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201368Inst Instance=new A201368Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201369
{
public static readonly long[] Value={ 0L,0L,0L,0L,27L,21792L,3324193L,119138166L,1979541332L,20142680752L,145977165234L,824771174978L,3850985758339L,15461577137802L,54912339921707L,176153338628674L,518569625849418L,1418340918023792L,3639736652346172L,8833161922947702L,20405252721413369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201369Inst : IEnumerable<long>
{
public static readonly long[] Value=A201369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201369.Bytes);
public long this[int i]=>Value[i];

public static A201369Inst Instance=new A201369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201370
{
public static readonly long[] Value={ 2L,3L,8L,36L,268L,3739L,115168L,8866257L,1799674094L,976134459840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201370Inst : IEnumerable<long>
{
public static readonly long[] Value=A201370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201370.Bytes);
public long this[int i]=>Value[i];

public static A201370Inst Instance=new A201370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201371
{
public static readonly long[] Value={ 2L,5L,14L,36L,80L,157L,280L,464L,726L,1085L,1562L,2180L,2964L,3941L,5140L,6592L,8330L,10389L,12806L,15620L,18872L,22605L,26864L,31696L,37150L,43277L,50130L,57764L,66236L,75605L,85932L,97280L,109714L,123301L,138110L,154212L,171680L,190589L,211016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201371Inst : IEnumerable<long>
{
public static readonly long[] Value=A201371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201371.Bytes);
public long this[int i]=>Value[i];

public static A201371Inst Instance=new A201371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201372
{
public static readonly long[] Value={ 2L,6L,22L,80L,268L,786L,2016L,4608L,9582L,18446L,33330L,57136L,93704L,147994L,226284L,336384L,487866L,692310L,963566L,1318032L,1774948L,2356706L,3089176L,4002048L,5129190L,6509022L,8184906L,10205552L,12625440L,15505258L,18912356L,22921216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201372Inst : IEnumerable<long>
{
public static readonly long[] Value=A201372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201372.Bytes);
public long this[int i]=>Value[i];

public static A201372Inst Instance=new A201372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201373
{
public static readonly long[] Value={ 2L,7L,32L,157L,786L,3739L,15574L,55410L,170616L,465037L,1145954L,2597729L,5492076L,10947133L,20749996L,37660122L,65814022L,111254955L,182614908L,291980013L,455974718L,697104503L,1045401722L,1540424266L,2233662188L,3191413217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201373Inst : IEnumerable<long>
{
public static readonly long[] Value=A201373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201373.Bytes);
public long this[int i]=>Value[i];

public static A201373Inst Instance=new A201373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201374
{
public static readonly long[] Value={ 2L,8L,44L,280L,2016L,15574L,115168L,728078L,3793342L,16517460L,61759798L,203474642L,603403128L,1638153030L,4126393250L,9747403504L,21778931370L,46349684784L,94496712184L,185448946836L,351735813872L,646956766742L,1157359269036L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201374Inst : IEnumerable<long>
{
public static readonly long[] Value=A201374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201374.Bytes);
public long this[int i]=>Value[i];

public static A201374Inst Instance=new A201374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201375
{
public static readonly long[] Value={ 2L,2L,2L,2L,3L,2L,2L,4L,4L,2L,2L,5L,8L,5L,2L,2L,6L,14L,14L,6L,2L,2L,7L,22L,36L,22L,7L,2L,2L,8L,32L,80L,80L,32L,8L,2L,2L,9L,44L,157L,268L,157L,44L,9L,2L,2L,10L,58L,280L,786L,786L,280L,58L,10L,2L,2L,11L,74L,464L,2016L,3739L,2016L,464L,74L,11L,2L,2L,12L,92L,726L,4608L,15574L,15574L,4608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201375Inst : IEnumerable<long>
{
public static readonly long[] Value=A201375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201375.Bytes);
public long this[int i]=>Value[i];

public static A201375Inst Instance=new A201375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201376
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,9L,3L,7L,16L,31L,5L,12L,29L,57L,109L,7L,19L,47L,97L,189L,339L,11L,30L,77L,162L,323L,589L,1043L,15L,45L,118L,257L,522L,975L,1752L,2998L,22L,67L,181L,401L,831L,1576L,2876L,4987L,8406L,30L,97L,267L,608L,1279L,2472L,4571L,8043L,13715L,22652L,42L,139L,392L,907L,1941L,3804L,7128L,12693L,21893L,36535L,59521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201376Inst : IEnumerable<long>
{
public static readonly long[] Value=A201376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201376.Bytes);
public long this[int i]=>Value[i];

public static A201376Inst Instance=new A201376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201377
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,5L,2L,5L,9L,17L,2L,7L,14L,27L,46L,3L,10L,21L,42L,74L,123L,4L,14L,31L,64L,116L,197L,323L,5L,19L,44L,93L,174L,303L,506L,809L,6L,25L,61L,132L,254L,452L,769L,1251L,1966L,8L,33L,83L,185L,363L,659L,1141L,1885L,3006L,4660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201377Inst : IEnumerable<long>
{
public static readonly long[] Value=A201377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201377.Bytes);
public long this[int i]=>Value[i];

public static A201377Inst Instance=new A201377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201378
{
public static readonly long[] Value={ 2L,3L,19L,121L,7148L,326650L,175765510L,74872992399L,400292326222730L,1748923742658486631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201378Inst : IEnumerable<long>
{
public static readonly long[] Value=A201378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201378.Bytes);
public long this[int i]=>Value[i];

public static A201378Inst Instance=new A201378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201379
{
public static readonly long[] Value={ 2L,4L,19L,27L,115L,122L,467L,433L,1461L,1208L,3797L,2931L,8642L,6292L,17780L,12430L,33822L,22825L,60401L,39688L,102439L,65739L,166387L,104780L,260549L,161323L,395367L,241382L,583802L,351915L,841664L,501871L,1188050L,701410L,1645719L,963241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201379Inst : IEnumerable<long>
{
public static readonly long[] Value=A201379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201379.Bytes);
public long this[int i]=>Value[i];

public static A201379Inst Instance=new A201379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201380
{
public static readonly long[] Value={ 1L,7L,27L,121L,483L,1751L,5694L,16870L,46014L,116842L,278837L,630353L,1358517L,2806843L,5584567L,10741640L,20039166L,36362252L,64333159L,111214759L,188207532L,312302096L,508868575L,815256003L,1285706310L,1998034336L,3062559792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201380Inst : IEnumerable<long>
{
public static readonly long[] Value=A201380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201380.Bytes);
public long this[int i]=>Value[i];

public static A201380Inst Instance=new A201380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201381
{
public static readonly long[] Value={ 2L,9L,115L,483L,7148L,24779L,295813L,804538L,7711613L,17135660L,137991357L,261853930L,1838296465L,3078156753L,19352193027L,29273561002L,168059197372L,233637796573L,1242746736360L,1608517392555L,8015798428649L,9756858004272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201381Inst : IEnumerable<long>
{
public static readonly long[] Value=A201381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201381.Bytes);
public long this[int i]=>Value[i];

public static A201381Inst Instance=new A201381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201382
{
public static readonly long[] Value={ 1L,13L,122L,1751L,24779L,326650L,3826202L,39589830L,364013320L,3005372641L,22522846792L,154739772302L,983097718721L,5818909235791L,32292922468841L,168956847012130L,837348841763554L,3947230438308504L,17762594565022972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201382Inst : IEnumerable<long>
{
public static readonly long[] Value=A201382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201382.Bytes);
public long this[int i]=>Value[i];

public static A201382Inst Instance=new A201382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201383
{
public static readonly long[] Value={ 2L,16L,467L,5694L,295813L,3826202L,175765510L,1819250859L,65629320845L,534428405524L,15483460261810L,102996778664996L,2488946990439369L,14017118437802211L,291386682009006888L,1427682924988875276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201383Inst : IEnumerable<long>
{
public static readonly long[] Value=A201383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201383.Bytes);
public long this[int i]=>Value[i];

public static A201383Inst Instance=new A201383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201384
{
public static readonly long[] Value={ 2L,1L,1L,2L,3L,2L,1L,4L,4L,1L,2L,7L,19L,7L,2L,1L,9L,27L,27L,9L,1L,2L,13L,115L,121L,115L,13L,2L,1L,16L,122L,483L,483L,122L,16L,1L,2L,21L,467L,1751L,7148L,1751L,467L,21L,2L,1L,25L,433L,5694L,24779L,24779L,5694L,433L,25L,1L,2L,31L,1461L,16870L,295813L,326650L,295813L,16870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201384Inst : IEnumerable<long>
{
public static readonly long[] Value=A201384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201384.Bytes);
public long this[int i]=>Value[i];

public static A201384Inst Instance=new A201384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201385
{
public static readonly long[] Value={ 1L,3L,7L,3L,15L,10L,31L,25L,10L,63L,56L,35L,127L,119L,91L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201385Inst : IEnumerable<long>
{
public static readonly long[] Value=A201385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201385.Bytes);
public long this[int i]=>Value[i];

public static A201385Inst Instance=new A201385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201386
{
public static readonly long[] Value={ 4L,8L,1606L,312604L,9842070647L,264043688162138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201386Inst : IEnumerable<long>
{
public static readonly long[] Value=A201386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201386.Bytes);
public long this[int i]=>Value[i];

public static A201386Inst Instance=new A201386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201387
{
public static readonly long[] Value={ 6L,8L,137L,98L,1416L,715L,9424L,3977L,47509L,17474L,195020L,65271L,685365L,212409L,2127347L,621431L,5970292L,1659237L,15403848L,4110026L,37018776L,9536251L,83699540L,20927871L,179497978L,43720826L,367499724L,87495195L,722212122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201387Inst : IEnumerable<long>
{
public static readonly long[] Value=A201387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201387.Bytes);
public long this[int i]=>Value[i];

public static A201387Inst Instance=new A201387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201388
{
public static readonly long[] Value={ 4L,137L,1606L,5897L,236224L,3364770L,19735330L,40088345L,1066040173L,10207216063L,41478543314L,60255150730L,1228071405908L,9109985067401L,29080781926297L,33671540790223L,567086887068128L,3500195283945353L,9371250160350500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201388Inst : IEnumerable<long>
{
public static readonly long[] Value=A201388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201388.Bytes);
public long this[int i]=>Value[i];

public static A201388Inst Instance=new A201388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201389
{
public static readonly BigInteger[] Value={ 1L,98L,5897L,312604L,14027391L,539625139L,18131486831L,541077286873L,14533375222752L,355152145922937L,7965464463977638L,165169207300414826L,3186082489177522116L,BigInteger.Parse("57478616703131109039"),BigInteger.Parse("974288796548462899774") };
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
public class A201389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201389Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201389.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201389.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201389Inst Instance=new A201389Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201390
{
public static readonly long[] Value={ 4L,1416L,236224L,14027391L,9842070647L,2308382992901L,214888479967271L,6753117745581190L,2832539834014535065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201390Inst : IEnumerable<long>
{
public static readonly long[] Value=A201390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201390.Bytes);
public long this[int i]=>Value[i];

public static A201390Inst Instance=new A201390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201391
{
public static readonly long[] Value={ 6L,715L,3364770L,539625139L,2308382992901L,264043688162138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201391Inst : IEnumerable<long>
{
public static readonly long[] Value=A201391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201391.Bytes);
public long this[int i]=>Value[i];

public static A201391Inst Instance=new A201391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201392
{
public static readonly long[] Value={ 4L,9424L,19735330L,18131486831L,214888479967271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201392Inst : IEnumerable<long>
{
public static readonly long[] Value=A201392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201392.Bytes);
public long this[int i]=>Value[i];

public static A201392Inst Instance=new A201392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201393
{
public static readonly long[] Value={ 4L,6L,6L,4L,8L,4L,1L,137L,137L,1L,4L,98L,1606L,98L,4L,6L,1416L,5897L,5897L,1416L,6L,4L,715L,236224L,312604L,236224L,715L,4L,1L,9424L,3364770L,14027391L,14027391L,3364770L,9424L,1L,4L,3977L,19735330L,539625139L,9842070647L,539625139L,19735330L,3977L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201393Inst : IEnumerable<long>
{
public static readonly long[] Value=A201393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201393.Bytes);
public long this[int i]=>Value[i];

public static A201393Inst Instance=new A201393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201394
{
public static readonly long[] Value={ 1L,2L,8L,3L,6L,1L,6L,7L,2L,7L,0L,5L,9L,4L,7L,4L,2L,0L,9L,4L,3L,7L,8L,8L,8L,5L,9L,7L,4L,7L,7L,2L,7L,8L,7L,0L,3L,8L,8L,5L,5L,9L,0L,3L,7L,2L,0L,6L,9L,2L,8L,1L,0L,8L,8L,9L,9L,6L,0L,1L,8L,7L,7L,0L,6L,2L,7L,3L,3L,5L,8L,4L,9L,4L,5L,5L,8L,9L,3L,0L,9L,0L,1L,1L,8L,6L,2L,3L,2L,5L,7L,3L,8L,1L,3L,6L,2L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201394Inst : IEnumerable<long>
{
public static readonly long[] Value=A201394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201394.Bytes);
public long this[int i]=>Value[i];

public static A201394Inst Instance=new A201394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201395
{
public static readonly long[] Value={ 9L,5L,1L,0L,5L,5L,2L,3L,9L,6L,9L,6L,6L,3L,2L,7L,7L,9L,0L,0L,7L,4L,2L,1L,2L,0L,3L,7L,2L,1L,2L,0L,6L,5L,6L,2L,8L,3L,9L,5L,3L,8L,3L,6L,6L,3L,9L,6L,0L,5L,6L,9L,3L,8L,5L,2L,9L,0L,8L,4L,3L,5L,0L,7L,7L,7L,4L,3L,4L,3L,3L,6L,3L,5L,0L,6L,7L,3L,5L,5L,8L,3L,7L,7L,3L,2L,2L,2L,6L,5L,8L,5L,3L,3L,7L,1L,5L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201395Inst : IEnumerable<long>
{
public static readonly long[] Value=A201395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201395.Bytes);
public long this[int i]=>Value[i];

public static A201395Inst Instance=new A201395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201396
{
public static readonly long[] Value={ 2L,2L,0L,4L,1L,1L,7L,7L,3L,3L,1L,7L,1L,6L,2L,0L,2L,9L,5L,9L,9L,0L,9L,5L,4L,8L,7L,7L,7L,3L,2L,3L,8L,4L,9L,5L,3L,5L,8L,6L,5L,9L,8L,9L,3L,9L,9L,3L,0L,0L,9L,7L,9L,4L,2L,1L,1L,7L,4L,4L,7L,7L,4L,9L,2L,0L,2L,1L,1L,8L,2L,3L,8L,6L,5L,9L,0L,1L,0L,7L,3L,0L,3L,3L,5L,9L,3L,8L,3L,0L,8L,0L,9L,8L,4L,6L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201396Inst : IEnumerable<long>
{
public static readonly long[] Value=A201396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201396.Bytes);
public long this[int i]=>Value[i];

public static A201396Inst Instance=new A201396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201397
{
public static readonly long[] Value={ 1L,2L,9L,5L,4L,5L,9L,6L,4L,6L,4L,1L,5L,4L,7L,8L,7L,6L,8L,6L,2L,9L,9L,1L,3L,2L,7L,0L,7L,1L,8L,6L,4L,1L,5L,8L,9L,7L,6L,7L,2L,7L,4L,8L,2L,7L,0L,6L,8L,7L,1L,3L,1L,6L,1L,6L,0L,5L,1L,8L,1L,4L,3L,0L,2L,1L,7L,4L,9L,5L,1L,2L,6L,5L,9L,9L,3L,0L,9L,5L,5L,9L,7L,8L,6L,7L,4L,3L,9L,4L,7L,1L,9L,8L,8L,4L,7L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201397Inst : IEnumerable<long>
{
public static readonly long[] Value=A201397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201397.Bytes);
public long this[int i]=>Value[i];

public static A201397Inst Instance=new A201397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201398
{
public static readonly long[] Value={ 1L,3L,6L,3L,5L,1L,9L,4L,6L,8L,4L,8L,6L,2L,0L,1L,8L,5L,7L,3L,5L,2L,2L,8L,1L,2L,8L,4L,5L,8L,4L,2L,3L,7L,8L,7L,7L,3L,2L,9L,5L,1L,4L,4L,9L,4L,6L,3L,1L,2L,5L,9L,4L,4L,8L,5L,3L,8L,7L,8L,9L,0L,6L,1L,7L,8L,7L,4L,8L,5L,4L,8L,4L,5L,6L,2L,7L,2L,1L,2L,4L,5L,7L,8L,9L,9L,5L,1L,3L,5L,3L,7L,2L,0L,8L,7L,7L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201398Inst : IEnumerable<long>
{
public static readonly long[] Value=A201398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201398.Bytes);
public long this[int i]=>Value[i];

public static A201398Inst Instance=new A201398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201399
{
public static readonly long[] Value={ 1L,4L,0L,2L,4L,0L,6L,0L,3L,1L,2L,7L,6L,5L,1L,6L,4L,7L,2L,8L,6L,3L,7L,6L,5L,8L,5L,4L,6L,9L,3L,9L,7L,3L,0L,3L,2L,3L,0L,5L,2L,3L,1L,8L,9L,3L,8L,7L,0L,0L,8L,1L,0L,9L,3L,8L,2L,9L,8L,9L,9L,6L,6L,5L,5L,8L,2L,5L,2L,7L,7L,7L,8L,3L,4L,2L,4L,3L,5L,0L,8L,4L,7L,5L,7L,8L,1L,8L,5L,1L,9L,3L,9L,3L,4L,9L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201399Inst : IEnumerable<long>
{
public static readonly long[] Value=A201399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201399.Bytes);
public long this[int i]=>Value[i];

public static A201399Inst Instance=new A201399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201400
{
public static readonly long[] Value={ 1L,4L,2L,8L,2L,6L,7L,7L,6L,5L,8L,3L,8L,2L,2L,2L,6L,4L,0L,3L,3L,9L,7L,6L,6L,3L,0L,1L,3L,2L,5L,2L,7L,7L,6L,0L,6L,6L,2L,8L,1L,3L,1L,0L,7L,4L,1L,3L,2L,3L,8L,0L,7L,8L,8L,4L,1L,0L,0L,4L,1L,5L,6L,5L,2L,4L,2L,1L,0L,7L,6L,0L,2L,9L,0L,4L,3L,2L,9L,3L,4L,0L,3L,3L,3L,5L,3L,6L,2L,7L,9L,5L,1L,4L,8L,7L,2L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201400Inst : IEnumerable<long>
{
public static readonly long[] Value=A201400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201400.Bytes);
public long this[int i]=>Value[i];

public static A201400Inst Instance=new A201400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201401
{
public static readonly long[] Value={ 1L,4L,4L,6L,9L,2L,5L,2L,6L,4L,8L,5L,3L,0L,3L,9L,2L,2L,3L,8L,8L,2L,5L,8L,9L,8L,8L,1L,4L,2L,8L,4L,9L,2L,1L,8L,1L,0L,5L,7L,9L,6L,4L,9L,6L,2L,1L,4L,2L,1L,7L,7L,5L,1L,4L,1L,7L,2L,7L,6L,0L,1L,6L,3L,3L,5L,8L,2L,4L,6L,2L,0L,2L,5L,5L,4L,2L,9L,0L,8L,4L,3L,8L,5L,8L,1L,7L,4L,0L,3L,5L,0L,2L,6L,9L,5L,6L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201401Inst : IEnumerable<long>
{
public static readonly long[] Value=A201401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201401.Bytes);
public long this[int i]=>Value[i];

public static A201401Inst Instance=new A201401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201402
{
public static readonly long[] Value={ 1L,4L,6L,1L,1L,0L,5L,3L,6L,4L,6L,3L,0L,1L,6L,7L,7L,8L,2L,2L,7L,7L,7L,8L,0L,7L,0L,2L,7L,3L,7L,6L,2L,2L,0L,7L,2L,6L,5L,2L,7L,6L,0L,9L,7L,5L,5L,9L,9L,9L,4L,2L,4L,9L,5L,8L,9L,4L,8L,7L,0L,4L,1L,8L,9L,8L,4L,8L,3L,9L,0L,9L,6L,5L,4L,3L,1L,6L,8L,7L,6L,7L,2L,8L,6L,8L,9L,6L,4L,2L,3L,0L,3L,7L,4L,4L,9L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201402Inst : IEnumerable<long>
{
public static readonly long[] Value=A201402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201402.Bytes);
public long this[int i]=>Value[i];

public static A201402Inst Instance=new A201402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201403
{
public static readonly long[] Value={ 1L,4L,7L,2L,2L,8L,5L,6L,9L,0L,4L,6L,1L,3L,4L,7L,6L,6L,2L,3L,7L,1L,4L,6L,4L,5L,4L,7L,8L,2L,4L,0L,4L,0L,1L,9L,5L,4L,5L,3L,2L,9L,4L,9L,3L,6L,6L,0L,9L,0L,1L,6L,2L,8L,3L,7L,4L,5L,4L,0L,1L,1L,7L,2L,4L,5L,1L,0L,4L,8L,4L,0L,8L,2L,2L,0L,9L,8L,2L,4L,3L,6L,7L,0L,1L,3L,8L,9L,2L,1L,7L,0L,7L,7L,5L,1L,4L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201403Inst : IEnumerable<long>
{
public static readonly long[] Value=A201403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201403.Bytes);
public long this[int i]=>Value[i];

public static A201403Inst Instance=new A201403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201404
{
public static readonly long[] Value={ 1L,4L,8L,1L,3L,4L,6L,6L,1L,2L,6L,2L,9L,7L,1L,7L,6L,7L,5L,9L,7L,6L,5L,3L,6L,8L,4L,1L,5L,7L,9L,5L,6L,5L,2L,3L,0L,3L,0L,3L,3L,0L,0L,0L,1L,8L,1L,5L,5L,5L,1L,0L,5L,2L,7L,4L,8L,9L,3L,4L,5L,5L,0L,6L,7L,0L,9L,9L,9L,5L,7L,6L,2L,4L,3L,8L,4L,1L,7L,7L,8L,3L,8L,9L,3L,0L,4L,3L,4L,0L,3L,1L,7L,3L,3L,2L,6L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201404Inst : IEnumerable<long>
{
public static readonly long[] Value=A201404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201404.Bytes);
public long this[int i]=>Value[i];

public static A201404Inst Instance=new A201404Inst();

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