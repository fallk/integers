using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A275347
{
public static readonly long[] Value={ 5L,81L,288L,1024L,4100L,16956L,70272L,291320L,1211092L,5070832L,21255328L,89170864L,374453028L,1574982464L,6627474512L,27898519192L,117476409700L,494869331248L,2084962994672L,8785404327328L,37022705828932L,156033713723616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275347Inst : IEnumerable<long>
{
public static readonly long[] Value=A275347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275347.Bytes);
public long this[int i]=>Value[i];

public static A275347Inst Instance=new A275347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275380
{
public static readonly long[] Value={ 0L,2L,1L,2L,2L,3L,3L,5L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275380Inst : IEnumerable<long>
{
public static readonly long[] Value=A275380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275380.Bytes);
public long this[int i]=>Value[i];

public static A275380Inst Instance=new A275380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275381
{
public static readonly long[] Value={ 1L,1L,2L,2L,5L,4L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275381Inst : IEnumerable<long>
{
public static readonly long[] Value=A275381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275381.Bytes);
public long this[int i]=>Value[i];

public static A275381Inst Instance=new A275381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275382
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,2L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275382Inst : IEnumerable<long>
{
public static readonly long[] Value=A275382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275382.Bytes);
public long this[int i]=>Value[i];

public static A275382Inst Instance=new A275382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275383
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,2L,5L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275383Inst : IEnumerable<long>
{
public static readonly long[] Value=A275383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275383.Bytes);
public long this[int i]=>Value[i];

public static A275383Inst Instance=new A275383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275384
{
public static readonly long[] Value={ 15L,21L,33L,35L,39L,42L,51L,55L,57L,65L,69L,77L,78L,85L,87L,91L,93L,95L,105L,110L,111L,114L,115L,119L,123L,129L,133L,141L,143L,145L,155L,159L,161L,170L,177L,183L,185L,186L,187L,195L,201L,203L,205L,209L,213L,215L,217L,219L,221L,222L,230L,231L,235L,237L,247L,249L,253L,258L,259L,265L,267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275384Inst : IEnumerable<long>
{
public static readonly long[] Value=A275384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275384.Bytes);
public long this[int i]=>Value[i];

public static A275384Inst Instance=new A275384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275385
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,73L,580L,5601L,63994L,844929L,12647016L,211616065L,3914510446L,79320037281L,1747219469164L,41569414869633L,1062343684252530L,29023112392093441L,844101839207139280L,BigInteger.Parse("26038508978625589377"),BigInteger.Parse("849150487829425227094"),BigInteger.Parse("29189561873274715264545") };
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
public class A275385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275385Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275385.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275385.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275385Inst Instance=new A275385Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275386
{
public static readonly long[] Value={ 1L,3L,7L,9L,11L,17L,21L,23L,13L,19L,27L,29L,33L,47L,39L,41L,31L,57L,61L,37L,43L,63L,67L,53L,49L,51L,59L,69L,71L,77L,83L,79L,73L,81L,91L,87L,97L,109L,89L,101L,111L,113L,99L,1037L,121L,107L,93L,103L,123L,127L,129L,131L,119L,1023L,1031L,117L,1039L,133L,1009L,153L,157L,141L,143L,139L,137L,149L,159L,161L,151L,163L,171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275386Inst : IEnumerable<long>
{
public static readonly long[] Value=A275386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275386.Bytes);
public long this[int i]=>Value[i];

public static A275386Inst Instance=new A275386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275387
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,0L,3L,1L,2L,0L,8L,0L,2L,2L,6L,0L,8L,0L,8L,2L,2L,0L,18L,1L,2L,3L,8L,0L,15L,0L,10L,2L,2L,2L,24L,0L,2L,2L,18L,0L,15L,0L,8L,8L,2L,0L,32L,1L,8L,2L,8L,0L,18L,2L,18L,2L,2L,0L,44L,0L,2L,8L,15L,2L,15L,0L,8L,2L,15L,0L,49L,0L,2L,8L,8L,2L,15L,0L,32L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275387Inst : IEnumerable<long>
{
public static readonly long[] Value=A275387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275387.Bytes);
public long this[int i]=>Value[i];

public static A275387Inst Instance=new A275387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275388
{
public static readonly long[] Value={ 0L,1L,2L,5L,10L,20L,37L,68L,120L,210L,360L,612L,1028L,1717L,2846L,4698L,7720L,12649L,20666L,33700L,54856L,89183L,144831L,235016L,381102L,617693L,1000753L,1620882L,2624645L,4249245L,6878455L,11133304L,18018601L,29160254L,47188998L,76361562L,123565443L,199944982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275388Inst : IEnumerable<long>
{
public static readonly long[] Value=A275388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275388.Bytes);
public long this[int i]=>Value[i];

public static A275388Inst Instance=new A275388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275389
{
public static readonly long[] Value={ 1L,1L,1L,4L,7L,19L,71L,219L,759L,2697L,12395L,47477L,231950L,1040116L,4851742L,26690821L,131478031L,736418510L,4262619682L,24680045903L,145629814329L,935900941506L,5778263418232L,37626913475878L,257550263109475L,1782180357952449L,12526035635331581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275389Inst : IEnumerable<long>
{
public static readonly long[] Value=A275389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275389.Bytes);
public long this[int i]=>Value[i];

public static A275389Inst Instance=new A275389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275390
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,15L,23L,39L,42L,43L,115L,223L,231L,239L,474L,719L,1367L,1403L,1406L,1407L,1410L,1411L,1419L,1646L,1659L,1662L,1663L,3423L,8810L,8818L,8819L,8822L,8823L,8915L,9239L,9242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275390Inst : IEnumerable<long>
{
public static readonly long[] Value=A275390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275390.Bytes);
public long this[int i]=>Value[i];

public static A275390Inst Instance=new A275390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275391
{
public static readonly long[] Value={ 1L,3L,5L,3L,3L,5L,2L,3L,5L,3L,19L,11L,11L,5L,15L,7L,15L,5L,11L,3L,5L,19L,10L,11L,7L,11L,17L,11L,13L,15L,5L,7L,29L,15L,23L,11L,11L,11L,11L,3L,15L,5L,35L,19L,23L,21L,22L,15L,13L,7L,15L,11L,23L,17L,19L,11L,11L,13L,28L,15L,11L,5L,5L,15L,15L,29L,21L,15L,65L,23L,34L,11L,4L,11L,29L,11L,39L,11L,23L,7L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275391Inst : IEnumerable<long>
{
public static readonly long[] Value=A275391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275391.Bytes);
public long this[int i]=>Value[i];

public static A275391Inst Instance=new A275391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275392
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,2L,7L,1L,2L,1L,4L,1L,13L,1L,2L,1L,4L,1L,2L,7L,1L,2L,1L,24L,1L,2L,1L,4L,1L,2L,7L,1L,2L,1L,4L,1L,13L,1L,2L,1L,4L,1L,2L,44L,1L,2L,1L,4L,1L,2L,7L,1L,2L,1L,4L,1L,13L,1L,2L,1L,4L,1L,2L,7L,1L,2L,1L,24L,1L,2L,1L,4L,1L,2L,7L,1L,2L,1L,4L,1L,81L,1L,2L,1L,4L,1L,2L,7L,1L,2L,1L,4L,1L,13L,1L,2L,1L,4L,1L,2L,7L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275392Inst : IEnumerable<long>
{
public static readonly long[] Value=A275392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275392.Bytes);
public long this[int i]=>Value[i];

public static A275392Inst Instance=new A275392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275393
{
public static readonly long[] Value={ 3L,0L,5L,3L,8L,3L,1L,9L,1L,6L,4L,3L,8L,0L,2L,7L,0L,2L,0L,2L,5L,0L,5L,5L,7L,7L,7L,7L,3L,8L,7L,3L,3L,3L,9L,7L,5L,5L,2L,4L,7L,0L,7L,8L,8L,1L,0L,9L,7L,0L,7L,5L,8L,2L,4L,9L,5L,4L,9L,7L,2L,3L,0L,6L,2L,0L,9L,7L,2L,6L,8L,6L,5L,9L,9L,3L,6L,5L,7L,3L,2L,2L,5L,0L,5L,5L,5L,1L,3L,6L,6L,4L,7L,0L,5L,7L,2L,6L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275393Inst : IEnumerable<long>
{
public static readonly long[] Value=A275393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275393.Bytes);
public long this[int i]=>Value[i];

public static A275393Inst Instance=new A275393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275394
{
public static readonly long[] Value={ 1L,9L,84L,1011L,14884L,518049L,30551417L,3146508594L,552879942836L,167170218443304L,86562563964524453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275394Inst : IEnumerable<long>
{
public static readonly long[] Value=A275394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275394.Bytes);
public long this[int i]=>Value[i];

public static A275394Inst Instance=new A275394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275395
{
public static readonly long[] Value={ 2L,9L,16L,31L,63L,129L,260L,534L,1083L,2210L,4496L,9157L,18653L,37980L,77372L,157551L,320905L,653525L,1331010L,2710764L,5520787L,11243865L,22899407L,46637722L,94983335L,193445757L,393976458L,802382692L,1634153628L,3328158969L,6778215744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275395Inst : IEnumerable<long>
{
public static readonly long[] Value=A275395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275395.Bytes);
public long this[int i]=>Value[i];

public static A275395Inst Instance=new A275395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275444
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,4L,3L,10L,6L,14L,4L,6L,26L,12L,11L,34L,36L,11L,62L,68L,8L,20L,82L,140L,32L,20L,144L,228L,112L,37L,186L,424L,264L,16L,37L,316L,664L,608L,80L,68L,404L,1176L,1168L,320L,68L,676L,1784L,2312L,896L,32L,125L,860L,3032L,4096L,2304L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275444Inst : IEnumerable<long>
{
public static readonly long[] Value=A275444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275444.Bytes);
public long this[int i]=>Value[i];

public static A275444Inst Instance=new A275444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275445
{
public static readonly long[] Value={ 0L,0L,0L,2L,4L,10L,22L,50L,106L,222L,458L,936L,1890L,3788L,7540L,14924L,29388L,57620L,112540L,219062L,425112L,822726L,1588314L,3059470L,5881254L,11284514L,21614774L,41336300L,78936358L,150533496L,286708744L,545428024L,1036468344L,1967555208L,3731449176L,7070218506L,13384916364L,25319020898L,47857031870L,90391975562L,170614347714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275445Inst : IEnumerable<long>
{
public static readonly long[] Value=A275445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275445.Bytes);
public long this[int i]=>Value[i];

public static A275445Inst Instance=new A275445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275446
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,4L,4L,10L,6L,16L,4L,8L,30L,12L,11L,48L,36L,15L,82L,76L,8L,21L,128L,164L,32L,29L,204L,312L,112L,40L,312L,596L,288L,16L,55L,482L,1064L,704L,80L,76L,728L,1884L,1536L,320L,105L,1100L,3212L,3248L,960L,32L,145L,1640L,5428L,6464L,2624L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275446Inst : IEnumerable<long>
{
public static readonly long[] Value=A275446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275446.Bytes);
public long this[int i]=>Value[i];

public static A275446Inst Instance=new A275446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275447
{
public static readonly long[] Value={ 0L,0L,0L,2L,4L,10L,24L,54L,120L,258L,552L,1164L,2432L,5042L,10384L,21268L,43344L,87962L,177840L,358358L,719964L,1442584L,2883504L,5751020L,11447164L,22743262L,45110096L,89334192L,176658732L,348875904L,688122336L,1355674528L,2667921660L,5245033102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275447Inst : IEnumerable<long>
{
public static readonly long[] Value=A275447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275447.Bytes);
public long this[int i]=>Value[i];

public static A275447Inst Instance=new A275447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275448
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,12L,28L,65L,146L,327L,749L,1756L,4165L,9913L,23652L,56687L,136627L,330969L,804915L,1963830L,4805523L,11793046L,29019930L,71589861L,177006752L,438561959L,1088714711L,2707615555L,6745272783L,16830750107L,42058592797L,105248042792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275448Inst : IEnumerable<long>
{
public static readonly long[] Value=A275448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275448.Bytes);
public long this[int i]=>Value[i];

public static A275448Inst Instance=new A275448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275449
{
public static readonly long[] Value={ 945L,7425L,81081L,78975L,1468935L,6375105L,85930875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275449Inst : IEnumerable<long>
{
public static readonly long[] Value=A275449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275449.Bytes);
public long this[int i]=>Value[i];

public static A275449Inst Instance=new A275449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275450
{
public static readonly long[] Value={ 3L,9L,21L,27L,34L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,46L,50L,51L,52L,53L,56L,57L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,73L,74L,75L,76L,77L,79L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,103L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275450Inst : IEnumerable<long>
{
public static readonly long[] Value=A275450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275450.Bytes);
public long this[int i]=>Value[i];

public static A275450Inst Instance=new A275450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275451
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,2L,2L,1L,1L,0L,2L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,3L,0L,0L,3L,2L,2L,1L,1L,1L,1L,2L,0L,5L,4L,4L,2L,4L,4L,0L,0L,4L,2L,4L,3L,1L,0L,1L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275451Inst : IEnumerable<long>
{
public static readonly long[] Value=A275451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275451.Bytes);
public long this[int i]=>Value[i];

public static A275451Inst Instance=new A275451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275452
{
public static readonly BigInteger[] Value={ 1L,84L,32760L,16302000L,9020711700L,5299182393120L,3234930051733380L,2028415806982164600L,BigInteger.Parse("1297264109283593451000"),BigInteger.Parse("842341453312777393815840"),BigInteger.Parse("553562736218491223861661024"),BigInteger.Parse("367351669654325623384052435136"),BigInteger.Parse("245756466255265144369306647476400") };
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
public class A275452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275452Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275452.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275452.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275452Inst Instance=new A275452Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275453
{
public static readonly BigInteger[] Value={ 1L,42L,13104L,5705700L,2870226450L,1565667525240L,899552741658480L,535848881630582520L,BigInteger.Parse("327799728893143306800"),BigInteger.Parse("204660966917426732512800"),BigInteger.Parse("129859500691523648952466560"),BigInteger.Parse("83483493583251639541209993720"),BigInteger.Parse("54254332317972702411364923299700"),BigInteger.Parse("35581785531539194815959254026276000") };
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
public class A275453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275453Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275453.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275453.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275453Inst Instance=new A275453Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275454
{
public static readonly BigInteger[] Value={ 1L,48L,15912L,7205484L,3731294385L,2082701917296L,1219626159039288L,738421413473848104L,BigInteger.Parse("458174434421099404008"),BigInteger.Parse("289681112497807349679360"),BigInteger.Parse("185894363292170517130962816"),BigInteger.Parse("120738965077159251405022531728"),BigInteger.Parse("79206198459248339865163888224660"),BigInteger.Parse("52397749335891513408552541281755520") };
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
public class A275454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275454Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275454.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275454.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275454Inst Instance=new A275454Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275455
{
public static readonly BigInteger[] Value={ 1L,120L,53550L,28973100L,17036182800L,10496595041856L,6664244456261700L,4320449008019199000L,BigInteger.Parse("2844426519643185378000"),BigInteger.Parse("1894935877560218667820800"),BigInteger.Parse("1274265873172890987907535424"),BigInteger.Parse("863426385292565961502380501120"),BigInteger.Parse("588738285265666300220495724048000"),BigInteger.Parse("403569219885941102398195162309056000") };
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
public class A275455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275455Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275455.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275455.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275455Inst Instance=new A275455Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275456
{
public static readonly BigInteger[] Value={ 1L,168L,85680L,50388000L,31479903000L,20342022734880L,13431668094985140L,9002968680250888200L,BigInteger.Parse("6101557410115488321000"),BigInteger.Parse("4170391891453158061891200"),BigInteger.Parse("2869634745103513910507157888"),BigInteger.Parse("1985363415926004500849300108544"),BigInteger.Parse("1379778913200535726019164327886400"),BigInteger.Parse("962553011288199733460143650698784000") };
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
public class A275456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275456Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275456.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275456.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275456Inst Instance=new A275456Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275457
{
public static readonly BigInteger[] Value={ 1L,120L,45045L,21707400L,11708971560L,6735720993408L,4039678502036100L,2494516661768577600L,BigInteger.Parse("1573990406710539567750"),BigInteger.Parse("1009797626141015909237040"),BigInteger.Parse("656436978973434195655059942"),BigInteger.Parse("431326871057383042747830748560"),BigInteger.Parse("285942228994752084893009228453460"),BigInteger.Parse("190985447073724962020463006948873600") };
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
public class A275457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275457Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275457.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275457.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275457Inst Instance=new A275457Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275458
{
public static readonly BigInteger[] Value={ 1L,210L,91728L,48348300L,27795877200L,16801416515520L,10492649333712000L,6704867164952174400L,BigInteger.Parse("4357981459741604877000"),BigInteger.Parse("2869985317222538272758000"),BigInteger.Parse("1909866367099566641482516800"),BigInteger.Parse("1281775836140482143996826609500"),BigInteger.Parse("866321769175062822028788514251300"),BigInteger.Parse("589012467640059218480339437176228000") };
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
public class A275458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275458Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275458.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275458.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275458Inst Instance=new A275458Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275459
{
public static readonly BigInteger[] Value={ 1L,240L,111384L,61056996L,36134640360L,22349791271808L,14226080375707200L,9239577908667986880UL,BigInteger.Parse("6091267058935364926620"),BigInteger.Parse("4062233028933305475849600"),BigInteger.Parse("2733980882372812975378956480"),BigInteger.Parse("1853783080629966591378982417800"),BigInteger.Parse("1264747920529034302126861656883140"),BigInteger.Parse("867379957865303554725274256161714560") };
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
public class A275459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275459Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275459.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275459.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275459Inst Instance=new A275459Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275540
{
public static readonly long[] Value={ 1L,0L,1L,5L,27L,129L,761L,5137L,40695L,363815L,3632629L,39927183L,479047667L,6227155921L,87178936305L,1307676395009L,20922800209903L,355687462555407L,6402373891522541L,121645101063561055L,2432902011892531179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275540Inst : IEnumerable<long>
{
public static readonly long[] Value=A275540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275540.Bytes);
public long this[int i]=>Value[i];

public static A275540Inst Instance=new A275540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275541
{
public static readonly long[] Value={ 0L,0L,1L,6L,25L,126L,733L,5086L,40423L,363262L,3629743L,39920638L,479011993L,6227066878L,87178426333L,1307675013118L,20922791915023L,355687438417918L,6402373740187423L,121645100594626558L,2432902008831369073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275541Inst : IEnumerable<long>
{
public static readonly long[] Value=A275541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275541.Bytes);
public long this[int i]=>Value[i];

public static A275541Inst Instance=new A275541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275542
{
public static readonly long[] Value={ 2L,3L,5L,7L,2L,3L,5L,7L,2L,2L,2L,2L,2L,3L,2L,2L,5L,2L,2L,7L,2L,2L,3L,3L,3L,2L,3L,3L,3L,3L,5L,3L,3L,7L,3L,3L,2L,3L,5L,7L,5L,5L,5L,2L,5L,3L,5L,5L,5L,5L,5L,7L,5L,5L,2L,3L,5L,7L,7L,7L,7L,2L,7L,3L,7L,7L,5L,7L,7L,7L,7L,7L,2L,3L,5L,7L,2L,3L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275542Inst : IEnumerable<long>
{
public static readonly long[] Value=A275542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275542.Bytes);
public long this[int i]=>Value[i];

public static A275542Inst Instance=new A275542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275543
{
public static readonly long[] Value={ 1L,1L,9L,17L,33L,49L,73L,97L,129L,161L,201L,241L,289L,337L,393L,449L,513L,577L,649L,721L,801L,881L,969L,1057L,1153L,1249L,1353L,1457L,1569L,1681L,1801L,1921L,2049L,2177L,2313L,2449L,2593L,2737L,2889L,3041L,3201L,3361L,3529L,3697L,3873L,4049L,4233L,4417L,4609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275543Inst : IEnumerable<long>
{
public static readonly long[] Value=A275543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275543.Bytes);
public long this[int i]=>Value[i];

public static A275543Inst Instance=new A275543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275544
{
public static readonly long[] Value={ 1L,2L,4L,8L,15L,29L,56L,108L,208L,400L,766L,1465L,2793L,5314L,10088L,19115L,36156L,68290L,128817L,242720L,456884L,859269L,1614809L,3032673L,5692145L,10678326L,20023239L,37531218L,70323203L,131725663L,246674211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275544Inst : IEnumerable<long>
{
public static readonly long[] Value=A275544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275544.Bytes);
public long this[int i]=>Value[i];

public static A275544Inst Instance=new A275544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275545
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,4L,8L,16L,34L,67L,137L,272L,540L,1061L,2074L,4022L,7763L,14914L,28556L,54499L,103729L,196945L,373201L,705964L,1333413L,2515298L,4739834L,8926089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275545Inst : IEnumerable<long>
{
public static readonly long[] Value=A275545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275545.Bytes);
public long this[int i]=>Value[i];

public static A275545Inst Instance=new A275545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275546
{
public static readonly BigInteger[] Value={ 5L,55L,2365L,113311L,5476405L,264893255L,12813875437L,619859803695L,29985188632421L,1450508002869079L,70167091762786205L,3394273427239643839L,BigInteger.Parse("164195092176119969173"),BigInteger.Parse("7942798031108524622951"),BigInteger.Parse("384226104001681151724877"),BigInteger.Parse("18586611219134532494467151"),BigInteger.Parse("899111520569015285343455941"),BigInteger.Parse("43493755633501102693569684087"),BigInteger.Parse("2103973462501643822799172235773") };
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
public class A275546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275546Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275546.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275546.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275546Inst Instance=new A275546Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275547
{
public static readonly long[] Value={ 2L,40L,46L,48L,50L,7960L,7962L,7984L,7986L,8808L,8810L,8812L,8816L,8822L,8824L,8826L,8828L,8830L,8836L,8844L,8846L,8848L,8850L,8854L,8856L,8858L,8860L,8862L,8864L,8866L,8872L,8878L,8970L,8972L,8974L,9064L,9078L,9080L,9082L,9084L,9086L,9088L,9096L,9164L,9220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275547Inst : IEnumerable<long>
{
public static readonly long[] Value=A275547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275547.Bytes);
public long this[int i]=>Value[i];

public static A275547Inst Instance=new A275547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275548
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,9L,16L,25L,43L,68L,113L,181L,298L,479L,781L,1260L,2048L,3308L,5364L,8672L,14048L,22720L,36782L,59502L,96305L,155807L,252136L,407943L,660113L,1068056L,1728210L,2796266L,4524531L,7320797L,11845394L,19166191L,31011673L,50177864L,81189642L,131367506L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275548Inst : IEnumerable<long>
{
public static readonly long[] Value=A275548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275548.Bytes);
public long this[int i]=>Value[i];

public static A275548Inst Instance=new A275548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275549
{
public static readonly BigInteger[] Value={ 1L,1L,3L,18L,136L,1625L,23436L,412972L,8390656L,193739769L,5000050000L,142656721086L,4458051717120L,151437584670385L,5556003465485760L,218946946471875000L,9223372039002259456UL,BigInteger.Parse("413620131002462320337"),BigInteger.Parse("19673204037747448432896"),BigInteger.Parse("989209827833222327690890") };
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
public class A275549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275549Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275549.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275549.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275549Inst Instance=new A275549Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275550
{
public static readonly BigInteger[] Value={ 1L,1L,2L,10L,72L,819L,11772L,206572L,206572L,4196352L,96871525L,2500050000L,71328400806L,2229026605056L,75718793541895L,2778001759096256L,109473473278652344L,4611686020574871552L,BigInteger.Parse("206810065502975099529") };
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
public class A275550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275550Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275550.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275550.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275550Inst Instance=new A275550Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275551
{
public static readonly long[] Value={ 1L,1L,2L,6L,36L,325L,3924L,58996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275551Inst : IEnumerable<long>
{
public static readonly long[] Value=A275551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275551.Bytes);
public long this[int i]=>Value[i];

public static A275551Inst Instance=new A275551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275552
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,36L,313L,3904L,58825L,1048640L,21523361L,500000256L,12968712301L,371504186368L,11649042561241L,396857386631168L,14596463012695313L,576460752303439872L,BigInteger.Parse("24330595937833434241"),BigInteger.Parse("1092955779869348331520"),BigInteger.Parse("52063675148955620766421"),BigInteger.Parse("2621440000000000000262144") };
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
public class A275552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275552Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275552.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275552.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275552Inst Instance=new A275552Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275553
{
public static readonly long[] Value={ 1L,1L,2L,4L,24L,169L,2024L,29584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275553Inst : IEnumerable<long>
{
public static readonly long[] Value=A275553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275553.Bytes);
public long this[int i]=>Value[i];

public static A275553Inst Instance=new A275553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275554
{
public static readonly long[] Value={ 1L,1L,2L,3L,14L,65L,680L,8407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275554Inst : IEnumerable<long>
{
public static readonly long[] Value=A275554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275554.Bytes);
public long this[int i]=>Value[i];

public static A275554Inst Instance=new A275554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275555
{
public static readonly long[] Value={ 1L,1L,2L,4L,16L,77L,730L,8578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275555Inst : IEnumerable<long>
{
public static readonly long[] Value=A275555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275555.Bytes);
public long this[int i]=>Value[i];

public static A275555Inst Instance=new A275555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275604
{
public static readonly long[] Value={ 1L,2L,5L,8L,11L,14L,23L,12L,19L,6L,7L,4L,3L,10L,9L,16L,13L,20L,31L,24L,25L,18L,17L,26L,29L,32L,15L,22L,35L,38L,41L,30L,37L,28L,27L,34L,21L,50L,39L,46L,43L,40L,49L,48L,55L,36L,53L,76L,33L,52L,51L,64L,57L,56L,47L,68L,45L,58L,65L,44L,67L,60L,59L,62L,73L,42L,61L,54L,71L,80L,63L,74L,77L,94L,75L,82L,79L,72L,83L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275604Inst : IEnumerable<long>
{
public static readonly long[] Value=A275604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275604.Bytes);
public long this[int i]=>Value[i];

public static A275604Inst Instance=new A275604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275605
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,51L,191L,773L,3336L,15207L,72697L,362447L,1876392L,10051083L,55544661L,315899245L,1845139684L,11048651523L,67719859612L,424287619507L,2714074517843L,17706680249505L,117704101959444L,796546613501759L,5483490237025393L,38372546811580251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275605Inst : IEnumerable<long>
{
public static readonly long[] Value=A275605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275605.Bytes);
public long this[int i]=>Value[i];

public static A275605Inst Instance=new A275605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275606
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275606Inst : IEnumerable<long>
{
public static readonly long[] Value=A275606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275606.Bytes);
public long this[int i]=>Value[i];

public static A275606Inst Instance=new A275606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275607
{
public static readonly BigInteger[] Value={ 1L,4L,27L,216L,1890L,17496L,168399L,1667952L,16888014L,173997720L,1818276174L,19225409616L,205299909828L,2210922105840L,23984556773175L,261854925711840L,2874948871877910L,31722346066169880L,351589335566716170L,3912422681494285200L,BigInteger.Parse("43694647856506630620"),BigInteger.Parse("489597172255515289680") };
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
public class A275607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275607Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275607.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275607.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275607Inst Instance=new A275607Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275608
{
public static readonly long[] Value={ 3L,6L,8L,9L,12L,13L,15L,16L,18L,20L,21L,24L,25L,26L,27L,28L,29L,30L,32L,33L,35L,36L,39L,40L,42L,43L,44L,45L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,63L,64L,65L,66L,67L,68L,69L,70L,72L,75L,76L,78L,79L,80L,81L,83L,84L,85L,86L,87L,88L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275608Inst : IEnumerable<long>
{
public static readonly long[] Value=A275608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275608.Bytes);
public long this[int i]=>Value[i];

public static A275608Inst Instance=new A275608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275609
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,2L,1L,3L,2L,0L,3L,0L,1L,4L,0L,2L,0L,3L,0L,3L,0L,2L,0L,1L,3L,1L,2L,1L,2L,3L,0L,2L,3L,1L,3L,1L,2L,4L,1L,2L,1L,2L,1L,3L,1L,3L,2L,0L,2L,0L,3L,0L,3L,0L,1L,2L,1L,3L,1L,0L,2L,0L,4L,0L,1L,3L,0L,3L,0L,3L,0L,3L,0L,2L,0L,2L,0L,1L,3L,1L,3L,1L,2L,1L,2L,1L,2L,3L,0L,3L,0L,2L,0L,2L,3L,1L,3L,1L,2L,3L,0L,2L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275609Inst : IEnumerable<long>
{
public static readonly long[] Value=A275609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275609.Bytes);
public long this[int i]=>Value[i];

public static A275609Inst Instance=new A275609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275610
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,0L,7L,0L,8L,0L,9L,0L,10L,0L,11L,0L,12L,13L,14L,0L,15L,16L,0L,17L,18L,0L,19L,20L,0L,21L,22L,0L,23L,24L,0L,25L,0L,26L,27L,28L,0L,29L,30L,31L,0L,32L,33L,34L,0L,35L,36L,37L,0L,38L,39L,40L,0L,41L,42L,0L,43L,44L,0L,45L,0L,46L,47L,0L,48L,0L,49L,50L,0L,51L,0L,52L,53L,0L,54L,0L,55L,56L,0L,57L,0L,58L,59L,0L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275610Inst : IEnumerable<long>
{
public static readonly long[] Value=A275610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275610.Bytes);
public long this[int i]=>Value[i];

public static A275610Inst Instance=new A275610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275611
{
public static readonly BigInteger[] Value={ 1L,2L,10L,310L,384710L,740009305210L,BigInteger.Parse("3285682630785061608169810"),BigInteger.Parse("75569972451698504356522006689642008796426176222510"),BigInteger.Parse("45686565890803766858880247710072390769807010129716258796255559717444312778982342222557219570421823310") };
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
public class A275611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275611Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275611.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275611.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275611Inst Instance=new A275611Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275612
{
public static readonly long[] Value={ 27664033L,46672291L,102690901L,130944133L,517697641L,545670533L,801123451L,855073301L,970355431L,1235188597L,3273820903L,3841324339L,3924969689L,4982970241L,5130186571L,5242624003L,6335800411L,7045248121L,7279379941L,7825642579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275612Inst : IEnumerable<long>
{
public static readonly long[] Value=A275612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275612.Bytes);
public long this[int i]=>Value[i];

public static A275612Inst Instance=new A275612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275613
{
public static readonly long[] Value={ 27664033L,46672291L,102690901L,130944133L,517697641L,545670533L,801123451L,855073301L,970355431L,1235188597L,3273820903L,3841324339L,3924969689L,4982970241L,5130186571L,5242624003L,6335800411L,7045248121L,7279379941L,7825642579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275613Inst : IEnumerable<long>
{
public static readonly long[] Value=A275613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275613.Bytes);
public long this[int i]=>Value[i];

public static A275613Inst Instance=new A275613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275614
{
public static readonly long[] Value={ 6L,9L,1L,5L,9L,4L,1L,9L,2L,4L,2L,1L,9L,7L,8L,0L,8L,4L,2L,8L,2L,8L,9L,2L,8L,6L,6L,9L,2L,6L,4L,3L,0L,6L,3L,6L,8L,3L,3L,8L,0L,1L,4L,3L,6L,9L,6L,2L,9L,5L,5L,4L,7L,7L,3L,3L,3L,5L,5L,0L,7L,0L,9L,8L,9L,1L,7L,3L,2L,6L,6L,8L,9L,2L,5L,2L,7L,8L,1L,0L,1L,1L,9L,0L,7L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275614Inst : IEnumerable<long>
{
public static readonly long[] Value=A275614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275614.Bytes);
public long this[int i]=>Value[i];

public static A275614Inst Instance=new A275614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275615
{
public static readonly long[] Value={ 1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L,1L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275615Inst : IEnumerable<long>
{
public static readonly long[] Value=A275615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275615.Bytes);
public long this[int i]=>Value[i];

public static A275615Inst Instance=new A275615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275616
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,11L,13L,15L,16L,17L,19L,21L,23L,25L,27L,29L,31L,32L,33L,35L,37L,39L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,63L,64L,65L,67L,69L,70L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,107L,109L,110L,111L,113L,115L,117L,119L,121L,123L,125L,127L,128L,129L,130L,131L,133L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275616Inst : IEnumerable<long>
{
public static readonly long[] Value=A275616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275616.Bytes);
public long this[int i]=>Value[i];

public static A275616Inst Instance=new A275616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275617
{
public static readonly long[] Value={ 1L,1L,2L,11L,11L,254L,1031L,15960L,178193L,2481669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275617Inst : IEnumerable<long>
{
public static readonly long[] Value=A275617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275617.Bytes);
public long this[int i]=>Value[i];

public static A275617Inst Instance=new A275617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275618
{
public static readonly long[] Value={ 0L,1L,1L,7L,74L,250L,3017L,25297L,332045L,4835964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275618Inst : IEnumerable<long>
{
public static readonly long[] Value=A275618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275618.Bytes);
public long this[int i]=>Value[i];

public static A275618Inst Instance=new A275618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275619
{
public static readonly long[] Value={ 0L,0L,2L,0L,0L,5L,12L,44L,251L,1814L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275619Inst : IEnumerable<long>
{
public static readonly long[] Value=A275619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275619.Bytes);
public long this[int i]=>Value[i];

public static A275619Inst Instance=new A275619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275668
{
public static readonly long[] Value={ 1L,3L,5L,10L,12L,15L,33L,35L,39L,42L,45L,50L,58L,68L,75L,117L,119L,164L,180L,189L,194L,216L,236L,246L,249L,259L,262L,389L,391L,404L,420L,501L,552L,604L,609L,658L,825L,827L,888L,910L,946L,1035L,1049L,1088L,1160L,1229L,1279L,1535L,1537L,1577L,1600L,1603L,1613L,1652L,1677L,1687L,1736L,1744L,1784L,1796L,1847L,1910L,1975L,2214L,2397L,2426L,2561L,2615L,2629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275668Inst : IEnumerable<long>
{
public static readonly long[] Value=A275668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275668.Bytes);
public long this[int i]=>Value[i];

public static A275668Inst Instance=new A275668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275669
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,12L,13L,15L,17L,19L,21L,22L,23L,25L,26L,27L,29L,31L,32L,33L,35L,37L,39L,40L,41L,42L,43L,45L,47L,48L,49L,51L,52L,53L,54L,55L,57L,59L,61L,62L,63L,65L,67L,68L,69L,70L,71L,72L,73L,74L,75L,77L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275669Inst : IEnumerable<long>
{
public static readonly long[] Value=A275669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275669.Bytes);
public long this[int i]=>Value[i];

public static A275669Inst Instance=new A275669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275670
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,4L,0L,8L,1L,0L,16L,4L,0L,32L,14L,0L,64L,40L,0L,128L,108L,2L,0L,256L,272L,12L,0L,512L,664L,52L,0L,1024L,1568L,188L,0L,2048L,3632L,608L,1L,0L,4096L,8256L,1816L,12L,0L,8192L,18528L,5128L,76L,0L,16384L,41088L,13856L,360L,0L,32768L,90304L,36176L,1446L,0L,65536L,196864L,91856L,5192L,4L,0L,131072L,426368L,227968L,17192L,42L,0L,262144L,918016L,555040L,53504L,284L,0L,524288L,1966848L,1329696L,158588L,1496L,0L,1048576L,4195328L,3141632L,451824L,6704L,0L,2097152L,8914432L,7334208L,1245936L,26772L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275670Inst : IEnumerable<long>
{
public static readonly long[] Value=A275670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275670.Bytes);
public long this[int i]=>Value[i];

public static A275670Inst Instance=new A275670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275671
{
public static readonly long[] Value={ 4L,6L,8L,12L,14L,18L,20L,24L,28L,30L,32L,36L,38L,40L,42L,44L,48L,54L,56L,60L,62L,68L,72L,74L,78L,80L,84L,90L,96L,98L,102L,104L,108L,110L,112L,114L,120L,124L,126L,128L,132L,138L,140L,144L,150L,152L,156L,158L,160L,162L,164L,168L,174L,176L,180L,182L,186L,192L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275671Inst : IEnumerable<long>
{
public static readonly long[] Value=A275671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275671.Bytes);
public long this[int i]=>Value[i];

public static A275671Inst Instance=new A275671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275672
{
public static readonly long[] Value={ 0L,1L,3L,4L,6L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275672Inst : IEnumerable<long>
{
public static readonly long[] Value=A275672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275672.Bytes);
public long this[int i]=>Value[i];

public static A275672Inst Instance=new A275672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275673
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,11L,13L,15L,17L,19L,22L,25L,28L,31L,34L,37L,41L,45L,49L,53L,57L,61L,66L,71L,76L,81L,86L,91L,97L,103L,109L,115L,121L,127L,134L,141L,148L,155L,162L,169L,177L,185L,193L,201L,209L,217L,226L,235L,244L,253L,262L,271L,281L,291L,301L,311L,321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275673Inst : IEnumerable<long>
{
public static readonly long[] Value=A275673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275673.Bytes);
public long this[int i]=>Value[i];

public static A275673Inst Instance=new A275673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275674
{
public static readonly long[] Value={ 1L,2L,4L,16L,25L,50L,64L,100L,361L,1444L,1600L,4096L,5776L,9025L,36100L,65536L,102400L,262144L,1478656L,1638400L,6553600L,23658496L,36966400L,94633984L,591462400L,1073741824L,2365849600L,26843545600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275674Inst : IEnumerable<long>
{
public static readonly long[] Value=A275674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275674.Bytes);
public long this[int i]=>Value[i];

public static A275674Inst Instance=new A275674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275675
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,1L,1L,2L,1L,2L,2L,1L,2L,1L,3L,2L,2L,3L,2L,4L,1L,1L,2L,2L,3L,3L,1L,1L,2L,2L,3L,3L,1L,3L,3L,2L,1L,2L,1L,5L,3L,2L,2L,3L,4L,1L,4L,2L,3L,5L,2L,2L,3L,1L,3L,3L,1L,4L,2L,4L,1L,2L,3L,2L,6L,2L,3L,3L,2L,2L,2L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275675Inst : IEnumerable<long>
{
public static readonly long[] Value=A275675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275675.Bytes);
public long this[int i]=>Value[i];

public static A275675Inst Instance=new A275675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275676
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,2L,1L,3L,2L,3L,4L,1L,1L,3L,1L,3L,4L,2L,3L,3L,3L,1L,2L,3L,2L,7L,2L,1L,4L,3L,4L,5L,3L,2L,4L,2L,4L,4L,1L,5L,8L,3L,2L,4L,1L,7L,3L,1L,2L,4L,5L,1L,5L,2L,4L,7L,3L,3L,5L,1L,3L,5L,1L,6L,6L,7L,2L,4L,5L,2L,9L,3L,4L,6L,3L,3L,2L,2L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275676Inst : IEnumerable<long>
{
public static readonly long[] Value=A275676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275676.Bytes);
public long this[int i]=>Value[i];

public static A275676Inst Instance=new A275676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275677
{
public static readonly long[] Value={ 0L,1L,2L,5L,3L,11L,4L,32L,6L,33L,7L,51L,8L,92L,9L,139L,10L,22L,12L,227L,13L,20L,14L,370L,15L,36L,16L,602L,17L,75L,18L,978L,19L,120L,21L,1586L,23L,2583L,24L,4169L,25L,202L,26L,6752L,27L,10939L,28L,29L,327L,30L,31L,34L,35L,539L,37L,38L,39L,40L,934L,41L,42L,56L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275677Inst : IEnumerable<long>
{
public static readonly long[] Value=A275677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275677.Bytes);
public long this[int i]=>Value[i];

public static A275677Inst Instance=new A275677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275678
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,3L,1L,2L,3L,4L,2L,1L,2L,3L,2L,1L,4L,4L,1L,3L,5L,3L,1L,3L,5L,5L,3L,1L,2L,7L,2L,2L,5L,3L,3L,3L,6L,2L,2L,4L,6L,7L,1L,2L,4L,7L,1L,1L,3L,5L,5L,2L,5L,5L,4L,3L,8L,4L,2L,2L,1L,7L,3L,1L,6L,8L,2L,4L,8L,6L,2L,4L,6L,3L,4L,1L,3L,6L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275678Inst : IEnumerable<long>
{
public static readonly long[] Value=A275678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275678.Bytes);
public long this[int i]=>Value[i];

public static A275678Inst Instance=new A275678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275679
{
public static readonly long[] Value={ 1L,1L,1L,4L,3L,20L,43L,136L,711L,1606L,12653L,36852L,250673L,1212498L,6016715L,45081688L,196537387L,1789229594L,8963510621L,76863454428L,512264745473L,3744799424978L,32870550965259L,219159966518160L,2257073412153459L,15778075163815474L,165231652982941085L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275679Inst : IEnumerable<long>
{
public static readonly long[] Value=A275679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275679.Bytes);
public long this[int i]=>Value[i];

public static A275679Inst Instance=new A275679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275680
{
public static readonly long[] Value={ 1L,9L,70L,10L,12L,72L,74L,30L,75L,14L,90L,76L,15L,16L,33L,18L,100L,91L,92L,93L,77L,34L,78L,700L,102L,104L,94L,105L,106L,35L,36L,702L,703L,95L,38L,39L,704L,300L,108L,705L,706L,96L,707L,98L,301L,99L,110L,302L,303L,710L,304L,111L,712L,112L,306L,115L,116L,308L,310L,900L,117L,118L,119L,312L,120L,121L,316L,318L,122L,319L,123L,124L,901L,125L,902L,904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275680Inst : IEnumerable<long>
{
public static readonly long[] Value=A275680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275680.Bytes);
public long this[int i]=>Value[i];

public static A275680Inst Instance=new A275680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275681
{
public static readonly long[] Value={ 7L,13L,19L,17L,23L,29L,31L,37L,43L,47L,53L,59L,67L,73L,79L,97L,103L,109L,101L,107L,113L,151L,157L,163L,167L,173L,179L,227L,233L,239L,257L,263L,269L,271L,277L,283L,347L,353L,359L,367L,373L,379L,557L,563L,569L,587L,593L,599L,607L,613L,619L,647L,653L,659L,727L,733L,739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275681Inst : IEnumerable<long>
{
public static readonly long[] Value=A275681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275681.Bytes);
public long this[int i]=>Value[i];

public static A275681Inst Instance=new A275681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275682
{
public static readonly long[] Value={ 11L,17L,23L,29L,41L,47L,53L,59L,61L,67L,73L,79L,251L,257L,263L,269L,601L,607L,613L,619L,641L,647L,653L,659L,1091L,1097L,1103L,1109L,1481L,1487L,1493L,1499L,1601L,1607L,1613L,1619L,1741L,1747L,1753L,1759L,1861L,1867L,1873L,1879L,2371L,2377L,2383L,2389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275682Inst : IEnumerable<long>
{
public static readonly long[] Value=A275682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275682.Bytes);
public long this[int i]=>Value[i];

public static A275682Inst Instance=new A275682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275683
{
public static readonly long[] Value={ 4L,2821L,1821127L,1598241813L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275683Inst : IEnumerable<long>
{
public static readonly long[] Value=A275683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275683.Bytes);
public long this[int i]=>Value[i];

public static A275683Inst Instance=new A275683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275716
{
public static readonly long[] Value={ 1L,2L,9L,3L,42L,17L,12L,4L,209L,115L,82L,41L,59L,26L,19L,5L,1042L,801L,572L,444L,409L,283L,202L,57L,292L,180L,129L,48L,92L,31L,22L,6L,5209L,5603L,4002L,4881L,2859L,3106L,2219L,733L,2042L,1977L,1412L,620L,1009L,395L,282L,97L,1459L,1258L,899L,525L,642L,334L,239L,74L,459L,213L,152L,63L,109L,40L,29L,7L,26042L,39217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275716Inst : IEnumerable<long>
{
public static readonly long[] Value=A275716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275716.Bytes);
public long this[int i]=>Value[i];

public static A275716Inst Instance=new A275716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275717
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,12L,14L,15L,16L,18L,20L,24L,26L,27L,30L,32L,35L,36L,38L,39L,40L,42L,44L,45L,48L,50L,52L,54L,56L,60L,62L,63L,64L,66L,68L,70L,72L,74L,75L,78L,80L,81L,84L,86L,87L,88L,90L,92L,95L,96L,98L,100L,102L,104L,108L,110L,112L,114L,116L,117L,119L,120L,122L,123L,124L,125L,126L,128L,130L,132L,135L,138L,140L,143L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275717Inst : IEnumerable<long>
{
public static readonly long[] Value=A275717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275717.Bytes);
public long this[int i]=>Value[i];

public static A275717Inst Instance=new A275717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275718
{
public static readonly long[] Value={ 5L,7L,9L,10L,11L,13L,17L,19L,21L,22L,23L,25L,28L,29L,31L,33L,34L,37L,41L,43L,46L,47L,49L,51L,53L,55L,57L,58L,59L,61L,65L,67L,69L,71L,73L,76L,77L,79L,82L,83L,85L,89L,91L,93L,94L,97L,99L,101L,103L,105L,106L,107L,109L,111L,113L,115L,118L,121L,127L,129L,131L,133L,134L,136L,137L,139L,141L,142L,145L,148L,149L,151L,153L,154L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275718Inst : IEnumerable<long>
{
public static readonly long[] Value=A275718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275718.Bytes);
public long this[int i]=>Value[i];

public static A275718Inst Instance=new A275718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275719
{
public static readonly long[] Value={ 3L,4L,5L,4L,3L,1L,3L,4L,5L,4L,3L,1L,2L,2L,1L,1L,-1L,1L,3L,4L,6L,5L,5L,6L,5L,5L,5L,4L,3L,1L,3L,4L,5L,5L,5L,6L,5L,5L,7L,5L,5L,8L,7L,7L,7L,9L,9L,9L,8L,9L,8L,7L,7L,7L,5L,5L,6L,7L,11L,12L,12L,13L,12L,13L,13L,14L,15L,14L,15L,16L,14L,13L,13L,11L,11L,11L,14L,13L,14L,11L,11L,13L,13L,15L,14L,14L,13L,13L,14L,13L,15L,15L,13L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275719Inst : IEnumerable<long>
{
public static readonly long[] Value=A275719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275719.Bytes);
public long this[int i]=>Value[i];

public static A275719Inst Instance=new A275719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275720
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,3L,2L,3L,2L,1L,0L,1L,0L,1L,2L,3L,2L,3L,2L,3L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,2L,3L,2L,3L,2L,3L,4L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,1L,0L,1L,0L,1L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,4L,3L,2L,3L,2L,3L,4L,3L,2L,3L,2L,3L,4L,5L,4L,5L,4L,5L,4L,3L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,4L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275720Inst : IEnumerable<long>
{
public static readonly long[] Value=A275720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275720.Bytes);
public long this[int i]=>Value[i];

public static A275720Inst Instance=new A275720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275721
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,13L,14L,15L,17L,19L,23L,25L,26L,29L,31L,34L,35L,37L,38L,39L,41L,43L,44L,47L,49L,51L,53L,55L,59L,61L,62L,63L,65L,67L,69L,71L,73L,74L,77L,79L,80L,83L,85L,86L,87L,89L,91L,94L,95L,97L,99L,101L,103L,107L,109L,111L,113L,115L,116L,118L,119L,121L,122L,123L,124L,125L,127L,129L,131L,134L,137L,139L,142L,143L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275721Inst : IEnumerable<long>
{
public static readonly long[] Value=A275721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275721.Bytes);
public long this[int i]=>Value[i];

public static A275721Inst Instance=new A275721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275722
{
public static readonly long[] Value={ 4L,6L,8L,9L,10L,12L,16L,18L,20L,21L,22L,24L,27L,28L,30L,32L,33L,36L,40L,42L,45L,46L,48L,50L,52L,54L,56L,57L,58L,60L,64L,66L,68L,70L,72L,75L,76L,78L,81L,82L,84L,88L,90L,92L,93L,96L,98L,100L,102L,104L,105L,106L,108L,110L,112L,114L,117L,120L,126L,128L,130L,132L,133L,135L,136L,138L,140L,141L,144L,147L,148L,150L,152L,153L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275722Inst : IEnumerable<long>
{
public static readonly long[] Value=A275722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275722.Bytes);
public long this[int i]=>Value[i];

public static A275722Inst Instance=new A275722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275723
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,2L,4L,1L,2L,3L,4L,5L,1L,2L,2L,4L,5L,6L,1L,2L,3L,4L,3L,4L,7L,1L,2L,2L,4L,2L,6L,7L,8L,1L,2L,3L,4L,2L,4L,7L,8L,9L,1L,2L,2L,4L,2L,6L,7L,8L,4L,10L,1L,2L,3L,4L,5L,4L,7L,8L,9L,10L,11L,1L,2L,2L,4L,5L,6L,7L,8L,4L,6L,11L,12L,1L,2L,3L,4L,3L,4L,5L,8L,9L,4L,11L,8L,13L,1L,2L,2L,4L,2L,6L,5L,8L,4L,4L,11L,12L,13L,14L,1L,2L,3L,4L,2L,4L,3L,8L,9L,4L,11L,8L,13L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275723Inst : IEnumerable<long>
{
public static readonly long[] Value=A275723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275723.Bytes);
public long this[int i]=>Value[i];

public static A275723Inst Instance=new A275723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275724
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,4L,2L,2L,1L,5L,4L,3L,2L,1L,6L,5L,4L,2L,2L,1L,7L,4L,3L,4L,3L,2L,1L,8L,7L,6L,2L,4L,2L,2L,1L,9L,8L,7L,4L,2L,4L,3L,2L,1L,10L,4L,8L,7L,6L,2L,4L,2L,2L,1L,11L,10L,9L,8L,7L,4L,5L,4L,3L,2L,1L,12L,11L,6L,4L,8L,7L,6L,5L,4L,2L,2L,1L,13L,8L,11L,4L,9L,8L,5L,4L,3L,4L,3L,2L,1L,14L,13L,12L,11L,4L,4L,8L,5L,6L,2L,4L,2L,2L,1L,15L,14L,13L,8L,11L,4L,9L,8L,3L,4L,2L,4L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275724Inst : IEnumerable<long>
{
public static readonly long[] Value=A275724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275724.Bytes);
public long this[int i]=>Value[i];

public static A275724Inst Instance=new A275724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275725
{
public static readonly long[] Value={ 2L,4L,18L,8L,12L,8L,150L,100L,54L,16L,24L,16L,90L,40L,54L,16L,36L,16L,60L,40L,36L,16L,24L,16L,1470L,980L,882L,392L,588L,392L,750L,500L,162L,32L,48L,32L,270L,80L,162L,32L,108L,32L,120L,80L,72L,32L,48L,32L,1050L,700L,378L,112L,168L,112L,750L,500L,162L,32L,48L,32L,450L,200L,162L,32L,72L,32L,300L,200L,108L,32L,48L,32L,630L,280L,378L,112L,252L,112L,450L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275725Inst : IEnumerable<long>
{
public static readonly long[] Value=A275725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275725.Bytes);
public long this[int i]=>Value[i];

public static A275725Inst Instance=new A275725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275726
{
public static readonly long[] Value={ 1L,2L,5L,3L,4L,3L,11L,10L,7L,4L,5L,4L,9L,7L,7L,4L,6L,4L,8L,7L,6L,4L,5L,4L,23L,22L,21L,19L,20L,19L,15L,14L,9L,5L,6L,5L,11L,8L,9L,5L,8L,5L,9L,8L,7L,5L,6L,5L,19L,18L,15L,12L,13L,12L,15L,14L,9L,5L,6L,5L,13L,11L,9L,5L,7L,5L,12L,11L,8L,5L,6L,5L,17L,15L,15L,12L,14L,12L,13L,11L,9L,5L,7L,5L,11L,8L,9L,5L,8L,5L,10L,8L,8L,5L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275726Inst : IEnumerable<long>
{
public static readonly long[] Value=A275726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275726.Bytes);
public long this[int i]=>Value[i];

public static A275726Inst Instance=new A275726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275727
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,3L,4L,5L,6L,7L,6L,7L,4L,5L,6L,7L,6L,7L,4L,5L,6L,7L,6L,7L,8L,9L,10L,11L,10L,11L,12L,13L,14L,15L,14L,15L,12L,13L,14L,15L,14L,15L,12L,13L,14L,15L,14L,15L,8L,9L,10L,11L,10L,11L,12L,13L,14L,15L,14L,15L,12L,13L,14L,15L,14L,15L,12L,13L,14L,15L,14L,15L,8L,9L,10L,11L,10L,11L,12L,13L,14L,15L,14L,15L,12L,13L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275727Inst : IEnumerable<long>
{
public static readonly long[] Value=A275727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275727.Bytes);
public long this[int i]=>Value[i];

public static A275727Inst Instance=new A275727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275728
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,2L,4L,5L,6L,7L,5L,6L,2L,3L,4L,5L,3L,4L,1L,2L,3L,4L,2L,3L,8L,9L,10L,11L,9L,10L,12L,13L,14L,15L,13L,14L,10L,11L,12L,13L,11L,12L,9L,10L,11L,12L,10L,11L,4L,5L,6L,7L,5L,6L,8L,9L,10L,11L,9L,10L,6L,7L,8L,9L,7L,8L,5L,6L,7L,8L,6L,7L,2L,3L,4L,5L,3L,4L,6L,7L,8L,9L,7L,8L,4L,5L,6L,7L,5L,6L,3L,4L,5L,6L,4L,5L,1L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275728Inst : IEnumerable<long>
{
public static readonly long[] Value=A275728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275728.Bytes);
public long this[int i]=>Value[i];

public static A275728Inst Instance=new A275728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275729
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,1L,2L,2L,3L,3L,4L,2L,3L,3L,4L,4L,5L,4L,5L,5L,6L,6L,7L,1L,2L,2L,3L,3L,4L,2L,3L,3L,4L,4L,5L,3L,4L,4L,5L,5L,6L,5L,6L,6L,7L,7L,8L,2L,3L,3L,4L,4L,5L,3L,4L,4L,5L,5L,6L,4L,5L,5L,6L,6L,7L,6L,7L,7L,8L,8L,9L,4L,5L,5L,6L,6L,7L,5L,6L,6L,7L,7L,8L,6L,7L,7L,8L,8L,9L,8L,9L,9L,10L,10L,11L,8L,9L,9L,10L,10L,11L,9L,10L,10L,11L,11L,12L,10L,11L,11L,12L,12L,13L,12L,13L,13L,14L,14L,15L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275729Inst : IEnumerable<long>
{
public static readonly long[] Value=A275729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275729.Bytes);
public long this[int i]=>Value[i];

public static A275729Inst Instance=new A275729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275730
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,0L,1L,0L,2L,0L,1L,2L,1L,4L,0L,1L,2L,3L,0L,4L,0L,1L,2L,3L,4L,1L,6L,0L,1L,2L,3L,4L,5L,6L,6L,0L,1L,2L,3L,4L,5L,0L,7L,8L,0L,1L,2L,3L,4L,5L,6L,1L,6L,8L,0L,1L,2L,3L,4L,5L,6L,7L,2L,7L,10L,0L,1L,2L,3L,4L,5L,6L,7L,8L,3L,6L,10L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,4L,7L,12L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,5L,12L,12L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,0L,13L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275730Inst : IEnumerable<long>
{
public static readonly long[] Value=A275730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275730.Bytes);
public long this[int i]=>Value[i];

public static A275730Inst Instance=new A275730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275731
{
public static readonly long[] Value={ 0L,0L,0L,2L,1L,0L,2L,0L,1L,0L,4L,1L,2L,1L,0L,4L,0L,3L,2L,1L,0L,6L,1L,4L,3L,2L,1L,0L,6L,6L,5L,4L,3L,2L,1L,0L,8L,7L,0L,5L,4L,3L,2L,1L,0L,8L,6L,1L,6L,5L,4L,3L,2L,1L,0L,10L,7L,2L,7L,6L,5L,4L,3L,2L,1L,0L,10L,6L,3L,8L,7L,6L,5L,4L,3L,2L,1L,0L,12L,7L,4L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,12L,12L,5L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,14L,13L,0L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275731Inst : IEnumerable<long>
{
public static readonly long[] Value=A275731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275731.Bytes);
public long this[int i]=>Value[i];

public static A275731Inst Instance=new A275731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275796
{
public static readonly long[] Value={ 3L,20L,117L,682L,3975L,23168L,135033L,787030L,4587147L,26735852L,155827965L,908231938L,5293563663L,30853150040L,179825336577L,1048098869422L,6108767879955L,35604508410308L,207518282581893L,1209505187081050L,7049512839904407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275796Inst : IEnumerable<long>
{
public static readonly long[] Value=A275796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275796.Bytes);
public long this[int i]=>Value[i];

public static A275796Inst Instance=new A275796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275797
{
public static readonly long[] Value={ 9L,11L,21L,43L,57L,119L,249L,331L,693L,1451L,1929L,4039L,8457L,11243L,23541L,49291L,65529L,137207L,287289L,381931L,799701L,1674443L,2226057L,4660999L,9759369L,12974411L,27166293L,56881771L,75620409L,158336759L,331531257L,440748043L,922854261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275797Inst : IEnumerable<long>
{
public static readonly long[] Value=A275797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275797.Bytes);
public long this[int i]=>Value[i];

public static A275797Inst Instance=new A275797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275798
{
public static readonly BigInteger[] Value={ 1L,3L,51L,4274L,2105872L,4295278656L,35184441295872L,1152921514002096128L,BigInteger.Parse("151115727460762179076096"),BigInteger.Parse("79228162514269052299408048128") };
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
public class A275798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275798Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275798.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275798.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275798Inst Instance=new A275798Inst();

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