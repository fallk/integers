using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A190329
{
public static readonly long[] Value={ 2L,5L,9L,11L,15L,18L,20L,24L,27L,31L,33L,36L,40L,42L,46L,49L,53L,55L,58L,62L,64L,68L,71L,73L,77L,80L,84L,86L,90L,93L,95L,99L,102L,106L,108L,111L,115L,117L,121L,124L,126L,130L,133L,137L,139L,143L,146L,148L,152L,155L,159L,161L,164L,168L,170L,174L,177L,181L,183L,186L,190L,192L,196L,199L,201L,205L,208L,212L,214L,217L,221L,223L,227L,230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190329Inst : IEnumerable<long>
{
public static readonly long[] Value=A190329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190329.Bytes);
public long this[int i]=>Value[i];

public static A190329Inst Instance=new A190329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190330
{
public static readonly long[] Value={ 1L,4L,6L,8L,10L,13L,14L,17L,19L,22L,23L,26L,28L,30L,32L,35L,37L,39L,41L,44L,45L,48L,50L,52L,54L,57L,59L,61L,63L,66L,67L,70L,72L,75L,76L,79L,81L,83L,85L,88L,89L,92L,94L,97L,98L,101L,103L,105L,107L,110L,112L,114L,116L,119L,120L,123L,125L,128L,129L,132L,134L,136L,138L,141L,142L,145L,147L,150L,151L,154L,156L,158L,160L,163L,165L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190330Inst : IEnumerable<long>
{
public static readonly long[] Value=A190330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190330.Bytes);
public long this[int i]=>Value[i];

public static A190330Inst Instance=new A190330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190331
{
public static readonly long[] Value={ 0L,1L,8L,66L,544L,4484L,36960L,304648L,2511104L,20698128L,170607232L,1406254112L,11591247360L,95542487104L,787522391552L,6491264106624L,53505157636096L,441023789302016L,3635200629688320L,29963652616110592L,246979622188261376L,2035764282738312192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190331Inst : IEnumerable<long>
{
public static readonly long[] Value=A190331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190331.Bytes);
public long this[int i]=>Value[i];

public static A190331Inst Instance=new A190331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190380
{
public static readonly long[] Value={ 180180L,235620L,263340L,278460L,300300L,311220L,318780L,376740L,392700L,401940L,406980L,420420L,429660L,437580L,438900L,450450L,464100L,475020L,489060L,492660L,507780L,512820L,518700L,531300L,549780L,550620L,568260L,589050L,592020L,595980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190380Inst : IEnumerable<long>
{
public static readonly long[] Value=A190380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190380.Bytes);
public long this[int i]=>Value[i];

public static A190380Inst Instance=new A190380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190381
{
public static readonly long[] Value={ 1021020L,1141140L,1381380L,1492260L,1531530L,1711710L,1741740L,1763580L,1806420L,1861860L,2018940L,2072070L,2134860L,2222220L,2238390L,2277660L,2386020L,2434740L,2462460L,2545620L,2552550L,2582580L,2612610L,2645370L,2691780L,2709630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190381Inst : IEnumerable<long>
{
public static readonly long[] Value=A190381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190381.Bytes);
public long this[int i]=>Value[i];

public static A190381Inst Instance=new A190381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190382
{
public static readonly long[] Value={ 88200L,132300L,217800L,220500L,304200L,308700L,326700L,426888L,456300L,520200L,544500L,596232L,640332L,649800L,760500L,780300L,894348L,952200L,974700L,1019592L,1185800L,1197900L,1273608L,1300500L,1428300L,1472328L,1494108L,1513800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190382Inst : IEnumerable<long>
{
public static readonly long[] Value=A190382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190382.Bytes);
public long this[int i]=>Value[i];

public static A190382Inst Instance=new A190382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190383
{
public static readonly long[] Value={ 36960L,43680L,57120L,63840L,68640L,77280L,89760L,96096L,97440L,100320L,104160L,106080L,118560L,121440L,124320L,125664L,137760L,140448L,143520L,144480L,148512L,153120L,155040L,157920L,160160L,163680L,165984L,170016L,178080L,180960L,187110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190383Inst : IEnumerable<long>
{
public static readonly long[] Value=A190383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190383.Bytes);
public long this[int i]=>Value[i];

public static A190383Inst Instance=new A190383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190384
{
public static readonly long[] Value={ 55440L,65520L,85680L,92400L,95760L,102960L,109200L,115920L,124740L,129360L,134640L,142800L,144144L,146160L,147420L,150480L,152880L,156240L,159120L,159600L,171600L,177840L,182160L,186480L,188496L,192780L,193200L,199920L,203280L,206640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190384Inst : IEnumerable<long>
{
public static readonly long[] Value=A190384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190384.Bytes);
public long this[int i]=>Value[i];

public static A190384Inst Instance=new A190384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190385
{
public static readonly long[] Value={ 83160L,98280L,128520L,143640L,154440L,173880L,201960L,216216L,219240L,225720L,231000L,234360L,238680L,266760L,273000L,273240L,279720L,282744L,309960L,316008L,322920L,325080L,334152L,344520L,348840L,355320L,357000L,368280L,373464L,382536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190385Inst : IEnumerable<long>
{
public static readonly long[] Value=A190385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190385.Bytes);
public long this[int i]=>Value[i];

public static A190385Inst Instance=new A190385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190386
{
public static readonly long[] Value={ 138600L,163800L,194040L,207900L,214200L,229320L,239400L,245700L,257400L,289800L,291060L,299880L,304920L,321300L,323400L,335160L,336600L,343980L,346500L,359100L,365400L,376200L,382200L,386100L,390600L,397800L,405720L,409500L,425880L,434700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190386Inst : IEnumerable<long>
{
public static readonly long[] Value=A190386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190386.Bytes);
public long this[int i]=>Value[i];

public static A190386Inst Instance=new A190386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190387
{
public static readonly long[] Value={ 485100L,573300L,749700L,762300L,837900L,1014300L,1064700L,1067220L,1278900L,1367100L,1415700L,1490580L,1631700L,1673100L,1778700L,1808100L,1820700L,1851300L,1896300L,2069100L,2072700L,2274300L,2337300L,2484300L,2504700L,2548980L,2585700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190387Inst : IEnumerable<long>
{
public static readonly long[] Value=A190387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190387.Bytes);
public long this[int i]=>Value[i];

public static A190387Inst Instance=new A190387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190388
{
public static readonly long[] Value={ 240240L,314160L,351120L,371280L,414960L,425040L,502320L,535920L,542640L,572880L,583440L,633360L,652080L,656880L,677040L,683760L,734160L,757680L,789360L,794640L,808080L,810810L,816816L,828240L,852720L,868560L,885360L,895440L,912912L,925680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190388Inst : IEnumerable<long>
{
public static readonly long[] Value=A190388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190388.Bytes);
public long this[int i]=>Value[i];

public static A190388Inst Instance=new A190388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190389
{
public static readonly long[] Value={ 1L,2L,2L,0L,0L,36L,144L,672L,0L,688L,161420L,1568320L,16640624L,234147048L,2955532608L,39844932096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190389Inst : IEnumerable<long>
{
public static readonly long[] Value=A190389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190389.Bytes);
public long this[int i]=>Value[i];

public static A190389Inst Instance=new A190389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190390
{
public static readonly long[] Value={ 360360L,471240L,526680L,540540L,556920L,600600L,622440L,637560L,706860L,753480L,785400L,790020L,803880L,813960L,835380L,840840L,859320L,875160L,877800L,928200L,933660L,950040L,956340L,978120L,985320L,1015560L,1025640L,1037400L,1062600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190390Inst : IEnumerable<long>
{
public static readonly long[] Value=A190390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190390.Bytes);
public long this[int i]=>Value[i];

public static A190390Inst Instance=new A190390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190391
{
public static readonly long[] Value={ 900900L,1178100L,1261260L,1316700L,1392300L,1556100L,1593900L,1649340L,1843380L,1883700L,1949220L,1981980L,2009700L,2034900L,2102100L,2148300L,2178540L,2187900L,2231460L,2342340L,2375100L,2445300L,2463300L,2538900L,2564100L,2591820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190391Inst : IEnumerable<long>
{
public static readonly long[] Value=A190391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190391.Bytes);
public long this[int i]=>Value[i];

public static A190391Inst Instance=new A190391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190392
{
public static readonly BigInteger[] Value={ 1L,1L,0L,-4L,-12L,4L,240L,1184L,-1008L,-59504L,-401280L,643136L,38584128L,323581504L,-848090880L,-51666451456L,-509739310848L,2004840714496L,123888658698240L,1386061762251776L,-7721141999864832L,-483475390212586496L,-5974101514137292800L,BigInteger.Parse("45231727252157947904") };
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
public class A190392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190392Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190392.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190392.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190392Inst Instance=new A190392Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190393
{
public static readonly long[] Value={ 1L,2L,6L,24L,120L,144L,28L,1408L,2025L,86400L,1782L,1092096L,4186L,31360L,241920000L,23953408L,140692L,114108912L,1092690L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190393Inst : IEnumerable<long>
{
public static readonly long[] Value=A190393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190393.Bytes);
public long this[int i]=>Value[i];

public static A190393Inst Instance=new A190393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190394
{
public static readonly long[] Value={ 1L,4L,5L,8L,10L,16L,17L,20L,21L,24L,26L,32L,33L,36L,39L,42L,45L,48L,51L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190394Inst : IEnumerable<long>
{
public static readonly long[] Value=A190394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190394.Bytes);
public long this[int i]=>Value[i];

public static A190394Inst Instance=new A190394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190395
{
public static readonly long[] Value={ 0L,4L,76L,516L,2172L,6860L,17904L,40796L,83976L,159732L,285220L,483604L,785316L,1229436L,1865192L,2753580L,3969104L,5601636L,7758396L,10566052L,14172940L,18751404L,24500256L,31647356L,40452312L,51209300L,64250004L,79946676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190395Inst : IEnumerable<long>
{
public static readonly long[] Value=A190395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190395.Bytes);
public long this[int i]=>Value[i];

public static A190395Inst Instance=new A190395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190444
{
public static readonly BigInteger[] Value={ 1L,1L,3L,7L,49L,201L,1411L,7183L,68097L,453169L,4523491L,34273911L,403454833L,3618761017L,45157828899L,445900023871L,6206361667201L,69111310499553L,1017103374816067L,12237616620289639L,195222691795726641L,2575612811875082281L,BigInteger.Parse("43240905591424459843"),BigInteger.Parse("608870179599833137647") };
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
public class A190444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190444Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190444.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190444.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190444Inst Instance=new A190444Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190445
{
public static readonly long[] Value={ 3L,1L,4L,2L,0L,3L,1L,4L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,1L,4L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,4L,2L,0L,3L,1L,4L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,4L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,0L,3L,1L,4L,2L,0L,3L,1L,4L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,1L,4L,2L,1L,3L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190445Inst : IEnumerable<long>
{
public static readonly long[] Value=A190445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190445.Bytes);
public long this[int i]=>Value[i];

public static A190445Inst Instance=new A190445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190446
{
public static readonly long[] Value={ 5L,13L,26L,34L,47L,60L,68L,81L,89L,94L,102L,115L,123L,136L,149L,157L,170L,178L,191L,204L,212L,225L,233L,238L,246L,259L,267L,280L,293L,301L,314L,322L,335L,348L,356L,369L,382L,390L,403L,411L,424L,437L,445L,458L,466L,471L,479L,492L,500L,513L,526L,534L,547L,555L,568L,581L,589L,602L,610L,615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190446Inst : IEnumerable<long>
{
public static readonly long[] Value=A190446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190446.Bytes);
public long this[int i]=>Value[i];

public static A190446Inst Instance=new A190446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190447
{
public static readonly long[] Value={ 2L,7L,10L,15L,18L,23L,28L,31L,36L,39L,41L,44L,49L,52L,57L,62L,65L,70L,73L,78L,83L,86L,91L,96L,99L,104L,107L,112L,117L,120L,125L,128L,130L,133L,138L,141L,146L,151L,154L,159L,162L,167L,172L,175L,180L,183L,185L,188L,193L,196L,201L,206L,209L,214L,217L,222L,227L,230L,235L,240L,243L,248L,251L,256L,261L,264L,269L,272L,274L,277L,282L,285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190447Inst : IEnumerable<long>
{
public static readonly long[] Value=A190447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190447.Bytes);
public long this[int i]=>Value[i];

public static A190447Inst Instance=new A190447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190448
{
public static readonly long[] Value={ 4L,9L,12L,17L,20L,25L,30L,33L,38L,43L,46L,51L,54L,59L,64L,67L,72L,75L,77L,80L,85L,88L,93L,98L,101L,106L,109L,114L,119L,122L,127L,132L,135L,140L,143L,148L,153L,156L,161L,164L,166L,169L,174L,177L,182L,187L,190L,195L,198L,203L,208L,211L,216L,219L,221L,224L,229L,232L,237L,242L,245L,250L,253L,258L,263L,266L,271L,276L,279L,284L,287L,292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190448Inst : IEnumerable<long>
{
public static readonly long[] Value=A190448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190448.Bytes);
public long this[int i]=>Value[i];

public static A190448Inst Instance=new A190448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190449
{
public static readonly long[] Value={ 1L,6L,11L,14L,19L,22L,24L,27L,32L,35L,40L,45L,48L,53L,56L,61L,66L,69L,74L,79L,82L,87L,90L,95L,100L,103L,108L,111L,113L,116L,121L,124L,129L,134L,137L,142L,145L,150L,155L,158L,163L,168L,171L,176L,179L,184L,189L,192L,197L,200L,202L,205L,210L,213L,218L,223L,226L,231L,234L,239L,244L,247L,252L,255L,257L,260L,265L,268L,273L,278L,281L,286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190449Inst : IEnumerable<long>
{
public static readonly long[] Value=A190449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190449.Bytes);
public long this[int i]=>Value[i];

public static A190449Inst Instance=new A190449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190450
{
public static readonly long[] Value={ 3L,8L,16L,21L,29L,37L,42L,50L,55L,58L,63L,71L,76L,84L,92L,97L,105L,110L,118L,126L,131L,139L,144L,147L,152L,160L,165L,173L,181L,186L,194L,199L,207L,215L,220L,228L,236L,241L,249L,254L,262L,270L,275L,283L,288L,291L,296L,304L,309L,317L,325L,330L,338L,343L,351L,359L,364L,372L,377L,380L,385L,393L,398L,406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190450Inst : IEnumerable<long>
{
public static readonly long[] Value=A190450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190450.Bytes);
public long this[int i]=>Value[i];

public static A190450Inst Instance=new A190450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190451
{
public static readonly long[] Value={ 2L,1L,3L,2L,0L,3L,1L,4L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,0L,2L,1L,3L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,0L,3L,1L,3L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,0L,2L,1L,3L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,4L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,0L,3L,1L,3L,2L,0L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190451Inst : IEnumerable<long>
{
public static readonly long[] Value=A190451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190451.Bytes);
public long this[int i]=>Value[i];

public static A190451Inst Instance=new A190451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190452
{
public static readonly long[] Value={ 1L,1L,2L,4L,11L,31L,106L,372L,1499L,6211L,28606L,135356L,697357L,3688049L,20935006L,121837276L,753159801L,4767863657L,31807384354L,217048147396L,1551200297291L,11327527814191L,86206555248122L,669666314150164L,5399592811359331L,44398500646885851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190452Inst : IEnumerable<long>
{
public static readonly long[] Value=A190452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190452.Bytes);
public long this[int i]=>Value[i];

public static A190452Inst Instance=new A190452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190453
{
public static readonly long[] Value={ 2L,7L,12L,15L,20L,23L,28L,33L,36L,41L,44L,46L,49L,54L,57L,62L,67L,70L,75L,78L,83L,88L,91L,96L,101L,104L,109L,112L,117L,122L,125L,130L,133L,135L,138L,143L,146L,151L,156L,159L,164L,167L,172L,177L,180L,185L,190L,193L,198L,201L,206L,211L,214L,219L,222L,224L,227L,232L,235L,240L,245L,248L,253L,256L,261L,266L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190453Inst : IEnumerable<long>
{
public static readonly long[] Value=A190453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190453.Bytes);
public long this[int i]=>Value[i];

public static A190453Inst Instance=new A190453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190454
{
public static readonly long[] Value={ 1L,4L,9L,14L,17L,22L,25L,27L,30L,35L,38L,43L,48L,51L,56L,59L,64L,69L,72L,77L,80L,82L,85L,90L,93L,98L,103L,106L,111L,114L,119L,124L,127L,132L,137L,140L,145L,148L,153L,158L,161L,166L,169L,171L,174L,179L,182L,187L,192L,195L,200L,203L,208L,213L,216L,221L,226L,229L,234L,237L,242L,247L,250L,255L,258L,260L,263L,268L,271L,276L,281L,284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190454Inst : IEnumerable<long>
{
public static readonly long[] Value=A190454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190454.Bytes);
public long this[int i]=>Value[i];

public static A190454Inst Instance=new A190454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190455
{
public static readonly long[] Value={ 6L,11L,16L,19L,24L,29L,32L,37L,40L,45L,50L,53L,58L,61L,63L,66L,71L,74L,79L,84L,87L,92L,95L,100L,105L,108L,113L,116L,118L,121L,126L,129L,134L,139L,142L,147L,150L,155L,160L,163L,168L,173L,176L,181L,184L,189L,194L,197L,202L,205L,207L,210L,215L,218L,223L,228L,231L,236L,239L,244L,249L,252L,257L,262L,265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190455Inst : IEnumerable<long>
{
public static readonly long[] Value=A190455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190455.Bytes);
public long this[int i]=>Value[i];

public static A190455Inst Instance=new A190455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190456
{
public static readonly long[] Value={ 8L,21L,42L,55L,76L,97L,110L,131L,144L,152L,165L,186L,199L,220L,241L,254L,275L,288L,309L,330L,343L,364L,377L,385L,398L,419L,432L,453L,474L,487L,508L,521L,542L,563L,576L,597L,618L,631L,652L,665L,686L,707L,720L,741L,754L,762L,775L,796L,809L,830L,851L,864L,885L,898L,919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190456Inst : IEnumerable<long>
{
public static readonly long[] Value=A190456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190456.Bytes);
public long this[int i]=>Value[i];

public static A190456Inst Instance=new A190456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190457
{
public static readonly long[] Value={ 3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,4L,2L,0L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,4L,2L,1L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,4L,2L,0L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,4L,2L,1L,3L,2L,4L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,4L,2L,1L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190457Inst : IEnumerable<long>
{
public static readonly long[] Value=A190457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190457.Bytes);
public long this[int i]=>Value[i];

public static A190457Inst Instance=new A190457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190458
{
public static readonly long[] Value={ 13L,34L,68L,89L,123L,157L,178L,212L,233L,246L,267L,301L,322L,356L,390L,411L,445L,466L,500L,534L,555L,589L,610L,623L,644L,678L,699L,733L,767L,788L,822L,843L,877L,911L,932L,966L,1000L,1021L,1055L,1076L,1110L,1144L,1165L,1199L,1220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190458Inst : IEnumerable<long>
{
public static readonly long[] Value=A190458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190458.Bytes);
public long this[int i]=>Value[i];

public static A190458Inst Instance=new A190458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190459
{
public static readonly long[] Value={ 2L,5L,10L,15L,18L,23L,26L,31L,36L,39L,44L,47L,49L,52L,57L,60L,65L,70L,73L,78L,81L,86L,91L,94L,99L,102L,104L,107L,112L,115L,120L,125L,128L,133L,136L,141L,146L,149L,154L,159L,162L,167L,170L,175L,180L,183L,188L,191L,193L,196L,201L,204L,209L,214L,217L,222L,225L,230L,235L,238L,243L,248L,251L,256L,259L,264L,269L,272L,277L,280L,282L,285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190459Inst : IEnumerable<long>
{
public static readonly long[] Value=A190459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190459.Bytes);
public long this[int i]=>Value[i];

public static A190459Inst Instance=new A190459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190508
{
public static readonly long[] Value={ 8L,18L,26L,36L,47L,55L,65L,73L,84L,94L,102L,112L,123L,131L,141L,149L,160L,170L,178L,188L,196L,207L,217L,225L,235L,246L,254L,264L,272L,283L,293L,301L,311L,322L,330L,340L,348L,358L,369L,377L,387L,395L,406L,416L,424L,434L,445L,453L,463L,471L,482L,492L,500L,510L,518L,529L,539L,547L,557L,568L,576L,586L,594L,605L,615L,623L,633L,644L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190508Inst : IEnumerable<long>
{
public static readonly long[] Value=A190508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190508.Bytes);
public long this[int i]=>Value[i];

public static A190508Inst Instance=new A190508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190509
{
public static readonly long[] Value={ 4L,11L,15L,22L,29L,33L,40L,44L,51L,58L,62L,69L,76L,80L,87L,91L,98L,105L,109L,116L,120L,127L,134L,138L,145L,152L,156L,163L,167L,174L,181L,185L,192L,199L,203L,210L,214L,221L,228L,232L,239L,243L,250L,257L,261L,268L,275L,279L,286L,290L,297L,304L,308L,315L,319L,326L,333L,337L,344L,351L,355L,362L,366L,373L,380L,384L,391L,398L,402L,409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190509Inst : IEnumerable<long>
{
public static readonly long[] Value=A190509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190509.Bytes);
public long this[int i]=>Value[i];

public static A190509Inst Instance=new A190509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190510
{
public static readonly long[] Value={ 0L,1L,8L,68L,576L,4880L,41344L,350272L,2967552L,25141504L,213002240L,1804583936L,15288680448L,129527779328L,1097376956416L,9297126768640L,78766521974784L,667320682872832L,5653631550881792L,47898335138545664L,405801207311892480L,3438002999049322496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190510Inst : IEnumerable<long>
{
public static readonly long[] Value=A190510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190510.Bytes);
public long this[int i]=>Value[i];

public static A190510Inst Instance=new A190510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190511
{
public static readonly long[] Value={ 1L,3L,5L,7L,10L,12L,14L,16L,19L,21L,23L,25L,28L,30L,32L,34L,37L,39L,41L,43L,45L,48L,50L,52L,54L,57L,59L,61L,63L,66L,68L,70L,72L,75L,77L,79L,81L,83L,86L,88L,90L,92L,95L,97L,99L,101L,104L,106L,108L,110L,113L,115L,117L,119L,121L,124L,126L,128L,130L,133L,135L,137L,139L,142L,144L,146L,148L,151L,153L,155L,157L,159L,162L,164L,166L,168L,171L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190511Inst : IEnumerable<long>
{
public static readonly long[] Value=A190511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190511.Bytes);
public long this[int i]=>Value[i];

public static A190511Inst Instance=new A190511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190512
{
public static readonly long[] Value={ 1L,2L,5L,11L,24L,53L,117L,258L,569L,1255L,2768L,6105L,13465L,29698L,65501L,144467L,318632L,702765L,1549997L,3418626L,7540017L,16630031L,36678688L,80897393L,178424817L,393528322L,867954037L,1914332891L,4222194104L,9312342245L,20539017381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190512Inst : IEnumerable<long>
{
public static readonly long[] Value=A190512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190512.Bytes);
public long this[int i]=>Value[i];

public static A190512Inst Instance=new A190512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190513
{
public static readonly long[] Value={ 9L,19L,31L,41L,52L,64L,74L,85L,97L,107L,118L,129L,140L,151L,162L,173L,184L,195L,205L,216L,227L,239L,249L,261L,271L,282L,294L,304L,313L,327L,337L,348L,359L,370L,381L,392L,402L,412L,425L,436L,447L,457L,469L,480L,490L,501L,513L,523L,534L,545L,557L,567L,578L,589L,599L,612L,621L,631L,644L,655L,665L,677L,687L,699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190513Inst : IEnumerable<long>
{
public static readonly long[] Value=A190513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190513.Bytes);
public long this[int i]=>Value[i];

public static A190513Inst Instance=new A190513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190514
{
public static readonly long[] Value={ 5L,14L,22L,29L,37L,46L,53L,61L,69L,78L,84L,93L,101L,109L,116L,125L,132L,141L,149L,157L,165L,172L,181L,188L,197L,204L,212L,220L,229L,236L,244L,252L,260L,267L,276L,285L,291L,300L,309L,317L,323L,332L,340L,347L,355L,364L,371L,379L,388L,396L,403L,411L,419L,427L,435L,443L,451L,459L,467L,475L,483L,491L,499L,506L,515L,522L,530L,538L,547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190514Inst : IEnumerable<long>
{
public static readonly long[] Value=A190514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190514.Bytes);
public long this[int i]=>Value[i];

public static A190514Inst Instance=new A190514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190515
{
public static readonly long[] Value={ 6L,15L,25L,33L,42L,51L,59L,68L,79L,87L,94L,104L,113L,121L,131L,139L,147L,158L,166L,175L,183L,192L,201L,210L,219L,228L,237L,246L,254L,264L,272L,280L,290L,298L,307L,318L,325L,333L,343L,352L,361L,369L,378L,387L,397L,406L,415L,422L,431L,441L,449L,458L,468L,476L,485L,495L,502L,510L,520L,529L,537L,548L,556L,564L,574L,583L,590L,600L,608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190515Inst : IEnumerable<long>
{
public static readonly long[] Value=A190515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190515.Bytes);
public long this[int i]=>Value[i];

public static A190515Inst Instance=new A190515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190516
{
public static readonly long[] Value={ 1L,4L,10L,12L,17L,20L,24L,27L,32L,36L,38L,43L,47L,50L,55L,57L,62L,66L,70L,73L,76L,80L,83L,89L,92L,96L,99L,103L,108L,111L,115L,119L,122L,126L,130L,135L,136L,142L,145L,150L,153L,155L,160L,163L,168L,171L,177L,178L,182L,187L,191L,194L,198L,202L,206L,209L,214L,217L,221L,224L,230L,233L,234L,240L,243L,247L,251L,256L,258L,262L,266L,270L,275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190516Inst : IEnumerable<long>
{
public static readonly long[] Value=A190516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190516.Bytes);
public long this[int i]=>Value[i];

public static A190516Inst Instance=new A190516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190517
{
public static readonly long[] Value={ 3L,8L,13L,18L,23L,28L,34L,39L,45L,49L,56L,60L,65L,71L,75L,81L,86L,91L,98L,102L,106L,112L,117L,123L,127L,133L,138L,144L,148L,154L,159L,164L,169L,174L,179L,186L,190L,196L,200L,207L,211L,215L,222L,225L,232L,238L,242L,248L,253L,257L,263L,268L,274L,279L,284L,289L,295L,299L,305L,310L,314L,321L,326L,331L,336L,341L,346L,351L,356L,362L,367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190517Inst : IEnumerable<long>
{
public static readonly long[] Value=A190517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190517.Bytes);
public long this[int i]=>Value[i];

public static A190517Inst Instance=new A190517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190518
{
public static readonly long[] Value={ 2L,7L,11L,16L,21L,26L,30L,35L,40L,44L,48L,54L,58L,63L,67L,72L,77L,82L,88L,90L,95L,100L,105L,110L,114L,120L,124L,128L,134L,137L,143L,146L,152L,156L,161L,167L,170L,176L,180L,185L,189L,193L,199L,203L,208L,213L,218L,223L,226L,231L,235L,241L,245L,250L,255L,259L,265L,269L,273L,278L,283L,287L,292L,297L,302L,306L,311L,316L,320L,324L,329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190518Inst : IEnumerable<long>
{
public static readonly long[] Value=A190518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190518.Bytes);
public long this[int i]=>Value[i];

public static A190518Inst Instance=new A190518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190519
{
public static readonly long[] Value={ 8L,16L,26L,35L,45L,54L,63L,72L,82L,93L,101L,110L,121L,129L,139L,148L,157L,167L,177L,186L,195L,205L,214L,223L,233L,242L,251L,261L,270L,281L,290L,298L,308L,318L,327L,336L,345L,355L,365L,374L,384L,392L,402L,412L,421L,429L,440L,450L,458L,469L,478L,486L,497L,505L,514L,525L,534L,543L,553L,563L,571L,581L,590L,599L,610L,618L,627L,639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190519Inst : IEnumerable<long>
{
public static readonly long[] Value=A190519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190519.Bytes);
public long this[int i]=>Value[i];

public static A190519Inst Instance=new A190519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190520
{
public static readonly long[] Value={ 27L,55L,85L,113L,143L,171L,200L,229L,258L,287L,316L,344L,375L,403L,433L,461L,490L,519L,547L,578L,606L,635L,664L,693L,721L,751L,779L,809L,837L,867L,895L,924L,953L,982L,1011L,1039L,1068L,1097L,1128L,1157L,1186L,1214L,1244L,1272L,1302L,1330L,1359L,1388L,1417L,1445L,1474L,1503L,1533L,1561L,1590L,1619L,1647L,1677L,1706L,1736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190520Inst : IEnumerable<long>
{
public static readonly long[] Value=A190520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190520.Bytes);
public long this[int i]=>Value[i];

public static A190520Inst Instance=new A190520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190521
{
public static readonly long[] Value={ 2L,4L,7L,10L,12L,15L,18L,20L,23L,28L,30L,33L,36L,38L,41L,43L,46L,49L,52L,57L,60L,62L,65L,68L,70L,73L,76L,78L,81L,86L,88L,90L,94L,96L,98L,102L,104L,107L,112L,115L,118L,120L,123L,126L,128L,131L,134L,137L,140L,144L,146L,149L,152L,154L,156L,160L,163L,165L,170L,173L,175L,179L,181L,183L,187L,189L,192L,196L,198L,201L,204L,207L,209L,212L,215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190521Inst : IEnumerable<long>
{
public static readonly long[] Value=A190521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190521.Bytes);
public long this[int i]=>Value[i];

public static A190521Inst Instance=new A190521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190522
{
public static readonly long[] Value={ 6L,14L,22L,32L,40L,48L,58L,66L,74L,83L,91L,99L,109L,117L,125L,133L,142L,151L,159L,168L,176L,184L,193L,202L,210L,220L,228L,236L,244L,253L,262L,269L,278L,286L,295L,304L,312L,321L,331L,339L,348L,354L,363L,371L,380L,389L,397L,406L,415L,423L,431L,442L,449L,457L,465L,474L,482L,491L,500L,508L,516L,526L,533L,541L,552L,560L,568L,577L,585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190522Inst : IEnumerable<long>
{
public static readonly long[] Value=A190522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190522.Bytes);
public long this[int i]=>Value[i];

public static A190522Inst Instance=new A190522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190523
{
public static readonly long[] Value={ 1L,3L,5L,9L,11L,13L,17L,19L,21L,25L,29L,31L,34L,37L,39L,42L,44L,47L,50L,53L,56L,59L,61L,64L,67L,69L,71L,75L,77L,80L,84L,87L,89L,92L,95L,97L,100L,103L,105L,108L,111L,114L,116L,119L,122L,124L,127L,130L,132L,136L,138L,141L,145L,147L,150L,153L,155L,158L,161L,164L,166L,169L,172L,174L,178L,180L,182L,185L,188L,191L,194L,197L,199L,203L,206L,208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190523Inst : IEnumerable<long>
{
public static readonly long[] Value=A190523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190523.Bytes);
public long this[int i]=>Value[i];

public static A190523Inst Instance=new A190523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190572
{
public static readonly long[] Value={ 6L,8L,9L,10L,10L,11L,11L,12L,12L,13L,14L,14L,15L,15L,16L,16L,16L,17L,18L,19L,20L,20L,21L,22L,22L,22L,22L,23L,23L,24L,24L,24L,25L,25L,26L,26L,26L,26L,27L,27L,27L,28L,28L,28L,29L,29L,29L,29L,30L,30L,30L,31L,31L,31L,31L,32L,32L,33L,33L,34L,34L,34L,34L,35L,35L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190572Inst : IEnumerable<long>
{
public static readonly long[] Value=A190572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190572.Bytes);
public long this[int i]=>Value[i];

public static A190572Inst Instance=new A190572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190573
{
public static readonly long[] Value={ 7L,8L,5L,3L,8L,0L,5L,5L,7L,2L,9L,8L,6L,3L,2L,8L,7L,3L,4L,9L,2L,5L,8L,3L,0L,1L,1L,4L,6L,7L,3L,3L,2L,5L,2L,4L,7L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190573Inst : IEnumerable<long>
{
public static readonly long[] Value=A190573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190573.Bytes);
public long this[int i]=>Value[i];

public static A190573Inst Instance=new A190573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190574
{
public static readonly long[] Value={ 640320L,1653264929L,30L,1L,321L,2L,1L,1L,1L,4L,3L,4L,2L,1L,1L,31L,2L,1L,3L,1L,1L,10L,1L,1L,3L,2L,1L,2L,30L,1L,1L,1L,1L,2L,1L,3L,9L,3L,1L,1L,1L,1L,1L,1L,7L,3L,2L,1L,6L,1L,16L,1L,12L,2L,1L,25L,2L,2L,5L,1L,1L,1L,2L,1L,3L,6L,35L,2L,1L,2L,1L,3L,9L,1L,22L,2L,1L,2L,6L,1L,3L,6L,1L,2L,1L,1L,49L,1L,1L,8L,1L,2L,1L,6L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190574Inst : IEnumerable<long>
{
public static readonly long[] Value=A190574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190574.Bytes);
public long this[int i]=>Value[i];

public static A190574Inst Instance=new A190574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190575
{
public static readonly long[] Value={ 6L,4L,0L,3L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,6L,0L,4L,8L,6L,3L,7L,3L,5L,0L,4L,9L,0L,1L,6L,0L,3L,9L,4L,7L,1L,7L,4L,1L,8L,1L,8L,8L,1L,8L,5L,3L,9L,4L,7L,5L,7L,7L,1L,4L,8L,5L,7L,6L,0L,3L,6L,6L,5L,9L,1L,8L,1L,9L,4L,6L,5L,2L,2L,1L,8L,2L,5L,8L,2L,8L,6L,9L,4L,2L,5L,3L,6L,3L,4L,0L,8L,1L,5L,8L,2L,2L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190575Inst : IEnumerable<long>
{
public static readonly long[] Value=A190575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190575.Bytes);
public long this[int i]=>Value[i];

public static A190575Inst Instance=new A190575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190576
{
public static readonly long[] Value={ 1L,9L,19L,31L,45L,61L,79L,99L,121L,145L,171L,199L,229L,261L,295L,331L,369L,409L,451L,495L,541L,589L,639L,691L,745L,801L,859L,919L,981L,1045L,1111L,1179L,1249L,1321L,1395L,1471L,1549L,1629L,1711L,1795L,1881L,1969L,2059L,2151L,2245L,2341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190576Inst : IEnumerable<long>
{
public static readonly long[] Value=A190576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190576.Bytes);
public long this[int i]=>Value[i];

public static A190576Inst Instance=new A190576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190577
{
public static readonly long[] Value={ 105L,384L,945L,1920L,3465L,5760L,9009L,13440L,19305L,26880L,36465L,48384L,62985L,80640L,101745L,126720L,156009L,190080L,229425L,274560L,326025L,384384L,450225L,524160L,606825L,698880L,801009L,913920L,1038345L,1175040L,1324785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190577Inst : IEnumerable<long>
{
public static readonly long[] Value=A190577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190577.Bytes);
public long this[int i]=>Value[i];

public static A190577Inst Instance=new A190577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190578
{
public static readonly long[] Value={ 0L,2L,130L,2190L,16388L,78130L,279942L,823550L,2097160L,4782978L,10000010L,19487182L,35831820L,62748530L,105413518L,170859390L,268435472L,410338690L,612220050L,893871758L,1280000020L,1801088562L,2494357910L,3404825470L,4586471448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190578Inst : IEnumerable<long>
{
public static readonly long[] Value=A190578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190578.Bytes);
public long this[int i]=>Value[i];

public static A190578Inst Instance=new A190578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190579
{
public static readonly long[] Value={ 0L,0L,2L,998L,51618L,873852L,8039322L,50272978L,240764814L,947860554L,3210392210L,9649651136L,26316155354L,66191981440L,155482089002L,344411086374L,725043524246L,1459722296638L,2825136685698L,5278863810724L,9557560367842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190579Inst : IEnumerable<long>
{
public static readonly long[] Value=A190579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190579.Bytes);
public long this[int i]=>Value[i];

public static A190579Inst Instance=new A190579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190580
{
public static readonly long[] Value={ 1L,17L,-1L,1L,19L,2L,397L,-1L,-2L,1L,17299L,-1L,1L,107L,-65L,523L,-359L,2L,-3L,-71L,1L,-2L,-11267L,62641L,-1819L,-14653L,-4L,7L,-1L,1L,1208L,-472663L,-10441L,17L,-126L,-11951L,53L,-4L,323L,-2404889L,5L,-907929611L,36L,-431L,3L,-3547L,-15616184186396177L,-5L,-3L,-349L,3527L,-140131L,17L,-71L,-901L,-2741617L,-2L,10183412861L,-1L,1L,-6L,33728183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190580Inst : IEnumerable<long>
{
public static readonly long[] Value=A190580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190580.Bytes);
public long this[int i]=>Value[i];

public static A190580Inst Instance=new A190580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190581
{
public static readonly long[] Value={ 1L,21L,1L,1L,39L,3L,294L,7L,1L,7L,9954L,1L,1L,57L,42L,582L,182L,1L,1L,129L,2L,3L,6111L,197028L,217L,7083L,1L,3L,1L,1L,1323L,620505L,3318L,13L,43L,3606L,1302L,3L,111L,330498L,3L,216266610L,13L,273L,1L,5733L,590736058375050L,3L,1L,117L,1014L,25767L,19L,37L,1878L,1029364L,1L,37045412880L,1L,1L,1L,11285694L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190581Inst : IEnumerable<long>
{
public static readonly long[] Value=A190581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190581.Bytes);
public long this[int i]=>Value[i];

public static A190581Inst Instance=new A190581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190582
{
public static readonly long[] Value={ 16L,17L,18L,13L,14L,15L,16L,17L,18L,13L,14L,15L,16L,17L,18L,13L,14L,15L,16L,17L,18L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190582Inst : IEnumerable<long>
{
public static readonly long[] Value=A190582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190582.Bytes);
public long this[int i]=>Value[i];

public static A190582Inst Instance=new A190582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190583
{
public static readonly long[] Value={ 4827859L,5413813L,59069473L,59069489L,171426679L,189784123L,191766193L,196232137L,306928507L,359727833L,367733497L,409634959L,452273897L,508068287L,644033227L,665209213L,737454929L,879260659L,889580717L,924491669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190583Inst : IEnumerable<long>
{
public static readonly long[] Value=A190583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190583.Bytes);
public long this[int i]=>Value[i];

public static A190583Inst Instance=new A190583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190584
{
public static readonly long[] Value={ 4L,27L,119L,497L,2023L,8149L,32692L,130938L,524050L,2096730L,8387859L,33553102L,134215364L,536866711L,2147476180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190584Inst : IEnumerable<long>
{
public static readonly long[] Value=A190584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190584.Bytes);
public long this[int i]=>Value[i];

public static A190584Inst Instance=new A190584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190585
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,-5L,-29L,-89L,-209L,-9239L,-120455L,-801359L,-3674879L,15450931L,505760971L,4925214295L,30957618511L,-3280733667119L,-49063880680079L,-327527326905119L,-1087577476736255L,97366167074820331L,1723137650565888691L,13360549076712501511UL };
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
public class A190585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190585Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190585.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190585.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190585Inst Instance=new A190585Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190586
{
public static readonly long[] Value={ 1L,3L,6L,15L,35L,83L,195L,460L,1085L,2560L,6039L,14247L,33613L,79306L,187114L,441477L,1041626L,2457630L,5798569L,13681202L,32279488L,76160166L,179691649L,423961718L,1000285928L,2360046161L,5568211498L,13137414580L,30995819288L,73129978187L,172538870438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190586Inst : IEnumerable<long>
{
public static readonly long[] Value=A190586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190586.Bytes);
public long this[int i]=>Value[i];

public static A190586Inst Instance=new A190586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190587
{
public static readonly long[] Value={ 1L,2L,4L,10L,24L,56L,130L,304L,714L,1678L,3944L,9276L,21832L,51408L,121088L,285288L,672304L,1584638L,3735596L,8807312L,20766914L,48970942L,115487946L,272371376L,642404770L,1515218012L,3574025956L,8430514614L,19886678810L,46911630678L,110664280068L,261060908326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190587Inst : IEnumerable<long>
{
public static readonly long[] Value=A190587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190587.Bytes);
public long this[int i]=>Value[i];

public static A190587Inst Instance=new A190587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190636
{
public static readonly long[] Value={ 1L,98L,1647L,12304L,58625L,210006L,617743L,1572992L,3587409L,7500250L,14615711L,26874288L,47061937L,79060814L,128145375L,201327616L,307755233L,459166482L,670405519L,960002000L,1350818721L,1870771078L,2553622127L,3439857024L,4577640625L,6023862026L,7845269823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190636Inst : IEnumerable<long>
{
public static readonly long[] Value=A190636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190636.Bytes);
public long this[int i]=>Value[i];

public static A190636Inst Instance=new A190636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190637
{
public static readonly long[] Value={ 3L,43L,7639L,25703L,38371L,61291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190637Inst : IEnumerable<long>
{
public static readonly long[] Value=A190637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190637.Bytes);
public long this[int i]=>Value[i];

public static A190637Inst Instance=new A190637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190638
{
public static readonly long[] Value={ 5L,41L,257L,2309L,14621L,48821L,125429L,177269L,1595417L,5278001L,10596137L,15146069L,21523361L,63993929L,83629517L,111321257L,363526421L,375805589L,427518041L,446072909L,552010829L,752665649L,1980098177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190638Inst : IEnumerable<long>
{
public static readonly long[] Value=A190638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190638.Bytes);
public long this[int i]=>Value[i];

public static A190638Inst Instance=new A190638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190639
{
public static readonly long[] Value={ 473267L,726760L,1773439L,1808828L,1919128L,2131583L,2165420L,2339971L,2390652L,2518488L,2802591L,2844914L,2982584L,2996184L,3183263L,3193175L,3250986L,3418185L,3428241L,3633472L,3909324L,3953449L,4280455L,4303819L,4373399L,4658285L,4728653L,4978360L,5165402L,5254365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190639Inst : IEnumerable<long>
{
public static readonly long[] Value=A190639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190639.Bytes);
public long this[int i]=>Value[i];

public static A190639Inst Instance=new A190639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190640
{
public static readonly long[] Value={ 2L,8L,20L,26L,56L,62L,74L,80L,164L,170L,182L,188L,218L,224L,236L,242L,488L,494L,506L,512L,542L,548L,560L,566L,650L,656L,668L,674L,704L,710L,722L,728L,1460L,1466L,1478L,1484L,1514L,1520L,1532L,1538L,1622L,1628L,1640L,1646L,1676L,1682L,1694L,1700L,1946L,1952L,1964L,1970L,2000L,2006L,2018L,2024L,2108L,2114L,2126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190640Inst : IEnumerable<long>
{
public static readonly long[] Value=A190640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190640.Bytes);
public long this[int i]=>Value[i];

public static A190640Inst Instance=new A190640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190641
{
public static readonly long[] Value={ 4L,8L,9L,12L,16L,18L,20L,24L,25L,27L,28L,32L,40L,44L,45L,48L,49L,50L,52L,54L,56L,60L,63L,64L,68L,75L,76L,80L,81L,84L,88L,90L,92L,96L,98L,99L,104L,112L,116L,117L,120L,121L,124L,125L,126L,128L,132L,135L,136L,140L,147L,148L,150L,152L,153L,156L,160L,162L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190641Inst : IEnumerable<long>
{
public static readonly long[] Value=A190641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190641.Bytes);
public long this[int i]=>Value[i];

public static A190641Inst Instance=new A190641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190642
{
public static readonly long[] Value={ 2L,12L,22L,102L,112L,122L,202L,212L,222L,1002L,1012L,1022L,1102L,1112L,1122L,1202L,1212L,1222L,2002L,2012L,2022L,2102L,2112L,2122L,2202L,2212L,2222L,10002L,10012L,10022L,10102L,10112L,10122L,10202L,10212L,10222L,11002L,11012L,11022L,11102L,11112L,11122L,11202L,11212L,11222L,12002L,12012L,12022L,12102L,12112L,12122L,12202L,12212L,12222L,20002L,20012L,20022L,20102L,20112L,20122L,20202L,20212L,20222L,21002L,21012L,21022L,21102L,21112L,21122L,21202L,21212L,21222L,22002L,22012L,22022L,22102L,22112L,22122L,22202L,22212L,22222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190642Inst : IEnumerable<long>
{
public static readonly long[] Value=A190642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190642.Bytes);
public long this[int i]=>Value[i];

public static A190642Inst Instance=new A190642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190643
{
public static readonly long[] Value={ 1L,5L,1L,7L,1L,1L,9L,8L,0L,6L,9L,9L,2L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190643Inst : IEnumerable<long>
{
public static readonly long[] Value=A190643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190643.Bytes);
public long this[int i]=>Value[i];

public static A190643Inst Instance=new A190643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190644
{
public static readonly long[] Value={ 6L,34L,39L,7L,11L,19L,29L,41L,79L,71L,179L,199L,181L,239L,883L,419L,701L,839L,881L,1429L,2351L,1259L,1871L,2161L,4049L,3079L,3361L,2521L,6481L,4159L,6299L,5279L,11551L,5039L,20789L,7561L,25919L,10079L,16561L,13441L,38611L,13859L,23761L,21839L,100673L,20161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190644Inst : IEnumerable<long>
{
public static readonly long[] Value=A190644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190644.Bytes);
public long this[int i]=>Value[i];

public static A190644Inst Instance=new A190644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190645
{
public static readonly long[] Value={ 350L,738L,1276L,1314L,2890L,5052L,6356L,9052L,9054L,9950L,14050L,15966L,16852L,17916L,17948L,19166L,19852L,22475L,23348L,23420L,24350L,25182L,25184L,25186L,30476L,32418L,41058L,41060L,47646L,47648L,54927L,56452L,57436L,59924L,61794L,61796L,66787L,68348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190645Inst : IEnumerable<long>
{
public static readonly long[] Value=A190645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190645.Bytes);
public long this[int i]=>Value[i];

public static A190645Inst Instance=new A190645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190646
{
public static readonly long[] Value={ 4L,7L,19L,41L,127252L,199L,26890624L,919L,17299L,6641L,25269208984376L,3401L,3900566650390624L,640063L,8418574L,18089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190646Inst : IEnumerable<long>
{
public static readonly long[] Value=A190646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190646.Bytes);
public long this[int i]=>Value[i];

public static A190646Inst Instance=new A190646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190647
{
public static readonly long[] Value={ -1L,1L,4L,1L,30L,1L,870L,1L,9L,5L,1L,12L,1L,14L,1L,1L,1L,1L,2L,4L,1L,40L,1L,9L,13L,8L,35L,1L,8L,3L,1L,1L,10L,4L,15L,3L,1L,6L,6L,1L,4L,1L,4L,1L,9L,6L,7L,1L,4L,20L,3L,2L,1L,3L,1L,9L,1L,2L,2L,1L,1L,1L,2L,1L,1L,1L,1L,3L,4L,2L,18L,3L,1L,1L,1L,1L,1L,4L,53L,4L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190647Inst : IEnumerable<long>
{
public static readonly long[] Value=A190647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190647.Bytes);
public long this[int i]=>Value[i];

public static A190647Inst Instance=new A190647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190648
{
public static readonly long[] Value={ 1L,6L,7L,5L,3L,9L,2L,9L,8L,4L,5L,5L,6L,2L,5L,1L,1L,8L,3L,2L,4L,1L,3L,9L,8L,4L,1L,0L,0L,9L,1L,4L,4L,8L,3L,8L,5L,3L,7L,3L,6L,6L,8L,7L,1L,5L,9L,9L,2L,8L,3L,7L,9L,8L,4L,3L,3L,9L,0L,0L,0L,6L,9L,6L,0L,8L,6L,8L,0L,2L,7L,3L,3L,2L,2L,2L,3L,3L,7L,0L,4L,5L,0L,8L,9L,7L,7L,0L,8L,7L,2L,6L,5L,2L,9L,7L,4L,7L,2L,8L,2L,3L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190648Inst : IEnumerable<long>
{
public static readonly long[] Value=A190648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190648.Bytes);
public long this[int i]=>Value[i];

public static A190648Inst Instance=new A190648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190649
{
public static readonly long[] Value={ 1L,1L,4L,1L,2L,3L,6L,2L,1L,3L,1L,189L,1L,3L,12L,1L,1L,2L,10L,3L,1L,2L,17L,124L,2L,2L,6L,1L,137L,5L,3L,1L,3L,1L,1L,9L,2L,1L,5L,13L,1L,13L,2L,7L,1L,2L,309L,1L,2L,1L,1L,2L,2L,2L,1L,1L,3L,8L,2L,21L,1L,1L,35L,6L,1L,2L,1L,3L,1L,50L,1L,6L,8L,2L,5L,2L,109L,1L,1L,1L,1L,1L,3L,1L,2L,1L,1L,1L,5L,1L,4L,1L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190649Inst : IEnumerable<long>
{
public static readonly long[] Value=A190649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190649.Bytes);
public long this[int i]=>Value[i];

public static A190649Inst Instance=new A190649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190650
{
public static readonly long[] Value={ 1L,2L,3L,8L,10L,12L,14L,16L,27L,30L,33L,36L,39L,42L,45L,128L,136L,144L,152L,160L,168L,176L,184L,192L,250L,260L,270L,280L,290L,300L,310L,320L,330L,340L,350L,432L,444L,456L,468L,480L,492L,504L,516L,528L,540L,552L,564L,576L,686L,700L,714L,728L,742L,756L,770L,784L,798L,812L,826L,840L,854L,868L,882L,1024L,1040L,1056L,1072L,1088L,1104L,1120L,1136L,1152L,1168L,1184L,1200L,1216L,1232L,1248L,1264L,1280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190650Inst : IEnumerable<long>
{
public static readonly long[] Value=A190650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190650.Bytes);
public long this[int i]=>Value[i];

public static A190650Inst Instance=new A190650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190651
{
public static readonly long[] Value={ 1902L,1904L,1909L,1910L,1913L,1915L,1916L,1919L,1921L,1924L,1926L,1927L,1930L,1932L,1937L,1938L,1941L,1943L,1944L,1947L,1949L,1952L,1954L,1955L,1958L,1960L,1965L,1966L,1969L,1971L,1972L,1975L,1977L,1980L,1982L,1983L,1986L,1988L,1993L,1994L,1997L,1999L,2000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190651Inst : IEnumerable<long>
{
public static readonly long[] Value=A190651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190651.Bytes);
public long this[int i]=>Value[i];

public static A190651Inst Instance=new A190651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190700
{
public static readonly long[] Value={ 3L,7L,14L,18L,22L,25L,29L,33L,37L,40L,44L,48L,55L,59L,63L,66L,70L,74L,78L,81L,85L,89L,93L,96L,100L,104L,111L,115L,119L,122L,126L,130L,134L,137L,141L,145L,149L,152L,156L,160L,167L,171L,175L,178L,182L,186L,190L,193L,197L,201L,205L,208L,212L,216L,223L,227L,231L,234L,238L,242L,246L,249L,253L,257L,264L,268L,272L,275L,279L,283L,287L,290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190700Inst : IEnumerable<long>
{
public static readonly long[] Value=A190700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190700.Bytes);
public long this[int i]=>Value[i];

public static A190700Inst Instance=new A190700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190701
{
public static readonly long[] Value={ 2L,6L,10L,13L,17L,21L,28L,32L,36L,39L,43L,47L,51L,54L,58L,62L,69L,73L,77L,80L,84L,88L,92L,95L,99L,103L,107L,110L,114L,118L,125L,129L,133L,136L,140L,144L,148L,151L,155L,159L,163L,166L,170L,174L,181L,185L,189L,192L,196L,200L,204L,207L,211L,215L,219L,222L,226L,230L,237L,241L,245L,248L,252L,256L,260L,263L,267L,271L,278L,282L,286L,289L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190701Inst : IEnumerable<long>
{
public static readonly long[] Value=A190701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190701.Bytes);
public long this[int i]=>Value[i];

public static A190701Inst Instance=new A190701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190702
{
public static readonly long[] Value={ 1L,5L,9L,12L,16L,20L,24L,27L,31L,35L,42L,46L,50L,53L,57L,61L,65L,68L,72L,76L,83L,87L,91L,94L,98L,102L,106L,109L,113L,117L,121L,124L,128L,132L,139L,143L,147L,150L,154L,158L,162L,165L,169L,173L,177L,180L,184L,188L,195L,199L,203L,206L,210L,214L,218L,221L,225L,229L,233L,236L,240L,244L,247L,251L,255L,259L,262L,266L,270L,274L,277L,281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190702Inst : IEnumerable<long>
{
public static readonly long[] Value=A190702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190702.Bytes);
public long this[int i]=>Value[i];

public static A190702Inst Instance=new A190702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190703
{
public static readonly long[] Value={ 4L,8L,15L,19L,23L,30L,34L,38L,45L,49L,56L,60L,64L,71L,75L,79L,86L,90L,101L,105L,112L,116L,120L,127L,131L,135L,142L,146L,157L,161L,168L,172L,176L,183L,187L,191L,198L,202L,209L,213L,217L,224L,228L,232L,239L,243L,254L,258L,265L,269L,273L,280L,284L,288L,295L,299L,310L,314L,321L,325L,329L,336L,340L,344L,351L,355L,366L,370L,377L,381L,385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190703Inst : IEnumerable<long>
{
public static readonly long[] Value=A190703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190703.Bytes);
public long this[int i]=>Value[i];

public static A190703Inst Instance=new A190703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190704
{
public static readonly long[] Value={ 3L,2L,1L,4L,3L,2L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190704Inst : IEnumerable<long>
{
public static readonly long[] Value=A190704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190704.Bytes);
public long this[int i]=>Value[i];

public static A190704Inst Instance=new A190704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190705
{
public static readonly long[] Value={ 0L,18L,120L,378L,864L,1650L,2808L,4410L,6528L,9234L,12600L,16698L,21600L,27378L,34104L,41850L,50688L,60690L,71928L,84474L,98400L,113778L,130680L,149178L,169344L,191250L,214968L,240570L,268128L,297714L,329400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190705Inst : IEnumerable<long>
{
public static readonly long[] Value=A190705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190705.Bytes);
public long this[int i]=>Value[i];

public static A190705Inst Instance=new A190705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190706
{
public static readonly long[] Value={ 3L,10L,14L,18L,21L,25L,29L,33L,36L,40L,44L,48L,51L,55L,59L,66L,70L,74L,77L,81L,85L,89L,92L,96L,100L,107L,111L,115L,118L,122L,126L,130L,133L,137L,141L,145L,148L,152L,156L,163L,167L,171L,174L,178L,182L,186L,189L,193L,197L,201L,204L,208L,212L,219L,223L,227L,230L,234L,238L,242L,245L,249L,253L,257L,260L,264L,268L,275L,279L,283L,286L,290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190706Inst : IEnumerable<long>
{
public static readonly long[] Value=A190706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190706.Bytes);
public long this[int i]=>Value[i];

public static A190706Inst Instance=new A190706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190707
{
public static readonly long[] Value={ 2L,6L,9L,13L,17L,24L,28L,32L,35L,39L,43L,47L,50L,54L,58L,62L,65L,69L,73L,80L,84L,88L,91L,95L,99L,103L,106L,110L,114L,121L,125L,129L,132L,136L,140L,144L,147L,151L,155L,159L,162L,166L,170L,177L,181L,185L,188L,192L,196L,200L,203L,207L,211L,215L,218L,222L,226L,233L,237L,241L,244L,248L,252L,256L,259L,263L,267L,271L,274L,278L,282L,289L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190707Inst : IEnumerable<long>
{
public static readonly long[] Value=A190707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190707.Bytes);
public long this[int i]=>Value[i];

public static A190707Inst Instance=new A190707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190708
{
public static readonly long[] Value={ 1L,5L,8L,12L,16L,20L,23L,27L,31L,38L,42L,46L,49L,53L,57L,61L,64L,68L,72L,76L,79L,83L,87L,94L,98L,102L,105L,109L,113L,117L,120L,124L,128L,135L,139L,143L,146L,150L,154L,158L,161L,165L,169L,173L,176L,180L,184L,191L,195L,199L,202L,206L,210L,214L,217L,221L,225L,229L,232L,236L,240L,247L,251L,255L,258L,262L,266L,270L,273L,277L,281L,285L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190708Inst : IEnumerable<long>
{
public static readonly long[] Value=A190708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190708.Bytes);
public long this[int i]=>Value[i];

public static A190708Inst Instance=new A190708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190709
{
public static readonly long[] Value={ 4L,15L,19L,30L,34L,45L,56L,60L,71L,75L,86L,90L,101L,112L,116L,127L,131L,142L,157L,168L,172L,183L,187L,198L,209L,213L,224L,228L,239L,243L,254L,265L,269L,280L,284L,295L,310L,321L,325L,336L,340L,351L,366L,377L,381L,392L,396L,407L,418L,422L,433L,437L,448L,452L,463L,474L,478L,489L,493L,504L,519L,530L,534L,545L,549L,560L,575L,586L,590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190709Inst : IEnumerable<long>
{
public static readonly long[] Value=A190709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190709.Bytes);
public long this[int i]=>Value[i];

public static A190709Inst Instance=new A190709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190710
{
public static readonly long[] Value={ 3L,2L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,1L,0L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190710Inst : IEnumerable<long>
{
public static readonly long[] Value=A190710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190710.Bytes);
public long this[int i]=>Value[i];

public static A190710Inst Instance=new A190710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190711
{
public static readonly long[] Value={ 3L,7L,11L,18L,22L,26L,33L,37L,41L,48L,52L,59L,63L,67L,74L,78L,82L,89L,93L,97L,104L,108L,115L,119L,123L,130L,134L,138L,145L,149L,153L,156L,160L,164L,171L,175L,179L,186L,190L,194L,201L,205L,212L,216L,220L,227L,231L,235L,242L,246L,250L,257L,261L,268L,272L,276L,283L,287L,291L,298L,302L,306L,313L,317L,324L,328L,332L,339L,343L,347L,354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190711Inst : IEnumerable<long>
{
public static readonly long[] Value=A190711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190711.Bytes);
public long this[int i]=>Value[i];

public static A190711Inst Instance=new A190711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190712
{
public static readonly long[] Value={ 6L,10L,14L,17L,21L,25L,29L,32L,36L,40L,44L,47L,51L,55L,62L,66L,70L,73L,77L,81L,85L,88L,92L,96L,100L,103L,107L,111L,118L,122L,126L,129L,133L,137L,141L,144L,148L,152L,159L,163L,167L,170L,174L,178L,182L,185L,189L,193L,197L,200L,204L,208L,215L,219L,223L,226L,230L,234L,238L,241L,245L,249L,253L,256L,260L,264L,271L,275L,279L,282L,286L,290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190712Inst : IEnumerable<long>
{
public static readonly long[] Value=A190712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190712.Bytes);
public long this[int i]=>Value[i];

public static A190712Inst Instance=new A190712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190713
{
public static readonly long[] Value={ 2L,5L,9L,13L,20L,24L,28L,31L,35L,39L,43L,46L,50L,54L,58L,61L,65L,69L,76L,80L,84L,87L,91L,95L,99L,102L,106L,110L,114L,117L,121L,125L,132L,136L,140L,143L,147L,151L,155L,158L,162L,166L,173L,177L,181L,184L,188L,192L,196L,199L,203L,207L,211L,214L,218L,222L,229L,233L,237L,240L,244L,248L,252L,255L,259L,263L,267L,270L,274L,278L,285L,289L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190713Inst : IEnumerable<long>
{
public static readonly long[] Value=A190713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190713.Bytes);
public long this[int i]=>Value[i];

public static A190713Inst Instance=new A190713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190714
{
public static readonly long[] Value={ 1L,4L,8L,12L,16L,19L,23L,27L,34L,38L,42L,45L,49L,53L,57L,60L,64L,68L,72L,75L,79L,83L,90L,94L,98L,101L,105L,109L,113L,116L,120L,124L,128L,131L,135L,139L,146L,150L,154L,157L,161L,165L,169L,172L,176L,180L,187L,191L,195L,198L,202L,206L,210L,213L,217L,221L,225L,228L,232L,236L,243L,247L,251L,254L,258L,262L,266L,269L,273L,277L,281L,284L,288L,292L,299L,303L,307L,310L,314L,318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190714Inst : IEnumerable<long>
{
public static readonly long[] Value=A190714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190714.Bytes);
public long this[int i]=>Value[i];

public static A190714Inst Instance=new A190714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190715
{
public static readonly long[] Value={ 15L,30L,56L,71L,86L,112L,127L,142L,168L,183L,209L,224L,239L,265L,280L,295L,321L,336L,377L,392L,418L,433L,448L,474L,489L,504L,530L,545L,586L,601L,627L,642L,657L,683L,698L,713L,739L,754L,780L,795L,810L,836L,851L,866L,892L,907L,948L,963L,989L,1004L,1019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190715Inst : IEnumerable<long>
{
public static readonly long[] Value=A190715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190715.Bytes);
public long this[int i]=>Value[i];

public static A190715Inst Instance=new A190715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190732
{
public static readonly long[] Value={ 1L,1L,2L,8L,3L,7L,9L,1L,6L,7L,0L,9L,5L,5L,1L,2L,5L,7L,3L,8L,9L,6L,1L,5L,8L,9L,0L,3L,1L,2L,1L,5L,4L,5L,1L,7L,1L,6L,8L,8L,1L,0L,1L,2L,5L,8L,6L,5L,7L,9L,9L,7L,7L,1L,3L,6L,8L,8L,1L,7L,1L,4L,4L,3L,4L,2L,1L,2L,8L,4L,9L,3L,6L,8L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190732Inst : IEnumerable<long>
{
public static readonly long[] Value=A190732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190732.Bytes);
public long this[int i]=>Value[i];

public static A190732Inst Instance=new A190732Inst();

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