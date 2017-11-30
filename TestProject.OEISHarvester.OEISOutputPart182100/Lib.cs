using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A212557
{
public static readonly long[] Value={ 67L,877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212557Inst : IEnumerable<long>
{
public static readonly long[] Value=A212557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212557.Bytes);
public long this[int i]=>Value[i];

public static A212557Inst Instance=new A212557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212558
{
public static readonly long[] Value={ 0L,-4L,6L,12L,4L,18L,5L,2L,0L,19L,0L,12L,2L,6L,24L,-12L,14L,0L,16L,-12L,-6L,19L,7L,18L,25L,28L,9L,2L,18L,6L,-8L,-20L,0L,30L,44L,0L,4L,4L,36L,28L,35L,21L,3L,-19L,0L,-30L,-19L,-12L,36L,35L,-24L,26L,6L,36L,8L,-24L,-6L,8L,18L,24L,35L,15L,-9L,46L,16L,45L,7L,28L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212558Inst : IEnumerable<long>
{
public static readonly long[] Value=A212558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212558.Bytes);
public long this[int i]=>Value[i];

public static A212558Inst Instance=new A212558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212559
{
public static readonly BigInteger[] Value={ 1L,1L,4L,27L,244L,2745L,36966L,580111L,10399096L,209672721L,4696872490L,115732052271L,3110867569140L,90587751885241L,2840805169411678L,95450112571474095L,3420897993621996016L,BigInteger.Parse("130266500391456691233"),BigInteger.Parse("5252293203395848789842"),BigInteger.Parse("223535386151669737094095"),BigInteger.Parse("10014286301754519472897900") };
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
public class A212559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212559Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A212559.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A212559.Bytes);
public BigInteger this[int i]=>Value[i];

public static A212559Inst Instance=new A212559Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212560
{
public static readonly long[] Value={ 0L,1L,11L,50L,150L,355L,721L,1316L,2220L,3525L,5335L,7766L,10946L,15015L,20125L,26440L,34136L,43401L,54435L,67450L,82670L,100331L,120681L,143980L,170500L,200525L,234351L,272286L,314650L,361775L,414005L,471696L,535216L,604945L,681275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212560Inst : IEnumerable<long>
{
public static readonly long[] Value=A212560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212560.Bytes);
public long this[int i]=>Value[i];

public static A212560Inst Instance=new A212560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212561
{
public static readonly long[] Value={ 0L,0L,1L,5L,12L,26L,45L,75L,112L,164L,225L,305L,396L,510L,637L,791L,960L,1160L,1377L,1629L,1900L,2210L,2541L,2915L,3312L,3756L,4225L,4745L,5292L,5894L,6525L,7215L,7936L,8720L,9537L,10421L,11340L,12330L,13357L,14459L,15600L,16820L,18081L,19425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212561Inst : IEnumerable<long>
{
public static readonly long[] Value=A212561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212561.Bytes);
public long this[int i]=>Value[i];

public static A212561Inst Instance=new A212561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212562
{
public static readonly long[] Value={ 0L,1L,15L,73L,228L,551L,1137L,2097L,3568L,5701L,8675L,12681L,17940L,24683L,33173L,43681L,56512L,71977L,90423L,112201L,137700L,167311L,201465L,240593L,285168L,335661L,392587L,456457L,527828L,607251L,695325L,792641L,899840L,1017553L,1146463L,1287241L,1440612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212562Inst : IEnumerable<long>
{
public static readonly long[] Value=A212562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212562.Bytes);
public long this[int i]=>Value[i];

public static A212562Inst Instance=new A212562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212563
{
public static readonly long[] Value={ 0L,1L,16L,78L,240L,577L,1182L,2172L,3680L,5865L,8900L,12986L,18336L,25193L,33810L,44472L,57472L,73137L,91800L,113830L,139600L,169521L,204006L,243508L,288480L,339417L,396812L,461202L,533120L,613145L,701850L,799856L,907776L,1026273L,1156000L,1297662L,1451952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212563Inst : IEnumerable<long>
{
public static readonly long[] Value=A212563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212563.Bytes);
public long this[int i]=>Value[i];

public static A212563Inst Instance=new A212563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212564
{
public static readonly long[] Value={ 0L,0L,0L,3L,16L,48L,114L,229L,416L,696L,1100L,1655L,2400L,3368L,4606L,6153L,8064L,10384L,13176L,16491L,20400L,24960L,30250L,36333L,43296L,51208L,60164L,70239L,81536L,94136L,108150L,123665L,140800L,159648L,180336L,202963L,227664L,254544L,283746L,315381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212564Inst : IEnumerable<long>
{
public static readonly long[] Value=A212564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212564.Bytes);
public long this[int i]=>Value[i];

public static A212564Inst Instance=new A212564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212565
{
public static readonly long[] Value={ 0L,0L,1L,8L,28L,74L,159L,304L,528L,860L,1325L,1960L,2796L,3878L,5243L,6944L,9024L,11544L,14553L,18120L,22300L,27170L,32791L,39248L,46608L,54964L,64389L,74984L,86828L,100030L,114675L,130880L,148736L,168368L,189873L,213384L,239004L,266874L,297103L,329840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212565Inst : IEnumerable<long>
{
public static readonly long[] Value=A212565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212565.Bytes);
public long this[int i]=>Value[i];

public static A212565Inst Instance=new A212565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212566
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,9L,16L,26L,44L,63L,87L,123L,160L,204L,264L,325L,395L,485L,576L,678L,804L,931L,1071L,1239L,1408L,1592L,1808L,2025L,2259L,2529L,2800L,3090L,3420L,3751L,4103L,4499L,4896L,5316L,5784L,6253L,6747L,7293L,7840L,8414L,9044L,9675L,10335L,11055L,11776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212566Inst : IEnumerable<long>
{
public static readonly long[] Value=A212566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212566.Bytes);
public long this[int i]=>Value[i];

public static A212566Inst Instance=new A212566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212567
{
public static readonly long[] Value={ 0L,0L,2L,5L,11L,27L,42L,68L,106L,149L,201L,279L,354L,452L,572L,701L,845L,1031L,1212L,1428L,1676L,1937L,2219L,2559L,2892L,3272L,3694L,4133L,4599L,5139L,5670L,6260L,6902L,7565L,8261L,9047L,9822L,10668L,11576L,12509L,13481L,14559L,15624L,16772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212567Inst : IEnumerable<long>
{
public static readonly long[] Value=A212567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212567.Bytes);
public long this[int i]=>Value[i];

public static A212567Inst Instance=new A212567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212568
{
public static readonly long[] Value={ 0L,0L,2L,24L,98L,272L,608L,1184L,2092L,3440L,5350L,7960L,11422L,15904L,21588L,28672L,37368L,47904L,60522L,75480L,93050L,113520L,137192L,164384L,195428L,230672L,270478L,315224L,365302L,421120L,483100L,551680L,627312L,710464L,801618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212568Inst : IEnumerable<long>
{
public static readonly long[] Value=A212568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212568.Bytes);
public long this[int i]=>Value[i];

public static A212568Inst Instance=new A212568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212569
{
public static readonly long[] Value={ 0L,1L,2L,31L,96L,321L,690L,1471L,2576L,4465L,6930L,10671L,15312L,21841L,29666L,40111L,52320L,68001L,85986L,108415L,133760L,164641L,199122L,240351L,285936L,339601L,398450L,466831L,541296L,626865L,719490L,824911L,938432L,1066561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212569Inst : IEnumerable<long>
{
public static readonly long[] Value=A212569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212569.Bytes);
public long this[int i]=>Value[i];

public static A212569Inst Instance=new A212569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212570
{
public static readonly long[] Value={ 0L,1L,6L,23L,52L,105L,178L,287L,424L,609L,830L,1111L,1436L,1833L,2282L,2815L,3408L,4097L,4854L,5719L,6660L,7721L,8866L,10143L,11512L,13025L,14638L,16407L,18284L,20329L,22490L,24831L,27296L,29953L,32742L,35735L,38868L,42217L,45714L,49439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212570Inst : IEnumerable<long>
{
public static readonly long[] Value=A212570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212570.Bytes);
public long this[int i]=>Value[i];

public static A212570Inst Instance=new A212570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212571
{
public static readonly long[] Value={ 0L,0L,8L,48L,168L,428L,916L,1728L,2992L,4840L,7440L,10960L,15608L,21588L,29148L,38528L,50016L,63888L,80472L,100080L,123080L,149820L,180708L,216128L,256528L,302328L,354016L,412048L,476952L,549220L,629420L,718080L,815808L,923168L,1040808L,1169328L,1309416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212571Inst : IEnumerable<long>
{
public static readonly long[] Value=A212571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212571.Bytes);
public long this[int i]=>Value[i];

public static A212571Inst Instance=new A212571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212572
{
public static readonly long[] Value={ 0L,1L,14L,71L,220L,533L,1094L,2015L,3416L,5449L,8270L,12071L,17044L,23421L,31430L,41343L,53424L,67985L,85326L,105799L,129740L,157541L,189574L,226271L,268040L,315353L,368654L,428455L,495236L,569549L,651910L,742911L,843104L,953121L,1073550L,1205063L,1348284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212572Inst : IEnumerable<long>
{
public static readonly long[] Value=A212572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212572.Bytes);
public long this[int i]=>Value[i];

public static A212572Inst Instance=new A212572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212573
{
public static readonly long[] Value={ 0L,0L,2L,10L,36L,92L,202L,386L,680L,1112L,1730L,2570L,3692L,5140L,6986L,9282L,12112L,15536L,19650L,24522L,30260L,36940L,44682L,53570L,63736L,75272L,88322L,102986L,119420L,137732L,158090L,180610L,205472L,232800L,262786L,295562L,331332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212573Inst : IEnumerable<long>
{
public static readonly long[] Value=A212573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212573.Bytes);
public long this[int i]=>Value[i];

public static A212573Inst Instance=new A212573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212574
{
public static readonly long[] Value={ 0L,1L,8L,33L,88L,197L,380L,673L,1104L,1721L,2560L,3681L,5128L,6973L,9268L,12097L,15520L,19633L,24504L,30241L,36920L,44661L,53548L,63713L,75248L,88297L,102960L,119393L,137704L,158061L,180580L,205441L,232768L,262753L,295528L,331297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212574Inst : IEnumerable<long>
{
public static readonly long[] Value=A212574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212574.Bytes);
public long this[int i]=>Value[i];

public static A212574Inst Instance=new A212574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212575
{
public static readonly long[] Value={ 0L,1L,4L,17L,42L,85L,142L,235L,346L,495L,680L,911L,1172L,1505L,1872L,2305L,2798L,3365L,3978L,4699L,5470L,6335L,7284L,8335L,9448L,10705L,12028L,13473L,15026L,16709L,18470L,20411L,22434L,24607L,26912L,29375L,31932L,34705L,37576L,40625L,43830L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212575Inst : IEnumerable<long>
{
public static readonly long[] Value=A212575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212575.Bytes);
public long this[int i]=>Value[i];

public static A212575Inst Instance=new A212575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212576
{
public static readonly long[] Value={ 0L,1L,2L,7L,16L,33L,52L,87L,126L,181L,246L,331L,422L,545L,674L,831L,1006L,1213L,1428L,1691L,1964L,2277L,2614L,2995L,3388L,3845L,4314L,4835L,5388L,5997L,6620L,7323L,8042L,8825L,9646L,10535L,11442L,12445L,13466L,14563L,15706L,16929L,18172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212576Inst : IEnumerable<long>
{
public static readonly long[] Value=A212576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212576.Bytes);
public long this[int i]=>Value[i];

public static A212576Inst Instance=new A212576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212577
{
public static readonly long[] Value={ 0L,1L,4L,17L,46L,89L,154L,251L,374L,531L,736L,979L,1268L,1621L,2024L,2485L,3026L,3629L,4302L,5071L,5914L,6839L,7876L,8999L,10216L,11561L,13004L,14553L,16246L,18049L,19970L,22051L,24254L,26587L,29096L,31739L,34524L,37501L,40624L,43901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212577Inst : IEnumerable<long>
{
public static readonly long[] Value=A212577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212577.Bytes);
public long this[int i]=>Value[i];

public static A212577Inst Instance=new A212577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212578
{
public static readonly long[] Value={ 0L,1L,4L,13L,28L,55L,92L,147L,216L,309L,420L,561L,724L,923L,1148L,1415L,1712L,2057L,2436L,2869L,3340L,3871L,4444L,5083L,5768L,6525L,7332L,8217L,9156L,10179L,11260L,12431L,13664L,14993L,16388L,17885L,19452L,21127L,22876L,24739L,26680L,28741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212578Inst : IEnumerable<long>
{
public static readonly long[] Value=A212578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212578.Bytes);
public long this[int i]=>Value[i];

public static A212578Inst Instance=new A212578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212579
{
public static readonly long[] Value={ 0L,1L,8L,31L,80L,171L,308L,509L,780L,1137L,1584L,2143L,2812L,3615L,4552L,5645L,6892L,8321L,9924L,11731L,13736L,15967L,18416L,21117L,24056L,27269L,30744L,34515L,38568L,42943L,47620L,52641L,57988L,63701L,69760L,76211L,83028L,90259L,97880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212579Inst : IEnumerable<long>
{
public static readonly long[] Value=A212579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212579.Bytes);
public long this[int i]=>Value[i];

public static A212579Inst Instance=new A212579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212580
{
public static readonly long[] Value={ 1L,1L,2L,5L,20L,102L,626L,4458L,36144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212580Inst : IEnumerable<long>
{
public static readonly long[] Value=A212580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212580.Bytes);
public long this[int i]=>Value[i];

public static A212580Inst Instance=new A212580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212581
{
public static readonly long[] Value={ 1L,1L,2L,4L,17L,89L,556L,4011L,32843L,301210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212581Inst : IEnumerable<long>
{
public static readonly long[] Value=A212581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212581.Bytes);
public long this[int i]=>Value[i];

public static A212581Inst Instance=new A212581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212582
{
public static readonly long[] Value={ 8L,12L,18L,20L,27L,28L,30L,42L,44L,45L,50L,52L,63L,66L,68L,70L,75L,76L,78L,92L,98L,99L,102L,105L,110L,114L,116L,117L,124L,125L,130L,138L,147L,153L,154L,164L,165L,170L,171L,174L,175L,182L,186L,188L,190L,195L,207L,230L,231L,236L,238L,242L,245L,246L,255L,261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212582Inst : IEnumerable<long>
{
public static readonly long[] Value=A212582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212582.Bytes);
public long this[int i]=>Value[i];

public static A212582Inst Instance=new A212582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212583
{
public static readonly long[] Value={ 66161L,534851L,3152573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212583Inst : IEnumerable<long>
{
public static readonly long[] Value=A212583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212583.Bytes);
public long this[int i]=>Value[i];

public static A212583Inst Instance=new A212583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212584
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,6L,9L,12L,18L,24L,34L,46L,65L,89L,124L,170L,236L,325L,450L,620L,857L,1182L,1633L,2253L,3111L,4293L,5927L,8180L,11292L,15585L,21513L,29693L,40986L,56571L,78085L,107778L,148765L,205336L,283422L,391200L,539966L,745302L,1028725L,1419925L,1959892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212584Inst : IEnumerable<long>
{
public static readonly long[] Value=A212584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212584.Bytes);
public long this[int i]=>Value[i];

public static A212584Inst Instance=new A212584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212585
{
public static readonly long[] Value={ 1L,2L,4L,8L,12L,18L,26L,40L,56L,82L,112L,162L,222L,316L,432L,608L,834L,1166L,1602L,2228L,3066L,4252L,5858L,8108L,11178L,15454L,21316L,29450L,40632L,56114L,77434L,106914L,147550L,203696L,281134L,388082L,535636L,739368L,1020506L,1408626L,1944266L,2683674L,3704184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212585Inst : IEnumerable<long>
{
public static readonly long[] Value=A212585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212585.Bytes);
public long this[int i]=>Value[i];

public static A212585Inst Instance=new A212585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212586
{
public static readonly long[] Value={ 1L,2L,6L,13L,29L,60L,128L,269L,569L,1198L,2526L,5321L,11213L,23624L,49776L,104873L,220961L,465546L,980870L,2066613L,4354189L,9173924L,19328720L,40724053L,85802297L,180778518L,380885758L,802495569L,1690793437L,3562365392L,7505616544L,15813728657L,33318250753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212586Inst : IEnumerable<long>
{
public static readonly long[] Value=A212586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212586.Bytes);
public long this[int i]=>Value[i];

public static A212586Inst Instance=new A212586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212587
{
public static readonly long[] Value={ 1L,4L,12L,30L,66L,148L,316L,682L,1438L,3052L,6428L,13574L,28594L,60284L,127004L,267634L,563870L,1188084L,2503180L,5274062L,11112002L,23412164L,49327516L,103929178L,218970366L,461352988L,972033500L,2047996278L,4314962930L,9091278956L,19154591420L,40357179234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212587Inst : IEnumerable<long>
{
public static readonly long[] Value=A212587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212587.Bytes);
public long this[int i]=>Value[i];

public static A212587Inst Instance=new A212587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212588
{
public static readonly long[] Value={ 1L,2L,4L,8L,14L,25L,44L,78L,137L,241L,423L,743L,1304L,2289L,4017L,7050L,12372L,21712L,38102L,66865L,117340L,205918L,361361L,634145L,1112847L,1952911L,3427120L,6014177L,10554145L,18521234L,32502500L,57037912L,100094558L,175653705L,308250764L,540942382L,949287705L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212588Inst : IEnumerable<long>
{
public static readonly long[] Value=A212588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212588.Bytes);
public long this[int i]=>Value[i];

public static A212588Inst Instance=new A212588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212589
{
public static readonly long[] Value={ 1L,3L,8L,18L,34L,64L,118L,214L,382L,678L,1198L,2112L,3716L,6532L,11474L,20148L,35370L,62084L,108964L,191234L,335608L,588968L,1033584L,1813832L,3183072L,5585922L,9802630L,17202438L,30188196L,52976614L,92967500L,163146614L,286302374L,502425668L,881695610L,1547267962L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212589Inst : IEnumerable<long>
{
public static readonly long[] Value=A212589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212589.Bytes);
public long this[int i]=>Value[i];

public static A212589Inst Instance=new A212589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212590
{
public static readonly long[] Value={ 2L,5L,773L,10915517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212590Inst : IEnumerable<long>
{
public static readonly long[] Value=A212590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212590.Bytes);
public long this[int i]=>Value[i];

public static A212590Inst Instance=new A212590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212591
{
public static readonly long[] Value={ 0L,1L,2L,5L,8L,9L,10L,21L,32L,33L,34L,37L,40L,41L,42L,85L,128L,129L,130L,133L,136L,137L,138L,149L,160L,161L,162L,165L,168L,169L,170L,341L,512L,513L,514L,517L,520L,521L,522L,533L,544L,545L,546L,549L,552L,553L,554L,597L,640L,641L,642L,645L,648L,649L,650L,661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212591Inst : IEnumerable<long>
{
public static readonly long[] Value=A212591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212591.Bytes);
public long this[int i]=>Value[i];

public static A212591Inst Instance=new A212591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212592
{
public static readonly long[] Value={ 1L,6L,11L,106L,201L,2022L,3843L,38794L,73745L,744646L,1415547L,14293930L,27172313L,274381478L,521590643L,5266936010L,10012281377L,101102361990L,192192442603L,1940727511786L,3689262580969L,37253563629926L,70817864678883L,715107089849866L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212592Inst : IEnumerable<long>
{
public static readonly long[] Value=A212592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212592.Bytes);
public long this[int i]=>Value[i];

public static A212592Inst Instance=new A212592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212593
{
public static readonly long[] Value={ 1L,8L,15L,232L,449L,7400L,14351L,237832L,461313L,7648968L,14836623L,246015528L,477194433L,7912700328L,15348206223L,254499628104L,493651049985L,8185582834056L,15877514618127L,263276481572712L,510675448527297L,8467876653984360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212593Inst : IEnumerable<long>
{
public static readonly long[] Value=A212593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212593.Bytes);
public long this[int i]=>Value[i];

public static A212593Inst Instance=new A212593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212594
{
public static readonly long[] Value={ 1L,10L,19L,430L,841L,20602L,40363L,995710L,1951057L,48162410L,94373763L,2329795534L,4565217305L,112701782490L,220838347675L,5451852478622L,10682866609569L,263728727794378L,516774588979187L,12757653047779310L,24998531506579433L,617140623134480698L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212594Inst : IEnumerable<long>
{
public static readonly long[] Value=A212594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212594.Bytes);
public long this[int i]=>Value[i];

public static A212594Inst Instance=new A212594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212595
{
public static readonly long[] Value={ 2L,2L,4L,2L,2L,4L,2L,4L,6L,2L,2L,4L,6L,2L,4L,2L,2L,4L,2L,4L,6L,2L,4L,6L,2L,2L,4L,6L,2L,4L,2L,2L,4L,6L,2L,4L,2L,4L,6L,2L,4L,6L,8L,2L,4L,2L,2L,4L,2L,2L,4L,2L,4L,6L,8L,10L,12L,14L,2L,4L,2L,4L,6L,2L,2L,4L,6L,8L,10L,2L,2L,4L,6L,2L,4L,6L,2L,4L,2L,4L,6L,2L,4L,6L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212595Inst : IEnumerable<long>
{
public static readonly long[] Value=A212595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212595.Bytes);
public long this[int i]=>Value[i];

public static A212595Inst Instance=new A212595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212596
{
public static readonly BigInteger[] Value={ 12L,192L,3456L,66048L,1296384L,25731072L,513048576L,10248388608L,204867108864L,4096536870912L,81924294967296L,1638434359738368L,32768274877906944L,655362199023255552L,13107217592186044416UL,BigInteger.Parse("262144140737488355328"),BigInteger.Parse("5242881125899906842624") };
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
public class A212596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212596Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A212596.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A212596.Bytes);
public BigInteger this[int i]=>Value[i];

public static A212596Inst Instance=new A212596Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212597
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,3L,5L,5L,7L,9L,10L,11L,14L,15L,16L,19L,20L,23L,24L,27L,28L,33L,30L,37L,36L,42L,40L,48L,44L,53L,49L,57L,55L,65L,55L,72L,64L,74L,70L,83L,72L,90L,77L,95L,87L,102L,84L,112L,94L,112L,104L,124L,102L,133L,109L,135L,123L,142L,117L,160L,128L,152L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212597Inst : IEnumerable<long>
{
public static readonly long[] Value=A212597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212597.Bytes);
public long this[int i]=>Value[i];

public static A212597Inst Instance=new A212597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212598
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212598Inst : IEnumerable<long>
{
public static readonly long[] Value=A212598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212598.Bytes);
public long this[int i]=>Value[i];

public static A212598Inst Instance=new A212598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212599
{
public static readonly BigInteger[] Value={ 1L,1L,3L,18L,160L,1875L,27126L,466186L,9275064L,209654325L,5307031000L,148720701426L,4570816040352L,152874605142727L,5527634477245440L,214862754390554250L,8934811701563214976L,BigInteger.Parse("395788795274021394729"),BigInteger.Parse("18606559519007667893376"),BigInteger.Parse("925222631836457779380370"),BigInteger.Parse("48518852386696450625510400") };
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
public class A212599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212599Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A212599.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A212599.Bytes);
public BigInteger this[int i]=>Value[i];

public static A212599Inst Instance=new A212599Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212600
{
public static readonly long[] Value={ 35L,49L,55L,65L,77L,85L,77L,91L,119L,121L,143L,161L,187L,217L,247L,253L,259L,289L,299L,301L,319L,323L,329L,341L,343L,371L,403L,427L,437L,451L,473L,481L,493L,497L,511L,527L,533L,539L,553L,581L,589L,49L,77L,91L,119L,133L,143L,161L,187L,209L,217L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212600Inst : IEnumerable<long>
{
public static readonly long[] Value=A212600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212600.Bytes);
public long this[int i]=>Value[i];

public static A212600Inst Instance=new A212600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212601
{
public static readonly long[] Value={ 4033L,6601L,8321L,15841L,25761L,29341L,41041L,46657L,75361L,115921L,162401L,172081L,252601L,294409L,314821L,332949L,401401L,410041L,488881L,530881L,552721L,642001L,721801L,873181L,934021L,1004653L,1207361L,1461241L,1876393L,1909001L,2081713L,2085301L,2113921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212601Inst : IEnumerable<long>
{
public static readonly long[] Value=A212601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212601.Bytes);
public long this[int i]=>Value[i];

public static A212601Inst Instance=new A212601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212602
{
public static readonly long[] Value={ 17L,3L,37L,17L,409L,79L,11L,97L,673L,251L,53L,673L,17L,239L,211L,97L,353L,337L,23L,521L,1213L,97L,173L,4201L,409L,859L,439L,113L,937L,7369L,293L,2129L,7573L,569L,571L,673L,41L,1567L,997L,409L,1601L,337L,47L,401L,1801L,1783L,1867L,4201L,197L,499L,733L,1301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212602Inst : IEnumerable<long>
{
public static readonly long[] Value=A212602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212602.Bytes);
public long this[int i]=>Value[i];

public static A212602Inst Instance=new A212602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212603
{
public static readonly long[] Value={ 101L,97L,163L,101L,3061L,1777L,113L,2617L,8353L,419L,4937L,8353L,3457L,34729L,8209L,2617L,53201L,2203L,4253L,12301L,54049L,991L,6803L,232801L,3061L,11491L,739L,2237L,32297L,68329L,857L,19801L,12853L,7411L,53299L,28081L,941L,14503L,20107L,88729L,23993L,23251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212603Inst : IEnumerable<long>
{
public static readonly long[] Value=A212603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212603.Bytes);
public long this[int i]=>Value[i];

public static A212603Inst Instance=new A212603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212604
{
public static readonly long[] Value={ 409L,577L,1759L,409L,55049L,1783L,127L,20873L,12889L,6529L,4943L,12889L,3461L,138041L,46411L,20873L,115013L,7417L,4919L,158209L,8490721L,7177L,15787L,4967401L,55049L,383393L,76597L,5273L,252541L,10448401L,2543L,577193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212604Inst : IEnumerable<long>
{
public static readonly long[] Value=A212604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212604.Bytes);
public long this[int i]=>Value[i];

public static A212604Inst Instance=new A212604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212605
{
public static readonly long[] Value={ 2633L,587L,1777L,2633L,239521L,862471L,2017L,208457L,586273L,147451L,4951L,586273L,207073L,612553L,102871L,208457L,301681L,351439L,242447L,2076901L,55948657L,27487L,119503L,9425257L,239521L,5188507L,128467L,75853L,74049413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212605Inst : IEnumerable<long>
{
public static readonly long[] Value=A212605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212605.Bytes);
public long this[int i]=>Value[i];

public static A212605Inst Instance=new A212605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212606
{
public static readonly long[] Value={ 1L,2L,3L,6L,10L,26L,34L,103L,175L,393L,599L,2015L,2551L,8681L,14254L,19620L,34700L,129557L,161272L,595304L,695175L,1094164L,1903859L,7654850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212606Inst : IEnumerable<long>
{
public static readonly long[] Value=A212606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212606.Bytes);
public long this[int i]=>Value[i];

public static A212606Inst Instance=new A212606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212607
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,14L,21L,38L,70L,129L,238L,440L,504L,949L,1790L,2301L,4363L,8272L,12408L,23604L,26675L,45724L,87781L,168549L,181989L,351076L,677339L,1306894L,1399054L,2709128L,2795144L,5423805L,10525050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212607Inst : IEnumerable<long>
{
public static readonly long[] Value=A212607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212607.Bytes);
public long this[int i]=>Value[i];

public static A212607Inst Instance=new A212607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212608
{
public static readonly long[] Value={ 135L,3375L,1485L,2295L,2565L,3105L,3915L,4185L,4995L,5535L,5805L,6345L,25137L,7155L,7965L,8235L,9045L,9585L,9855L,10665L,11205L,12015L,13095L,13635L,13905L,14445L,14715L,43875L,15255L,16335L,17145L,17685L,18495L,18765L,57375L,20115L,20385L,21195L,64125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212608Inst : IEnumerable<long>
{
public static readonly long[] Value=A212608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212608.Bytes);
public long this[int i]=>Value[i];

public static A212608Inst Instance=new A212608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212609
{
public static readonly long[] Value={ 819L,6975L,9009L,13923L,15561L,18837L,23751L,25389L,30303L,33579L,35217L,38493L,40131L,43407L,48321L,49959L,54873L,58149L,59787L,64701L,67977L,72891L,79443L,82719L,84357L,87633L,89271L,90675L,92547L,99099L,104013L,107289L,112203L,113841L,118575L,122031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212609Inst : IEnumerable<long>
{
public static readonly long[] Value=A212609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212609.Bytes);
public long this[int i]=>Value[i];

public static A212609Inst Instance=new A212609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212610
{
public static readonly long[] Value={ 135L,819L,3375L,6975L,25137L,40131L,68607L,154791L,22113L,448335L,557375L,721525L,451737L,1401543L,1278316L,1680705L,273L,2876211L,6739509L,10590125L,188325L,11208375L,8775L,12525435L,9020375L,13934375L,20365625L,56162575L,1083537L,83479977L,3416875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212610Inst : IEnumerable<long>
{
public static readonly long[] Value=A212610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212610.Bytes);
public long this[int i]=>Value[i];

public static A212610Inst Instance=new A212610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212611
{
public static readonly long[] Value={ 135L,3375L,25137L,68607L,22113L,557375L,451737L,1278316L,273L,6739509L,188325L,8775L,9020375L,20365625L,1083537L,3416875L,17875L,1995L,171387125L,382536063L,49166L,366776L,1487640245L,417725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212611Inst : IEnumerable<long>
{
public static readonly long[] Value=A212611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212611.Bytes);
public long this[int i]=>Value[i];

public static A212611Inst Instance=new A212611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212612
{
public static readonly long[] Value={ 819L,6975L,40131L,154791L,448335L,721525L,1401543L,1680705L,2876211L,10590125L,11208375L,12525435L,13934375L,56162575L,83479977L,90190625L,102018125L,262840851L,730113475L,788522553L,1280965413L,1581644246L,1601338375L,1841695625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212612Inst : IEnumerable<long>
{
public static readonly long[] Value=A212612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212612.Bytes);
public long this[int i]=>Value[i];

public static A212612Inst Instance=new A212612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212613
{
public static readonly long[] Value={ 4208L,24536L,28916L,21278L,51806L,68078L,73538L,89216L,83978L,171146L,111116L,130586L,164876L,171788L,128498L,188546L,188816L,205796L,247376L,258968L,254546L,287306L,275456L,323966L,351788L,302816L,325148L,368378L,445688L,380168L,467696L,455486L,553118L,456608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212613Inst : IEnumerable<long>
{
public static readonly long[] Value=A212613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212613.Bytes);
public long this[int i]=>Value[i];

public static A212613Inst Instance=new A212613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212614
{
public static readonly long[] Value={ 2L,5L,3L,6L,2L,4L,10L,0L,13L,7L,5L,4L,9L,3L,20L,208L,185L,14L,5L,2L,6L,14L,12L,115L,55L,37L,748L,11L,12L,1358L,90L,90L,6L,3L,21L,11L,26L,10L,33L,21L,265L,51L,61L,75L,96L,131L,201L,411L,0L,10L,7L,148L,113L,92L,4L,68L,364L,329L,50L,5083L,43L,329594L,38L,36L,2414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212614Inst : IEnumerable<long>
{
public static readonly long[] Value=A212614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212614.Bytes);
public long this[int i]=>Value[i];

public static A212614Inst Instance=new A212614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212615
{
public static readonly long[] Value={ 2L,39L,2231L,40L,14L,94974L,47L,212L,1071L,477L,124L,261L,15120L,5L,180L,375638L,2413L,22L,4270831L,924L,278L,18L,126L,33510L,355L,376L,9047610L,37313170L,1533015L,7315L,1687018L,520L,363155L,8827L,13514L,11701449166L,670L,3290L,2L,4L,817L,31175067L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212615Inst : IEnumerable<long>
{
public static readonly long[] Value=A212615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212615.Bytes);
public long this[int i]=>Value[i];

public static A212615Inst Instance=new A212615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212616
{
public static readonly long[] Value={ 3L,36L,300L,1485L,3240L,265356L,265356L,21520080L,21520080L,193720086L,1743362676L,141214502520L,141214502520L,11438393835996L,11438393835996L,926510072902560L,926510072902560L,75047317454789316L,75047317454789316L,6078832727785072200L,6078832727785072200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212616Inst : IEnumerable<long>
{
public static readonly long[] Value=A212616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212616.Bytes);
public long this[int i]=>Value[i];

public static A212616Inst Instance=new A212616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212617
{
public static readonly BigInteger[] Value={ 5L,10045L,20475L,836640L,12397000L,1331330000L,143820000L,213051960000L,94724270640000L,3908675145375000L,104284286367187500L,BigInteger.Parse("43867845932728125000000"),BigInteger.Parse("12399293137277921875000") };
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
public class A212617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212617Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A212617.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A212617.Bytes);
public BigInteger this[int i]=>Value[i];

public static A212617Inst Instance=new A212617Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212618
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,0L,0L,4L,4L,4L,0L,0L,0L,10L,0L,0L,2L,0L,1L,1L,10L,2L,0L,20L,2L,6L,0L,1L,6L,10L,0L,20L,1L,4L,2L,0L,0L,6L,1L,2L,0L,0L,4L,13L,6L,6L,0L,0L,14L,4L,0L,0L,6L,35L,0L,1L,6L,1L,6L,2L,20L,2L,0L,13L,13L,0L,0L,13L,1L,1L,2L,0L,2L,24L,0L,10L,3L,4L,1L,12L,6L,6L,0L,10L,0L,14L,4L,0L,13L,2L,2L,35L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212618Inst : IEnumerable<long>
{
public static readonly long[] Value=A212618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212618.Bytes);
public long this[int i]=>Value[i];

public static A212618Inst Instance=new A212618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212619
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,2L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,2L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,2L,1L,0L,0L,0L,0L,0L,4L,0L,0L,1L,2L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212619Inst : IEnumerable<long>
{
public static readonly long[] Value=A212619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212619.Bytes);
public long this[int i]=>Value[i];

public static A212619Inst Instance=new A212619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212620
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,1L,4L,3L,3L,1L,4L,3L,3L,1L,5L,4L,3L,2L,1L,5L,4L,3L,2L,1L,5L,4L,3L,2L,1L,5L,4L,4L,3L,1L,5L,4L,4L,3L,1L,5L,4L,4L,3L,1L,6L,5L,4L,3L,2L,1L,5L,4L,6L,4L,1L,5L,4L,4L,3L,1L,6L,5L,5L,5L,3L,1L,5L,4L,6L,4L,1L,6L,5L,5L,4L,3L,1L,6L,5L,5L,4L,3L,1L,6L,5L,4L,3L,2L,1L,6L,5L,5L,5L,3L,1L,6L,5L,7L,7L,4L,1L,7L,6L,5L,4L,3L,2L,1L,6L,5L,5L,5L,3L,1L,7L,6L,6L,7L,6L,3L,1L,6L,5L,6L,6L,4L,1L,6L,5L,5L,4L,3L,1L,7L,6L,6L,6L,5L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212620Inst : IEnumerable<long>
{
public static readonly long[] Value=A212620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212620.Bytes);
public long this[int i]=>Value[i];

public static A212620Inst Instance=new A212620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212621
{
public static readonly long[] Value={ 0L,2L,10L,10L,28L,28L,36L,36L,60L,60L,60L,80L,80L,80L,110L,112L,80L,158L,112L,146L,146L,110L,158L,222L,182L,158L,294L,196L,146L,266L,110L,320L,182L,146L,238L,414L,222L,222L,266L,370L,158L,354L,196L,238L,472L,294L,266L,594L,312L,424L,238L,354L,320L,744L,280L,494L,370L,266L,146L,660L,414L,182L,624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212621Inst : IEnumerable<long>
{
public static readonly long[] Value=A212621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212621.Bytes);
public long this[int i]=>Value[i];

public static A212621Inst Instance=new A212621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212622
{
public static readonly long[] Value={ 0L,1L,6L,6L,19L,19L,24L,24L,44L,44L,44L,59L,59L,59L,85L,80L,59L,125L,80L,114L,114L,85L,125L,173L,146L,125L,246L,156L,114L,219L,85L,240L,146L,114L,193L,344L,173L,173L,219L,302L,125L,297L,156L,193L,407L,246L,219L,481L,256L,360L,193L,297L,240L,651L,231L,414L,302L,219L,114L,567L,344L,146L,548L,672L,345L,345L,173L,256L,407L,482L,302L,914L,297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212622Inst : IEnumerable<long>
{
public static readonly long[] Value=A212622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212622.Bytes);
public long this[int i]=>Value[i];

public static A212622Inst Instance=new A212622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212623
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,3L,1L,1L,3L,1L,1L,4L,3L,1L,4L,3L,1L,4L,3L,1L,1L,4L,3L,1L,1L,5L,6L,1L,1L,5L,6L,1L,1L,5L,6L,1L,1L,5L,6L,2L,1L,5L,6L,2L,1L,5L,6L,2L,1L,6L,10L,4L,1L,5L,6L,4L,1L,1L,5L,6L,2L,1L,6L,10L,5L,1L,5L,6L,4L,1L,1L,6L,10L,5L,1L,1L,6L,10L,5L,1L,1L,6L,10L,4L,1L,6L,10L,5L,1L,6L,10L,7L,2L,1L,7L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212623Inst : IEnumerable<long>
{
public static readonly long[] Value=A212623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212623.Bytes);
public long this[int i]=>Value[i];

public static A212623Inst Instance=new A212623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212624
{
public static readonly long[] Value={ 1L,2L,5L,5L,10L,10L,13L,13L,20L,20L,20L,23L,23L,23L,38L,33L,23L,41L,33L,45L,45L,38L,41L,55L,71L,41L,74L,48L,45L,78L,38L,81L,71L,45L,82L,92L,55L,55L,78L,105L,41L,85L,48L,82L,137L,74L,78L,131L,98L,146L,82L,85L,81L,155L,130L,108L,105L,78L,45L,173L,92L,71L,153L,193L,141L,141L,55L,98L,137L,157L,105L,212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212624Inst : IEnumerable<long>
{
public static readonly long[] Value=A212624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212624.Bytes);
public long this[int i]=>Value[i];

public static A212624Inst Instance=new A212624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212625
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,3L,3L,4L,4L,4L,3L,3L,4L,4L,3L,4L,4L,4L,4L,3L,5L,4L,4L,4L,4L,4L,4L,4L,5L,3L,4L,4L,4L,4L,4L,4L,5L,5L,5L,4L,4L,5L,4L,4L,5L,5L,4L,4L,5L,4L,4L,5L,6L,4L,4L,4L,5L,4L,5L,5L,5L,4L,4L,5L,5L,5L,4L,4L,6L,5L,4L,4L,5L,5L,4L,5L,5L,5L,5L,5L,5L,4L,4L,5L,6L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212625Inst : IEnumerable<long>
{
public static readonly long[] Value=A212625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212625.Bytes);
public long this[int i]=>Value[i];

public static A212625Inst Instance=new A212625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212626
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,3L,1L,1L,1L,1L,1L,2L,2L,2L,4L,1L,2L,5L,1L,1L,1L,4L,5L,2L,1L,5L,1L,1L,1L,2L,4L,1L,1L,1L,3L,4L,2L,2L,2L,1L,5L,3L,1L,3L,6L,1L,2L,2L,1L,1L,3L,3L,1L,9L,5L,1L,1L,2L,1L,2L,4L,1L,1L,1L,7L,7L,2L,1L,6L,1L,1L,4L,3L,4L,2L,1L,1L,8L,3L,1L,1L,2L,1L,2L,1L,3L,1L,3L,2L,4L,2L,1L,5L,6L,3L,2L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212626Inst : IEnumerable<long>
{
public static readonly long[] Value=A212626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212626.Bytes);
public long this[int i]=>Value[i];

public static A212626Inst Instance=new A212626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212627
{
public static readonly long[] Value={ 1L,2L,1L,1L,1L,1L,0L,3L,0L,3L,1L,0L,1L,1L,0L,1L,0L,3L,1L,0L,3L,1L,0L,3L,1L,0L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L,4L,1L,0L,0L,1L,0L,1L,2L,0L,0L,5L,1L,0L,0L,1L,0L,2L,1L,1L,0L,2L,1L,1L,0L,1L,4L,0L,0L,5L,0L,1L,0L,2L,0L,0L,6L,1L,0L,0L,5L,0L,0L,7L,1L,0L,0L,2L,1L,0L,2L,1L,1L,0L,0L,4L,2L,0L,1L,4L,1L,0L,0L,0L,1L,0L,0L,6L,1L,0L,2L,1L,1L,0L,1L,1L,3L,0L,0L,1L,4L,0L,1L,0L,2L,0L,1L,0L,2L,0L,0L,4L,2L,0L,2L,0L,1L,1L,0L,0L,5L,0L,0L,2L,3L,0L,0L,2L,1L,0L,1L,1L,3L,0L,0L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212627Inst : IEnumerable<long>
{
public static readonly long[] Value=A212627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212627.Bytes);
public long this[int i]=>Value[i];

public static A212627Inst Instance=new A212627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212628
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,3L,2L,2L,4L,4L,4L,3L,3L,3L,5L,2L,3L,5L,2L,4L,4L,5L,5L,3L,7L,5L,8L,3L,4L,6L,5L,2L,7L,4L,5L,5L,3L,3L,6L,4L,5L,5L,3L,5L,9L,8L,6L,3L,4L,8L,5L,5L,2L,9L,9L,3L,4L,6L,4L,6L,5L,7L,8L,2L,8L,8L,3L,4L,9L,6L,4L,5L,5L,5L,11L,3L,7L,8L,5L,4L,16L,6L,8L,5L,7L,5L,8L,5L,3L,10L,6L,8L,9L,9L,5L,3L,8L,5L,13L,8L,5L,6L,9L,5L,9L,3L,3L,9L,6L,10L,6L,3L,6L,5L,13L,6L,12L,5L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212628Inst : IEnumerable<long>
{
public static readonly long[] Value=A212628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212628.Bytes);
public long this[int i]=>Value[i];

public static A212628Inst Instance=new A212628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212629
{
public static readonly long[] Value={ 1L,2L,3L,3L,6L,6L,4L,4L,9L,9L,9L,8L,8L,8L,14L,5L,8L,15L,5L,11L,11L,14L,15L,10L,22L,15L,25L,10L,11L,20L,14L,6L,22L,11L,17L,19L,10L,10L,20L,13L,15L,18L,10L,17L,33L,25L,20L,12L,13L,28L,17L,18L,6L,36L,32L,12L,13L,20L,11L,24L,19L,22L,29L,7L,31L,31L,10L,13L,33L,24L,13L,23L,18L,19L,45L,12L,26L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212629Inst : IEnumerable<long>
{
public static readonly long[] Value=A212629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212629.Bytes);
public long this[int i]=>Value[i];

public static A212629Inst Instance=new A212629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212630
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,1L,1L,3L,1L,0L,4L,4L,1L,0L,4L,4L,1L,1L,3L,4L,1L,1L,3L,4L,1L,0L,3L,8L,5L,1L,0L,3L,8L,5L,1L,0L,3L,8L,5L,1L,0L,2L,7L,5L,1L,0L,2L,7L,5L,1L,0L,2L,7L,5L,1L,0L,1L,10L,13L,6L,1L,1L,4L,6L,5L,1L,0L,2L,7L,5L,1L,0L,0L,8L,12L,6L,1L,1L,4L,6L,5L,1L,0L,2L,8L,12L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212630Inst : IEnumerable<long>
{
public static readonly long[] Value=A212630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212630.Bytes);
public long this[int i]=>Value[i];

public static A212630Inst Instance=new A212630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212631
{
public static readonly long[] Value={ 1L,3L,5L,5L,9L,9L,9L,9L,17L,17L,17L,15L,15L,15L,31L,17L,15L,27L,17L,29L,29L,31L,27L,27L,57L,27L,53L,25L,29L,51L,31L,33L,57L,29L,53L,45L,27L,27L,51L,53L,27L,45L,25L,53L,97L,53L,51L,51L,49L,97L,53L,45L,33L,81L,105L,45L,53L,51L,29L,87L,45L,57L,89L,65L,93L,93L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212631Inst : IEnumerable<long>
{
public static readonly long[] Value=A212631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212631.Bytes);
public long this[int i]=>Value[i];

public static A212631Inst Instance=new A212631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212632
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,2L,2L,2L,2L,2L,1L,2L,3L,1L,2L,2L,2L,3L,2L,3L,3L,3L,2L,2L,3L,2L,1L,3L,2L,2L,3L,2L,2L,3L,2L,3L,3L,2L,2L,3L,3L,3L,2L,2L,3L,2L,3L,1L,4L,3L,2L,2L,3L,2L,3L,3L,3L,3L,1L,3L,3L,2L,2L,3L,3L,2L,3L,3L,3L,3L,2L,3L,4L,2L,2L,4L,3L,3L,3L,3L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212632Inst : IEnumerable<long>
{
public static readonly long[] Value=A212632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212632.Bytes);
public long this[int i]=>Value[i];

public static A212632Inst Instance=new A212632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212633
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,1L,0L,4L,4L,1L,0L,3L,8L,5L,1L,0L,1L,10L,13L,6L,1L,0L,0L,8L,22L,19L,7L,1L,0L,0L,4L,26L,40L,26L,8L,1L,0L,0L,1L,22L,61L,65L,34L,9L,1L,0L,0L,0L,13L,70L,120L,98L,43L,10L,1L,0L,0L,0L,5L,61L,171L,211L,140L,53L,11L,1L,0L,0L,0L,1L,40L,192L,356L,343L,192L,64L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212633Inst : IEnumerable<long>
{
public static readonly long[] Value=A212633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212633.Bytes);
public long this[int i]=>Value[i];

public static A212633Inst Instance=new A212633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212634
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,1L,0L,6L,4L,1L,0L,5L,10L,5L,1L,0L,3L,14L,15L,6L,1L,0L,0L,14L,28L,21L,7L,1L,0L,0L,8L,38L,48L,28L,8L,1L,0L,0L,3L,36L,81L,75L,36L,9L,1L,0L,0L,0L,25L,102L,150L,110L,45L,10L,1L,0L,0L,0L,11L,99L,231L,253L,154L,55L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212634Inst : IEnumerable<long>
{
public static readonly long[] Value=A212634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212634.Bytes);
public long this[int i]=>Value[i];

public static A212634Inst Instance=new A212634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212635
{
public static readonly long[] Value={ 4L,6L,4L,1L,1L,10L,10L,5L,1L,1L,10L,20L,15L,6L,1L,1L,9L,29L,35L,21L,7L,1L,1L,7L,35L,63L,56L,28L,8L,1L,1L,8L,36L,94L,118L,84L,36L,9L,1L,1L,9L,39L,120L,207L,201L,120L,45L,10L,1L,1L,10L,45L,145L,312L,402L,320L,165L,55L,11L,1L,1L,11L,55L,176L,429L,693L,715L,484L,220L,66L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212635Inst : IEnumerable<long>
{
public static readonly long[] Value=A212635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212635.Bytes);
public long this[int i]=>Value[i];

public static A212635Inst Instance=new A212635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212636
{
public static readonly long[] Value={ 1L,1L,3L,3L,8L,1L,1L,1L,5L,7L,19L,7L,5L,15L,7L,17L,5L,3L,9L,11L,63L,9L,5L,1L,53L,27L,51L,11L,3L,11L,13L,15L,17L,35L,1L,17L,21L,13L,139L,61L,3L,13L,1L,7L,147L,23L,123L,47L,41L,35L,11L,39L,69L,21L,123L,29L,27L,49L,3L,9L,37L,171L,57L,1L,31L,37L,5L,61L,27L,31L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212636Inst : IEnumerable<long>
{
public static readonly long[] Value=A212636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212636.Bytes);
public long this[int i]=>Value[i];

public static A212636Inst Instance=new A212636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212637
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,4L,3L,2L,6L,1L,1L,3L,1L,2L,7L,5L,11L,16L,2L,3L,2L,4L,4L,11L,6L,4L,33L,1L,12L,18L,3L,20L,5L,38L,17L,2L,1L,18L,3L,14L,26L,11L,14L,63L,3L,2L,13L,110L,44L,34L,1L,22L,44L,114L,37L,43L,39L,5L,13L,12L,57L,41L,12L,18L,13L,9L,8L,13L,52L,26L,78L,37L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212637Inst : IEnumerable<long>
{
public static readonly long[] Value=A212637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212637.Bytes);
public long this[int i]=>Value[i];

public static A212637Inst Instance=new A212637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212638
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,6L,32L,12L,64L,24L,36L,128L,48L,72L,256L,96L,144L,30L,512L,192L,216L,288L,60L,1024L,384L,432L,576L,120L,2048L,768L,864L,180L,1152L,240L,1296L,4096L,1536L,1728L,360L,2304L,480L,2592L,8192L,3072L,3456L,720L,900L,4608L,960L,5184L,1080L,16384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212638Inst : IEnumerable<long>
{
public static readonly long[] Value=A212638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212638.Bytes);
public long this[int i]=>Value[i];

public static A212638Inst Instance=new A212638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212639
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,4L,6L,5L,7L,6L,6L,8L,7L,7L,9L,8L,8L,6L,10L,9L,8L,9L,7L,11L,10L,9L,10L,8L,12L,11L,10L,8L,11L,9L,10L,13L,12L,11L,9L,12L,10L,11L,14L,13L,12L,10L,9L,13L,11L,12L,10L,15L,14L,13L,11L,8L,12L,10L,14L,12L,13L,11L,16L,15L,14L,12L,9L,13L,11L,15L,13L,14L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212639Inst : IEnumerable<long>
{
public static readonly long[] Value=A212639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212639.Bytes);
public long this[int i]=>Value[i];

public static A212639Inst Instance=new A212639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212640
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,9L,7L,12L,8L,15L,16L,9L,18L,20L,10L,21L,24L,27L,11L,24L,25L,28L,36L,12L,27L,30L,32L,45L,13L,30L,35L,48L,36L,54L,36L,14L,33L,40L,60L,40L,63L,42L,15L,36L,45L,72L,64L,44L,72L,48L,75L,16L,39L,50L,84L,81L,49L,80L,48L,81L,54L,90L,17L,42L,55L,96L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212640Inst : IEnumerable<long>
{
public static readonly long[] Value=A212640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212640.Bytes);
public long this[int i]=>Value[i];

public static A212640Inst Instance=new A212640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212641
{
public static readonly long[] Value={ 1L,3L,1L,5L,3L,9L,7L,3L,1L,15L,1L,9L,9L,5L,5L,21L,3L,27L,11L,3L,25L,7L,9L,3L,27L,15L,1L,45L,13L,15L,35L,3L,9L,27L,9L,7L,33L,5L,15L,5L,63L,21L,15L,9L,45L,9L,1L,11L,9L,3L,75L,1L,39L,25L,21L,81L,49L,5L,3L,81L,27L,45L,17L,21L,55L,3L,27L,7L,3L,13L,45L,15L,105L,9L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212641Inst : IEnumerable<long>
{
public static readonly long[] Value=A212641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212641.Bytes);
public long this[int i]=>Value[i];

public static A212641Inst Instance=new A212641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212642
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,6L,7L,9L,8L,12L,10L,9L,15L,14L,10L,18L,18L,10L,11L,21L,15L,22L,16L,12L,24L,20L,26L,22L,13L,27L,25L,19L,30L,28L,21L,14L,30L,30L,28L,34L,34L,27L,15L,33L,35L,37L,20L,38L,40L,33L,31L,16L,36L,40L,46L,15L,28L,30L,42L,46L,39L,43L,17L,39L,45L,55L,25L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212642Inst : IEnumerable<long>
{
public static readonly long[] Value=A212642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212642.Bytes);
public long this[int i]=>Value[i];

public static A212642Inst Instance=new A212642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212643
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,0L,1L,4L,1L,5L,4L,1L,6L,5L,1L,7L,6L,2L,1L,8L,5L,7L,2L,1L,9L,6L,8L,2L,1L,10L,7L,1L,9L,2L,6L,1L,11L,8L,0L,10L,2L,7L,1L,12L,9L,18L,0L,11L,2L,8L,15L,1L,13L,10L,22L,0L,7L,14L,12L,2L,9L,20L,1L,14L,11L,26L,7L,8L,18L,13L,2L,10L,25L,1L,15L,15L,12L,30L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212643Inst : IEnumerable<long>
{
public static readonly long[] Value=A212643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212643.Bytes);
public long this[int i]=>Value[i];

public static A212643Inst Instance=new A212643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212644
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,3L,6L,5L,7L,7L,6L,8L,9L,9L,9L,11L,12L,4L,10L,13L,10L,15L,7L,11L,15L,14L,18L,10L,12L,17L,18L,9L,21L,13L,15L,13L,19L,22L,14L,24L,14L,18L,10L,12L,17L,18L,9L,21L,13L,15L,13L,19L,22L,14L,24L,16L,20L,14L,21L,26L,19L,10L,27L,19L,25L,16L,15L,23L,30L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212644Inst : IEnumerable<long>
{
public static readonly long[] Value=A212644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212644.Bytes);
public long this[int i]=>Value[i];

public static A212644Inst Instance=new A212644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212645
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,2L,5L,3L,6L,4L,4L,7L,5L,5L,8L,6L,6L,3L,9L,7L,6L,7L,4L,10L,8L,7L,8L,5L,11L,9L,8L,5L,9L,6L,8L,12L,10L,9L,6L,10L,7L,9L,13L,11L,10L,7L,6L,11L,8L,10L,7L,14L,12L,11L,8L,4L,10L,7L,12L,9L,11L,8L,15L,13L,12L,9L,5L,11L,8L,13L,10L,12L,9L,16L,14L,8L,13L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212645Inst : IEnumerable<long>
{
public static readonly long[] Value=A212645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212645.Bytes);
public long this[int i]=>Value[i];

public static A212645Inst Instance=new A212645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212646
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,4L,11L,6L,15L,10L,9L,22L,14L,15L,30L,22L,21L,8L,42L,30L,25L,33L,12L,56L,44L,35L,45L,20L,77L,60L,55L,18L,66L,28L,49L,101L,84L,75L,30L,90L,44L,77L,135L,112L,110L,42L,27L,126L,60L,105L,50L,176L,154L,150L,66L,16L,121L,45L,168L,88L,154L,70L,231L,202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212646Inst : IEnumerable<long>
{
public static readonly long[] Value=A212646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212646.Bytes);
public long this[int i]=>Value[i];

public static A212646Inst Instance=new A212646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212647
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,4L,6L,6L,7L,8L,9L,8L,10L,12L,9L,12L,15L,8L,10L,14L,16L,18L,12L,11L,16L,20L,21L,16L,12L,18L,24L,18L,24L,20L,25L,13L,20L,28L,24L,27L,24L,30L,14L,22L,32L,30L,27L,30L,28L,35L,32L,15L,24L,36L,36L,16L,36L,36L,33L,32L,40L,40L,16L,26L,40L,42L,24L,42L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212647Inst : IEnumerable<long>
{
public static readonly long[] Value=A212647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212647.Bytes);
public long this[int i]=>Value[i];

public static A212647Inst Instance=new A212647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212648
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,1L,1L,1L,6L,9L,2L,6L,6L,8L,16L,2L,15L,6L,3L,3L,5L,7L,26L,1L,8L,16L,18L,7L,14L,12L,9L,5L,14L,8L,1L,32L,7L,2L,2L,3L,53L,8L,1L,3L,10L,10L,20L,8L,25L,20L,2L,23L,7L,13L,21L,87L,16L,76L,35L,30L,18L,12L,7L,1L,117L,36L,40L,57L,25L,3L,5L,47L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212648Inst : IEnumerable<long>
{
public static readonly long[] Value=A212648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212648.Bytes);
public long this[int i]=>Value[i];

public static A212648Inst Instance=new A212648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212649
{
public static readonly long[] Value={ 1L,3L,8L,13L,21L,30L,41L,53L,67L,82L,99L,118L,138L,159L,183L,207L,234L,262L,291L,322L,355L,389L,425L,462L,501L,542L,584L,628L,673L,720L,768L,818L,870L,923L,977L,1034L,1091L,1151L,1212L,1274L,1338L,1404L,1471L,1540L,1610L,1682L,1756L,1831L,1908L,1986L,2066L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212649Inst : IEnumerable<long>
{
public static readonly long[] Value=A212649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212649.Bytes);
public long this[int i]=>Value[i];

public static A212649Inst Instance=new A212649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212650
{
public static readonly BigInteger[] Value={ 0L,0L,0L,3L,6L,25L,180L,1281L,10010L,90063L,902790L,9929755L,119134224L,1548768585L,21683033372L,325245031125L,5203916869710L,88466595897631L,1592398778725710L,30255576613653483L,605111531456405960L,12707342164389159945UL,BigInteger.Parse("279561527629906821684") };
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
public class A212650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212650Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A212650.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A212650.Bytes);
public BigInteger this[int i]=>Value[i];

public static A212650Inst Instance=new A212650Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212651
{
public static readonly long[] Value={ 3L,49L,242L,48L,1444L,2645L,4374L,6727L,288L,13689L,18490L,24299L,31212L,39325L,48734L,960L,71824L,85697L,101250L,118579L,137780L,158949L,182182L,207575L,2400L,265225L,297674L,332667L,370300L,410669L,453870L,499999L,549152L,601425L,656914L,5040L,777924L,843637L,912950L,985959L,1062760L,1143449L,1228122L,1316875L,1409804L,1507005L,1608574L,1714607L,675L,1681L,2060450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212651Inst : IEnumerable<long>
{
public static readonly long[] Value=A212651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212651.Bytes);
public long this[int i]=>Value[i];

public static A212651Inst Instance=new A212651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212652
{
public static readonly long[] Value={ 1L,2L,2L,4L,3L,3L,4L,8L,4L,4L,6L,5L,7L,5L,5L,16L,9L,6L,10L,6L,6L,7L,12L,9L,7L,8L,7L,7L,15L,8L,16L,32L,8L,10L,8L,8L,19L,11L,9L,10L,21L,9L,22L,9L,9L,13L,24L,17L,10L,12L,11L,10L,27L,10L,10L,11L,12L,16L,30L,11L,31L,17L,11L,64L,11L,11L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212652Inst : IEnumerable<long>
{
public static readonly long[] Value=A212652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212652.Bytes);
public long this[int i]=>Value[i];

public static A212652Inst Instance=new A212652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212653
{
public static readonly long[] Value={ 1L,2L,6L,18L,110L,21L,95L,32L,75L,74L,42L,134L,133L,132L,131L,143L,204L,128L,189L,139L,94L,93L,260L,427L,90L,257L,393L,330L,254L,253L,389L,388L,387L,461L,460L,459L,458L,457L,456L,455L,454L,453L,452L,500L,499L,449L,497L,496L,751L,494L,493L,492L,747L,490L,745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212653Inst : IEnumerable<long>
{
public static readonly long[] Value=A212653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212653.Bytes);
public long this[int i]=>Value[i];

public static A212653Inst Instance=new A212653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212654
{
public static readonly long[] Value={ 1L,2L,4L,6L,12L,24L,60L,120L,360L,720L,3600L,5040L,25200L,55440L,277200L,720720L,3603600L,10810800L,21621600L,122522400L,367567200L,2327925600L,6983776800L,48886437600L,97772875200L,293318625600L,3226504881600L,6746328388800L,74209612276800L,195643523275200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212654Inst : IEnumerable<long>
{
public static readonly long[] Value=A212654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212654.Bytes);
public long this[int i]=>Value[i];

public static A212654Inst Instance=new A212654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212655
{
public static readonly long[] Value={ 1L,4L,112L,64L,2816L,93184L,4096L,278528L,8716288L,2883584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212655Inst : IEnumerable<long>
{
public static readonly long[] Value=A212655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212655.Bytes);
public long this[int i]=>Value[i];

public static A212655Inst Instance=new A212655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212656
{
public static readonly long[] Value={ 1L,6L,21L,46L,81L,126L,181L,246L,321L,406L,501L,606L,721L,846L,981L,1126L,1281L,1446L,1621L,1806L,2001L,2206L,2421L,2646L,2881L,3126L,3381L,3646L,3921L,4206L,4501L,4806L,5121L,5446L,5781L,6126L,6481L,6846L,7221L,7606L,8001L,8406L,8821L,9246L,9681L,10126L,10581L,11046L,11521L,12006L,12501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212656Inst : IEnumerable<long>
{
public static readonly long[] Value=A212656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212656.Bytes);
public long this[int i]=>Value[i];

public static A212656Inst Instance=new A212656Inst();

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