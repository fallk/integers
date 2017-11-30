using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A242239
{
public static readonly long[] Value={ 3L,6L,5L,10L,12L,8L,15L,22L,22L,13L,21L,35L,43L,40L,21L,28L,51L,71L,82L,74L,34L,36L,70L,106L,139L,157L,136L,55L,45L,92L,148L,211L,271L,304L,250L,89L,55L,117L,197L,298L,416L,531L,586L,460L,144L,66L,145L,253L,400L,592L,821L,1047L,1129L,846L,233L,78L,176L,316L,517L,799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242239Inst : IEnumerable<long>
{
public static readonly long[] Value=A242239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242239.Bytes);
public long this[int i]=>Value[i];

public static A242239Inst Instance=new A242239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242288
{
public static readonly long[] Value={ 3L,5L,5L,0L,0L,3L,0L,0L,0L,0L,1L,2L,0L,0L,1L,2L,1L,0L,0L,0L,2L,0L,0L,0L,4L,0L,2L,0L,0L,1L,2L,0L,0L,0L,1L,2L,0L,1L,0L,0L,2L,0L,0L,0L,3L,0L,0L,0L,0L,0L,2L,2L,0L,0L,0L,4L,1L,0L,2L,0L,2L,0L,0L,0L,1L,0L,0L,0L,0L,0L,3L,2L,0L,0L,0L,1L,0L,0L,4L,0L,2L,0L,3L,0L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242288Inst : IEnumerable<long>
{
public static readonly long[] Value=A242288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242288.Bytes);
public long this[int i]=>Value[i];

public static A242288Inst Instance=new A242288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242289
{
public static readonly long[] Value={ 1L,2L,3L,4L,3L,4L,3L,3L,3L,3L,4L,4L,4L,2L,5L,5L,4L,5L,4L,4L,5L,3L,4L,4L,5L,4L,5L,6L,3L,5L,6L,3L,3L,5L,5L,4L,5L,6L,3L,4L,4L,4L,4L,4L,6L,5L,4L,4L,6L,5L,5L,6L,4L,2L,3L,6L,5L,4L,4L,3L,6L,6L,3L,4L,5L,6L,5L,6L,4L,5L,5L,6L,4L,5L,3L,5L,5L,6L,6L,4L,5L,5L,5L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242289Inst : IEnumerable<long>
{
public static readonly long[] Value=A242289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242289.Bytes);
public long this[int i]=>Value[i];

public static A242289Inst Instance=new A242289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242290
{
public static readonly long[] Value={ 5L,6L,8L,9L,10L,11L,14L,15L,19L,20L,21L,23L,24L,25L,27L,29L,30L,33L,34L,35L,38L,40L,41L,43L,44L,45L,47L,48L,49L,50L,51L,54L,55L,56L,59L,61L,63L,64L,65L,67L,68L,69L,70L,71L,74L,75L,76L,78L,79L,81L,83L,85L,90L,93L,98L,99L,104L,105L,106L,107L,108L,109L,110L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242290Inst : IEnumerable<long>
{
public static readonly long[] Value=A242290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242290.Bytes);
public long this[int i]=>Value[i];

public static A242290Inst Instance=new A242290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242291
{
public static readonly long[] Value={ 35L,56L,120L,165L,220L,286L,560L,680L,1330L,1540L,1771L,2300L,2600L,2925L,3654L,4495L,4960L,6545L,7140L,7770L,9880L,11480L,12341L,14190L,15180L,16215L,18424L,19600L,20825L,22100L,23426L,27720L,29260L,30856L,35990L,39711L,43680L,45760L,47905L,52394L,54740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242291Inst : IEnumerable<long>
{
public static readonly long[] Value=A242291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242291.Bytes);
public long this[int i]=>Value[i];

public static A242291Inst Instance=new A242291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242292
{
public static readonly long[] Value={ 1L,2L,5L,3L,1L,29L,11L,31L,503L,13L,7L,1021L,8179L,1637L,4679L,1L,8737L,131063L,524269L,262139L,2097131L,349L,131L,773L,271L,197L,457L,1493L,317L,17L,6733L,73L,41L,157109L,83L,53L,1741L,3329L,49977801259L,997L,149L,2199023255531L,61L,4398046511093L,3769453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242292Inst : IEnumerable<long>
{
public static readonly long[] Value=A242292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242292.Bytes);
public long this[int i]=>Value[i];

public static A242292Inst Instance=new A242292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242293
{
public static readonly long[] Value={ 7L,18L,28L,25L,0L,1L,8L,0L,19L,15L,18L,0L,0L,19L,11L,15L,0L,0L,7L,9L,20L,27L,10L,0L,6L,0L,0L,15L,6L,11L,8L,9L,11L,6L,27L,10L,23L,0L,0L,0L,2L,2L,0L,9L,0L,9L,10L,0L,15L,27L,6L,17L,2L,21L,16L,0L,12L,5L,1L,17L,26L,6L,18L,6L,2L,0L,10L,1L,2L,14L,21L,10L,5L,17L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242293Inst : IEnumerable<long>
{
public static readonly long[] Value=A242293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242293.Bytes);
public long this[int i]=>Value[i];

public static A242293Inst Instance=new A242293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242294
{
public static readonly long[] Value={ 1L,2L,3L,4L,3L,3L,5L,3L,5L,6L,5L,4L,4L,6L,6L,5L,5L,3L,5L,6L,5L,6L,7L,5L,4L,6L,4L,5L,5L,5L,5L,6L,7L,5L,6L,7L,6L,4L,6L,3L,6L,7L,5L,6L,6L,6L,7L,6L,6L,6L,6L,6L,6L,7L,6L,7L,6L,4L,5L,7L,7L,5L,7L,6L,6L,7L,7L,6L,6L,6L,7L,5L,5L,5L,6L,7L,7L,7L,6L,6L,5L,4L,6L,5L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242294Inst : IEnumerable<long>
{
public static readonly long[] Value=A242294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242294.Bytes);
public long this[int i]=>Value[i];

public static A242294Inst Instance=new A242294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242295
{
public static readonly long[] Value={ 6L,9L,13L,14L,18L,19L,25L,27L,28L,39L,40L,41L,44L,46L,49L,57L,67L,78L,82L,87L,90L,92L,93L,99L,100L,103L,109L,114L,115L,123L,125L,130L,132L,133L,135L,140L,150L,151L,160L,165L,169L,173L,182L,188L,193L,204L,208L,209L,211L,214L,217L,224L,230L,237L,238L,240L,244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242295Inst : IEnumerable<long>
{
public static readonly long[] Value=A242295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242295.Bytes);
public long this[int i]=>Value[i];

public static A242295Inst Instance=new A242295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242296
{
public static readonly long[] Value={ 216L,729L,2197L,2744L,5832L,6859L,15625L,19683L,21952L,59319L,64000L,68921L,85184L,97336L,117649L,185193L,300763L,474552L,551368L,658503L,729000L,778688L,804357L,970299L,1000000L,1092727L,1295029L,1481544L,1520875L,1860867L,1953125L,2197000L,2299968L,2352637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242296Inst : IEnumerable<long>
{
public static readonly long[] Value=A242296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242296.Bytes);
public long this[int i]=>Value[i];

public static A242296Inst Instance=new A242296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242297
{
public static readonly long[] Value={ 1L,3L,6L,12L,18L,24L,36L,54L,72L,108L,162L,216L,324L,486L,540L,648L,720L,972L,1008L,1080L,1440L,1458L,1512L,2016L,2160L,4320L,5040L,6048L,8640L,12096L,12960L,30240L,40320L,50400L,60480L,80640L,100800L,129600L,136080L,181440L,226800L,272160L,403200L,408240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242297Inst : IEnumerable<long>
{
public static readonly long[] Value=A242297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242297.Bytes);
public long this[int i]=>Value[i];

public static A242297Inst Instance=new A242297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242298
{
public static readonly long[] Value={ 1L,2L,4L,6L,12L,24L,36L,48L,60L,120L,180L,240L,300L,360L,420L,840L,1680L,2520L,5040L,7560L,10080L,12600L,15120L,17640L,20160L,22680L,25200L,27720L,55440L,83160L,110880L,138600L,166320L,194040L,221760L,249480L,277200L,304920L,332640L,360360L,720720L,1441440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242298Inst : IEnumerable<long>
{
public static readonly long[] Value=A242298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242298.Bytes);
public long this[int i]=>Value[i];

public static A242298Inst Instance=new A242298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242299
{
public static readonly BigInteger[] Value={ 9L,91L,913L,9131L,91311L,913111L,9131111L,91311111L,913111111L,9131111111L,91311111111L,913111111113L,9131111111131L,91311111111311L,913111111113111L,9131111111131111L,91311111111311111L,913111111113111111L,9131111111131111111L,BigInteger.Parse("91311111111311111111") };
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
public class A242299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242299Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242299.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242299.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242299Inst Instance=new A242299Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242300
{
public static readonly long[] Value={ 0L,2L,11L,35L,105L,292L,796L,2130L,5655L,14927L,39281L,103160L,270600L,709282L,1858291L,4867275L,12746265L,33375932L,87388676L,228801650L,599034975L,1568333527L,4106014561L,10749789360L,28143481680L,73680863042L,192899442971L,505018008755L,1322155461705L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242300Inst : IEnumerable<long>
{
public static readonly long[] Value=A242300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242300.Bytes);
public long this[int i]=>Value[i];

public static A242300Inst Instance=new A242300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242301
{
public static readonly long[] Value={ 1L,6L,2L,8L,1L,6L,2L,4L,6L,6L,6L,3L,6L,0L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242301Inst : IEnumerable<long>
{
public static readonly long[] Value=A242301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242301.Bytes);
public long this[int i]=>Value[i];

public static A242301Inst Instance=new A242301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242302
{
public static readonly long[] Value={ 9L,3L,4L,6L,3L,6L,3L,1L,3L,9L,9L,6L,4L,9L,8L,8L,9L,1L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242302Inst : IEnumerable<long>
{
public static readonly long[] Value=A242302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242302.Bytes);
public long this[int i]=>Value[i];

public static A242302Inst Instance=new A242302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242303
{
public static readonly long[] Value={ 5L,1L,3L,7L,8L,3L,0L,5L,1L,6L,6L,7L,4L,8L,2L,8L,2L,5L,7L,5L,2L,0L,0L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242303Inst : IEnumerable<long>
{
public static readonly long[] Value=A242303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242303.Bytes);
public long this[int i]=>Value[i];

public static A242303Inst Instance=new A242303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242352
{
public static readonly long[] Value={ 1L,1L,2L,4L,1L,9L,6L,21L,29L,2L,51L,124L,28L,127L,499L,241L,10L,323L,1933L,1667L,216L,1L,835L,7307L,10142L,2765L,98L,2188L,27166L,56748L,27214L,2637L,22L,5798L,99841L,299485L,227847L,44051L,1546L,2L,15511L,363980L,1514445L,1708700L,563444L,46947L,570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242352Inst : IEnumerable<long>
{
public static readonly long[] Value=A242352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242352.Bytes);
public long this[int i]=>Value[i];

public static A242352Inst Instance=new A242352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242353
{
public static readonly long[] Value={ 2L,4L,8L,6L,16L,12L,16L,8L,32L,24L,32L,16L,32L,24L,20L,24L,10L,64L,48L,64L,32L,64L,48L,40L,48L,20L,64L,48L,64L,32L,64L,48L,48L,36L,40L,32L,12L,128L,96L,128L,64L,128L,96L,80L,96L,40L,128L,96L,128L,64L,128L,96L,96L,72L,80L,64L,24L,128L,96L,128L,64L,128L,96L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242353Inst : IEnumerable<long>
{
public static readonly long[] Value=A242353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242353.Bytes);
public long this[int i]=>Value[i];

public static A242353Inst Instance=new A242353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242354
{
public static readonly long[] Value={ 4L,16L,64L,40L,256L,160L,256L,80L,1024L,640L,1024L,320L,1024L,640L,544L,640L,140L,4096L,2560L,4096L,1280L,4096L,2560L,2176L,2560L,560L,4096L,2560L,4096L,1280L,4096L,2560L,2560L,1600L,2176L,1280L,224L,16384L,10240L,16384L,5120L,16384L,10240L,8704L,10240L,2240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242354Inst : IEnumerable<long>
{
public static readonly long[] Value=A242354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242354.Bytes);
public long this[int i]=>Value[i];

public static A242354Inst Instance=new A242354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242355
{
public static readonly long[] Value={ 8L,128L,1416L,13568L,119960L,1009440L,8205656L,65068352L,506193144L,3879735776L,29378067080L,220265711040L,1637726387096L,12091336503584L,88727095777896L,647661676223168L,4705654523841704L,34049855885188128L,245482626441965048L,1764039730476165824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242355Inst : IEnumerable<long>
{
public static readonly long[] Value=A242355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242355.Bytes);
public long this[int i]=>Value[i];

public static A242355Inst Instance=new A242355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242356
{
public static readonly long[] Value={ 36L,120L,276L,300L,325L,903L,1653L,2485L,2556L,3240L,4851L,5253L,5460L,5995L,6105L,6441L,6903L,8001L,8256L,8911L,9591L,10585L,12561L,12720L,14365L,20301L,21115L,22791L,23436L,24753L,26335L,26565L,26796L,27495L,29161L,30381L,31375L,34191L,34980L,37401L,40755L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242356Inst : IEnumerable<long>
{
public static readonly long[] Value=A242356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242356.Bytes);
public long this[int i]=>Value[i];

public static A242356Inst Instance=new A242356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242357
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,1L,2L,3L,3L,3L,2L,1L,1L,2L,3L,4L,4L,4L,4L,3L,2L,1L,1L,2L,3L,4L,5L,5L,5L,5L,5L,4L,3L,2L,1L,1L,2L,3L,4L,5L,6L,6L,6L,6L,6L,6L,5L,4L,3L,2L,1L,1L,2L,3L,4L,5L,6L,7L,7L,7L,7L,7L,7L,7L,6L,5L,4L,3L,2L,1L,1L,2L,3L,4L,5L,6L,7L,8L,8L,8L,8L,8L,8L,8L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242357Inst : IEnumerable<long>
{
public static readonly long[] Value=A242357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242357.Bytes);
public long this[int i]=>Value[i];

public static A242357Inst Instance=new A242357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242358
{
public static readonly long[] Value={ 23L,567L,6814L,47358L,239511L,954226L,3207212L,9414828L,24862239L,60136329L,135311658L,286229762L,574460495L,1101240084L,2028333848L,3605765688L,6211552455L,10402472811L,16984387958L,27099325638L,42342870823L,64905898662L,97761436356L,144885584740L,211543443215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242358Inst : IEnumerable<long>
{
public static readonly long[] Value=A242358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242358.Bytes);
public long this[int i]=>Value[i];

public static A242358Inst Instance=new A242358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242359
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,3L,1L,2L,3L,3L,4L,1L,2L,3L,3L,4L,4L,5L,5L,1L,2L,3L,3L,4L,4L,5L,5L,5L,5L,7L,7L,6L,1L,2L,3L,3L,4L,4L,5L,5L,5L,5L,7L,7L,6L,6L,7L,7L,9L,8L,10L,9L,7L,1L,2L,3L,3L,4L,4L,5L,5L,5L,5L,7L,7L,6L,6L,7L,7L,9L,8L,10L,9L,7L,7L,9L,10L,8L,9L,11L,12L,11L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242359Inst : IEnumerable<long>
{
public static readonly long[] Value=A242359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242359.Bytes);
public long this[int i]=>Value[i];

public static A242359Inst Instance=new A242359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242360
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,3L,1L,5L,5L,4L,2L,1L,6L,7L,7L,5L,5L,3L,2L,1L,7L,9L,10L,8L,9L,7L,7L,6L,4L,3L,3L,2L,1L,8L,11L,13L,11L,13L,11L,12L,11L,9L,8L,10L,9L,7L,5L,5L,4L,4L,3L,3L,2L,1L,9L,13L,16L,14L,17L,15L,17L,16L,14L,13L,17L,16L,13L,11L,12L,11L,13L,11L,13L,11L,8L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242360Inst : IEnumerable<long>
{
public static readonly long[] Value=A242360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242360.Bytes);
public long this[int i]=>Value[i];

public static A242360Inst Instance=new A242360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242361
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,1L,3L,5L,3L,5L,2L,5L,8L,4L,5L,8L,4L,3L,1L,4L,8L,7L,13L,7L,4L,8L,7L,13L,7L,3L,5L,2L,7L,13L,7L,12L,21L,11L,11L,5L,7L,13L,7L,12L,21L,11L,11L,5L,5L,8L,4L,3L,1L,5L,11L,11L,21L,12L,9L,19L,18L,34L,19L,10L,18L,9L,5L,11L,11L,21L,12L,9L,19L,18L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242361Inst : IEnumerable<long>
{
public static readonly long[] Value=A242361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242361.Bytes);
public long this[int i]=>Value[i];

public static A242361Inst Instance=new A242361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242362
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,11L,20L,30L,50L,75L,121L,176L,276L,398L,604L,864L,1285L,1814L,2652L,3713L,5339L,7417L,10526L,14500L,20349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242362Inst : IEnumerable<long>
{
public static readonly long[] Value=A242362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242362.Bytes);
public long this[int i]=>Value[i];

public static A242362Inst Instance=new A242362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242363
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,5L,3L,1L,3L,4L,8L,5L,2L,5L,3L,7L,13L,7L,8L,4L,1L,3L,4L,8L,5L,5L,11L,11L,21L,12L,7L,13L,7L,2L,5L,3L,7L,13L,7L,8L,4L,9L,18L,10L,19L,34L,18L,19L,9L,12L,21L,11L,11L,5L,1L,3L,4L,8L,5L,5L,11L,11L,21L,12L,7L,13L,7L,6L,14L,15L,29L,17L,14L,30L,29L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242363Inst : IEnumerable<long>
{
public static readonly long[] Value=A242363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242363.Bytes);
public long this[int i]=>Value[i];

public static A242363Inst Instance=new A242363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242364
{
public static readonly long[] Value={ 1L,0L,2L,-1L,4L,-3L,-2L,3L,8L,-7L,-6L,-4L,5L,6L,16L,-15L,-14L,-12L,-8L,-5L,7L,9L,10L,12L,32L,-31L,-30L,-28L,-24L,-16L,-11L,-10L,-9L,13L,14L,15L,17L,18L,20L,24L,64L,-63L,-62L,-60L,-56L,-48L,-32L,-23L,-22L,-20L,-19L,-18L,-17L,-13L,11L,25L,26L,28L,29L,30L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242364Inst : IEnumerable<long>
{
public static readonly long[] Value=A242364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242364.Bytes);
public long this[int i]=>Value[i];

public static A242364Inst Instance=new A242364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242365
{
public static readonly long[] Value={ 1L,2L,4L,8L,3L,16L,6L,5L,32L,12L,10L,9L,7L,64L,24L,20L,18L,17L,15L,14L,13L,128L,48L,40L,36L,34L,33L,31L,30L,29L,28L,26L,25L,11L,256L,96L,80L,72L,68L,66L,65L,63L,62L,61L,60L,58L,57L,56L,52L,50L,49L,23L,22L,21L,19L,512L,192L,160L,144L,136L,132L,130L,129L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242365Inst : IEnumerable<long>
{
public static readonly long[] Value=A242365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242365.Bytes);
public long this[int i]=>Value[i];

public static A242365Inst Instance=new A242365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242366
{
public static readonly long[] Value={ 2L,3L,11L,59L,131L,179L,347L,1259L,1571L,1979L,2027L,2411L,2699L,2819L,3251L,3347L,4211L,5051L,5099L,5171L,5531L,6779L,7187L,8747L,10091L,12227L,13259L,13451L,13499L,13931L,14411L,14771L,15131L,15467L,16451L,16691L,17987L,18131L,18539L,18731L,18899L,19211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242366Inst : IEnumerable<long>
{
public static readonly long[] Value=A242366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242366.Bytes);
public long this[int i]=>Value[i];

public static A242366Inst Instance=new A242366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242367
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,14L,16L,18L,21L,23L,25L,27L,29L,30L,32L,34L,36L,38L,41L,43L,45L,47L,49L,50L,52L,54L,56L,58L,61L,63L,65L,67L,69L,70L,72L,74L,76L,78L,81L,83L,85L,87L,89L,90L,92L,94L,96L,98L,110L,112L,114L,116L,118L,130L,132L,134L,136L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242367Inst : IEnumerable<long>
{
public static readonly long[] Value=A242367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242367.Bytes);
public long this[int i]=>Value[i];

public static A242367Inst Instance=new A242367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242416
{
public static readonly long[] Value={ 12L,18L,20L,24L,28L,40L,44L,45L,48L,50L,52L,54L,56L,60L,63L,68L,72L,75L,76L,80L,84L,88L,92L,96L,98L,99L,104L,108L,112L,116L,117L,120L,124L,132L,135L,136L,140L,144L,147L,148L,150L,152L,153L,156L,160L,162L,164L,168L,171L,172L,175L,176L,180L,184L,188L,189L,192L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242416Inst : IEnumerable<long>
{
public static readonly long[] Value=A242416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242416.Bytes);
public long this[int i]=>Value[i];

public static A242416Inst Instance=new A242416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242417
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,13L,16L,17L,19L,21L,23L,25L,27L,29L,30L,31L,32L,36L,37L,41L,43L,47L,49L,53L,59L,61L,64L,65L,67L,70L,71L,73L,79L,81L,83L,89L,90L,97L,101L,103L,107L,109L,113L,121L,125L,127L,128L,131L,133L,137L,139L,149L,151L,154L,157L,163L,165L,167L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242417Inst : IEnumerable<long>
{
public static readonly long[] Value=A242417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242417.Bytes);
public long this[int i]=>Value[i];

public static A242417Inst Instance=new A242417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242418
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,10L,14L,16L,22L,26L,30L,32L,34L,36L,38L,46L,58L,62L,64L,74L,82L,86L,90L,94L,100L,106L,110L,118L,122L,128L,134L,142L,146L,158L,166L,178L,194L,196L,202L,206L,210L,214L,216L,218L,226L,238L,254L,256L,262L,270L,274L,278L,298L,300L,302L,314L,326L,334L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242418Inst : IEnumerable<long>
{
public static readonly long[] Value=A242418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242418.Bytes);
public long this[int i]=>Value[i];

public static A242418Inst Instance=new A242418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242419
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,15L,11L,18L,13L,35L,10L,16L,17L,12L,19L,75L,21L,77L,23L,54L,25L,143L,27L,245L,29L,30L,31L,32L,55L,221L,14L,36L,37L,323L,91L,375L,41L,105L,43L,847L,50L,437L,47L,162L,49L,45L,187L,1859L,53L,24L,33L,1715L,247L,667L,59L,150L,61L,899L,147L,64L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242419Inst : IEnumerable<long>
{
public static readonly long[] Value=A242419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242419.Bytes);
public long this[int i]=>Value[i];

public static A242419Inst Instance=new A242419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242420
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,15L,11L,12L,13L,35L,10L,16L,17L,18L,19L,45L,21L,77L,23L,24L,25L,143L,27L,175L,29L,30L,31L,32L,55L,221L,14L,36L,37L,323L,91L,135L,41L,105L,43L,539L,20L,437L,47L,48L,49L,75L,187L,1573L,53L,54L,33L,875L,247L,667L,59L,90L,61L,899L,63L,64L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242420Inst : IEnumerable<long>
{
public static readonly long[] Value=A242420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242420.Bytes);
public long this[int i]=>Value[i];

public static A242420Inst Instance=new A242420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242421
{
public static readonly long[] Value={ 1L,2L,6L,9L,30L,45L,50L,125L,210L,294L,315L,350L,441L,686L,875L,2310L,2401L,3234L,3465L,3630L,3850L,4851L,5445L,6050L,7546L,7986L,9625L,11979L,15125L,26411L,29282L,30030L,35490L,42042L,45045L,47190L,49686L,50050L,53235L,59150L,63063L,65910L,70785L,74529L,78650L,98098L,98865L,103818L,109850L,115934L,125125L,147875L,155727L,161051L,171366L,196625L,257049L,274625L,343343L,380666L,405769L,510510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242421Inst : IEnumerable<long>
{
public static readonly long[] Value=A242421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242421.Bytes);
public long this[int i]=>Value[i];

public static A242421Inst Instance=new A242421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242422
{
public static readonly long[] Value={ 1L,2L,5L,6L,8L,13L,21L,22L,25L,27L,28L,29L,30L,36L,40L,46L,47L,48L,57L,64L,73L,76L,85L,86L,91L,102L,107L,117L,121L,123L,130L,136L,142L,147L,151L,154L,156L,164L,165L,175L,185L,189L,196L,197L,198L,201L,206L,208L,210L,217L,220L,222L,225L,243L,250L,252L,257L,264L,268L,270L,279L,280L,296L,298L,299L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242422Inst : IEnumerable<long>
{
public static readonly long[] Value=A242422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242422.Bytes);
public long this[int i]=>Value[i];

public static A242422Inst Instance=new A242422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242423
{
public static readonly long[] Value={ 3L,4L,7L,9L,10L,11L,12L,14L,15L,16L,17L,18L,19L,20L,23L,24L,26L,31L,32L,33L,34L,35L,37L,38L,39L,41L,42L,43L,44L,45L,49L,50L,51L,52L,53L,54L,55L,56L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,72L,74L,75L,77L,78L,79L,80L,81L,82L,83L,84L,87L,88L,89L,90L,92L,93L,94L,95L,96L,97L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242423Inst : IEnumerable<long>
{
public static readonly long[] Value=A242423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242423.Bytes);
public long this[int i]=>Value[i];

public static A242423Inst Instance=new A242423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242424
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,6L,10L,5L,12L,9L,14L,10L,22L,15L,18L,7L,26L,20L,34L,15L,30L,21L,38L,14L,27L,33L,40L,25L,46L,30L,58L,11L,42L,39L,45L,28L,62L,51L,66L,21L,74L,50L,82L,35L,60L,57L,86L,22L,75L,45L,78L,55L,94L,56L,63L,35L,102L,69L,106L,42L,118L,87L,100L,13L,99L,70L,122L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242424Inst : IEnumerable<long>
{
public static readonly long[] Value=A242424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242424.Bytes);
public long this[int i]=>Value[i];

public static A242424Inst Instance=new A242424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242425
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,1L,2L,2L,1L,2L,3L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,3L,3L,3L,3L,3L,2L,4L,2L,1L,4L,3L,4L,4L,3L,4L,2L,2L,2L,8L,2L,2L,2L,6L,5L,1L,4L,2L,5L,3L,3L,1L,2L,6L,4L,4L,2L,3L,3L,3L,5L,2L,3L,2L,5L,5L,4L,8L,4L,2L,7L,2L,4L,5L,5L,3L,4L,3L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242425Inst : IEnumerable<long>
{
public static readonly long[] Value=A242425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242425.Bytes);
public long this[int i]=>Value[i];

public static A242425Inst Instance=new A242425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242426
{
public static readonly BigInteger[] Value={ 1L,0L,0L,0L,0L,3L,14L,78L,497L,3628L,29990L,277200L,2834328L,31770514L,387459072L,5108103000L,72397196844L,1097800704000L,17735107218083L,304112751022080L,5516784599040000L,105559797875432727L,2124765080865042873L,BigInteger.Parse("44881973505008640000"),BigInteger.Parse("992717442773183102976") };
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
public class A242426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242426Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242426.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242426.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242426Inst Instance=new A242426Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242427
{
public static readonly long[] Value={ 0L,2L,6L,24L,120L,72L,238L,384L,567L,800L,110L,0L,2184L,784L,0L,0L,1428L,0L,703L,0L,0L,2904L,4209L,0L,0L,13520L,0L,0L,15109L,0L,18228L,0L,0L,30056L,0L,0L,9546L,14440L,0L,0L,26855L,0L,23994L,0L,0L,25392L,13207L,0L,0L,0L,0L,0L,95453L,0L,0L,0L,0L,148016L,93928L,0L,208315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242427Inst : IEnumerable<long>
{
public static readonly long[] Value=A242427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242427.Bytes);
public long this[int i]=>Value[i];

public static A242427Inst Instance=new A242427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242428
{
public static readonly BigInteger[] Value={ 0L,2L,17L,180L,3298L,88431L,3064050L,130905678L,6732227475L,409094032964L,28917250469178L,2346562701385648L,216180120430479731L,BigInteger.Parse("22397392442055209003"),BigInteger.Parse("2588479398843886168171"),BigInteger.Parse("331352273262513644199134"),BigInteger.Parse("46692196905193286953380160"),BigInteger.Parse("7203294536351261350956567853"),BigInteger.Parse("1210694223244114528129261255186") };
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
public class A242428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242428Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242428.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242428.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242428Inst Instance=new A242428Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242429
{
public static readonly long[] Value={ 1L,5L,17L,53L,167L,550L,1899L,6809L,25067L,93902L,355775L,1358208L,5212573L,20082860L,77607895L,300638481L,1166999699L,4537960846L,17673418311L,68924837252L,269132082925L,1052055773292L,4116727946687L,16123827007348L,63205353550497L,247959367137320L,973469914150619L,3824345703033374L,15033634055076857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242429Inst : IEnumerable<long>
{
public static readonly long[] Value=A242429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242429.Bytes);
public long this[int i]=>Value[i];

public static A242429Inst Instance=new A242429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242430
{
public static readonly long[] Value={ 2L,6L,7L,7L,8L,6L,8L,4L,0L,2L,1L,7L,8L,8L,9L,1L,1L,2L,3L,7L,6L,6L,7L,1L,4L,0L,3L,5L,8L,4L,3L,0L,2L,5L,5L,2L,5L,5L,5L,0L,5L,9L,8L,9L,7L,9L,9L,3L,4L,8L,4L,5L,3L,2L,0L,7L,6L,3L,1L,1L,8L,8L,8L,5L,1L,1L,2L,1L,4L,9L,3L,7L,7L,8L,5L,2L,3L,2L,7L,6L,2L,8L,5L,3L,5L,4L,4L,7L,6L,2L,2L,3L,8L,5L,6L,1L,3L,6L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242430Inst : IEnumerable<long>
{
public static readonly long[] Value=A242430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242430.Bytes);
public long this[int i]=>Value[i];

public static A242430Inst Instance=new A242430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242431
{
public static readonly long[] Value={ 1L,2L,1L,5L,3L,1L,14L,10L,4L,1L,43L,35L,17L,5L,1L,144L,128L,74L,26L,6L,1L,523L,491L,329L,137L,37L,7L,1L,2048L,1984L,1498L,730L,230L,50L,8L,1L,8597L,8469L,7011L,3939L,1439L,359L,65L,9L,1L,38486L,38230L,33856L,21568L,9068L,2588L,530L,82L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242431Inst : IEnumerable<long>
{
public static readonly long[] Value=A242431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242431.Bytes);
public long this[int i]=>Value[i];

public static A242431Inst Instance=new A242431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242528
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,4L,18L,13L,62L,8L,133L,225L,209L,32L,2644L,4462L,61341L,113986L,750294L,176301L,7575912L,3575686L,7705362L,36777080L,108638048L,97295807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242528Inst : IEnumerable<long>
{
public static readonly long[] Value=A242528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242528.Bytes);
public long this[int i]=>Value[i];

public static A242528Inst Instance=new A242528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242529
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,6L,2L,36L,36L,360L,288L,11016L,3888L,238464L,200448L,3176496L,4257792L,402573312L,139511808L,18240768000L,11813990400L,440506183680L,532754620416L,96429560832000L,32681097216000L,5244692024217600L,6107246661427200L,490508471914905600L,468867166554931200L,BigInteger.Parse("134183696369843404800") };
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
public class A242529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242529Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242529.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242529.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242529Inst Instance=new A242529Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242530
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,8L,0L,0L,224L,754L,0L,26256L,0L,0L,22472304L,0L,90654576L,277251016L,0L,7852128780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242530Inst : IEnumerable<long>
{
public static readonly long[] Value=A242530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242530.Bytes);
public long this[int i]=>Value[i];

public static A242530Inst Instance=new A242530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242531
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,4L,3L,9L,26L,82L,46L,397L,283L,1675L,9938L,19503L,10247L,97978L,70478L,529383L,3171795L,7642285L,3824927L,48091810L,116017829L,448707198L,1709474581L,6445720883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242531Inst : IEnumerable<long>
{
public static readonly long[] Value=A242531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242531.Bytes);
public long this[int i]=>Value[i];

public static A242531Inst Instance=new A242531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242532
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,20L,39L,0L,0L,0L,0L,319L,967L,0L,0L,1464L,6114L,16856L,44370L,0L,0L,0L,0L,2032951L,8840796L,12791922L,101519154L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242532Inst : IEnumerable<long>
{
public static readonly long[] Value=A242532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242532.Bytes);
public long this[int i]=>Value[i];

public static A242532Inst Instance=new A242532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242533
{
public static readonly long[] Value={ 1L,1L,2L,36L,288L,3888L,200448L,4257792L,139511808L,11813990400L,532754620416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242533Inst : IEnumerable<long>
{
public static readonly long[] Value=A242533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242533.Bytes);
public long this[int i]=>Value[i];

public static A242533Inst Instance=new A242533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242534
{
public static readonly BigInteger[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,72L,288L,3600L,17856L,174528L,2540160L,14768640L,101030400L,1458266112L,11316188160L,140951577600L,2659218508800L,30255151463424L,287496736542720L,5064092578713600L,76356431941939200L,987682437203558400L,BigInteger.Parse("19323690313219522560") };
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
public class A242534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242534Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242534.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242534.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242534Inst Instance=new A242534Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242535
{
public static readonly long[] Value={ 1L,3L,5L,6L,8L,9L,10L,12L,13L,16L,17L,18L,20L,21L,24L,25L,27L,28L,29L,32L,33L,35L,36L,37L,39L,41L,42L,44L,45L,48L,49L,50L,53L,54L,56L,57L,58L,59L,61L,63L,65L,66L,67L,70L,71L,73L,74L,76L,77L,78L,79L,82L,83L,85L,87L,88L,90L,91L,93L,95L,97L,98L,99L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242535Inst : IEnumerable<long>
{
public static readonly long[] Value=A242535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242535.Bytes);
public long this[int i]=>Value[i];

public static A242535Inst Instance=new A242535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242536
{
public static readonly long[] Value={ 1L,2L,4L,12L,26L,66L,160L,386L,946L,2292L,5582L,13578L,33016L,80330L,195370L,475236L,1155974L,2811762L,6839416L,16636178L,40466002L,98429844L,239421374L,582370554L,1416562360L,3445657082L,8381242522L,20386597380L,49588514390L,120619477410L,293395730296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242536Inst : IEnumerable<long>
{
public static readonly long[] Value=A242536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242536.Bytes);
public long this[int i]=>Value[i];

public static A242536Inst Instance=new A242536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242537
{
public static readonly long[] Value={ 1L,3L,8L,27L,82L,255L,794L,2463L,7654L,23775L,73850L,229407L,712606L,2213583L,6876098L,21359343L,66348934L,206100927L,640215146L,1988712255L,6177573934L,19189513071L,59608742162L,185163746895L,575177598550L,1786684895967L,5550012597050L,17240107585311L,53553267556606L,166353513271311L,516747019188962L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242537Inst : IEnumerable<long>
{
public static readonly long[] Value=A242537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242537.Bytes);
public long this[int i]=>Value[i];

public static A242537Inst Instance=new A242537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242538
{
public static readonly long[] Value={ 1L,9L,36L,81L,144L,225L,324L,441L,729L,1089L,1296L,2025L,2304L,2601L,2916L,3249L,3600L,3969L,4356L,4761L,6561L,7056L,7569L,8100L,8649L,9216L,9801L,10404L,11025L,11664L,12996L,13689L,15129L,16641L,17424L,20736L,22500L,23409L,26244L,29241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242538Inst : IEnumerable<long>
{
public static readonly long[] Value=A242538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242538.Bytes);
public long this[int i]=>Value[i];

public static A242538Inst Instance=new A242538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242539
{
public static readonly long[] Value={ 1584L,1589L,1595L,1600L,1606L,1612L,1617L,1623L,1628L,1634L,1640L,1645L,1651L,1656L,1662L,1668L,1673L,1679L,1684L,1690L,1696L,1702L,1708L,1713L,1719L,1724L,1730L,1736L,1741L,1747L,1752L,1758L,1764L,1769L,1775L,1780L,1786L,1792L,1797L,1804L,1809L,1815L,1820L,1826L,1832L,1837L,1843L,1848L,1854L,1860L,1865L,1871L,1876L,1882L,1888L,1893L,1899L,1905L,1911L,1916L,1922L,1928L,1933L,1939L,1944L,1950L,1956L,1961L,1967L,1972L,1978L,1984L,1989L,1995L,2000L,2006L,2012L,2017L,2023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242539Inst : IEnumerable<long>
{
public static readonly long[] Value=A242539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242539.Bytes);
public long this[int i]=>Value[i];

public static A242539Inst Instance=new A242539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242540
{
public static readonly long[] Value={ 444L,11L,3L,0L,13L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242540Inst : IEnumerable<long>
{
public static readonly long[] Value=A242540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242540.Bytes);
public long this[int i]=>Value[i];

public static A242540Inst Instance=new A242540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242541
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,131L,151L,181L,191L,313L,353L,373L,383L,727L,757L,787L,797L,919L,929L,18181L,32323L,35353L,72727L,74747L,78787L,94949L,95959L,1212121L,1616161L,323232323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242541Inst : IEnumerable<long>
{
public static readonly long[] Value=A242541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242541.Bytes);
public long this[int i]=>Value[i];

public static A242541Inst Instance=new A242541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242542
{
public static readonly long[] Value={ 6L,32L,150L,690L,3311L,16968L,93103L,544920L,3386262L,22243902L,153850981L,1116625523L,8478969009L,67185160511L,554235206898L,4750165417926L,42219358673456L,388485398829204L,3695187060252009L,36282147267628868L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242542Inst : IEnumerable<long>
{
public static readonly long[] Value=A242542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242542.Bytes);
public long this[int i]=>Value[i];

public static A242542Inst Instance=new A242542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242543
{
public static readonly long[] Value={ 12L,32L,88L,242L,660L,1800L,4920L,13448L,36736L,100352L,274176L,749088L,2046528L,5591168L,15275392L,41733248L,114017280L,311500800L,851036160L,2325074432L,6352221184L,17354590208L,47413622784L,129536428032L,353900101632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242543Inst : IEnumerable<long>
{
public static readonly long[] Value=A242543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242543.Bytes);
public long this[int i]=>Value[i];

public static A242543Inst Instance=new A242543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242576
{
public static readonly BigInteger[] Value={ 13L,151L,277L,36313L,225949L,7129366889L,933784181621L,BigInteger.Parse("19397107178326126131136629644898891137047"),BigInteger.Parse("401151570474397232184569825031979125080583558010764826781295643008140597581801") };
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
public class A242576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242576Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242576.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242576.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242576Inst Instance=new A242576Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242577
{
public static readonly long[] Value={ 7L,35L,159L,723L,3453L,17634L,96472L,563256L,3492837L,22901243L,158134009L,1145995500L,8690227115L,68774540753L,566710394107L,4852093593696L,43084515133226L,396100229113680L,3764573877643410L,36935721134238873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242577Inst : IEnumerable<long>
{
public static readonly long[] Value=A242577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242577.Bytes);
public long this[int i]=>Value[i];

public static A242577Inst Instance=new A242577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242578
{
public static readonly long[] Value={ 13L,35L,97L,271L,757L,2115L,5913L,16535L,46237L,129291L,361537L,1010975L,2827013L,7905235L,22105577L,61814311L,172852717L,483351835L,1351607313L,3779529135L,10568780117L,29553711331L,82641690297L,231092768695L,646209770813L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242578Inst : IEnumerable<long>
{
public static readonly long[] Value=A242578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242578.Bytes);
public long this[int i]=>Value[i];

public static A242578Inst Instance=new A242578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242579
{
public static readonly long[] Value={ 14L,45L,159L,587L,2209L,8391L,32020L,122439L,468605L,1794215L,6871124L,26316013L,100792856L,386053397L,1478661408L,5663590035L,21692801897L,83088294355L,318246913929L,1218957694705L,4668884168508L,17882884906745L,68495504779439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242579Inst : IEnumerable<long>
{
public static readonly long[] Value=A242579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242579.Bytes);
public long this[int i]=>Value[i];

public static A242579Inst Instance=new A242579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242580
{
public static readonly long[] Value={ 14L,46L,174L,723L,3192L,14648L,68819L,327821L,1574161L,7594177L,36734890L,177970751L,862989003L,4186822990L,20318525824L,98621961836L,478737668736L,2324053123861L,11282584749066L,54774608227458L,265922223475021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242580Inst : IEnumerable<long>
{
public static readonly long[] Value=A242580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242580.Bytes);
public long this[int i]=>Value[i];

public static A242580Inst Instance=new A242580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242581
{
public static readonly long[] Value={ 14L,46L,175L,744L,3453L,17178L,90033L,489821L,2734513L,15534111L,89271482L,516935609L,3008249095L,17562798942L,102750973652L,601965097333L,3529737223262L,20709247799845L,121548480504365L,713577294998844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242581Inst : IEnumerable<long>
{
public static readonly long[] Value=A242581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242581.Bytes);
public long this[int i]=>Value[i];

public static A242581Inst Instance=new A242581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242582
{
public static readonly long[] Value={ 14L,46L,175L,745L,3481L,17634L,95729L,550503L,3316400L,20716789L,133010422L,871426139L,5793393075L,38920526974L,263416849112L,1792161569676L,12237842678789L,83782031880589L,574620337324485L,3946034125700132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242582Inst : IEnumerable<long>
{
public static readonly long[] Value=A242582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242582.Bytes);
public long this[int i]=>Value[i];

public static A242582Inst Instance=new A242582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242583
{
public static readonly long[] Value={ 14L,46L,175L,745L,3482L,17670L,96472L,562109L,3469255L,22511261L,152416564L,1068885011L,7711216523L,56883599674L,426892077104L,3245855512924L,24923815228380L,192793238658181L,1499479762818409L,11709699180354092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242583Inst : IEnumerable<long>
{
public static readonly long[] Value=A242583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242583.Bytes);
public long this[int i]=>Value[i];

public static A242583Inst Instance=new A242583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242584
{
public static readonly long[] Value={ 7L,13L,12L,14L,35L,21L,14L,45L,97L,37L,14L,46L,159L,271L,65L,14L,46L,174L,587L,757L,114L,14L,46L,175L,723L,2209L,2115L,200L,14L,46L,175L,744L,3192L,8391L,5913L,351L,14L,46L,175L,745L,3453L,14648L,32020L,16535L,616L,14L,46L,175L,745L,3481L,17178L,68819L,122439L,46237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242584Inst : IEnumerable<long>
{
public static readonly long[] Value=A242584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242584.Bytes);
public long this[int i]=>Value[i];

public static A242584Inst Instance=new A242584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242585
{
public static readonly long[] Value={ 1L,9L,9L,45L,9L,405L,15L,189L,81L,729L,27L,6075L,27L,1215L,2025L,729L,81L,45927L,27L,32805L,2025L,6561L,81L,229635L,243L,2187L,2187L,18225L,9L,7381125L,243L,24057L,2187L,19683L,3645L,6200145L,729L,19683L,19683L,1240029L,81L,22143375L,243L,295245L,492075L,19683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242585Inst : IEnumerable<long>
{
public static readonly long[] Value=A242585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242585.Bytes);
public long this[int i]=>Value[i];

public static A242585Inst Instance=new A242585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242586
{
public static readonly long[] Value={ 1L,2L,6L,23L,98L,437L,1995L,9242L,43258L,204053L,968441L,4619012L,22120631L,106300508L,512321438L,2475395303L,11986728458L,58156146653L,282640193313L,1375737276788L,6705522150973L,32724071280518L,159878425878848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242586Inst : IEnumerable<long>
{
public static readonly long[] Value=A242586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242586.Bytes);
public long this[int i]=>Value[i];

public static A242586Inst Instance=new A242586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242587
{
public static readonly long[] Value={ 1L,3L,12L,39L,129L,399L,1245L,3783L,11514L,34734L,104754L,314922L,946623L,2842077L,8532147L,25603788L,76830033L,230513439L,691598901L,2074870002L,6224790639L,18674600664L,56024355396L,168073769199L,504222998115L,1512671142432L,4538018555652L,13614062210490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242587Inst : IEnumerable<long>
{
public static readonly long[] Value=A242587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242587.Bytes);
public long this[int i]=>Value[i];

public static A242587Inst Instance=new A242587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242588
{
public static readonly long[] Value={ 1L,8L,8L,2L,3L,1L,2L,6L,4L,4L,3L,8L,9L,6L,6L,0L,1L,6L,0L,1L,0L,5L,6L,0L,0L,8L,3L,8L,8L,6L,8L,3L,6L,7L,5L,8L,7L,8L,5L,2L,4L,6L,2L,8L,8L,0L,3L,1L,0L,7L,0L,7L,9L,6L,0L,5L,5L,2L,9L,3L,2L,3L,1L,4L,5L,7L,7L,2L,1L,0L,3L,7L,9L,6L,1L,0L,6L,0L,3L,5L,8L,1L,2L,7L,2L,3L,9L,9L,9L,9L,1L,4L,8L,4L,5L,6L,2L,0L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242588Inst : IEnumerable<long>
{
public static readonly long[] Value=A242588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242588.Bytes);
public long this[int i]=>Value[i];

public static A242588Inst Instance=new A242588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242589
{
public static readonly long[] Value={ 5L,19L,37L,43L,97L,107L,6091L,6389L,7121L,21727L,147107L,148151L,148279L,148429L,148469L,172877L,173209L,173741L,2621387L,5642293L,5642321L,8932771L,8981827L,8981879L,9094979L,9095089L,9997783L,10010687L,10010789L,10037749L,10144523L,40179929L,40365217L,40379077L,40379197L,40386811L,40612933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242589Inst : IEnumerable<long>
{
public static readonly long[] Value=A242589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242589.Bytes);
public long this[int i]=>Value[i];

public static A242589Inst Instance=new A242589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242590
{
public static readonly long[] Value={ 1L,2L,3L,9L,10L,11L,12L,13L,19L,20L,21L,22L,23L,29L,30L,31L,32L,33L,39L,90L,91L,92L,93L,99L,100L,101L,102L,103L,109L,110L,111L,112L,113L,119L,120L,121L,122L,123L,129L,130L,131L,132L,133L,139L,190L,191L,192L,193L,199L,200L,201L,202L,203L,209L,210L,211L,212L,213L,219L,220L,221L,222L,223L,229L,230L,231L,232L,233L,239L,290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242590Inst : IEnumerable<long>
{
public static readonly long[] Value=A242590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242590.Bytes);
public long this[int i]=>Value[i];

public static A242590Inst Instance=new A242590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242591
{
public static readonly long[] Value={ 1L,12L,2L,2L,1L,54L,6L,2L,9L,2L,2L,6L,1L,3L,32L,6L,28L,6L,24L,3L,8L,24L,3L,18L,1L,12L,85L,6L,100L,16L,95L,12L,60L,4L,25L,240L,6L,70L,4L,50L,1L,30L,201L,10L,60L,40L,330L,35L,266L,20L,150L,5L,66L,588L,20L,210L,10L,180L,5L,120L,1L,60L,462L,15L,147L,1512L,1050L,90L,952L,66L,672L,30L,357L,6L,147L,1344L,35L,336L,20L,546L,15L,420L,6L,252L,1L,105L,1044L,21L,336L,3564L,70L,210L,3024L,182L,2464L,112L,1576L,42L,784L,7L,288L,2970L,56L,756L,8700L,1456L,35L,1288L,21L,896L,7L,476L,1L,168L,2277L,28L,702L,7965L,126L,1680L,8736L,448L,7938L,336L,5868L,176L,3453L,56L,1584L,8L,513L,6390L,84L,1620L,19965L,252L,70L,3528L,56L,2808L,28L,1764L,8L,828L,1L,252L,4720L,36L,1350L,17182L,210L,3630L,47124L,1008L,23220L,882L,19260L,576L,13050L,261L,7090L,72L,2970L,9L,850L,13310L,120L,3267L,43824L,462L,7920L,8820L,126L,7920L,84L,5715L,36L,3240L,9L,1350L,1L,360L,9251L,45L,2420L,35970L,330L,7524L,105963L,924L,62700L,2100L,57387L,1620L,43725L,930L,27335L,370L,13706L,90L,5225L,10L,1331L,26664L,165L,6204L,92950L,792L,16731L,244244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242591Inst : IEnumerable<long>
{
public static readonly long[] Value=A242591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242591.Bytes);
public long this[int i]=>Value[i];

public static A242591Inst Instance=new A242591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242720
{
public static readonly long[] Value={ 12L,38L,80L,212L,224L,440L,440L,854L,1250L,1460L,1742L,2282L,2282L,3434L,4190L,4664L,4760L,4760L,6890L,8054L,8054L,8054L,12374L,12830L,12830L,13592L,13592L,14282L,17402L,17402L,18212L,22502L,22502L,22502L,25220L,28202L,28202L,32234L,32402L,32402L,38012L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242720Inst : IEnumerable<long>
{
public static readonly long[] Value=A242720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242720.Bytes);
public long this[int i]=>Value[i];

public static A242720Inst Instance=new A242720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242721
{
public static readonly long[] Value={ 1L,1L,1L,4L,3L,0L,5L,5L,5L,0L,8L,4L,8L,6L,9L,0L,0L,0L,2L,3L,0L,1L,6L,9L,3L,5L,8L,4L,9L,4L,4L,8L,2L,1L,1L,3L,4L,8L,2L,7L,3L,7L,8L,2L,5L,6L,3L,1L,9L,1L,7L,7L,4L,2L,5L,5L,7L,0L,0L,9L,1L,8L,1L,3L,7L,4L,3L,5L,0L,7L,0L,2L,7L,9L,3L,3L,4L,4L,4L,3L,4L,3L,0L,9L,6L,1L,2L,9L,5L,5L,1L,9L,1L,0L,2L,2L,8L,9L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242721Inst : IEnumerable<long>
{
public static readonly long[] Value=A242721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242721.Bytes);
public long this[int i]=>Value[i];

public static A242721Inst Instance=new A242721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242722
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,5L,16L,6L,7L,9L,32L,10L,64L,12L,11L,15L,128L,13L,256L,17L,14L,18L,512L,19L,31L,20L,21L,23L,1024L,22L,2048L,24L,25L,33L,47L,26L,4096L,34L,28L,27L,8192L,35L,16384L,29L,37L,36L,32768L,30L,127L,40L,38L,39L,65536L,41L,55L,43L,42L,48L,131072L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242722Inst : IEnumerable<long>
{
public static readonly long[] Value=A242722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242722.Bytes);
public long this[int i]=>Value[i];

public static A242722Inst Instance=new A242722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242723
{
public static readonly long[] Value={ 1L,1L,6L,5L,6L,5L,0L,5L,1L,1L,7L,7L,0L,7L,7L,9L,8L,9L,3L,5L,1L,5L,7L,2L,1L,9L,3L,7L,2L,0L,4L,5L,3L,2L,9L,4L,6L,7L,1L,2L,0L,4L,2L,1L,4L,2L,9L,9L,6L,4L,5L,2L,2L,1L,0L,2L,7L,9L,8L,6L,0L,1L,6L,3L,1L,5L,2L,8L,8L,0L,6L,5L,8L,2L,1L,4L,8L,4L,7L,4L,0L,6L,1L,1L,7L,0L,8L,5L,7L,3L,8L,1L,0L,6L,0L,2L,1L,6L,4L,7L,2L,1L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242723Inst : IEnumerable<long>
{
public static readonly long[] Value=A242723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242723.Bytes);
public long this[int i]=>Value[i];

public static A242723Inst Instance=new A242723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242724
{
public static readonly long[] Value={ 6L,2L,9L,4L,6L,5L,0L,2L,0L,4L,5L,5L,1L,8L,6L,7L,7L,1L,8L,3L,1L,2L,9L,4L,2L,2L,9L,1L,0L,7L,2L,3L,2L,1L,2L,2L,6L,9L,3L,5L,3L,0L,0L,6L,9L,2L,3L,9L,0L,8L,8L,0L,5L,6L,1L,7L,5L,7L,0L,4L,5L,6L,1L,3L,2L,9L,8L,3L,4L,7L,4L,4L,3L,6L,1L,7L,3L,6L,2L,4L,9L,1L,9L,5L,3L,9L,9L,8L,8L,7L,7L,9L,4L,0L,7L,3L,7L,3L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242724Inst : IEnumerable<long>
{
public static readonly long[] Value=A242724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242724.Bytes);
public long this[int i]=>Value[i];

public static A242724Inst Instance=new A242724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242725
{
public static readonly long[] Value={ 1L,1L,3L,10L,37L,137L,511L,1906L,7113L,26545L,99067L,369722L,1379821L,5149561L,19218423L,71724130L,267678097L,998988257L,3728274931L,13914111466L,51928170933L,193798572265L,723266118127L,2699265900242L,10073797482841L,37595924031121L,140309898641643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242725Inst : IEnumerable<long>
{
public static readonly long[] Value=A242725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242725.Bytes);
public long this[int i]=>Value[i];

public static A242725Inst Instance=new A242725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242726
{
public static readonly long[] Value={ 66L,286L,606L,682L,2222L,2486L,2626L,2882L,3333L,3939L,5555L,6262L,6842L,6886L,7777L,9393L,14443L,18887L,22462L,22682L,22826L,24266L,26422L,26462L,26686L,28622L,33693L,34441L,36399L,39633L,39693L,62822L,66242L,68662L,78881L,99363L,118877L,125543L,145541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242726Inst : IEnumerable<long>
{
public static readonly long[] Value=A242726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242726.Bytes);
public long this[int i]=>Value[i];

public static A242726Inst Instance=new A242726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242727
{
public static readonly long[] Value={ 1L,7L,29L,86L,198L,396L,719L,1203L,1899L,2866L,4156L,5840L,7997L,10695L,14025L,18086L,22962L,28764L,35611L,43603L,52871L,63554L,75768L,89664L,105401L,123111L,142965L,165142L,189790L,217100L,247271L,280467L,316899L,356786L,400308L,447696L,499189L,554983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242727Inst : IEnumerable<long>
{
public static readonly long[] Value=A242727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242727.Bytes);
public long this[int i]=>Value[i];

public static A242727Inst Instance=new A242727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242728
{
public static readonly long[] Value={ 1L,2L,7L,25L,93L,346L,1291L,4817L,17977L,67090L,250383L,934441L,3487381L,13015082L,48572947L,181276705L,676533873L,2524858786L,9422901271L,35166746297L,131244083917L,489809589370L,1827994273563L,6822167504881L,25460675745961L,95020535478962L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242728Inst : IEnumerable<long>
{
public static readonly long[] Value=A242728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242728.Bytes);
public long this[int i]=>Value[i];

public static A242728Inst Instance=new A242728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242729
{
public static readonly long[] Value={ 3L,1L,6L,6L,8L,4L,1L,7L,3L,6L,5L,2L,7L,0L,5L,8L,2L,0L,2L,1L,8L,3L,5L,6L,5L,7L,2L,3L,0L,8L,2L,8L,8L,3L,2L,9L,6L,4L,6L,6L,7L,9L,9L,5L,4L,3L,9L,1L,7L,0L,8L,3L,4L,4L,6L,0L,2L,2L,0L,0L,5L,6L,8L,8L,2L,0L,2L,0L,0L,1L,4L,0L,2L,1L,2L,6L,1L,4L,6L,8L,2L,5L,6L,5L,6L,5L,0L,1L,7L,8L,9L,8L,2L,5L,5L,0L,4L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242729Inst : IEnumerable<long>
{
public static readonly long[] Value=A242729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242729.Bytes);
public long this[int i]=>Value[i];

public static A242729Inst Instance=new A242729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242730
{
public static readonly long[] Value={ 2L,3L,5L,1L,2L,5L,2L,8L,4L,8L,1L,1L,1L,7L,4L,8L,6L,5L,6L,3L,5L,5L,8L,8L,1L,7L,4L,3L,9L,1L,8L,7L,9L,0L,0L,9L,8L,8L,0L,9L,8L,4L,5L,1L,9L,5L,8L,3L,5L,2L,9L,5L,9L,8L,5L,8L,2L,6L,7L,7L,9L,6L,6L,3L,1L,6L,7L,0L,3L,1L,9L,0L,5L,1L,3L,7L,1L,3L,2L,4L,8L,7L,4L,7L,1L,4L,0L,9L,0L,0L,0L,0L,1L,5L,0L,0L,3L,1L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242730Inst : IEnumerable<long>
{
public static readonly long[] Value=A242730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242730.Bytes);
public long this[int i]=>Value[i];

public static A242730Inst Instance=new A242730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242731
{
public static readonly long[] Value={ 5L,6L,8L,10L,12L,17L,7L,9L,11L,13L,16L,6L,10L,9L,12L,15L,16L,14L,18L,22L,27L,20L,26L,32L,37L,8L,14L,18L,18L,22L,22L,27L,27L,32L,20L,20L,26L,32L,32L,37L,37L,42L,42L,26L,34L,42L,47L,52L,8L,11L,14L,10L,13L,11L,14L,14L,17L,16L,20L,20L,24L,12L,8L,10L,14L,22L,30L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242731Inst : IEnumerable<long>
{
public static readonly long[] Value=A242731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242731.Bytes);
public long this[int i]=>Value[i];

public static A242731Inst Instance=new A242731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242732
{
public static readonly long[] Value={ 8L,10L,15L,20L,25L,35L,12L,16L,20L,20L,25L,9L,15L,15L,20L,25L,24L,27L,36L,45L,55L,33L,44L,55L,65L,14L,24L,32L,32L,40L,40L,50L,50L,60L,36L,36L,48L,60L,60L,70L,70L,80L,80L,42L,56L,70L,80L,90L,13L,17L,21L,19L,23L,22L,26L,26L,30L,35L,40L,40L,45L,20L,15L,18L,27L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242732Inst : IEnumerable<long>
{
public static readonly long[] Value=A242732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242732.Bytes);
public long this[int i]=>Value[i];

public static A242732Inst Instance=new A242732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242733
{
public static readonly long[] Value={ 5L,6L,9L,12L,15L,20L,7L,9L,11L,9L,11L,5L,7L,8L,10L,12L,10L,15L,20L,25L,30L,15L,20L,25L,30L,8L,12L,16L,16L,20L,20L,25L,25L,30L,18L,18L,24L,30L,30L,35L,35L,40L,40L,18L,24L,30L,35L,40L,7L,8L,9L,11L,12L,13L,14L,14L,15L,21L,22L,22L,23L,10L,9L,10L,15L,28L,32L,65L,70L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242733Inst : IEnumerable<long>
{
public static readonly long[] Value=A242733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242733.Bytes);
public long this[int i]=>Value[i];

public static A242733Inst Instance=new A242733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242734
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,2L,2L,4L,3L,2L,3L,2L,3L,2L,2L,3L,6L,4L,5L,4L,6L,6L,17L,9L,2L,3L,6L,1L,3L,22L,3L,2L,2L,8L,12L,15L,7L,4L,17L,25L,41L,20L,11L,23L,22L,54L,3L,28L,3L,7L,43L,14L,24L,13L,6L,61L,10L,10L,30L,17L,4L,8L,4L,32L,68L,1L,21L,29L,28L,17L,16L,23L,17L,46L,69L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242734Inst : IEnumerable<long>
{
public static readonly long[] Value=A242734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242734.Bytes);
public long this[int i]=>Value[i];

public static A242734Inst Instance=new A242734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242735
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,-3L,-1L,1L,3L,15L,3L,-1L,3L,15L,-35L,-5L,1L,-1L,5L,35L,315L,35L,-5L,3L,-5L,35L,315L,-693L,-63L,7L,-3L,3L,-7L,63L,693L,3003L,231L,-21L,7L,-5L,7L,-21L,231L,3003L,-6435L,-429L,33L,-9L,5L,-5L,9L,-33L,429L,6435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242735Inst : IEnumerable<long>
{
public static readonly long[] Value=A242735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242735.Bytes);
public long this[int i]=>Value[i];

public static A242735Inst Instance=new A242735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242800
{
public static readonly long[] Value={ 1L,3L,4L,5L,9L,13L,17L,21L,25L,37L,41L,45L,49L,57L,65L,73L,77L,89L,109L,113L,117L,121L,145L,151L,161L,169L,185L,205L,209L,233L,237L,241L,261L,265L,277L,281L,289L,313L,329L,337L,353L,361L,385L,401L,409L,425L,433L,449L,481L,489L,505L,517L,521L,545L,553L,586L,593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242800Inst : IEnumerable<long>
{
public static readonly long[] Value=A242800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242800.Bytes);
public long this[int i]=>Value[i];

public static A242800Inst Instance=new A242800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242801
{
public static readonly long[] Value={ 3L,4L,3L,6L,3L,8L,5L,4L,3L,4L,5L,7L,11L,4L,5L,18L,4L,20L,5L,8L,3L,11L,9L,4L,5L,13L,9L,16L,7L,19L,7L,4L,11L,5L,5L,7L,19L,4L,9L,16L,7L,9L,5L,6L,15L,16L,5L,8L,7L,7L,9L,13L,19L,12L,5L,7L,12L,29L,4L,5L,16L,16L,9L,10L,7L,16L,13L,16L,6L,17L,9L,13L,5L,16L,5L,9L,7L,13L,7L,4L,9L,41L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242801Inst : IEnumerable<long>
{
public static readonly long[] Value=A242801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242801.Bytes);
public long this[int i]=>Value[i];

public static A242801Inst Instance=new A242801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242802
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,2L,2L,2L,4L,2L,2L,2L,4L,3L,4L,3L,3L,3L,3L,5L,4L,3L,5L,5L,3L,4L,2L,3L,3L,4L,2L,3L,4L,5L,3L,4L,2L,3L,3L,5L,3L,5L,4L,7L,3L,3L,5L,7L,4L,7L,6L,4L,5L,9L,5L,5L,5L,5L,6L,9L,4L,5L,8L,6L,8L,6L,4L,6L,8L,5L,10L,7L,6L,8L,9L,5L,14L,10L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242802Inst : IEnumerable<long>
{
public static readonly long[] Value=A242802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242802.Bytes);
public long this[int i]=>Value[i];

public static A242802Inst Instance=new A242802Inst();

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