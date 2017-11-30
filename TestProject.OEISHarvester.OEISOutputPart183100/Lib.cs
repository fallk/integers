using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A213557
{
public static readonly long[] Value={ 1L,6L,23L,70L,184L,438L,971L,2042L,4125L,8076L,15424L,28876L,53189L,96670L,173747L,309362L,546456L,958690L,1672015L,2901170L,5011321L,8621976L,14781888L,25263000L,43053769L,73186038L,124119311L,210055582L,354806200L,598245006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213557Inst : IEnumerable<long>
{
public static readonly long[] Value=A213557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213557.Bytes);
public long this[int i]=>Value[i];

public static A213557Inst Instance=new A213557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213558
{
public static readonly long[] Value={ 1L,16L,8L,118L,91L,27L,560L,496L,280L,64L,2003L,1878L,1366L,637L,125L,5888L,5672L,4672L,2944L,1216L,216L,14988L,14645L,12917L,9542L,5446L,2071L,343L,34176L,33664L,30920L,25088L,17088L,9088L,3256L,512L,71445L,70716L,66620L,57359L,43535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213558Inst : IEnumerable<long>
{
public static readonly long[] Value=A213558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213558.Bytes);
public long this[int i]=>Value[i];

public static A213558Inst Instance=new A213558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213559
{
public static readonly long[] Value={ 1L,91L,1366L,9542L,43535L,151313L,435324L,1089804L,2452269L,5071495L,9794290L,17873362L,31098587L,51953981L,83802680L,131102232L,199652505L,296878515L,432150478L,617143390L,866238439L,1196968553L,1630510388L,2192225060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213559Inst : IEnumerable<long>
{
public static readonly long[] Value=A213559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213559.Bytes);
public long this[int i]=>Value[i];

public static A213559Inst Instance=new A213559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213560
{
public static readonly long[] Value={ 1L,24L,236L,1400L,6009L,20608L,59952L,153792L,357225L,765688L,1535820L,2913560L,5270993L,9153600L,15339712L,24914112L,39357873L,60656664L,91429900L,135083256L,195987209L,279684416L,393128880L,544960000L,745814745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213560Inst : IEnumerable<long>
{
public static readonly long[] Value=A213560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213560.Bytes);
public long this[int i]=>Value[i];

public static A213560Inst Instance=new A213560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213561
{
public static readonly long[] Value={ 1L,7L,3L,27L,18L,6L,77L,61L,34L,10L,182L,157L,109L,55L,15L,378L,342L,267L,171L,81L,21L,714L,665L,557L,407L,247L,112L,28L,1254L,1190L,1043L,827L,577L,337L,148L,36L,2079L,1998L,1806L,1512L,1152L,777L,441L,189L,45L,3289L,3189L,2946L,2562L,2072L,1532L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213561Inst : IEnumerable<long>
{
public static readonly long[] Value=A213561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213561.Bytes);
public long this[int i]=>Value[i];

public static A213561Inst Instance=new A213561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213562
{
public static readonly long[] Value={ 1L,18L,109L,407L,1152L,2723L,5670L,10746L,18939L,31504L,49995L,76297L,112658L,161721L,226556L,310692L,418149L,553470L,721753L,928683L,1180564L,1484351L,1847682L,2278910L,2787135L,3382236L,4074903L,4876669L,5799942L,6858037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213562Inst : IEnumerable<long>
{
public static readonly long[] Value=A213562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213562.Bytes);
public long this[int i]=>Value[i];

public static A213562Inst Instance=new A213562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213563
{
public static readonly long[] Value={ 1L,10L,51L,182L,518L,1260L,2730L,5412L,9999L,17446L,29029L,46410L,71708L,107576L,157284L,224808L,314925L,433314L,586663L,782782L,1030722L,1340900L,1725230L,2197260L,2772315L,3467646L,4302585L,5298706L,6479992L,7873008L,9507080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213563Inst : IEnumerable<long>
{
public static readonly long[] Value=A213563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213563.Bytes);
public long this[int i]=>Value[i];

public static A213563Inst Instance=new A213563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213564
{
public static readonly long[] Value={ 1L,7L,4L,27L,21L,9L,77L,67L,43L,16L,182L,167L,127L,73L,25L,378L,357L,297L,207L,111L,36L,714L,686L,602L,467L,307L,157L,49L,1254L,1218L,1106L,917L,677L,427L,211L,64L,2079L,2034L,1890L,1638L,1302L,927L,567L,273L,81L,3289L,3234L,3054L,2730L,2282L,1757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213564Inst : IEnumerable<long>
{
public static readonly long[] Value=A213564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213564.Bytes);
public long this[int i]=>Value[i];

public static A213564Inst Instance=new A213564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213565
{
public static readonly long[] Value={ 1L,21L,127L,467L,1302L,3038L,6258L,11754L,20559L,33979L,53625L,81445L,119756L,171276L,239156L,327012L,438957L,579633L,754243L,968583L,1229074L,1542794L,1917510L,2361710L,2884635L,3496311L,4207581L,5030137L,5976552L,7060312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213565Inst : IEnumerable<long>
{
public static readonly long[] Value=A213565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213565.Bytes);
public long this[int i]=>Value[i];

public static A213565Inst Instance=new A213565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213566
{
public static readonly long[] Value={ 1L,5L,4L,15L,13L,9L,36L,33L,25L,16L,76L,71L,59L,41L,25L,148L,140L,120L,93L,61L,36L,273L,260L,228L,183L,135L,85L,49L,485L,464L,412L,340L,260L,185L,113L,64L,839L,805L,721L,604L,476L,351L,243L,145L,81L,1424L,1369L,1233L,1044L,836L,636L,456L,309L,181L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213566Inst : IEnumerable<long>
{
public static readonly long[] Value=A213566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213566.Bytes);
public long this[int i]=>Value[i];

public static A213566Inst Instance=new A213566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213567
{
public static readonly long[] Value={ 1L,13L,59L,183L,476L,1108L,2409L,4993L,10007L,19559L,37504L,70832L,132145L,244029L,446763L,811847L,1465676L,2630836L,4697945L,8350305L,14779671L,26058903L,45784224L,80179968L,139995361L,243755533L,423324539L,733409943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213567Inst : IEnumerable<long>
{
public static readonly long[] Value=A213567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213567.Bytes);
public long this[int i]=>Value[i];

public static A213567Inst Instance=new A213567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213568
{
public static readonly long[] Value={ 1L,4L,2L,11L,7L,3L,26L,18L,10L,4L,57L,41L,25L,13L,5L,120L,88L,56L,32L,16L,6L,247L,183L,119L,71L,39L,19L,7L,502L,374L,246L,150L,86L,46L,22L,8L,1013L,757L,501L,309L,181L,101L,53L,25L,9L,2036L,1524L,1012L,628L,372L,212L,116L,60L,28L,10L,4083L,3059L,2035L,1267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213568Inst : IEnumerable<long>
{
public static readonly long[] Value=A213568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213568.Bytes);
public long this[int i]=>Value[i];

public static A213568Inst Instance=new A213568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213569
{
public static readonly long[] Value={ 1L,7L,25L,71L,181L,435L,1009L,2287L,5101L,11243L,24553L,53223L,114661L,245731L,524257L,1114079L,2359261L,4980699L,10485721L,22020055L,46137301L,96468947L,201326545L,419430351L,872415181L,1811939275L,3758096329L,7784628167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213569Inst : IEnumerable<long>
{
public static readonly long[] Value=A213569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213569.Bytes);
public long this[int i]=>Value[i];

public static A213569Inst Instance=new A213569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213570
{
public static readonly long[] Value={ 1L,9L,37L,110L,272L,598L,1213L,2323L,4265L,7588L,13184L,22500L,37881L,63125L,104381L,171602L,280896L,458330L,746085L,1212415L,1967761L,3190824L,5170752L,8375400L,13561777L,21954753L,35536213L,57512918L,93073520L,150613438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213570Inst : IEnumerable<long>
{
public static readonly long[] Value=A213570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213570.Bytes);
public long this[int i]=>Value[i];

public static A213570Inst Instance=new A213570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213571
{
public static readonly long[] Value={ 1L,5L,3L,16L,13L,7L,42L,38L,29L,15L,99L,94L,82L,61L,31L,219L,213L,198L,170L,125L,63L,466L,459L,441L,406L,346L,253L,127L,968L,960L,939L,897L,822L,698L,509L,255L,1981L,1972L,1948L,1899L,1809L,1654L,1402L,1021L,511L,4017L,4007L,3980L,3924L,3819L,3633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213571Inst : IEnumerable<long>
{
public static readonly long[] Value=A213571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213571.Bytes);
public long this[int i]=>Value[i];

public static A213571Inst Instance=new A213571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213572
{
public static readonly long[] Value={ 1L,13L,82L,406L,1809L,7659L,31588L,128476L,518611L,2084809L,8361918L,33497010L,134094757L,536608663L,2146926472L,8588754808L,34357247847L,137433710421L,549744803650L,2199000186670L,8796044787481L,35184271425283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213572Inst : IEnumerable<long>
{
public static readonly long[] Value=A213572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213572.Bytes);
public long this[int i]=>Value[i];

public static A213572Inst Instance=new A213572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213573
{
public static readonly long[] Value={ 1L,6L,4L,21L,17L,9L,58L,50L,34L,16L,141L,125L,93L,57L,25L,318L,286L,222L,150L,86L,36L,685L,621L,493L,349L,221L,121L,49L,1434L,1306L,1050L,762L,506L,306L,162L,64L,2949L,2693L,2181L,1605L,1093L,693L,405L,209L,81L,5998L,5486L,4462L,3310L,2286L,1486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213573Inst : IEnumerable<long>
{
public static readonly long[] Value=A213573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213573.Bytes);
public long this[int i]=>Value[i];

public static A213573Inst Instance=new A213573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213574
{
public static readonly long[] Value={ 1L,17L,93L,349L,1093L,3093L,8221L,20957L,51861L,125509L,298477L,699789L,1621285L,3718325L,8453181L,19069885L,42728245L,95156901L,210762253L,464517485L,1019214021L,2227173397L,4848613213L,10519312029L,22749902293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213574Inst : IEnumerable<long>
{
public static readonly long[] Value=A213574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213574.Bytes);
public long this[int i]=>Value[i];

public static A213574Inst Instance=new A213574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213575
{
public static readonly long[] Value={ 1L,10L,47L,158L,441L,1098L,2539L,5590L,11909L,24818L,50967L,103662L,209521L,421786L,846947L,1697990L,3400893L,6807618L,13622095L,27252190L,54513641L,109037930L,218088027L,436189878L,872395381L,1744808338L,3489636359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213575Inst : IEnumerable<long>
{
public static readonly long[] Value=A213575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213575.Bytes);
public long this[int i]=>Value[i];

public static A213575Inst Instance=new A213575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213576
{
public static readonly long[] Value={ 1L,3L,1L,7L,4L,2L,14L,10L,7L,3L,26L,21L,17L,11L,5L,46L,40L,35L,27L,18L,8L,79L,72L,66L,56L,44L,29L,13L,133L,125L,118L,106L,91L,71L,47L,21L,221L,212L,204L,190L,172L,147L,115L,76L,34L,364L,354L,345L,329L,308L,278L,238L,186L,123L,55L,596L,585L,575L,557L,533L,498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213576Inst : IEnumerable<long>
{
public static readonly long[] Value=A213576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213576.Bytes);
public long this[int i]=>Value[i];

public static A213576Inst Instance=new A213576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213577
{
public static readonly long[] Value={ 1L,4L,17L,56L,172L,498L,1395L,3820L,10307L,27534L,73064L,193012L,508341L,1336132L,3507189L,9197732L,24107124L,63159782L,165433895L,433246860L,1134484871L,2970509594L,7777554192L,20363014056L,53312938537L,139578241348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213577Inst : IEnumerable<long>
{
public static readonly long[] Value=A213577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213577.Bytes);
public long this[int i]=>Value[i];

public static A213577Inst Instance=new A213577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213578
{
public static readonly long[] Value={ 1L,4L,13L,34L,80L,174L,359L,712L,1371L,2580L,4768L,8684L,15629L,27852L,49225L,86390L,150704L,261530L,451795L,777360L,1332791L,2277864L,3882048L,6599064L,11191705L,18940564L,31992709L,53943562L,90807056L,152631750L,256190783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213578Inst : IEnumerable<long>
{
public static readonly long[] Value=A213578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213578.Bytes);
public long this[int i]=>Value[i];

public static A213578Inst Instance=new A213578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213579
{
public static readonly long[] Value={ 1L,3L,2L,7L,5L,3L,14L,11L,7L,4L,26L,21L,15L,9L,5L,46L,38L,28L,19L,11L,6L,79L,66L,50L,35L,23L,13L,7L,133L,112L,86L,62L,42L,27L,15L,8L,221L,187L,145L,106L,74L,49L,31L,17L,9L,364L,309L,241L,178L,126L,86L,56L,35L,19L,10L,596L,507L,397L,295L,211L,146L,98L,63L,39L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213579Inst : IEnumerable<long>
{
public static readonly long[] Value=A213579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213579.Bytes);
public long this[int i]=>Value[i];

public static A213579Inst Instance=new A213579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213580
{
public static readonly long[] Value={ 1L,5L,15L,35L,74L,146L,277L,511L,925L,1651L,2916L,5108L,8889L,15385L,26507L,45491L,77806L,132678L,225645L,382835L,648121L,1095075L,1846920L,3109800L,5228209L,8777261L,14716167L,24643331L,41220050L,68873786L,114964741L,191719783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213580Inst : IEnumerable<long>
{
public static readonly long[] Value=A213580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213580.Bytes);
public long this[int i]=>Value[i];

public static A213580Inst Instance=new A213580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213581
{
public static readonly long[] Value={ 1L,8L,36L,124L,367L,988L,2498L,6048L,14197L,32576L,73472L,163508L,360027L,785908L,1703294L,3669240L,7863393L,16776120L,35650300L,75495980L,159381831L,335542348L,704640826L,1476392464L,3087004877L,6442447728L,13421769208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213581Inst : IEnumerable<long>
{
public static readonly long[] Value=A213581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213581.Bytes);
public long this[int i]=>Value[i];

public static A213581Inst Instance=new A213581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213582
{
public static readonly long[] Value={ 1L,5L,2L,16L,9L,3L,42L,27L,13L,4L,99L,68L,38L,17L,5L,219L,156L,94L,49L,21L,6L,466L,339L,213L,120L,60L,25L,7L,968L,713L,459L,270L,146L,71L,29L,8L,1981L,1470L,960L,579L,327L,172L,82L,33L,9L,4017L,2994L,1972L,1207L,699L,384L,198L,93L,37L,10L,8100L,6053L,4007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213582Inst : IEnumerable<long>
{
public static readonly long[] Value=A213582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213582.Bytes);
public long this[int i]=>Value[i];

public static A213582Inst Instance=new A213582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213583
{
public static readonly long[] Value={ 1L,9L,38L,120L,327L,819L,1948L,4482L,10085L,22341L,48930L,106236L,229075L,491175L,1048184L,2227782L,4718097L,9960921L,20970910L,44039520L,92273951L,192937179L,402652308L,838859850L,1744829437L,3623877549L,7516191578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213583Inst : IEnumerable<long>
{
public static readonly long[] Value=A213583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213583.Bytes);
public long this[int i]=>Value[i];

public static A213583Inst Instance=new A213583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213584
{
public static readonly long[] Value={ 1L,4L,2L,10L,7L,3L,21L,16L,10L,4L,40L,32L,22L,13L,5L,72L,59L,43L,28L,16L,6L,125L,104L,78L,54L,34L,19L,7L,212L,178L,136L,97L,65L,40L,22L,8L,354L,299L,231L,168L,116L,76L,46L,25L,9L,585L,496L,386L,284L,200L,135L,87L,52L,28L,10L,960L,816L,638L,473L,337L,232L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213584Inst : IEnumerable<long>
{
public static readonly long[] Value=A213584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213584.Bytes);
public long this[int i]=>Value[i];

public static A213584Inst Instance=new A213584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213585
{
public static readonly long[] Value={ 1L,7L,22L,54L,116L,232L,443L,821L,1490L,2664L,4710L,8256L,14373L,24883L,42878L,73594L,125880L,214664L,365087L,619425L,1048666L,1771852L,2988362L,5031744L,8459401L,14201887L,23811238L,39873726L,66695420L,111440104L,186016835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213585Inst : IEnumerable<long>
{
public static readonly long[] Value=A213585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213585.Bytes);
public long this[int i]=>Value[i];

public static A213585Inst Instance=new A213585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213586
{
public static readonly long[] Value={ 1L,6L,20L,51L,112L,224L,421L,758L,1324L,2263L,3808L,6336L,10457L,17158L,28036L,45675L,74256L,120544L,195485L,316790L,513116L,830831L,1344960L,2176896L,3523057L,5701254L,9225716L,14928483L,24155824L,39086048L,63243733L,102331766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213586Inst : IEnumerable<long>
{
public static readonly long[] Value=A213586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213586.Bytes);
public long this[int i]=>Value[i];

public static A213586Inst Instance=new A213586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213587
{
public static readonly long[] Value={ 1L,4L,2L,10L,7L,3L,22L,17L,11L,5L,45L,37L,27L,18L,8L,88L,75L,59L,44L,29L,13L,167L,146L,120L,96L,71L,47L,21L,310L,276L,234L,195L,155L,115L,76L,34L,566L,511L,443L,380L,315L,251L,186L,123L,55L,1020L,931L,821L,719L,614L,510L,406L,301L,199L,89L,1819L,1675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213587Inst : IEnumerable<long>
{
public static readonly long[] Value=A213587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213587.Bytes);
public long this[int i]=>Value[i];

public static A213587Inst Instance=new A213587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213588
{
public static readonly long[] Value={ 1L,7L,27L,96L,315L,994L,3043L,9123L,26909L,78370L,225911L,645732L,1832677L,5170111L,14509695L,40537284L,112805043L,312808198L,864707719L,2383649115L,6554153921L,17980221382L,49222822127L,134495771976L,366850762825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213588Inst : IEnumerable<long>
{
public static readonly long[] Value=A213588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213588.Bytes);
public long this[int i]=>Value[i];

public static A213588Inst Instance=new A213588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213589
{
public static readonly long[] Value={ 1L,6L,20L,55L,135L,308L,668L,1395L,2830L,5610L,10914L,20904L,39515L,73860L,136720L,250937L,457137L,827260L,1488190L,2662905L,4741946L,8407236L,14846100L,26120400L,45801925L,80064018L,139553708L,242597035L,420678315L,727792580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213589Inst : IEnumerable<long>
{
public static readonly long[] Value=A213589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213589.Bytes);
public long this[int i]=>Value[i];

public static A213589Inst Instance=new A213589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213590
{
public static readonly long[] Value={ 1L,5L,1L,15L,6L,2L,36L,20L,11L,3L,76L,51L,35L,17L,5L,148L,112L,87L,55L,28L,8L,273L,224L,188L,138L,90L,45L,13L,485L,421L,372L,300L,225L,145L,73L,21L,839L,758L,694L,596L,488L,363L,235L,118L,34L,1424L,1324L,1243L,1115L,968L,788L,588L,380L,191L,55L,2384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213590Inst : IEnumerable<long>
{
public static readonly long[] Value=A213590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213590.Bytes);
public long this[int i]=>Value[i];

public static A213590Inst Instance=new A213590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213591
{
public static readonly BigInteger[] Value={ 1L,1L,4L,24L,178L,1512L,14152L,142705L,1528212L,17211564L,202460400L,2474708496L,31310415376L,408815254832L,5495451727376L,75907303147652L,1075685334980240L,15618612118252960L,232102241507321384L,3526880759915999016L,BigInteger.Parse("54755450619399484512"),BigInteger.Parse("867928449982022915984") };
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
public class A213591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213591Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213591.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213591.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213591Inst Instance=new A213591Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213592
{
public static readonly long[] Value={ 1L,1L,4L,2L,6L,1L,6L,2L,7L,4L,8L,4L,10L,2L,10L,0L,9L,6L,12L,6L,10L,1L,14L,4L,16L,6L,8L,8L,12L,2L,12L,0L,20L,7L,20L,6L,10L,4L,20L,6L,11L,8L,16L,8L,20L,4L,14L,0L,20L,10L,12L,8L,26L,2L,22L,6L,15L,10L,20L,12L,18L,0L,28L,0L,20L,9L,20L,14L,16L,6L,10L,6L,24L,12L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213592Inst : IEnumerable<long>
{
public static readonly long[] Value=A213592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213592.Bytes);
public long this[int i]=>Value[i];

public static A213592Inst Instance=new A213592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213593
{
public static readonly long[] Value={ 2L,1L,2L,-3L,10L,-45L,250L,-1645L,12490L,-107415L,1031690L,-10943955L,127058690L,-1602400085L,21812913650L,-318763741725L,4977247397650L,-82695799908975L,1456703469048850L,-27117356172328675L,531930264143933050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213593Inst : IEnumerable<long>
{
public static readonly long[] Value=A213593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213593.Bytes);
public long this[int i]=>Value[i];

public static A213593Inst Instance=new A213593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213594
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,3L,5L,4L,4L,4L,7L,5L,6L,7L,5L,7L,8L,7L,9L,8L,11L,11L,8L,7L,9L,11L,8L,13L,12L,11L,12L,11L,12L,12L,14L,13L,15L,15L,11L,13L,14L,18L,15L,15L,15L,14L,17L,14L,17L,18L,18L,20L,17L,19L,19L,19L,18L,19L,21L,19L,19L,21L,20L,22L,18L,21L,24L,22L,26L,24L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213594Inst : IEnumerable<long>
{
public static readonly long[] Value=A213594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213594.Bytes);
public long this[int i]=>Value[i];

public static A213594Inst Instance=new A213594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213595
{
public static readonly long[] Value={ 1L,1L,3L,1L,9L,3L,1L,3L,3L,3L,1L,3L,3L,3L,15L,3L,3L,9L,3L,9L,1L,1L,15L,27L,9L,3L,15L,1L,5L,5L,3L,9L,9L,9L,3L,3L,1L,3L,45L,9L,15L,1L,15L,15L,15L,45L,9L,81L,9L,5L,5L,1L,25L,5L,3L,3L,5L,5L,3L,15L,27L,9L,21L,3L,81L,9L,3L,15L,1L,3L,75L,81L,9L,9L,135L,27L,25L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213595Inst : IEnumerable<long>
{
public static readonly long[] Value=A213595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213595.Bytes);
public long this[int i]=>Value[i];

public static A213595Inst Instance=new A213595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213596
{
public static readonly long[] Value={ 1L,4L,36L,450L,5172L,75204L,1353240L,27948312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213596Inst : IEnumerable<long>
{
public static readonly long[] Value=A213596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213596.Bytes);
public long this[int i]=>Value[i];

public static A213596Inst Instance=new A213596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213597
{
public static readonly long[] Value={ 1L,0L,1L,-1L,0L,1L,-2L,1L,0L,1L,-5L,10L,-9L,3L,0L,1L,-9L,36L,-79L,98L,-64L,17L,0L,1L,-17L,136L,-666L,2192L,-5032L,8111L,-9013L,6569L,-2818L,537L,0L,1L,-28L,378L,-3242L,19648L,-88676L,306308L,-819933L,1703404L,-2723374L,3285552L,-2887734L,1739326L,-639065L,107435L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213597Inst : IEnumerable<long>
{
public static readonly long[] Value=A213597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213597.Bytes);
public long this[int i]=>Value[i];

public static A213597Inst Instance=new A213597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213598
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,15L,22L,30L,42L,56L,77L,101L,135L,176L,231L,297L,385L,490L,627L,792L,1002L,1255L,1575L,1958L,2436L,3010L,3718L,4565L,5604L,6842L,8349L,10143L,12310L,14883L,17977L,21637L,26015L,31185L,37338L,44583L,53174L,63261L,75175L,89134L,105558L,124754L,147273L,173524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213598Inst : IEnumerable<long>
{
public static readonly long[] Value=A213598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213598.Bytes);
public long this[int i]=>Value[i];

public static A213598Inst Instance=new A213598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213599
{
public static readonly long[] Value={ 1L,3L,25L,549L,30535L,4168935L,1362083785L,1042729407045L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213599Inst : IEnumerable<long>
{
public static readonly long[] Value=A213599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213599.Bytes);
public long this[int i]=>Value[i];

public static A213599Inst Instance=new A213599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213600
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,4L,0L,1L,4L,0L,9L,0L,1L,0L,25L,0L,16L,0L,1L,25L,0L,81L,0L,25L,0L,1L,0L,196L,0L,196L,0L,36L,0L,1L,196L,0L,784L,0L,400L,0L,49L,0L,1L,0L,1764L,0L,2304L,0L,729L,0L,64L,0L,1L,1764L,0L,8100L,0L,5625L,0L,1225L,0L,81L,0L,1L,0L,17424L,0L,27225L,0L,12100L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213600Inst : IEnumerable<long>
{
public static readonly long[] Value=A213600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213600.Bytes);
public long this[int i]=>Value[i];

public static A213600Inst Instance=new A213600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213601
{
public static readonly long[] Value={ 1418575498567L,27899359257997L,34460918582317L,76075560855367L,186460616596327L,218021188549237L,234280497145537L,282854319391717L,345120905374087L,346117552180627L,604439135284057L,727417501795057L,1041814617748747L,1090754719898917L,1539765965257747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213601Inst : IEnumerable<long>
{
public static readonly long[] Value=A213601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213601.Bytes);
public long this[int i]=>Value[i];

public static A213601Inst Instance=new A213601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213602
{
public static readonly long[] Value={ 0L,1L,3L,19L,11L,17L,37L,17L,3L,173L,36L,44L,318L,18L,37L,129L,66L,226L,384L,144L,46L,1074L,99L,109L,287L,523L,95L,929L,671L,145L,293L,105L,53L,2893L,103L,183L,3505L,1241L,329L,209L,1473L,1555L,2459L,863L,121L,5719L,250L,262L,6584L,2296L,1200L,3760L,872L,248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213602Inst : IEnumerable<long>
{
public static readonly long[] Value=A213602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213602.Bytes);
public long this[int i]=>Value[i];

public static A213602Inst Instance=new A213602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213603
{
public static readonly long[] Value={ 1L,1L,2L,10L,5L,7L,14L,6L,1L,55L,11L,13L,91L,5L,10L,34L,17L,57L,95L,35L,11L,253L,23L,25L,65L,117L,21L,203L,145L,31L,62L,22L,11L,595L,21L,37L,703L,247L,65L,41L,287L,301L,473L,165L,23L,1081L,47L,49L,1225L,425L,221L,689L,159L,45L,385L,133L,551L,1711L,295L,305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213603Inst : IEnumerable<long>
{
public static readonly long[] Value=A213603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213603.Bytes);
public long this[int i]=>Value[i];

public static A213603Inst Instance=new A213603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213604
{
public static readonly long[] Value={ 1L,7L,14L,18L,24L,28L,35L,41L,42L,48L,55L,59L,65L,69L,76L,82L,83L,89L,96L,100L,106L,110L,117L,123L,124L,130L,137L,141L,147L,151L,158L,164L,165L,171L,178L,182L,188L,192L,199L,205L,206L,212L,219L,223L,229L,233L,240L,246L,247L,253L,260L,264L,270L,274L,281L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213604Inst : IEnumerable<long>
{
public static readonly long[] Value=A213604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213604.Bytes);
public long this[int i]=>Value[i];

public static A213604Inst Instance=new A213604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213605
{
public static readonly long[] Value={ 403L,1003L,110203L,118003L,418307L,429491L,439097L,559003L,1239869L,1887239L,2481463L,2502977L,3381403L,3693419L,5646257L,6120403L,6586003L,6954767L,7042661L,8350003L,11305093L,13083403L,13760203L,17297519L,21159419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213605Inst : IEnumerable<long>
{
public static readonly long[] Value=A213605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213605.Bytes);
public long this[int i]=>Value[i];

public static A213605Inst Instance=new A213605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213606
{
public static readonly long[] Value={ 407L,1007L,110207L,118007L,418309L,429493L,439099L,559007L,1239871L,1887241L,2481467L,2502979L,3381407L,3693421L,5646259L,6120407L,6586007L,6954769L,7042663L,8350007L,11305097L,13083407L,13760207L,17297521L,21159421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213606Inst : IEnumerable<long>
{
public static readonly long[] Value=A213606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213606.Bytes);
public long this[int i]=>Value[i];

public static A213606Inst Instance=new A213606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213607
{
public static readonly long[] Value={ 1L,1L,2L,0L,3L,2L,4L,0L,3L,3L,4L,0L,4L,3L,6L,0L,7L,3L,4L,0L,6L,5L,4L,0L,7L,4L,8L,0L,7L,5L,8L,0L,5L,4L,10L,0L,8L,5L,6L,0L,7L,7L,8L,0L,11L,5L,10L,0L,9L,8L,8L,0L,5L,4L,12L,0L,14L,5L,8L,0L,10L,8L,8L,0L,11L,8L,10L,0L,10L,9L,14L,0L,10L,5L,10L,0L,15L,7L,6L,0L,10L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213607Inst : IEnumerable<long>
{
public static readonly long[] Value=A213607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213607.Bytes);
public long this[int i]=>Value[i];

public static A213607Inst Instance=new A213607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213608
{
public static readonly long[] Value={ 1L,4L,25L,175L,1572L,19285L,321925L,7695406L,271013005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213608Inst : IEnumerable<long>
{
public static readonly long[] Value=A213608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213608.Bytes);
public long this[int i]=>Value[i];

public static A213608Inst Instance=new A213608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213609
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,11L,15L,16L,18L,20L,0L,28L,29L,33L,38L,42L,45L,48L,53L,54L,60L,64L,66L,67L,75L,77L,80L,86L,91L,92L,100L,102L,104L,109L,111L,110L,127L,0L,128L,133L,140L,144L,151L,154L,153L,160L,165L,170L,171L,178L,0L,189L,190L,192L,198L,202L,209L,210L,220L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213609Inst : IEnumerable<long>
{
public static readonly long[] Value=A213609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213609.Bytes);
public long this[int i]=>Value[i];

public static A213609Inst Instance=new A213609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213610
{
public static readonly long[] Value={ 3L,7L,6L,7L,3L,0L,3L,1L,3L,4L,6L,1L,7L,7L,0L,6L,5L,5L,4L,6L,8L,1L,9L,8L,4L,0L,0L,4L,2L,0L,3L,1L,9L,3L,0L,8L,2L,6L,8L,6L,2L,3L,5L,0L,8L,3L,5L,2L,4L,1L,8L,6L,5L,5L,2L,3L,2L,0L,7L,4L,6L,3L,8L,2L,9L,6L,7L,0L,7L,2L,6L,9L,2L,2L,1L,3L,0L,7L,6L,9L,8L,8L,8L,0L,1L,6L,6L,8L,7L,5L,1L,9L,9L,5L,6L,5L,5L,8L,6L,6L,9L,3L,6L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213610Inst : IEnumerable<long>
{
public static readonly long[] Value=A213610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213610.Bytes);
public long this[int i]=>Value[i];

public static A213610Inst Instance=new A213610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213611
{
public static readonly long[] Value={ 1L,0L,1L,3L,2L,5L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213611Inst : IEnumerable<long>
{
public static readonly long[] Value=A213611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213611.Bytes);
public long this[int i]=>Value[i];

public static A213611Inst Instance=new A213611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213612
{
public static readonly long[] Value={ 3L,1L,5L,5L,7L,6L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213612Inst : IEnumerable<long>
{
public static readonly long[] Value=A213612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213612.Bytes);
public long this[int i]=>Value[i];

public static A213612Inst Instance=new A213612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213613
{
public static readonly long[] Value={ 3L,1L,5L,5L,6L,9L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213613Inst : IEnumerable<long>
{
public static readonly long[] Value=A213613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213613.Bytes);
public long this[int i]=>Value[i];

public static A213613Inst Instance=new A213613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213614
{
public static readonly long[] Value={ 9L,4L,6L,0L,7L,3L,0L,4L,7L,2L,5L,8L,0L,8L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213614Inst : IEnumerable<long>
{
public static readonly long[] Value=A213614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213614.Bytes);
public long this[int i]=>Value[i];

public static A213614Inst Instance=new A213614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213615
{
public static readonly long[] Value={ 1L,2L,-1L,6L,-6L,1L,2L,-3L,1L,0L,30L,-60L,30L,0L,-1L,6L,-15L,10L,0L,-1L,0L,42L,-126L,105L,0L,-21L,0L,1L,6L,-21L,21L,0L,-7L,0L,1L,0L,30L,-120L,140L,0L,-70L,0L,20L,0L,-1L,10L,-45L,60L,0L,-42L,0L,20L,0L,-3L,0L,66L,-330L,495L,0L,-462L,0L,330L,0L,-99L,0L,5L,6L,-33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213615Inst : IEnumerable<long>
{
public static readonly long[] Value=A213615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213615.Bytes);
public long this[int i]=>Value[i];

public static A213615Inst Instance=new A213615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213616
{
public static readonly long[] Value={ 1L,2L,-3L,6L,-18L,13L,2L,-9L,13L,-6L,30L,-180L,390L,-360L,119L,6L,-45L,130L,-180L,119L,-30L,42L,-378L,1365L,-2520L,2499L,-1260L,253L,6L,-63L,273L,-630L,833L,-630L,253L,-42L,30L,-360L,1820L,-5040L,8330L,-8400L,5060L,-1680L,239L,10L,-135L,780L,-2520L,4998L,-6300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213616Inst : IEnumerable<long>
{
public static readonly long[] Value=A213616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213616.Bytes);
public long this[int i]=>Value[i];

public static A213616Inst Instance=new A213616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213617
{
public static readonly long[] Value={ 1L,2L,3L,3L,3L,5L,4L,5L,4L,5L,7L,5L,8L,4L,5L,8L,8L,9L,5L,7L,9L,6L,9L,9L,7L,10L,10L,11L,5L,6L,12L,12L,10L,10L,7L,10L,12L,14L,10L,5L,15L,8L,13L,8L,12L,17L,10L,16L,7L,9L,14L,12L,15L,11L,11L,12L,12L,16L,14L,15L,13L,15L,13L,7L,12L,17L,16L,15L,10L,13L,18L,16L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213617Inst : IEnumerable<long>
{
public static readonly long[] Value=A213617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213617.Bytes);
public long this[int i]=>Value[i];

public static A213617Inst Instance=new A213617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213618
{
public static readonly long[] Value={ 1L,0L,0L,-2L,0L,0L,0L,0L,-3L,0L,0L,6L,2L,0L,0L,0L,0L,0L,0L,0L,-6L,0L,0L,0L,6L,0L,0L,-14L,0L,0L,0L,0L,-3L,0L,0L,12L,12L,0L,0L,0L,0L,0L,0L,0L,-6L,0L,0L,0L,2L,0L,0L,-12L,0L,0L,0L,0L,-12L,0L,0L,18L,0L,0L,0L,0L,0L,0L,0L,0L,-12L,0L,0L,0L,18L,0L,0L,-14L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213618Inst : IEnumerable<long>
{
public static readonly long[] Value=A213618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213618.Bytes);
public long this[int i]=>Value[i];

public static A213618Inst Instance=new A213618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213619
{
public static readonly long[] Value={ 1L,2L,65536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213619Inst : IEnumerable<long>
{
public static readonly long[] Value=A213619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213619.Bytes);
public long this[int i]=>Value[i];

public static A213619Inst Instance=new A213619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213620
{
public static readonly long[] Value={ 1L,2L,-1L,1L,-1L,0L,4L,-6L,0L,1L,1L,-2L,0L,1L,0L,2L,-5L,0L,5L,0L,-1L,1L,-3L,0L,5L,0L,-3L,0L,8L,-28L,0L,70L,0L,-84L,0L,17L,1L,-4L,0L,14L,0L,-28L,0L,17L,0L,2L,-9L,0L,42L,0L,-126L,0L,153L,0L,-31L,1L,-5L,0L,30L,0L,-126L,0L,255L,0L,-155L,0L,4L,-22L,0L,165L,0L,-924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213620Inst : IEnumerable<long>
{
public static readonly long[] Value=A213620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213620.Bytes);
public long this[int i]=>Value[i];

public static A213620Inst Instance=new A213620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213621
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,3L,1L,5L,1L,3L,1L,105L,5L,3L,1L,15L,5L,105L,7L,165L,5L,15L,1L,273L,7L,7L,1L,15L,1L,231L,77L,1785L,35L,3L,1L,25935L,455L,105L,7L,1155L,55L,1155L,7L,2415L,35L,105L,1L,3315L,221L,429L,11L,165L,55L,399L,19L,435L,5L,15L,1L,465465L,5005L,2145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213621Inst : IEnumerable<long>
{
public static readonly long[] Value=A213621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213621.Bytes);
public long this[int i]=>Value[i];

public static A213621Inst Instance=new A213621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213622
{
public static readonly long[] Value={ 1L,3L,4L,7L,8L,4L,9L,8L,4L,16L,9L,8L,20L,8L,8L,11L,8L,12L,20L,20L,8L,15L,16L,12L,20L,16L,8L,24L,21L,8L,20L,8L,16L,28L,24L,8L,17L,32L,12L,36L,16L,8L,24L,16L,24L,19L,20L,20L,32L,16L,12L,28L,16L,20L,44L,27L,12L,36L,24L,16L,28L,24L,16L,28L,32L,12L,25L,32L,12L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213622Inst : IEnumerable<long>
{
public static readonly long[] Value=A213622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213622.Bytes);
public long this[int i]=>Value[i];

public static A213622Inst Instance=new A213622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213623
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,8L,10L,12L,16L,24L,28L,30L,36L,48L,60L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213623Inst : IEnumerable<long>
{
public static readonly long[] Value=A213623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213623.Bytes);
public long this[int i]=>Value[i];

public static A213623Inst Instance=new A213623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213624
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,2L,4L,4L,2L,2L,5L,4L,2L,6L,3L,6L,7L,2L,5L,4L,5L,6L,6L,2L,5L,10L,3L,6L,10L,4L,6L,8L,3L,8L,7L,6L,7L,6L,4L,6L,11L,6L,9L,10L,3L,6L,14L,4L,8L,10L,8L,10L,5L,6L,4L,16L,7L,4L,10L,4L,13L,14L,7L,8L,8L,6L,10L,12L,7L,12L,15L,8L,8L,10L,4L,6L,17L,6L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213624Inst : IEnumerable<long>
{
public static readonly long[] Value=A213624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213624.Bytes);
public long this[int i]=>Value[i];

public static A213624Inst Instance=new A213624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213625
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,4L,7L,2L,8L,10L,4L,10L,9L,6L,8L,10L,4L,8L,16L,8L,9L,12L,8L,12L,20L,6L,8L,10L,8L,18L,11L,12L,8L,20L,12L,8L,20L,6L,20L,26L,8L,8L,15L,10L,16L,18L,12L,16L,20L,10L,16L,16L,8L,24L,24L,8L,21L,26L,8L,20L,20L,14L,8L,28L,16L,10L,28L,10L,24L,22L,8L,16L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213625Inst : IEnumerable<long>
{
public static readonly long[] Value=A213625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213625.Bytes);
public long this[int i]=>Value[i];

public static A213625Inst Instance=new A213625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213626
{
public static readonly long[] Value={ 0L,0L,1L,-2L,-2L,0L,-5L,-4L,0L,8L,21L,2L,-10L,-16L,-15L,-20L,-20L,-16L,-7L,-22L,-14L,0L,-21L,-8L,-28L,-40L,-45L,-46L,-42L,-32L,-49L,-40L,-24L,0L,33L,-10L,22L,64L,11L,52L,104L,168L,245L,154L,78L,16L,65L,4L,-44L,-80L,-105L,-90L,-114L,-128L,-123L,-136L,-132L,-120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213626Inst : IEnumerable<long>
{
public static readonly long[] Value=A213626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213626.Bytes);
public long this[int i]=>Value[i];

public static A213626Inst Instance=new A213626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213627
{
public static readonly long[] Value={ 1L,4L,6L,7L,9L,6L,7L,15L,12L,12L,13L,6L,12L,18L,18L,13L,15L,18L,12L,24L,12L,13L,27L,12L,24L,15L,12L,24L,28L,30L,12L,27L,18L,12L,30L,18L,19L,27L,24L,24L,27L,24L,36L,30L,18L,19L,24L,24L,24L,45L,18L,12L,45L,30L,24L,28L,18L,36L,36L,36L,24L,15L,36L,36L,51L,18L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213627Inst : IEnumerable<long>
{
public static readonly long[] Value=A213627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213627.Bytes);
public long this[int i]=>Value[i];

public static A213627Inst Instance=new A213627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213628
{
public static readonly BigInteger[] Value={ 1L,1L,3L,14L,85L,616L,5072L,46013L,450739L,4702265L,51731956L,595874703L,7147366614L,88905147730L,1143097097833L,15152617826426L,206646826047563L,2894398418226395L,41577147999077079L,611779190051375147L,9211548488261257610L,BigInteger.Parse("141802624561414800815") };
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
public class A213628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213628Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213628.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213628.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213628Inst Instance=new A213628Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213629
{
public static readonly long[] Value={ 1L,1L,1L,2L,0L,1L,1L,1L,0L,1L,2L,1L,0L,0L,1L,2L,1L,1L,0L,0L,1L,3L,0L,2L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,2L,1L,0L,1L,0L,0L,0L,0L,1L,2L,2L,0L,0L,1L,0L,0L,0L,0L,1L,3L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,2L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,3L,1L,1L,0L,1L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213629Inst : IEnumerable<long>
{
public static readonly long[] Value=A213629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213629.Bytes);
public long this[int i]=>Value[i];

public static A213629Inst Instance=new A213629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213630
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,36L,49L,64L,81L,10L,22L,36L,52L,70L,90L,112L,136L,162L,190L,40L,63L,88L,115L,144L,175L,208L,243L,280L,319L,90L,124L,160L,198L,238L,280L,324L,370L,418L,468L,160L,205L,252L,301L,352L,405L,460L,517L,576L,637L,250L,306L,364L,424L,486L,550L,616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213630Inst : IEnumerable<long>
{
public static readonly long[] Value=A213630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213630.Bytes);
public long this[int i]=>Value[i];

public static A213630Inst Instance=new A213630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213631
{
public static readonly long[] Value={ 5L,19L,37L,43L,67L,97L,109L,223L,229L,277L,307L,313L,349L,457L,463L,613L,643L,853L,859L,877L,883L,1087L,1093L,1279L,1297L,1303L,1423L,1429L,1447L,1489L,1609L,1663L,1693L,1783L,1867L,1993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213631Inst : IEnumerable<long>
{
public static readonly long[] Value=A213631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213631.Bytes);
public long this[int i]=>Value[i];

public static A213631Inst Instance=new A213631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213632
{
public static readonly long[] Value={ 7L,23L,41L,47L,71L,101L,113L,227L,233L,281L,311L,317L,353L,461L,467L,617L,647L,857L,863L,881L,887L,1091L,1097L,1283L,1301L,1307L,1427L,1433L,1451L,1493L,1613L,1667L,1697L,1787L,1871L,1997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213632Inst : IEnumerable<long>
{
public static readonly long[] Value=A213632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213632.Bytes);
public long this[int i]=>Value[i];

public static A213632Inst Instance=new A213632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213633
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,3L,2L,4L,3L,5L,2L,6L,4L,7L,5L,8L,4L,9L,6L,10L,7L,11L,4L,12L,8L,13L,9L,14L,7L,15L,10L,16L,11L,17L,7L,18L,12L,19L,13L,20L,10L,21L,14L,22L,15L,23L,9L,24L,16L,25L,17L,26L,13L,27L,18L,28L,19L,29L,8L,30L,20L,31L,21L,32L,16L,33L,22L,34L,23L,35L,14L,36L,24L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213633Inst : IEnumerable<long>
{
public static readonly long[] Value=A213633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213633.Bytes);
public long this[int i]=>Value[i];

public static A213633Inst Instance=new A213633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213634
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,5L,4L,6L,5L,7L,6L,10L,7L,10L,8L,11L,9L,14L,10L,14L,11L,15L,12L,20L,13L,18L,14L,19L,15L,23L,16L,22L,17L,23L,18L,29L,19L,26L,20L,27L,21L,32L,22L,30L,23L,31L,24L,39L,25L,34L,26L,35L,27L,41L,28L,38L,29L,39L,30L,52L,31L,42L,32L,43L,33L,50L,34L,46L,35L,47L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213634Inst : IEnumerable<long>
{
public static readonly long[] Value=A213634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213634.Bytes);
public long this[int i]=>Value[i];

public static A213634Inst Instance=new A213634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213635
{
public static readonly long[] Value={ 0L,0L,2L,3L,4L,4L,6L,6L,8L,9L,10L,10L,12L,12L,14L,15L,16L,16L,18L,18L,20L,21L,22L,20L,24L,24L,26L,27L,28L,28L,30L,30L,32L,33L,34L,35L,36L,36L,38L,39L,40L,40L,42L,42L,44L,45L,46L,45L,48L,48L,50L,51L,52L,52L,54L,54L,56L,57L,58L,56L,60L,60L,62L,63L,64L,64L,66L,66L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213635Inst : IEnumerable<long>
{
public static readonly long[] Value=A213635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213635.Bytes);
public long this[int i]=>Value[i];

public static A213635Inst Instance=new A213635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213636
{
public static readonly long[] Value={ 1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,4L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,3L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,4L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,4L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213636Inst : IEnumerable<long>
{
public static readonly long[] Value=A213636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213636.Bytes);
public long this[int i]=>Value[i];

public static A213636Inst Instance=new A213636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213637
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,9L,10L,11L,13L,15L,16L,17L,19L,21L,22L,23L,25L,27L,28L,29L,31L,33L,34L,35L,36L,37L,39L,40L,41L,43L,45L,46L,47L,49L,51L,52L,53L,55L,57L,58L,59L,61L,63L,64L,65L,67L,69L,70L,71L,73L,75L,76L,77L,79L,81L,82L,83L,85L,87L,88L,89L,91L,93L,94L,95L,96L,97L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213637Inst : IEnumerable<long>
{
public static readonly long[] Value=A213637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213637.Bytes);
public long this[int i]=>Value[i];

public static A213637Inst Instance=new A213637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213638
{
public static readonly long[] Value={ 2L,6L,8L,12L,14L,18L,20L,26L,30L,32L,38L,42L,44L,50L,54L,56L,62L,66L,68L,72L,74L,78L,80L,86L,90L,92L,98L,102L,104L,110L,114L,116L,122L,126L,128L,132L,134L,138L,140L,146L,150L,152L,158L,162L,164L,170L,174L,176L,182L,186L,188L,192L,194L,198L,200L,206L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213638Inst : IEnumerable<long>
{
public static readonly long[] Value=A213638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213638.Bytes);
public long this[int i]=>Value[i];

public static A213638Inst Instance=new A213638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213639
{
public static readonly BigInteger[] Value={ 1L,1L,5L,38L,357L,3832L,45189L,572378L,7676653L,107971691L,1581714400L,24012849880L,376361077578L,6071985730614L,100602798234000L,1708558136679750L,29698002444820760L,527661478169200755L,9573199146196780335UL,BigInteger.Parse("177192815265794698364"),BigInteger.Parse("3343432166097650920872") };
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
public class A213639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213639Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213639.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213639.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213639Inst Instance=new A213639Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213640
{
public static readonly BigInteger[] Value={ 1L,2L,12L,132L,2040L,40560L,986160L,28344960L,940222080L,35350378560L,1485586206720L,69006955691520L,3510875174526720L,194162144086310400L,11597083480958976000UL,BigInteger.Parse("744005639375065267200"),BigInteger.Parse("51024015181398702643200"),BigInteger.Parse("3725042532308649628876800"),BigInteger.Parse("288434288836744276094668800") };
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
public class A213640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213640Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213640.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213640.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213640Inst Instance=new A213640Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213641
{
public static readonly BigInteger[] Value={ 1L,1L,4L,33L,408L,6760L,140880L,3543120L,104469120L,3535037856L,135053291520L,5750579640960L,270067321117440L,13868724577593600L,773138898730598400L,BigInteger.Parse("46500352460941579200"),BigInteger.Parse("3001412657729335449600"),BigInteger.Parse("206946807350480534937600"),BigInteger.Parse("15180752044039172426035200") };
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
public class A213641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213641Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213641.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213641.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213641Inst Instance=new A213641Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213642
{
public static readonly long[] Value={ 2L,2L,5L,2L,11L,5L,17L,2L,23L,11L,31L,5L,41L,17L,47L,2L,59L,23L,67L,11L,73L,31L,83L,5L,97L,41L,103L,17L,109L,47L,127L,2L,137L,59L,149L,23L,157L,67L,167L,11L,179L,73L,191L,31L,197L,83L,211L,5L,227L,97L,233L,41L,241L,103L,257L,17L,269L,109L,277L,47L,283L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213642Inst : IEnumerable<long>
{
public static readonly long[] Value=A213642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213642.Bytes);
public long this[int i]=>Value[i];

public static A213642Inst Instance=new A213642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213643
{
public static readonly BigInteger[] Value={ 1L,2L,18L,252L,4940L,124350L,3823722L,138915560L,5822192952L,276522143130L,14677209803630L,860990013672492L,55315008281020644L,3862656545279925302L,BigInteger.Parse("291301089508829138130"),BigInteger.Parse("23595204076694940812880"),BigInteger.Parse("2042970533426395737658352"),BigInteger.Parse("188298566037963463789282482") };
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
public class A213643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213643Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213643.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213643.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213643Inst Instance=new A213643Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213644
{
public static readonly BigInteger[] Value={ 1L,1L,6L,63L,988L,20725L,546246L,17364445L,646910328L,27652214313L,1334291800330L,71749167806041L,4255000637001588L,275904038948566093L,BigInteger.Parse("19420072633921942542"),BigInteger.Parse("1474700254793433800805"),BigInteger.Parse("120174737260376219862256"),BigInteger.Parse("10461031446553525766071249"),BigInteger.Parse("968785652772129485926955538") };
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
public class A213644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213644Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213644.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213644.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213644Inst Instance=new A213644Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213645
{
public static readonly long[] Value={ 11L,380284918609481L,437163765888581L,701889794782061L,980125031081081L,1277156391416021L,1487854607298791L,1833994713165731L,2115067287743141L,2325810733931801L,3056805353932061L,3252606350489381L,3360877662097841L,3501482688249431L,3595802556731501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213645Inst : IEnumerable<long>
{
public static readonly long[] Value=A213645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213645.Bytes);
public long this[int i]=>Value[i];

public static A213645Inst Instance=new A213645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213646
{
public static readonly long[] Value={ 1418575498573L,2118274828903L,4396774576273L,6368171154193L,6953798916913L,27899359258003L,28138953913303L,34460918582323L,40362095929003L,42023308245613L,44058461657443L,61062361183903L,76075560855373L,80114623697803L,84510447435493L,85160397055813L,90589658803723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213646Inst : IEnumerable<long>
{
public static readonly long[] Value=A213646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213646.Bytes);
public long this[int i]=>Value[i];

public static A213646Inst Instance=new A213646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213647
{
public static readonly long[] Value={ 11L,7908189600581L,10527733922591L,12640876669691L,38545620633251L,43564522846961L,60268613366231L,60596839933361L,71431649320301L,79405799458871L,109319665100531L,153467532929981L,171316998238271L,216585060731771L,254583955361621L,259685796605351L,268349524548221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213647Inst : IEnumerable<long>
{
public static readonly long[] Value=A213647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213647.Bytes);
public long this[int i]=>Value[i];

public static A213647Inst Instance=new A213647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213648
{
public static readonly long[] Value={ 2L,3L,5L,4L,11L,7L,5L,11L,14L,9L,11L,6L,23L,19L,11L,8L,11L,17L,29L,7L,29L,23L,11L,24L,20L,35L,23L,13L,59L,29L,23L,19L,8L,39L,11L,18L,17L,27L,29L,19L,23L,43L,29L,59L,23L,15L,11L,55L,74L,35L,41L,26L,35L,9L,23L,35L,41L,57L,59L,14L,29L,23L,47L,34L,59L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213648Inst : IEnumerable<long>
{
public static readonly long[] Value=A213648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213648.Bytes);
public long this[int i]=>Value[i];

public static A213648Inst Instance=new A213648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213649
{
public static readonly long[] Value={ 2L,1L,2L,1L,2L,1L,3L,2L,1L,2L,1L,4L,3L,2L,1L,3L,2L,1L,4L,3L,2L,1L,3L,2L,1L,5L,4L,3L,2L,1L,4L,3L,2L,1L,5L,4L,3L,2L,1L,5L,4L,3L,2L,1L,4L,3L,2L,1L,6L,5L,4L,3L,2L,1L,7L,6L,5L,4L,3L,2L,1L,5L,4L,3L,2L,1L,6L,5L,4L,3L,2L,1L,6L,5L,4L,3L,2L,1L,7L,6L,5L,4L,3L,2L,1L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213649Inst : IEnumerable<long>
{
public static readonly long[] Value=A213649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213649.Bytes);
public long this[int i]=>Value[i];

public static A213649Inst Instance=new A213649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213650
{
public static readonly long[] Value={ 3L,7L,8L,10L,16L,18L,22L,28L,32L,34L,36L,38L,44L,46L,48L,54L,55L,58L,59L,65L,66L,72L,75L,82L,92L,93L,94L,104L,106L,110L,118L,120L,133L,136L,137L,138L,140L,141L,142L,144L,148L,150L,154L,156L,164L,168L,170L,174L,190L,194L,202L,210L,212L,218L,224L,226L,232L,234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213650Inst : IEnumerable<long>
{
public static readonly long[] Value=A213650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213650.Bytes);
public long this[int i]=>Value[i];

public static A213650Inst Instance=new A213650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213651
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,1L,3L,6L,10L,15L,21L,28L,36L,45L,55L,63L,69L,73L,75L,75L,73L,69L,63L,55L,45L,36L,28L,21L,15L,10L,6L,3L,1L,1L,4L,10L,20L,35L,56L,84L,120L,165L,220L,282L,348L,415L,480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213651Inst : IEnumerable<long>
{
public static readonly long[] Value=A213651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213651.Bytes);
public long this[int i]=>Value[i];

public static A213651Inst Instance=new A213651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213652
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,8L,7L,6L,5L,4L,3L,2L,1L,1L,3L,6L,10L,15L,21L,28L,36L,45L,52L,57L,60L,61L,60L,57L,52L,45L,36L,28L,21L,15L,10L,6L,3L,1L,1L,4L,10L,20L,35L,56L,84L,120L,165L,216L,270L,324L,375L,420L,456L,480L,489L,480L,456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213652Inst : IEnumerable<long>
{
public static readonly long[] Value=A213652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213652.Bytes);
public long this[int i]=>Value[i];

public static A213652Inst Instance=new A213652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213653
{
public static readonly long[] Value={ 0L,10L,10001L,21L,4L,14L,6L,25L,26L,9L,46L,38L,39L,49L,77L,69L,169L,278L,0L,289L,299L,489L,589L,689L,699L,799L,899L,0L,2899L,3899L,4989L,5899L,5999L,6999L,7999L,9899L,0L,19999L,29999L,48999L,58999L,68999L,69999L,88999L,99899L,0L,299899L,398999L,589989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213653Inst : IEnumerable<long>
{
public static readonly long[] Value=A213653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213653.Bytes);
public long this[int i]=>Value[i];

public static A213653Inst Instance=new A213653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213654
{
public static readonly long[] Value={ 2L,6L,4L,1L,0L,7L,10L,5L,1L,0L,3L,16L,15L,6L,1L,0L,2L,16L,30L,21L,7L,1L,0L,0L,12L,42L,50L,28L,8L,1L,0L,0L,5L,44L,87L,77L,36L,9L,1L,0L,0L,2L,33L,116L,158L,112L,45L,10L,1L,0L,0L,0L,19L,119L,253L,263L,156L,55L,11L,1L,0L,0L,0L,7L,96L,322L,488L,411L,210L,66L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213654Inst : IEnumerable<long>
{
public static readonly long[] Value=A213654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213654.Bytes);
public long this[int i]=>Value[i];

public static A213654Inst Instance=new A213654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213655
{
public static readonly long[] Value={ 13L,23L,41L,77L,141L,259L,477L,877L,1613L,2967L,5457L,10037L,18461L,33955L,62453L,114869L,211277L,388599L,714745L,1314621L,2417965L,4447331L,8179917L,15045213L,27672461L,50897591L,93615265L,172185317L,316698173L,582498755L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213655Inst : IEnumerable<long>
{
public static readonly long[] Value=A213655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213655.Bytes);
public long this[int i]=>Value[i];

public static A213655Inst Instance=new A213655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213656
{
public static readonly long[] Value={ 32L,10L,96L,1152L,132L,176L,52L,448L,672L,400L,320L,544L,368L,2432L,1568L,1248L,2240L,752L,864L,232L,1920L,1376L,9472L,3104L,1760L,2624L,3264L,7296L,5440L,37376L,12352L,3552L,3776L,976L,7936L,2848L,108544L,21056L,37120L,49152L,56576L,7584L,11136L,6720L,10368L,12928L,231424L,30784L,22400L,4768L,8832L,5952L,9856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A213656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213656Inst : IEnumerable<long>
{
public static readonly long[] Value=A213656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A213656.Bytes);
public long this[int i]=>Value[i];

public static A213656Inst Instance=new A213656Inst();

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