using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A231432
{
public static readonly long[] Value={ 3L,7L,13L,19L,31L,41L,47L,53L,61L,71L,79L,89L,101L,107L,113L,139L,151L,173L,193L,199L,223L,229L,239L,251L,271L,281L,293L,349L,373L,397L,433L,457L,463L,521L,541L,557L,569L,593L,601L,613L,619L,641L,647L,673L,683L,743L,787L,809L,839L,911L,941L,953L,971L,1013L,1049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231432Inst : IEnumerable<long>
{
public static readonly long[] Value=A231432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231432.Bytes);
public long this[int i]=>Value[i];

public static A231432Inst Instance=new A231432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231433
{
public static readonly long[] Value={ 0L,11L,2L,3L,1L,4L,7L,6L,10L,9L,5L,12L,8L,18L,13L,15L,14L,17L,20L,23L,21L,16L,19L,22L,30L,25L,27L,26L,29L,24L,31L,28L,33L,32L,35L,36L,34L,37L,39L,38L,41L,42L,43L,45L,47L,44L,51L,40L,49L,46L,57L,50L,53L,48L,59L,56L,63L,52L,61L,54L,67L,55L,69L,58L,70L,60L,71L,62L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231433Inst : IEnumerable<long>
{
public static readonly long[] Value=A231433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231433.Bytes);
public long this[int i]=>Value[i];

public static A231433Inst Instance=new A231433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231434
{
public static readonly long[] Value={ 1L,4L,21L,182L,4450L,133646L,7859324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231434Inst : IEnumerable<long>
{
public static readonly long[] Value=A231434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231434.Bytes);
public long this[int i]=>Value[i];

public static A231434Inst Instance=new A231434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231435
{
public static readonly long[] Value={ 2L,4L,8L,17L,45L,104L,280L,752L,2076L,5947L,17063L,50170L,148048L,440654L,1318362L,3954541L,11900191L,35855502L,108184920L,326687124L,987055180L,2983676881L,9021446161L,27283340688L,82523932704L,249635724500L,755206783160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231435Inst : IEnumerable<long>
{
public static readonly long[] Value=A231435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231435.Bytes);
public long this[int i]=>Value[i];

public static A231435Inst Instance=new A231435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231436
{
public static readonly long[] Value={ 3L,8L,21L,54L,185L,561L,1943L,6756L,24003L,88488L,325775L,1225789L,4623559L,17568716L,67018935L,256235910L,982016953L,3767662049L,14470021611L,55610192696L,213805376253L,822314635406L,3163303832419L,12170737198879L,46831328979593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231436Inst : IEnumerable<long>
{
public static readonly long[] Value=A231436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231436.Bytes);
public long this[int i]=>Value[i];

public static A231436Inst Instance=new A231436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231437
{
public static readonly long[] Value={ 6L,17L,54L,182L,820L,3071L,13458L,59480L,266481L,1252868L,5822115L,27737178L,132560995L,635816704L,3070132496L,14824494889L,71797359606L,348050195323L,1688282296810L,8196752528576L,39802681383250L,193353414423825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231437Inst : IEnumerable<long>
{
public static readonly long[] Value=A231437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231437.Bytes);
public long this[int i]=>Value[i];

public static A231437Inst Instance=new A231437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231438
{
public static readonly long[] Value={ 11L,45L,185L,820L,4450L,21472L,117959L,653280L,3702873L,21843997L,128432043L,772854026L,4670530787L,28365620848L,173414566634L,1061055576890L,6512490329181L,40022336748789L,246149226462653L,1515462897926857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231438Inst : IEnumerable<long>
{
public static readonly long[] Value=A231438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231438.Bytes);
public long this[int i]=>Value[i];

public static A231438Inst Instance=new A231438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231439
{
public static readonly long[] Value={ 23L,104L,561L,3071L,21472L,133646L,919000L,6530487L,46899990L,351910410L,2629723769L,20061701402L,154031198836L,1186422216734L,9204115370568L,71469834411742L,556458026486814L,4340103184723855L,33868912292912126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231439Inst : IEnumerable<long>
{
public static readonly long[] Value=A231439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231439.Bytes);
public long this[int i]=>Value[i];

public static A231439Inst Instance=new A231439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231472
{
public static readonly long[] Value={ 11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,10L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,9L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,10L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,9L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,9L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,7L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231472Inst : IEnumerable<long>
{
public static readonly long[] Value=A231472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231472.Bytes);
public long this[int i]=>Value[i];

public static A231472Inst Instance=new A231472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231473
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,4L,1L,4L,4L,1L,6L,9L,1L,6L,18L,1L,8L,28L,10L,1L,8L,42L,28L,1L,10L,57L,76L,1L,10L,76L,140L,25L,1L,12L,96L,254L,107L,1L,12L,120L,392L,321L,1L,14L,145L,600L,731L,70L,1L,14L,174L,840L,1462L,366L,1L,16L,204L,1170L,2610L,1308L,1L,16L,238L,1540L,4350L,3416L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231473Inst : IEnumerable<long>
{
public static readonly long[] Value=A231473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231473.Bytes);
public long this[int i]=>Value[i];

public static A231473Inst Instance=new A231473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231474
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,29L,31L,37L,41L,59L,67L,79L,97L,101L,109L,113L,137L,139L,149L,151L,173L,181L,193L,223L,229L,251L,269L,271L,293L,311L,331L,353L,367L,373L,379L,383L,389L,397L,401L,457L,467L,491L,503L,617L,631L,641L,647L,653L,673L,701L,773L,787L,797L,809L,829L,853L,857L,911L,929L,953L,977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231474Inst : IEnumerable<long>
{
public static readonly long[] Value=A231474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231474.Bytes);
public long this[int i]=>Value[i];

public static A231474Inst Instance=new A231474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231475
{
public static readonly long[] Value={ 4L,3L,4L,3L,4L,1L,4L,3L,4L,3L,4L,1L,4L,3L,4L,3L,4L,1L,4L,3L,4L,3L,4L,1L,4L,3L,4L,3L,4L,1L,4L,3L,4L,3L,4L,1L,4L,3L,4L,3L,4L,1L,4L,3L,4L,3L,4L,1L,4L,3L,4L,3L,4L,1L,4L,3L,4L,3L,4L,1L,4L,3L,4L,3L,4L,1L,4L,3L,4L,3L,4L,1L,4L,3L,4L,3L,4L,1L,4L,3L,4L,3L,4L,1L,4L,3L,4L,3L,4L,1L,4L,3L,4L,3L,4L,1L,4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231475Inst : IEnumerable<long>
{
public static readonly long[] Value=A231475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231475.Bytes);
public long this[int i]=>Value[i];

public static A231475Inst Instance=new A231475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231476
{
public static readonly long[] Value={ 2L,7L,13L,19L,31L,151L,163L,211L,223L,229L,241L,271L,349L,367L,439L,601L,607L,613L,631L,643L,673L,727L,733L,859L,907L,937L,997L,1021L,1033L,1039L,1051L,1093L,1117L,1123L,1129L,1153L,1321L,1327L,1399L,1423L,1429L,1609L,1627L,1657L,1669L,1741L,1747L,1759L,1777L,1789L,1831L,1867L,1933L,1951L,1993L,1999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231476Inst : IEnumerable<long>
{
public static readonly long[] Value=A231476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231476.Bytes);
public long this[int i]=>Value[i];

public static A231476Inst Instance=new A231476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231477
{
public static readonly long[] Value={ 2L,3L,23L,41L,47L,53L,61L,67L,71L,89L,113L,127L,131L,137L,191L,193L,223L,251L,269L,283L,293L,311L,353L,397L,409L,421L,443L,463L,491L,503L,509L,541L,569L,601L,613L,701L,773L,787L,983L,1013L,1031L,1091L,1117L,1213L,1223L,1429L,1499L,1543L,1549L,1579L,1619L,1621L,1697L,1699L,1733L,1873L,1933L,1949L,1951L,1973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231477Inst : IEnumerable<long>
{
public static readonly long[] Value=A231477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231477.Bytes);
public long this[int i]=>Value[i];

public static A231477Inst Instance=new A231477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231478
{
public static readonly long[] Value={ 2L,7L,13L,31L,37L,43L,67L,73L,97L,193L,283L,307L,379L,457L,487L,499L,577L,619L,643L,727L,733L,757L,829L,1297L,1321L,1429L,1447L,1609L,1669L,1693L,2011L,2083L,2137L,2251L,2269L,2347L,2539L,2803L,2857L,2953L,2971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231478Inst : IEnumerable<long>
{
public static readonly long[] Value=A231478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231478.Bytes);
public long this[int i]=>Value[i];

public static A231478Inst Instance=new A231478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231479
{
public static readonly long[] Value={ 2L,3L,5L,11L,19L,23L,29L,37L,47L,67L,71L,89L,103L,107L,113L,127L,137L,163L,179L,239L,257L,313L,337L,347L,389L,401L,431L,457L,463L,499L,523L,547L,569L,571L,617L,709L,719L,739L,743L,751L,757L,761L,821L,823L,859L,883L,887L,971L,1019L,1069L,1093L,1129L,1153L,1213L,1297L,1307L,1327L,1367L,1373L,1381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231479Inst : IEnumerable<long>
{
public static readonly long[] Value=A231479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231479.Bytes);
public long this[int i]=>Value[i];

public static A231479Inst Instance=new A231479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231480
{
public static readonly long[] Value={ 2L,3L,5L,7L,17L,37L,53L,79L,89L,109L,127L,223L,263L,277L,367L,389L,433L,439L,457L,479L,521L,541L,577L,593L,709L,727L,757L,911L,953L,967L,983L,1061L,1097L,1117L,1151L,1153L,1297L,1447L,1567L,1583L,1601L,1637L,1693L,1709L,1801L,1879L,1933L,1951L,2017L,2069L,2081L,2213L,2269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231480Inst : IEnumerable<long>
{
public static readonly long[] Value=A231480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231480.Bytes);
public long this[int i]=>Value[i];

public static A231480Inst Instance=new A231480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231481
{
public static readonly long[] Value={ 2L,3L,5L,13L,17L,29L,59L,67L,71L,73L,97L,127L,191L,199L,223L,227L,239L,307L,337L,349L,353L,367L,409L,421L,433L,449L,461L,479L,487L,491L,563L,571L,577L,619L,647L,683L,739L,743L,811L,823L,829L,857L,881L,911L,937L,941L,991L,1021L,1051L,1091L,1103L,1117L,1163L,1201L,1217L,1259L,1277L,1289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231481Inst : IEnumerable<long>
{
public static readonly long[] Value=A231481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231481.Bytes);
public long this[int i]=>Value[i];

public static A231481Inst Instance=new A231481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231482
{
public static readonly long[] Value={ 1L,6L,39L,284L,2205L,17730L,145635L,1213560L,10218105L,86717630L,740526303L,6355522068L,54771976597L,473667151482L,4108390253595L,35725327438320L,311346430241265L,2718678371881590L,23780515097337495L,208330621395422220L,1827615453799100301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231482Inst : IEnumerable<long>
{
public static readonly long[] Value=A231482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231482.Bytes);
public long this[int i]=>Value[i];

public static A231482Inst Instance=new A231482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231483
{
public static readonly long[] Value={ 9L,8L,15L,18L,7L,12L,15L,10L,15L,18L,7L,28L,15L,10L,27L,12L,7L,24L,15L,8L,21L,18L,5L,30L,15L,8L,27L,24L,11L,18L,9L,10L,15L,30L,13L,18L,15L,10L,21L,30L,7L,42L,21L,10L,33L,18L,7L,30L,21L,10L,9L,18L,11L,30L,27L,8L,33L,24L,11L,48L,21L,8L,21L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231483Inst : IEnumerable<long>
{
public static readonly long[] Value=A231483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231483.Bytes);
public long this[int i]=>Value[i];

public static A231483Inst Instance=new A231483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231484
{
public static readonly long[] Value={ 1L,81L,1476326929L,10994571025L,61436066769L,98551417041L,119582481249L,141447449025L,220545762129L,388895668225L,619568914129L,890560253025L,970952066161L,2580138650961L,3076652813521L,3739640454225L,4138876942929L,4758545225281L,9262289646801L,26494089912081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231484Inst : IEnumerable<long>
{
public static readonly long[] Value=A231484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231484.Bytes);
public long this[int i]=>Value[i];

public static A231484Inst Instance=new A231484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231485
{
public static readonly BigInteger[] Value={ 722L,9922L,155682L,2540032L,41934482L,694861522L,11527389122L,191304901282L,3175220160032L,52703408458882L,874800747092322L,14520494659638322L,241020661471736882L,4000620276282860032L,BigInteger.Parse("66404949893677073282"),BigInteger.Parse("1102233473331064193122"),BigInteger.Parse("18295603728585969257522") };
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
public class A231485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231485Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231485.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A231485.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231485Inst Instance=new A231485Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231486
{
public static readonly long[] Value={ 1L,1L,7L,265L,38051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231486Inst : IEnumerable<long>
{
public static readonly long[] Value=A231486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231486.Bytes);
public long this[int i]=>Value[i];

public static A231486Inst Instance=new A231486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231487
{
public static readonly long[] Value={ 1L,1L,7L,221L,25789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231487Inst : IEnumerable<long>
{
public static readonly long[] Value=A231487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231487.Bytes);
public long this[int i]=>Value[i];

public static A231487Inst Instance=new A231487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231584
{
public static readonly BigInteger[] Value={ 144L,2776L,381076L,38768838L,2912579313L,260228939106L,24813120747919L,2275463989704521L,205616812796559119L,BigInteger.Parse("18796952266641265062"),BigInteger.Parse("1725445840621150550236"),BigInteger.Parse("157941351701793475474726") };
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
public class A231584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231584Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231584.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A231584.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231584Inst Instance=new A231584Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231585
{
public static readonly BigInteger[] Value={ 422L,12922L,5618444L,1453028265L,260228939106L,63676872069694L,16297132727558385L,3833026928529265733L,BigInteger.Parse("899070341715148291141"),BigInteger.Parse("216695260231841309307295"),BigInteger.Parse("52101389603112220215510578") };
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
public class A231585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231585Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231585.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A231585.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231585Inst Instance=new A231585Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231586
{
public static readonly long[] Value={ 4L,4L,4L,16L,28L,16L,50L,124L,124L,50L,144L,602L,2352L,602L,144L,422L,2776L,32650L,32650L,2776L,422L,1268L,12922L,381076L,1245468L,381076L,12922L,1268L,3823L,60720L,5618444L,38768838L,38768838L,5618444L,60720L,3823L,11472L,286047L,82479418L,1453028265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231586Inst : IEnumerable<long>
{
public static readonly long[] Value=A231586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231586.Bytes);
public long this[int i]=>Value[i];

public static A231586Inst Instance=new A231586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231587
{
public static readonly long[] Value={ 2L,4L,5L,6L,9L,11L,12L,13L,14L,15L,16L,19L,23L,24L,25L,29L,34L,37L,38L,42L,43L,48L,53L,54L,56L,57L,59L,60L,62L,63L,64L,67L,69L,73L,74L,75L,76L,77L,78L,79L,80L,81L,84L,85L,87L,88L,90L,91L,92L,95L,103L,104L,105L,107L,109L,111L,112L,113L,116L,118L,120L,122L,123L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231587Inst : IEnumerable<long>
{
public static readonly long[] Value=A231587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231587.Bytes);
public long this[int i]=>Value[i];

public static A231587Inst Instance=new A231587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231588
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,109L,173L,197L,307L,383L,593L,727L,739L,937L,2963L,4567L,4703L,5791L,7159L,8147L,9371L,10987L,15937L,19753L,37159L,52963L,53197L,58147L,71593L,72727L,73951L,76543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231588Inst : IEnumerable<long>
{
public static readonly long[] Value=A231588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231588.Bytes);
public long this[int i]=>Value[i];

public static A231588Inst Instance=new A231588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231589
{
public static readonly long[] Value={ 0L,0L,1L,1L,5L,5L,7L,6L,12L,20L,22L,19L,39L,35L,35L,28L,68L,60L,76L,65L,91L,99L,92L,74L,125L,156L,144L,147L,203L,175L,186L,152L,242L,272L,245L,201L,333L,323L,286L,270L,410L,392L,430L,363L,420L,437L,423L,340L,490L,550L,578L,585L,689L,639L,605L,546L,760L,812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231589Inst : IEnumerable<long>
{
public static readonly long[] Value=A231589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231589.Bytes);
public long this[int i]=>Value[i];

public static A231589Inst Instance=new A231589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231590
{
public static readonly long[] Value={ 0L,9L,78L,681L,6353L,59634L,570157L,5510645L,53680317L,525651276L,5166809159L,50931212973L,503152799893L,4979293536415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231590Inst : IEnumerable<long>
{
public static readonly long[] Value=A231590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231590.Bytes);
public long this[int i]=>Value[i];

public static A231590Inst Instance=new A231590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231591
{
public static readonly long[] Value={ 1L,3L,32L,391L,3906L,39572L,400626L,4047829L,40794211L,410514052L,4126066282L,41436122092L,415853103290L,4171375888398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231591Inst : IEnumerable<long>
{
public static readonly long[] Value=A231591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231591.Bytes);
public long this[int i]=>Value[i];

public static A231591Inst Instance=new A231591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231592
{
public static readonly long[] Value={ 1L,9L,75L,677L,6229L,58770L,564650L,5472472L,53396224L,523382007L,5148387363L,50778098799L,501864775685L,4968288427006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231592Inst : IEnumerable<long>
{
public static readonly long[] Value=A231592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231592.Bytes);
public long this[int i]=>Value[i];

public static A231592Inst Instance=new A231592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231593
{
public static readonly long[] Value={ 0L,3L,34L,360L,3772L,39006L,397474L,4022501L,40604951L,408986159L,4113511677L,41331763006L,414971464358L,4163826451096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231593Inst : IEnumerable<long>
{
public static readonly long[] Value=A231593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231593.Bytes);
public long this[int i]=>Value[i];

public static A231593Inst Instance=new A231593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231594
{
public static readonly long[] Value={ 1L,3L,33L,360L,3816L,38911L,396016L,4015732L,40543671L,408462140L,4109293287L,41296082801L,414669334188L,4161237526152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231594Inst : IEnumerable<long>
{
public static readonly long[] Value=A231594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231594.Bytes);
public long this[int i]=>Value[i];

public static A231594Inst Instance=new A231594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231595
{
public static readonly long[] Value={ 0L,2L,33L,369L,3741L,38714L,395621L,4007705L,40484195L,408035120L,4105718243L,41266320918L,414416274953L,4159068898063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231595Inst : IEnumerable<long>
{
public static readonly long[] Value=A231595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231595.Bytes);
public long this[int i]=>Value[i];

public static A231595Inst Instance=new A231595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231596
{
public static readonly long[] Value={ 1L,9L,78L,652L,6172L,58327L,560506L,5443074L,53152746L,521422184L,5132090751L,50642752951L,500714890907L,4958432528817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231596Inst : IEnumerable<long>
{
public static readonly long[] Value=A231596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231596.Bytes);
public long this[int i]=>Value[i];

public static A231596Inst Instance=new A231596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231597
{
public static readonly long[] Value={ 0L,2L,30L,351L,3690L,38541L,394398L,3998411L,40399778L,407316676L,4099892369L,41217744252L,414006129652L,4155543234392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231597Inst : IEnumerable<long>
{
public static readonly long[] Value=A231597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231597.Bytes);
public long this[int i]=>Value[i];

public static A231597Inst Instance=new A231597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231598
{
public static readonly long[] Value={ 0L,6L,67L,646L,6130L,58145L,558956L,5432190L,53071838L,520787464L,5127052380L,50599825547L,500350977737L,4955299345646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231598Inst : IEnumerable<long>
{
public static readonly long[] Value=A231598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231598.Bytes);
public long this[int i]=>Value[i];

public static A231598Inst Instance=new A231598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231599
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,-1L,0L,1L,1L,-1L,1L,-1L,-1L,0L,0L,2L,0L,0L,-1L,-1L,1L,1L,-1L,-1L,0L,0L,1L,1L,1L,-1L,-1L,-1L,0L,0L,1L,1L,-1L,1L,-1L,-1L,0L,0L,1L,0L,2L,0L,-1L,-1L,-1L,-1L,0L,2L,0L,1L,0L,0L,-1L,-1L,1L,1L,-1L,-1L,0L,0L,1L,0L,1L,1L,0L,-1L,-1L,-2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231599Inst : IEnumerable<long>
{
public static readonly long[] Value=A231599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231599.Bytes);
public long this[int i]=>Value[i];

public static A231599Inst Instance=new A231599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231664
{
public static readonly long[] Value={ 0L,1L,3L,6L,7L,9L,12L,16L,18L,21L,25L,30L,33L,37L,42L,48L,49L,51L,54L,58L,60L,63L,67L,72L,75L,79L,84L,90L,94L,99L,105L,112L,114L,117L,121L,126L,129L,133L,138L,144L,148L,153L,159L,166L,171L,177L,184L,192L,195L,199L,204L,210L,214L,219L,225L,232L,237L,243L,250L,258L,264L,271L,279L,288L,289L,291L,294L,298L,300L,303L,307L,312L,315L,319L,324L,330L,334L,339L,345L,352L,354L,357L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231664Inst : IEnumerable<long>
{
public static readonly long[] Value=A231664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231664.Bytes);
public long this[int i]=>Value[i];

public static A231664Inst Instance=new A231664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231665
{
public static readonly long[] Value={ 0L,1L,5L,14L,15L,19L,28L,44L,48L,57L,73L,98L,107L,123L,148L,184L,185L,189L,198L,214L,218L,227L,243L,268L,277L,293L,318L,354L,370L,395L,431L,480L,484L,493L,509L,534L,543L,559L,584L,620L,636L,661L,697L,746L,771L,807L,856L,920L,929L,945L,970L,1006L,1022L,1047L,1083L,1132L,1157L,1193L,1242L,1306L,1342L,1391L,1455L,1536L,1537L,1541L,1550L,1566L,1570L,1579L,1595L,1620L,1629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231665Inst : IEnumerable<long>
{
public static readonly long[] Value=A231665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231665.Bytes);
public long this[int i]=>Value[i];

public static A231665Inst Instance=new A231665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231666
{
public static readonly long[] Value={ 0L,1L,9L,36L,37L,45L,72L,136L,144L,171L,235L,360L,387L,451L,576L,792L,793L,801L,828L,892L,900L,927L,991L,1116L,1143L,1207L,1332L,1548L,1612L,1737L,1953L,2296L,2304L,2331L,2395L,2520L,2547L,2611L,2736L,2952L,3016L,3141L,3357L,3700L,3825L,4041L,4384L,4896L,4923L,4987L,5112L,5328L,5392L,5517L,5733L,6076L,6201L,6417L,6760L,7272L,7488L,7831L,8343L,9072L,9073L,9081L,9108L,9172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231666Inst : IEnumerable<long>
{
public static readonly long[] Value=A231666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231666.Bytes);
public long this[int i]=>Value[i];

public static A231666Inst Instance=new A231666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231667
{
public static readonly long[] Value={ 0L,1L,17L,98L,99L,115L,196L,452L,468L,549L,805L,1430L,1511L,1767L,2392L,3688L,3689L,3705L,3786L,4042L,4058L,4139L,4395L,5020L,5101L,5357L,5982L,7278L,7534L,8159L,9455L,11856L,11872L,11953L,12209L,12834L,12915L,13171L,13796L,15092L,15348L,15973L,17269L,19670L,20295L,21591L,23992L,28088L,28169L,28425L,29050L,30346L,30602L,31227L,32523L,34924L,35549L,36845L,39246L,43342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231667Inst : IEnumerable<long>
{
public static readonly long[] Value=A231667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231667.Bytes);
public long this[int i]=>Value[i];

public static A231667Inst Instance=new A231667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231668
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,11L,13L,16L,20L,25L,27L,30L,34L,39L,45L,48L,52L,57L,63L,70L,74L,79L,85L,92L,100L,101L,103L,106L,110L,115L,117L,120L,124L,129L,135L,138L,142L,147L,153L,160L,164L,169L,175L,182L,190L,195L,201L,208L,216L,225L,227L,230L,234L,239L,245L,248L,252L,257L,263L,270L,274L,279L,285L,292L,300L,305L,311L,318L,326L,335L,341L,348L,356L,365L,375L,378L,382L,387L,393L,400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231668Inst : IEnumerable<long>
{
public static readonly long[] Value=A231668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231668.Bytes);
public long this[int i]=>Value[i];

public static A231668Inst Instance=new A231668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231669
{
public static readonly long[] Value={ 0L,1L,5L,14L,30L,31L,35L,44L,60L,85L,89L,98L,114L,139L,175L,184L,200L,225L,261L,310L,326L,351L,387L,436L,500L,501L,505L,514L,530L,555L,559L,568L,584L,609L,645L,654L,670L,695L,731L,780L,796L,821L,857L,906L,970L,995L,1031L,1080L,1144L,1225L,1229L,1238L,1254L,1279L,1315L,1324L,1340L,1365L,1401L,1450L,1466L,1491L,1527L,1576L,1640L,1665L,1701L,1750L,1814L,1895L,1931L,1980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231669Inst : IEnumerable<long>
{
public static readonly long[] Value=A231669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231669.Bytes);
public long this[int i]=>Value[i];

public static A231669Inst Instance=new A231669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231670
{
public static readonly long[] Value={ 0L,1L,9L,36L,100L,101L,109L,136L,200L,325L,333L,360L,424L,549L,765L,792L,856L,981L,1197L,1540L,1604L,1729L,1945L,2288L,2800L,2801L,2809L,2836L,2900L,3025L,3033L,3060L,3124L,3249L,3465L,3492L,3556L,3681L,3897L,4240L,4304L,4429L,4645L,4988L,5500L,5625L,5841L,6184L,6696L,7425L,7433L,7460L,7524L,7649L,7865L,7892L,7956L,8081L,8297L,8640L,8704L,8829L,9045L,9388L,9900L,10025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231670Inst : IEnumerable<long>
{
public static readonly long[] Value=A231670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231670.Bytes);
public long this[int i]=>Value[i];

public static A231670Inst Instance=new A231670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231671
{
public static readonly long[] Value={ 0L,1L,17L,98L,354L,355L,371L,452L,708L,1333L,1349L,1430L,1686L,2311L,3607L,3688L,3944L,4569L,5865L,8266L,8522L,9147L,10443L,12844L,16940L,16941L,16957L,17038L,17294L,17919L,17935L,18016L,18272L,18897L,20193L,20274L,20530L,21155L,22451L,24852L,25108L,25733L,27029L,29430L,33526L,34151L,35447L,37848L,41944L,48505L,48521L,48602L,48858L,49483L,50779L,50860L,51116L,51741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231671Inst : IEnumerable<long>
{
public static readonly long[] Value=A231671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231671.Bytes);
public long this[int i]=>Value[i];

public static A231671Inst Instance=new A231671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231672
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,15L,16L,18L,21L,25L,30L,36L,38L,41L,45L,50L,56L,63L,66L,70L,75L,81L,88L,96L,100L,105L,111L,118L,126L,135L,140L,146L,153L,161L,170L,180L,181L,183L,186L,190L,195L,201L,203L,206L,210L,215L,221L,228L,231L,235L,240L,246L,253L,261L,265L,270L,276L,283L,291L,300L,305L,311L,318L,326L,335L,345L,351L,358L,366L,375L,385L,396L,398L,401L,405L,410L,416L,423L,426L,430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231672Inst : IEnumerable<long>
{
public static readonly long[] Value=A231672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231672.Bytes);
public long this[int i]=>Value[i];

public static A231672Inst Instance=new A231672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231673
{
public static readonly long[] Value={ 0L,1L,5L,14L,30L,55L,56L,60L,69L,85L,110L,146L,150L,159L,175L,200L,236L,285L,294L,310L,335L,371L,420L,484L,500L,525L,561L,610L,674L,755L,780L,816L,865L,929L,1010L,1110L,1111L,1115L,1124L,1140L,1165L,1201L,1205L,1214L,1230L,1255L,1291L,1340L,1349L,1365L,1390L,1426L,1475L,1539L,1555L,1580L,1616L,1665L,1729L,1810L,1835L,1871L,1920L,1984L,2065L,2165L,2201L,2250L,2314L,2395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231673Inst : IEnumerable<long>
{
public static readonly long[] Value=A231673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231673.Bytes);
public long this[int i]=>Value[i];

public static A231673Inst Instance=new A231673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231674
{
public static readonly long[] Value={ 0L,1L,9L,36L,100L,225L,226L,234L,261L,325L,450L,666L,674L,701L,765L,890L,1106L,1449L,1476L,1540L,1665L,1881L,2224L,2736L,2800L,2925L,3141L,3484L,3996L,4725L,4850L,5066L,5409L,5921L,6650L,7650L,7651L,7659L,7686L,7750L,7875L,8091L,8099L,8126L,8190L,8315L,8531L,8874L,8901L,8965L,9090L,9306L,9649L,10161L,10225L,10350L,10566L,10909L,11421L,12150L,12275L,12491L,12834L,13346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231674Inst : IEnumerable<long>
{
public static readonly long[] Value=A231674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231674.Bytes);
public long this[int i]=>Value[i];

public static A231674Inst Instance=new A231674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231675
{
public static readonly long[] Value={ 0L,1L,17L,98L,354L,979L,980L,996L,1077L,1333L,1958L,3254L,3270L,3351L,3607L,4232L,5528L,7929L,8010L,8266L,8891L,10187L,12588L,16684L,16940L,17565L,18861L,21262L,25358L,31919L,32544L,33840L,36241L,40337L,46898L,56898L,56899L,56915L,56996L,57252L,57877L,59173L,59189L,59270L,59526L,60151L,61447L,63848L,63929L,64185L,64810L,66106L,68507L,72603L,72859L,73484L,74780L,77181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231675Inst : IEnumerable<long>
{
public static readonly long[] Value=A231675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231675.Bytes);
public long this[int i]=>Value[i];

public static A231675Inst Instance=new A231675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231676
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,15L,21L,22L,24L,27L,31L,36L,42L,49L,51L,54L,58L,63L,69L,76L,84L,87L,91L,96L,102L,109L,117L,126L,130L,135L,141L,148L,156L,165L,175L,180L,186L,193L,201L,210L,220L,231L,237L,244L,252L,261L,271L,282L,294L,295L,297L,300L,304L,309L,315L,322L,324L,327L,331L,336L,342L,349L,357L,360L,364L,369L,375L,382L,390L,399L,403L,408L,414L,421L,429L,438L,448L,453L,459L,466L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231676Inst : IEnumerable<long>
{
public static readonly long[] Value=A231676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231676.Bytes);
public long this[int i]=>Value[i];

public static A231676Inst Instance=new A231676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231677
{
public static readonly long[] Value={ 0L,1L,5L,14L,30L,55L,91L,92L,96L,105L,121L,146L,182L,231L,235L,244L,260L,285L,321L,370L,434L,443L,459L,484L,520L,569L,633L,714L,730L,755L,791L,840L,904L,985L,1085L,1110L,1146L,1195L,1259L,1340L,1440L,1561L,1597L,1646L,1710L,1791L,1891L,2012L,2156L,2157L,2161L,2170L,2186L,2211L,2247L,2296L,2300L,2309L,2325L,2350L,2386L,2435L,2499L,2508L,2524L,2549L,2585L,2634L,2698L,2779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231677Inst : IEnumerable<long>
{
public static readonly long[] Value=A231677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231677.Bytes);
public long this[int i]=>Value[i];

public static A231677Inst Instance=new A231677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231678
{
public static readonly long[] Value={ 0L,1L,9L,36L,100L,225L,441L,442L,450L,477L,541L,666L,882L,1225L,1233L,1260L,1324L,1449L,1665L,2008L,2520L,2547L,2611L,2736L,2952L,3295L,3807L,4536L,4600L,4725L,4941L,5284L,5796L,6525L,7525L,7650L,7866L,8209L,8721L,9450L,10450L,11781L,11997L,12340L,12852L,13581L,14581L,15912L,17640L,17641L,17649L,17676L,17740L,17865L,18081L,18424L,18432L,18459L,18523L,18648L,18864L,19207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231678Inst : IEnumerable<long>
{
public static readonly long[] Value=A231678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231678.Bytes);
public long this[int i]=>Value[i];

public static A231678Inst Instance=new A231678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231679
{
public static readonly long[] Value={ 0L,1L,17L,98L,354L,979L,2275L,2276L,2292L,2373L,2629L,3254L,4550L,6951L,6967L,7048L,7304L,7929L,9225L,11626L,15722L,15803L,16059L,16684L,17980L,20381L,24477L,31038L,31294L,31919L,33215L,35616L,39712L,46273L,56273L,56898L,58194L,60595L,64691L,71252L,81252L,95893L,97189L,99590L,103686L,110247L,120247L,134888L,155624L,155625L,155641L,155722L,155978L,156603L,157899L,160300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231679Inst : IEnumerable<long>
{
public static readonly long[] Value=A231679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231679.Bytes);
public long this[int i]=>Value[i];

public static A231679Inst Instance=new A231679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231728
{
public static readonly long[] Value={ 1L,0L,1L,2L,2L,3L,0L,1L,3L,4L,7L,4L,5L,0L,1L,5L,10L,19L,16L,16L,6L,7L,0L,1L,8L,20L,42L,48L,55L,36L,29L,8L,9L,0L,1L,13L,40L,94L,132L,164L,138L,119L,64L,46L,10L,11L,0L,1L,21L,76L,197L,324L,451L,464L,439L,304L,219L,100L,67L,12L,13L,0L,1L,34L,142L,405L,760L,1170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231728Inst : IEnumerable<long>
{
public static readonly long[] Value=A231728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231728.Bytes);
public long this[int i]=>Value[i];

public static A231728Inst Instance=new A231728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231729
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,4L,5L,3L,1L,1L,3L,7L,11L,11L,9L,5L,1L,1L,5L,15L,29L,35L,32L,22L,13L,7L,1L,1L,8L,28L,62L,90L,103L,91L,65L,37L,17L,9L,1L,1L,13L,53L,134L,226L,296L,302L,257L,183L,110L,56L,21L,11L,1L,1L,21L,97L,273L,521L,775L,915L,903L,743L,523L,319L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231729Inst : IEnumerable<long>
{
public static readonly long[] Value=A231729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231729.Bytes);
public long this[int i]=>Value[i];

public static A231729Inst Instance=new A231729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231730
{
public static readonly long[] Value={ 1L,2L,5L,4L,4L,9L,22L,12L,8L,29L,56L,72L,32L,16L,65L,202L,232L,208L,80L,32L,181L,556L,924L,800L,560L,192L,64L,441L,1726L,2964L,3480L,2480L,1440L,448L,128L,1165L,4832L,10112L,12608L,11680L,7168L,3584L,1024L,256L,2929L,14066L,31632L,46752L,46816L,36288L,19712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231730Inst : IEnumerable<long>
{
public static readonly long[] Value=A231730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231730.Bytes);
public long this[int i]=>Value[i];

public static A231730Inst Instance=new A231730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231731
{
public static readonly long[] Value={ 1L,2L,2L,4L,4L,3L,10L,12L,8L,5L,20L,36L,32L,16L,8L,40L,88L,112L,80L,32L,13L,76L,204L,320L,320L,192L,64L,21L,142L,444L,840L,1040L,864L,448L,128L,34L,260L,932L,2048L,3040L,3136L,2240L,1024L,256L,55L,470L,1896L,4752L,8176L,10080L,8960L,5632L,2304L,512L,89L,840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231731Inst : IEnumerable<long>
{
public static readonly long[] Value=A231731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231731.Bytes);
public long this[int i]=>Value[i];

public static A231731Inst Instance=new A231731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231732
{
public static readonly long[] Value={ 2L,1L,5L,6L,2L,12L,22L,14L,3L,29L,72L,69L,30L,5L,70L,219L,280L,182L,60L,8L,169L,638L,1021L,884L,436L,116L,13L,408L,1804L,3468L,3750L,2460L,978L,218L,21L,985L,4992L,11206L,14532L,11895L,6288L,2095L,402L,34L,2378L,13589L,34888L,52760L,51750L,34119L,15112L,4334L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231732Inst : IEnumerable<long>
{
public static readonly long[] Value=A231732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231732.Bytes);
public long this[int i]=>Value[i];

public static A231732Inst Instance=new A231732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231733
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,5L,11L,8L,2L,12L,34L,36L,17L,3L,29L,101L,141L,99L,35L,5L,70L,289L,499L,462L,242L,68L,8L,169L,807L,1659L,1905L,1320L,552L,129L,13L,408L,2212L,5272L,7218L,6210L,3438L,1196L,239L,21L,985L,5977L,16198L,25738L,26427L,18183L,8383L,2497L,436L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231733Inst : IEnumerable<long>
{
public static readonly long[] Value=A231733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231733.Bytes);
public long this[int i]=>Value[i];

public static A231733Inst Instance=new A231733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231734
{
public static readonly long[] Value={ 2L,2L,1L,1L,2L,1L,6L,1L,0L,3L,2L,1L,6L,1L,2L,0L,2L,1L,6L,1L,2L,3L,4L,1L,0L,2L,2L,3L,4L,1L,12L,1L,2L,6L,2L,0L,18L,1L,14L,3L,2L,1L,18L,1L,2L,27L,4L,1L,0L,2L,10L,3L,2L,1L,6L,2L,2L,3L,20L,1L,12L,1L,2L,0L,4L,2L,6L,1L,4L,9L,2L,1L,30L,1L,6L,3L,2L,2L,6L,1L,0L,12L,2L,1L,12L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231734Inst : IEnumerable<long>
{
public static readonly long[] Value=A231734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231734.Bytes);
public long this[int i]=>Value[i];

public static A231734Inst Instance=new A231734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231735
{
public static readonly long[] Value={ 2L,2L,1L,1L,2L,1L,1128L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231735Inst : IEnumerable<long>
{
public static readonly long[] Value=A231735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231735.Bytes);
public long this[int i]=>Value[i];

public static A231735Inst Instance=new A231735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231736
{
public static readonly long[] Value={ 3L,5L,9L,6L,2L,7L,4L,9L,9L,9L,7L,2L,9L,1L,5L,8L,1L,9L,8L,0L,8L,6L,0L,0L,1L,7L,5L,1L,6L,4L,6L,3L,6L,0L,3L,8L,1L,3L,6L,9L,1L,7L,9L,2L,8L,9L,7L,5L,3L,8L,7L,7L,2L,3L,0L,4L,9L,7L,2L,4L,4L,1L,2L,0L,8L,2L,0L,9L,5L,9L,5L,5L,6L,5L,4L,3L,7L,1L,6L,8L,2L,8L,3L,9L,7L,4L,6L,8L,9L,9L,6L,2L,4L,0L,7L,2L,5L,2L,2L,5L,2L,1L,6L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231736Inst : IEnumerable<long>
{
public static readonly long[] Value=A231736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231736.Bytes);
public long this[int i]=>Value[i];

public static A231736Inst Instance=new A231736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231737
{
public static readonly long[] Value={ 3L,6L,4L,3L,7L,8L,8L,3L,9L,6L,7L,5L,9L,0L,6L,2L,5L,7L,0L,4L,9L,5L,8L,7L,7L,3L,0L,3L,1L,6L,1L,6L,2L,4L,1L,3L,8L,9L,1L,7L,0L,7L,0L,3L,9L,0L,9L,8L,6L,0L,5L,5L,5L,0L,4L,7L,4L,6L,6L,9L,2L,1L,8L,6L,1L,0L,7L,9L,8L,1L,7L,6L,7L,5L,3L,7L,1L,3L,1L,5L,2L,9L,7L,2L,5L,8L,5L,9L,9L,3L,8L,2L,5L,2L,0L,1L,8L,5L,4L,0L,0L,6L,9L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231737Inst : IEnumerable<long>
{
public static readonly long[] Value=A231737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231737.Bytes);
public long this[int i]=>Value[i];

public static A231737Inst Instance=new A231737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231738
{
public static readonly long[] Value={ 6L,5L,6L,3L,0L,9L,6L,3L,9L,0L,2L,0L,2L,0L,4L,7L,0L,7L,4L,9L,3L,8L,3L,4L,5L,2L,1L,5L,4L,0L,0L,5L,3L,9L,9L,6L,0L,2L,6L,2L,4L,1L,9L,4L,1L,0L,0L,0L,6L,4L,5L,8L,1L,8L,6L,5L,8L,7L,3L,2L,9L,4L,7L,6L,8L,3L,6L,1L,7L,7L,3L,6L,6L,5L,5L,5L,0L,1L,3L,7L,3L,1L,1L,5L,1L,8L,4L,5L,6L,4L,6L,6L,4L,3L,9L,6L,6L,4L,0L,5L,4L,5L,5L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231738Inst : IEnumerable<long>
{
public static readonly long[] Value=A231738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231738.Bytes);
public long this[int i]=>Value[i];

public static A231738Inst Instance=new A231738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231739
{
public static readonly long[] Value={ 2775L,11100L,24975L,34125L,44400L,69375L,99900L,135975L,136500L,177600L,224775L,277500L,307125L,335775L,399600L,468975L,543900L,546000L,624375L,710400L,801975L,853125L,899100L,1001775L,1110000L,1223775L,1228500L,1343100L,1467975L,1598400L,1672125L,1734375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231739Inst : IEnumerable<long>
{
public static readonly long[] Value=A231739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231739.Bytes);
public long this[int i]=>Value[i];

public static A231739Inst Instance=new A231739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231740
{
public static readonly long[] Value={ 672L,2688L,6048L,10752L,15435L,16800L,19250L,24192L,32928L,37730L,43008L,54432L,56133L,61740L,67200L,77000L,81312L,96768L,113568L,131712L,138915L,150920L,151200L,172032L,173250L,194208L,217728L,221130L,224532L,242592L,246960L,268800L,296352L,308000L,325248L,339570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231740Inst : IEnumerable<long>
{
public static readonly long[] Value=A231740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231740.Bytes);
public long this[int i]=>Value[i];

public static A231740Inst Instance=new A231740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231741
{
public static readonly long[] Value={ 4L,84L,318L,1328L,6064L,26918L,116909L,511264L,2248196L,9868600L,43259517L,189716276L,832295019L,3650903623L,16013507645L,70240174360L,308101760364L,1351448959786L,5927927566218L,26002016887928L,114054342072628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231741Inst : IEnumerable<long>
{
public static readonly long[] Value=A231741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231741.Bytes);
public long this[int i]=>Value[i];

public static A231741Inst Instance=new A231741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231742
{
public static readonly long[] Value={ 16L,318L,4430L,60806L,784076L,9945132L,126926437L,1625269595L,20795246129L,265933115701L,3401419933047L,43511214955897L,556577494538011L,7119285135911590L,91064607669052460L,1164839484230300582L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231742Inst : IEnumerable<long>
{
public static readonly long[] Value=A231742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231742.Bytes);
public long this[int i]=>Value[i];

public static A231742Inst Instance=new A231742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231743
{
public static readonly BigInteger[] Value={ 50L,1328L,60806L,2154900L,71742015L,2426463539L,82701946547L,2814528154294L,95747933760688L,3259127333943936L,110951853201769471L,3776779941421524009L,BigInteger.Parse("128555070606110236059"),BigInteger.Parse("4375838168986252858545"),BigInteger.Parse("148948822494411349242405") };
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
public class A231743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231743Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231743.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A231743.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231743Inst Instance=new A231743Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231808
{
public static readonly long[] Value={ 0L,1L,2L,2L,67L,67L,230L,230L,5317L,70307L,70307L,70307L,70307L,70307L,23158993L,58560723101L,10373287618037L,10373287618037L,10373287618037L,736719736564627L,736719736564627L,736719736564627L,119433196256360189L,1970856524120023L,1970856524120023L,1970856524120023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231808Inst : IEnumerable<long>
{
public static readonly long[] Value=A231808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231808.Bytes);
public long this[int i]=>Value[i];

public static A231808Inst Instance=new A231808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231809
{
public static readonly long[] Value={ 1L,3L,5L,5L,165L,165L,561L,561L,12903L,170085L,170085L,170085L,170085L,170085L,55957965L,141368472245L,25022219587365L,25022219587365L,25022219587365L,1776577590702915L,1776577590702915L,1776577590702915L,287890168626762845L,4749253940274679L,4749253940274679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231809Inst : IEnumerable<long>
{
public static readonly long[] Value=A231809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231809.Bytes);
public long this[int i]=>Value[i];

public static A231809Inst Instance=new A231809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231810
{
public static readonly long[] Value={ 1L,5L,7L,11L,13L,17L,19L,23L,25L,29L,31L,37L,41L,43L,47L,49L,53L,59L,61L,65L,67L,71L,73L,79L,83L,85L,89L,91L,97L,101L,103L,107L,109L,113L,121L,125L,127L,131L,133L,137L,139L,145L,149L,151L,157L,163L,167L,169L,173L,179L,181L,185L,187L,191L,193L,197L,199L,205L,211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231810Inst : IEnumerable<long>
{
public static readonly long[] Value=A231810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231810.Bytes);
public long this[int i]=>Value[i];

public static A231810Inst Instance=new A231810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231811
{
public static readonly long[] Value={ 1L,2L,3L,4L,8L,9L,15L,16L,27L,32L,35L,64L,75L,81L,99L,128L,135L,243L,255L,256L,375L,455L,512L,539L,675L,729L,783L,875L,1024L,1089L,1215L,1295L,1715L,1859L,1875L,2048L,2115L,2187L,2375L,2703L,2975L,3375L,3519L,4096L,4335L,4355L,5375L,5915L,6075L,6479L,6561L,6723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231811Inst : IEnumerable<long>
{
public static readonly long[] Value=A231811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231811.Bytes);
public long this[int i]=>Value[i];

public static A231811Inst Instance=new A231811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231812
{
public static readonly BigInteger[] Value={ 1L,1L,4L,9L,64L,125L,2826L,5047L,218688L,504009L,32216950L,39916811L,7585223196L,6227020813L,2424646536326L,1813027195995L,1072898135852416L,355687428096017L,616925243565037854L,121645100408832019L,BigInteger.Parse("441395941479128984940"),BigInteger.Parse("72313131901887676821") };
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
public class A231812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231812Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231812.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A231812.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231812Inst Instance=new A231812Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231813
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,2L,1L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,1L,2L,3L,2L,2L,1L,2L,3L,2L,1L,2L,1L,2L,2L,3L,1L,2L,1L,2L,3L,2L,1L,2L,3L,2L,2L,2L,1L,2L,1L,2L,2L,1L,2L,2L,1L,3L,3L,2L,1L,2L,1L,3L,2L,2L,2L,2L,1L,2L,1L,4L,1L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231813Inst : IEnumerable<long>
{
public static readonly long[] Value=A231813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231813.Bytes);
public long this[int i]=>Value[i];

public static A231813Inst Instance=new A231813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231814
{
public static readonly long[] Value={ 6L,15L,30L,91L,703L,1891L,2701L,12403L,18721L,38503L,49141L,51319L,79003L,88831L,104653L,146611L,188191L,218791L,226801L,269011L,286903L,385003L,497503L,597871L,665281L,721801L,736291L,765703L,873181L,954271L,1056331L,1314631L,1373653L,1537381L,1755001L,1869211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231814Inst : IEnumerable<long>
{
public static readonly long[] Value=A231814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231814.Bytes);
public long this[int i]=>Value[i];

public static A231814Inst Instance=new A231814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231815
{
public static readonly long[] Value={ 30L,51319L,3882139L,289022911L,674910259L,991523479L,1893583519L,4550912389L,9761467669L,16721570539L,28685399311L,72886214809L,77372307511L,82720376839L,98685849571L,173850108931L,220038912319L,229352039821L,240313142749L,257401051861L,428178002569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231815Inst : IEnumerable<long>
{
public static readonly long[] Value=A231815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231815.Bytes);
public long this[int i]=>Value[i];

public static A231815Inst Instance=new A231815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231816
{
public static readonly BigInteger[] Value={ 2L,6L,30L,351137972965951L,8596208716179446431L,BigInteger.Parse("698211042943963834650959743951"),BigInteger.Parse("744014385572130806167897354113929551"),BigInteger.Parse("901203402294977554329263775346819632824908852456695769189267773301") };
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
public class A231816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231816Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231816.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A231816.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231816Inst Instance=new A231816Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231817
{
public static readonly long[] Value={ 1L,2L,3L,8L,5L,8L,7L,8L,4L,0L,1L,6L,3L,0L,5L,0L,7L,0L,9L,0L,8L,8L,6L,8L,0L,4L,6L,0L,8L,0L,3L,0L,4L,6L,0L,0L,2L,8L,8L,0L,4L,0L,2L,0L,0L,6L,6L,0L,0L,0L,0L,0L,5L,0L,0L,0L,0L,0L,0L,0L,6L,4L,0L,0L,0L,0L,8L,0L,2L,0L,7L,0L,2L,8L,0L,0L,8L,0L,8L,0L,0L,6L,8L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231817Inst : IEnumerable<long>
{
public static readonly long[] Value=A231817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231817.Bytes);
public long this[int i]=>Value[i];

public static A231817Inst Instance=new A231817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231818
{
public static readonly long[] Value={ 3L,1L,2L,5L,6L,3L,6L,39L,18L,6L,12L,19L,8L,23L,10L,3L,76L,13L,90L,26L,52L,45L,124L,12L,60L,27L,10L,99L,126L,11L,50L,27L,28L,59L,6L,80L,122L,71L,110L,21L,72L,111L,590L,147L,178L,84L,238L,12L,138L,236L,10L,53L,6L,60L,98L,72L,620L,30L,166L,5L,98L,18L,22L,384L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231818Inst : IEnumerable<long>
{
public static readonly long[] Value=A231818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231818.Bytes);
public long this[int i]=>Value[i];

public static A231818Inst Instance=new A231818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231819
{
public static readonly long[] Value={ 3L,1L,2L,2L,6L,2L,2L,2L,8L,2L,2L,3L,2L,3L,2L,5L,2L,2L,8L,5L,2L,2L,8L,2L,2L,3L,6L,2L,12L,3L,8L,5L,10L,2L,6L,2L,12L,2L,2L,3L,2L,2L,2L,3L,2L,2L,18L,3L,2L,2L,8L,2L,20L,3L,6L,2L,18L,3L,2L,3L,12L,2L,2L,2L,6L,7L,8L,6L,2L,3L,14L,3L,2L,3L,6L,2L,6L,3L,8L,2L,2L,5L,6L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231819Inst : IEnumerable<long>
{
public static readonly long[] Value=A231819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231819.Bytes);
public long this[int i]=>Value[i];

public static A231819Inst Instance=new A231819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231820
{
public static readonly long[] Value={ 3L,2L,1L,1L,3L,1L,2L,1L,2L,2L,4L,1L,4L,1L,2L,2L,3L,1L,2L,1L,2L,2L,3L,1L,3L,5L,2L,3L,3L,1L,2L,1L,3L,2L,4L,2L,2L,1L,3L,2L,4L,1L,3L,1L,2L,4L,3L,1L,2L,6L,2L,2L,3L,1L,2L,5L,2L,3L,3L,1L,10L,1L,4L,2L,3L,2L,3L,1L,2L,2L,7L,1L,8L,1L,2L,2L,3L,3L,2L,1L,5L,2L,8L,1L,3L,4L,2L,4L,15L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231820Inst : IEnumerable<long>
{
public static readonly long[] Value=A231820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231820.Bytes);
public long this[int i]=>Value[i];

public static A231820Inst Instance=new A231820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231821
{
public static readonly long[] Value={ 4L,2L,2L,3L,2L,4L,2L,3L,3L,4L,2L,3L,2L,4L,4L,3L,2L,3L,2L,3L,4L,4L,2L,3L,3L,4L,3L,3L,2L,2L,2L,3L,4L,4L,4L,3L,2L,4L,4L,3L,2L,2L,2L,3L,3L,4L,2L,3L,3L,3L,4L,3L,2L,3L,4L,3L,4L,4L,2L,3L,2L,4L,3L,3L,4L,2L,2L,3L,4L,2L,2L,3L,2L,4L,3L,3L,4L,2L,2L,3L,3L,4L,2L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231821Inst : IEnumerable<long>
{
public static readonly long[] Value=A231821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231821.Bytes);
public long this[int i]=>Value[i];

public static A231821Inst Instance=new A231821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231822
{
public static readonly long[] Value={ 1L,9L,64L,439L,2992L,20382L,138852L,945923L,6444056L,43899870L,299066137L,2037376372L,13879547189L,94553875250L,644144597665L,4388210021417L,29894510123024L,203655187692590L,1387393046555052L,9451561177738998L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231822Inst : IEnumerable<long>
{
public static readonly long[] Value=A231822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231822.Bytes);
public long this[int i]=>Value[i];

public static A231822Inst Instance=new A231822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231823
{
public static readonly BigInteger[] Value={ 3L,64L,1205L,21770L,393408L,7103846L,128269829L,2316065437L,41819317551L,755097522661L,13634184224634L,246181419676326L,4445098469972866L,80261542222378463L,1449217650304070918L,BigInteger.Parse("26167349141400257966") };
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
public class A231823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231823Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231823.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A231823.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231823Inst Instance=new A231823Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231888
{
public static readonly long[] Value={ 0L,7L,26L,57L,190L,646L,1914L,5960L,18824L,58248L,181196L,565328L,1759720L,5477376L,17062956L,53131824L,165443096L,515219344L,1604410136L,4996129756L,15558217340L,48448930636L,150871392396L,469819443204L,1463035474136L,4555944690588L,14187380873768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231888Inst : IEnumerable<long>
{
public static readonly long[] Value=A231888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231888.Bytes);
public long this[int i]=>Value[i];

public static A231888Inst Instance=new A231888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231889
{
public static readonly long[] Value={ 0L,10L,101L,100L,1L,1001L,111L,1010L,1000L,11L,10000L,110L,1011L,10001L,1101L,10010L,1110L,10011L,1100L,10101L,10100L,1111L,11000L,10110L,11001L,11010L,11100L,100001L,10111L,100000L,11011L,100010L,11101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231889Inst : IEnumerable<long>
{
public static readonly long[] Value=A231889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231889.Bytes);
public long this[int i]=>Value[i];

public static A231889Inst Instance=new A231889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231890
{
public static readonly long[] Value={ 0L,2L,5L,4L,1L,9L,7L,10L,8L,3L,16L,6L,11L,17L,13L,18L,14L,19L,12L,21L,20L,15L,24L,22L,25L,26L,28L,33L,23L,32L,27L,34L,29L,35L,30L,36L,31L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,48L,47L,49L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231890Inst : IEnumerable<long>
{
public static readonly long[] Value=A231890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231890.Bytes);
public long this[int i]=>Value[i];

public static A231890Inst Instance=new A231890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231891
{
public static readonly long[] Value={ 1L,100L,11L,1000L,10L,101L,1011L,110L,1101L,10001L,1110L,10010L,1111L,10000L,111L,1001L,1010L,1100L,10011L,10100L,10101L,10110L,11000L,10111L,100000L,11011L,100001L,11001L,11010L,11100L,100010L,11101L,100011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231891Inst : IEnumerable<long>
{
public static readonly long[] Value=A231891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231891.Bytes);
public long this[int i]=>Value[i];

public static A231891Inst Instance=new A231891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231892
{
public static readonly long[] Value={ 1L,4L,3L,8L,2L,5L,11L,6L,13L,17L,14L,18L,15L,16L,7L,9L,10L,12L,19L,20L,21L,22L,24L,23L,32L,27L,33L,25L,26L,28L,34L,29L,35L,30L,36L,31L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,48L,47L,49L,50L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231892Inst : IEnumerable<long>
{
public static readonly long[] Value=A231892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231892.Bytes);
public long this[int i]=>Value[i];

public static A231892Inst Instance=new A231892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231893
{
public static readonly long[] Value={ 3L,7L,46L,4436L,134281216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231893Inst : IEnumerable<long>
{
public static readonly long[] Value=A231893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231893.Bytes);
public long this[int i]=>Value[i];

public static A231893Inst Instance=new A231893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231894
{
public static readonly long[] Value={ 1L,3L,10L,37L,149L,648L,3039L,15401L,84619L,505500L,3287256L,23250514L,178382427L,1478782490L,13187788246L,125958159631L,1283067859947L,13886218459612L,159124624924418L,1924735353849082L,24506483918914367L,327627501208785322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231894Inst : IEnumerable<long>
{
public static readonly long[] Value=A231894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231894.Bytes);
public long this[int i]=>Value[i];

public static A231894Inst Instance=new A231894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231895
{
public static readonly BigInteger[] Value={ 3L,3L,5L,12L,37L,138L,605L,3042L,17257L,108978L,758105L,5759322L,47439277L,421090218L,4006875605L,40686781602L,439122198097L,5019624693858L,60582649901105L,769831261587882L,10273367294485717L,143649246839399898L,2100196647406842605L,BigInteger.Parse("32044492213621026162"),BigInteger.Parse("509357494543973054137") };
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
public class A231895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231895Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231895.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A231895.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231895Inst Instance=new A231895Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231896
{
public static readonly long[] Value={ 0L,4L,16L,60L,224L,836L,3120L,11644L,43456L,162180L,605264L,2258876L,8430240L,31462084L,117418096L,438210300L,1635423104L,6103482116L,22778505360L,85010539324L,317263651936L,1184044068420L,4418912621744L,16491606418556L,61547513052480L,229698445791364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231896Inst : IEnumerable<long>
{
public static readonly long[] Value=A231896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231896.Bytes);
public long this[int i]=>Value[i];

public static A231896Inst Instance=new A231896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231897
{
public static readonly long[] Value={ 0L,1L,3L,5L,13L,11L,21L,39L,45L,75L,155L,217L,331L,181L,627L,923L,1241L,2505L,3915L,5221L,6475L,11309L,15595L,19637L,31595L,44491L,69451L,113447L,185269L,244661L,357081L,453677L,1015143L,908091L,980853L,2960011L,4568757L,2965685L,5931189L,11862197L,20437147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231897Inst : IEnumerable<long>
{
public static readonly long[] Value=A231897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231897.Bytes);
public long this[int i]=>Value[i];

public static A231897Inst Instance=new A231897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231898
{
public static readonly long[] Value={ -1L,-1L,2L,-1L,4L,3L,4L,3L,4L,5L,5L,5L,6L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231898Inst : IEnumerable<long>
{
public static readonly long[] Value=A231898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231898.Bytes);
public long this[int i]=>Value[i];

public static A231898Inst Instance=new A231898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231899
{
public static readonly BigInteger[] Value={ 1L,1L,1L,7L,106L,2590L,89500L,4061830L,230971450L,15931539370L,1301850919000L,123784442479000L,13503177242345500L,1670758163868804100L,BigInteger.Parse("232275860883184444000"),BigInteger.Parse("35996619826480459259200"),BigInteger.Parse("6176482540368771725898700"),BigInteger.Parse("1166516670494844414929980300"),BigInteger.Parse("241253958437270751756621102400") };
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
public class A231899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231899Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231899.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A231899.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231899Inst Instance=new A231899Inst();

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