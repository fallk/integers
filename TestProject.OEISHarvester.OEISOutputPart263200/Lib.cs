using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A291089
{
public static readonly long[] Value={ 1L,4L,20L,104L,556L,3032L,16778L,93872L,529684L,3008864L,17184188L,98577712L,567591142L,3278348608L,18986482250L,110217131168L,641125473092L,3736134109936L,21807240851480L,127469052615104L,746057665449076L,4371699398312704L,25644387465768860L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291089Inst : IEnumerable<long>
{
public static readonly long[] Value=A291089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291089.Bytes);
public long this[int i]=>Value[i];

public static A291089Inst Instance=new A291089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291090
{
public static readonly long[] Value={ 1L,1L,3L,11L,46L,207L,977L,4769L,23872L,121862L,631958L,3319923L,17630692L,94493713L,510468519L,2776629563L,15194389388L,83591476528L,462062822648L,2564995473974L,14293435176216L,79927207249606L,448358398361618L,2522381161938591L,14228119729773226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291090Inst : IEnumerable<long>
{
public static readonly long[] Value=A291090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291090.Bytes);
public long this[int i]=>Value[i];

public static A291090Inst Instance=new A291090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291091
{
public static readonly long[] Value={ 1L,2L,7L,28L,122L,562L,2693L,13288L,67064L,344588L,1796518L,9479780L,50532640L,271710662L,1471935235L,8026070768L,44015873308L,242619318848L,1343427572648L,7469219870968L,41680871386016L,233373274580372L,1310659959443722L,7381448319246248L,41678055955034962L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291091Inst : IEnumerable<long>
{
public static readonly long[] Value=A291091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291091.Bytes);
public long this[int i]=>Value[i];

public static A291091Inst Instance=new A291091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291092
{
public static readonly long[] Value={ 1L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291092Inst : IEnumerable<long>
{
public static readonly long[] Value=A291092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291092.Bytes);
public long this[int i]=>Value[i];

public static A291092Inst Instance=new A291092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291093
{
public static readonly long[] Value={ 16L,26L,19L,49L,11L,12L,22L,13L,33L,34L,14L,44L,15L,55L,16L,64L,66L,17L,77L,18L,88L,19L,95L,96L,97L,39L,49L,98L,99L,101L,102L,103L,104L,21L,22L,121L,23L,33L,132L,34L,136L,24L,44L,143L,25L,55L,154L,26L,65L,66L,165L,106L,67L,27L,77L,176L,28L,88L,187L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291093Inst : IEnumerable<long>
{
public static readonly long[] Value=A291093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291093.Bytes);
public long this[int i]=>Value[i];

public static A291093Inst Instance=new A291093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291094
{
public static readonly long[] Value={ 64L,65L,95L,98L,110L,120L,121L,130L,132L,136L,140L,143L,150L,154L,160L,160L,165L,170L,176L,180L,187L,190L,190L,192L,194L,195L,196L,196L,198L,202L,204L,206L,208L,210L,220L,220L,230L,231L,231L,238L,238L,240L,242L,242L,250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291094Inst : IEnumerable<long>
{
public static readonly long[] Value=A291094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291094.Bytes);
public long this[int i]=>Value[i];

public static A291094Inst Instance=new A291094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291095
{
public static readonly BigInteger[] Value={ 3L,3L,878L,11404L,11404L,595413L,1797640L,98274734L,198347106L,8128636028L,75041122922L,922797637351L,6759747953135L,28036830572808L,1213341301344107L,19027704941439533L,71928417857731452L,240751079727999028L,5127701092145711019L,BigInteger.Parse("81320964235147379208"),BigInteger.Parse("1224942164619356399124") };
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
public class A291095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291095Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291095.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A291095.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291095Inst Instance=new A291095Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291096
{
public static readonly BigInteger[] Value={ 1L,3L,36L,594L,11340L,235467L,5164236L,117704340L,2760422652L,66179363580L,1614629242512L,39958835859306L,1000667989897524L,25310418084553770L,645671000841035400L,16592979103827051240UL,BigInteger.Parse("429173117580596633820"),BigInteger.Parse("11163550152596460675012"),BigInteger.Parse("291848008677713303547312") };
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
public class A291096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291096Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291096.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A291096.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291096Inst Instance=new A291096Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291097
{
public static readonly long[] Value={ 3L,8L,20L,47L,106L,233L,504L,1079L,2294L,4853L,10228L,21491L,45042L,94193L,196592L,409583L,851950L,1769453L,3669996L,7602155L,15728618L,32505833L,67108840L,138412007L,285212646L,587202533L,1207959524L,2483027939L,5100273634L,10468982753L,21474836448L,44023414751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291097Inst : IEnumerable<long>
{
public static readonly long[] Value=A291097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291097.Bytes);
public long this[int i]=>Value[i];

public static A291097Inst Instance=new A291097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291098
{
public static readonly long[] Value={ 1L,4L,12L,266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291098Inst : IEnumerable<long>
{
public static readonly long[] Value=A291098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291098.Bytes);
public long this[int i]=>Value[i];

public static A291098Inst Instance=new A291098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291133
{
public static readonly BigInteger[] Value={ 1L,574L,96620L,10358998L,886044810L,66943181150L,4719570364004L,320771944968342L,21454694483447459L,1431385710008667470L,BigInteger.Parse("96133394595460111056"),BigInteger.Parse("6540549310477955461846"),BigInteger.Parse("452777288307033641080180"),BigInteger.Parse("31990399760398854681388158"),BigInteger.Parse("2311790354938282481939931160") };
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
public class A291133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291133Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291133.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A291133.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291133Inst Instance=new A291133Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291134
{
public static readonly BigInteger[] Value={ 1L,1103L,269512L,38643849L,4218834608L,393933602129L,33499946915016L,2693983725947891L,209859823775671984L,16093162912317174422UL,BigInteger.Parse("1228462028909579534968"),BigInteger.Parse("94081283153407041089350"),BigInteger.Parse("7269699339591280955315232"),BigInteger.Parse("569088494101518607733459806") };
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
public class A291134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291134Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291134.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A291134.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291134Inst Instance=new A291134Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291135
{
public static readonly BigInteger[] Value={ 1L,2146L,754943L,143336610L,19795924787L,2267392009178L,231141766226605L,21881366451890002L,1976997422623843358L,BigInteger.Parse("173666031731576614842"),BigInteger.Parse("15025473411620865716938"),BigInteger.Parse("1292364106829281911023554"),BigInteger.Parse("111260031164008673095102874"),BigInteger.Parse("9635674549219284395173044506") };
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
public class A291135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291135Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291135.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A291135.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291135Inst Instance=new A291135Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291136
{
public static readonly BigInteger[] Value={ 1L,4215L,2127828L,530926606L,92071525556L,12851428617547L,1561750852160556L,173226805226723844L,18081637592017744356UL,BigInteger.Parse("1813499364725872444178"),BigInteger.Parse("177350996523515552397628"),BigInteger.Parse("17092810524840161845093436"),BigInteger.Parse("1636375630004710170560408532"),BigInteger.Parse("156537967540558397590739941650") };
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
public class A291136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291136Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291136.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A291136.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291136Inst Instance=new A291136Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291137
{
public static readonly long[] Value={ 1L,-1L,0L,1L,-1L,0L,1L,-1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,0L,0L,-1L,-1L,0L,1L,-1L,-1L,1L,1L,-1L,0L,1L,1L,0L,0L,-1L,-1L,-1L,0L,1L,-1L,0L,0L,1L,0L,1L,-1L,0L,1L,0L,0L,-1L,0L,0L,1L,-1L,-1L,0L,1L,0L,0L,0L,-1L,1L,-1L,-1L,1L,-1L,0L,1L,1L,0L,0L,0L,0L,-1L,0L,0L,-1L,-1L,0L,1L,-1L,0L,-1L,-1L,0L,1L,0L,1L,1L,1L,-1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,-1L,-1L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291137Inst : IEnumerable<long>
{
public static readonly long[] Value=A291137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291137.Bytes);
public long this[int i]=>Value[i];

public static A291137Inst Instance=new A291137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291138
{
public static readonly long[] Value={ 3L,14L,42L,210L,3570L,43890L,746130L,14804790L,281291010L,8720021310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291138Inst : IEnumerable<long>
{
public static readonly long[] Value=A291138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291138.Bytes);
public long this[int i]=>Value[i];

public static A291138Inst Instance=new A291138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291139
{
public static readonly long[] Value={ 2L,5L,11L,31L,41L,89L,103L,181L,281L,311L,353L,419L,769L,797L,811L,839L,853L,911L,1091L,1153L,1201L,1217L,1249L,1499L,1621L,1873L,2081L,2557L,2999L,3307L,3533L,3671L,3881L,3929L,4289L,5431L,6131L,6269L,6491L,6547L,7001L,7349L,7583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291139Inst : IEnumerable<long>
{
public static readonly long[] Value=A291139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291139.Bytes);
public long this[int i]=>Value[i];

public static A291139Inst Instance=new A291139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291140
{
public static readonly BigInteger[] Value={ 2L,13L,160L,3123L,181258L,6732437L,493478344L,24995572327L,2255433009730L,470444892889497L,38714638073629150L,7749166585021832891L,BigInteger.Parse("1203906832960860262108"),BigInteger.Parse("121893712541593098356317"),BigInteger.Parse("17161342484454585041813494") };
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
public class A291140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291140Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291140.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A291140.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291140Inst Instance=new A291140Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291142
{
public static readonly long[] Value={ 0L,1L,2L,6L,16L,43L,114L,300L,784L,2037L,5266L,13554L,34752L,88799L,226210L,574680L,1456352L,3682409L,9292002L,23403102L,58842416L,147713043L,370262930L,926852868L,2317191024L,5786293597L,14433117938L,35964267594L,89528469088L,222666575815L,553319176770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291142Inst : IEnumerable<long>
{
public static readonly long[] Value=A291142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291142.Bytes);
public long this[int i]=>Value[i];

public static A291142Inst Instance=new A291142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291143
{
public static readonly long[] Value={ 0L,0L,3L,9L,18L,36L,81L,189L,430L,954L,2097L,4602L,10080L,21996L,47796L,103473L,223308L,480584L,1031571L,2208807L,4718610L,10058580L,21398715L,45438270L,96313626L,203812110L,430615240L,908455203L,1913845374L,4026531804L,8460687861L,17756508321L,37223049942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291143Inst : IEnumerable<long>
{
public static readonly long[] Value=A291143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291143.Bytes);
public long this[int i]=>Value[i];

public static A291143Inst Instance=new A291143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291144
{
public static readonly BigInteger[] Value={ 2L,4L,25L,218L,1538L,20018L,570569L,9869858L,148728578L,7865117258L,198255197138L,5481986730218L,235725429399458L,12372844050106538L,587192044634054858L,BigInteger.Parse("32820287260716215258"),BigInteger.Parse("1325292444739061819018"),BigInteger.Parse("91010656573966064915978"),BigInteger.Parse("8683441125519459364805738") };
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
public class A291144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291144Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291144.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A291144.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291144Inst Instance=new A291144Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291145
{
public static readonly BigInteger[] Value={ 0L,1L,14641L,4228599998736L,BigInteger.Parse("2598836588984899974898904499869498896") };
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
public class A291145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291145Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291145.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A291145.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291145Inst Instance=new A291145Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291146
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,14L,18L,23L,29L,36L,44L,53L,64L,78L,96L,119L,148L,184L,228L,281L,345L,423L,519L,639L,788L,973L,1202L,1484L,1830L,2254L,2774L,3415L,4206L,5183L,6390L,7880L,9717L,11979L,14762L,18188L,22408L,27609L,34022L,41931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291146Inst : IEnumerable<long>
{
public static readonly long[] Value=A291146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291146.Bytes);
public long this[int i]=>Value[i];

public static A291146Inst Instance=new A291146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291147
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,-1L,0L,0L,-2L,0L,0L,0L,0L,-1L,0L,0L,-3L,0L,0L,0L,0L,-1L,0L,0L,-4L,0L,0L,-1L,0L,-1L,0L,0L,-5L,0L,0L,-3L,0L,-1L,0L,0L,-6L,0L,0L,-6L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291147Inst : IEnumerable<long>
{
public static readonly long[] Value=A291147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291147.Bytes);
public long this[int i]=>Value[i];

public static A291147Inst Instance=new A291147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291148
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,0L,-1L,-1L,-1L,-2L,-2L,-4L,-4L,-7L,-9L,-13L,-19L,-25L,-38L,-51L,-75L,-104L,-149L,-211L,-298L,-426L,-600L,-857L,-1211L,-1724L,-2444L,-3471L,-4930L,-6995L,-9940L,-14104L,-20038L,-28444L,-40397L,-57362L,-81453L,-115675L,-164250L,-233262L,-331227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291148Inst : IEnumerable<long>
{
public static readonly long[] Value=A291148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291148.Bytes);
public long this[int i]=>Value[i];

public static A291148Inst Instance=new A291148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291149
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,19L,22L,26L,31L,37L,44L,52L,61L,71L,82L,94L,107L,121L,136L,152L,169L,188L,210L,236L,267L,304L,348L,400L,461L,532L,614L,708L,815L,936L,1072L,1224L,1393L,1581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291149Inst : IEnumerable<long>
{
public static readonly long[] Value=A291149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291149.Bytes);
public long this[int i]=>Value[i];

public static A291149Inst Instance=new A291149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291549
{
public static readonly long[] Value={ 1L,60L,170L,240L,315L,540L,679L,680L,960L,1500L,2142L,2160L,2720L,2835L,3840L,4250L,4365L,4860L,5770L,6000L,7875L,8568L,8640L,9154L,9809L,10880L,13500L,14322L,15360L,15435L,17000L,19278L,19440L,22413L,23080L,24000L,25515L,29682L,33271L,34272L,34560L,36616L,37114L,37500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291549Inst : IEnumerable<long>
{
public static readonly long[] Value=A291549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291549.Bytes);
public long this[int i]=>Value[i];

public static A291549Inst Instance=new A291549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291550
{
public static readonly long[] Value={ 666030256L,696630544L,967947856L,1031796176L,2840437756L,3156691844L,4150593232L,4213181968L,4796703664L,4855069456L,10168398448L,11159012552L,33707179456L,33844856128L,53151801712L,55270703248L,62393407792L,65270990608L,107122129216L,107620508608L,284624443948L,287125556692L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291550Inst : IEnumerable<long>
{
public static readonly long[] Value=A291550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291550.Bytes);
public long this[int i]=>Value[i];

public static A291550Inst Instance=new A291550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291551
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,26L,0L,262L,0L,10226L,43964L,139484L,0L,13936472L,59652396L,301235944L,1915640632L,7969506364L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291551Inst : IEnumerable<long>
{
public static readonly long[] Value=A291551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291551.Bytes);
public long this[int i]=>Value[i];

public static A291551Inst Instance=new A291551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291552
{
public static readonly long[] Value={ 1L,2L,5L,11L,25L,52L,110L,221L,444L,868L,1685L,3212L,6082L,11361L,21071L,38693L,70570L,127670L,229557L,409963L,728069L,1285522L,2258318L,3947115L,6867238L,11893648L,20513199L,35235429L,60292928L,102787903L,174620017L,295644893L,498931699L,839367287L,1407864040L,2354559426L,3926878130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291552Inst : IEnumerable<long>
{
public static readonly long[] Value=A291552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291552.Bytes);
public long this[int i]=>Value[i];

public static A291552Inst Instance=new A291552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291553
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,8L,13L,22L,35L,54L,81L,121L,174L,250L,352L,491L,675L,924L,1246L,1674L,2226L,2944L,3862L,5046L,6541L,8449L,10846L,13869L,17641L,22365L,28214L,35485L,44443L,55494L,69036L,85650L,105894L,130594L,160561L,196923L,240847L,293907L,357722L,434477L,526448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291553Inst : IEnumerable<long>
{
public static readonly long[] Value=A291553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291553.Bytes);
public long this[int i]=>Value[i];

public static A291553Inst Instance=new A291553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291554
{
public static readonly long[] Value={ 31L,73L,89L,109L,113L,127L,151L,157L,193L,233L,241L,257L,281L,307L,313L,331L,337L,353L,397L,433L,457L,499L,577L,593L,601L,641L,673L,683L,811L,919L,953L,1013L,1049L,1103L,1153L,1163L,1201L,1217L,1249L,1321L,1327L,1399L,1429L,1433L,1459L,1471L,1553L,1601L,1613L,1657L,1709L,1721L,1753L,1777L,1789L,1801L,1873L,1913L,1933L,1993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291554Inst : IEnumerable<long>
{
public static readonly long[] Value=A291554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291554.Bytes);
public long this[int i]=>Value[i];

public static A291554Inst Instance=new A291554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291555
{
public static readonly long[] Value={ 0L,1L,4L,15L,40L,57L,76L,108L,146L,194L,258L,336L,447L,544L,663L,807L,970L,1132L,1333L,1567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291555Inst : IEnumerable<long>
{
public static readonly long[] Value=A291555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291555.Bytes);
public long this[int i]=>Value[i];

public static A291555Inst Instance=new A291555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291556
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,0L,1L,3L,3L,0L,1L,5L,11L,4L,0L,1L,9L,49L,50L,5L,0L,1L,17L,251L,820L,274L,6L,0L,1L,33L,1393L,16280L,21076L,1764L,7L,0L,1L,65L,8051L,357904L,2048824L,773136L,13068L,8L,0L,1L,129L,47449L,8252000L,224021776L,444273984L,38402064L,109584L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291556Inst : IEnumerable<long>
{
public static readonly long[] Value=A291556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291556.Bytes);
public long this[int i]=>Value[i];

public static A291556Inst Instance=new A291556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291557
{
public static readonly long[] Value={ 22L,45L,91L,183L,367L,735L,1471L,2943L,5887L,11775L,23551L,47103L,94207L,188415L,376831L,753663L,1507327L,3014655L,6029311L,12058623L,24117247L,48234495L,96468991L,192937983L,385875967L,771751935L,1543503871L,3087007743L,6174015487L,12348030975L,24696061951L,49392123903L,98784247807L,197568495615L,395136991231L,790273982463L,1580547964927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291557Inst : IEnumerable<long>
{
public static readonly long[] Value=A291557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291557.Bytes);
public long this[int i]=>Value[i];

public static A291557Inst Instance=new A291557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291558
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,25L,123L,695L,4710L,38573L,363290L,3762248L,42712427L,544108640L,7858522102L,125629094752L,2132933782538L,37180929264503L,653233840242274L,11489698066482812L,202366696882463928L,3583045708114956712L,BigInteger.Parse("64151951314880747470"),BigInteger.Parse("1170351942994473380196"),BigInteger.Parse("21993337390128064959103"),BigInteger.Parse("433693240259690293897796"),BigInteger.Parse("9276431005281628486906887"),BigInteger.Parse("226051070328728855263836057") };
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
public class A291558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291558Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291558.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A291558.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291558Inst Instance=new A291558Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291559
{
public static readonly long[] Value={ 0L,0L,1L,2L,5L,10L,23L,52L,120L,275L,644L,1508L,3558L,8418L,20012L,47699L,114082L,273476L,657250L,1582817L,3819514L,9233059L,22356918L,54216429L,131663670L,320158789L,779461271L,1899830067L,4635492672L,11321595218L,27677333555L,67720658475L,165835173692L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291559Inst : IEnumerable<long>
{
public static readonly long[] Value=A291559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291559.Bytes);
public long this[int i]=>Value[i];

public static A291559Inst Instance=new A291559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291560
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-10L,9L,-1L,91L,-315L,225L,1L,-820L,8694L,-18900L,11025L,-1L,7381L,-224730L,1143450L,-1819125L,893025L,1L,-66430L,5684679L,-61647300L,203378175L,-255405150L,108056025L,-1L,597871L,-142714845L,3162834675L,-19494349875L,47377655325L,-49165491375L,18261468225L,1L,-5380840L,3573251964L,-158546770200L,1734021238950L,-7311738634200L,14041664336700L,-12417798393000L,4108830350625L,-1L,48427561L,-89379726660L,7858123038900L,-148224512094750L,1025176095093150L,-3257761647640500L,5167045911327300L,-3981456609755625L,1187451971330625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291560Inst : IEnumerable<long>
{
public static readonly long[] Value=A291560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291560.Bytes);
public long this[int i]=>Value[i];

public static A291560Inst Instance=new A291560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291561
{
public static readonly BigInteger[] Value={ 1L,10L,315L,18900L,1819125L,255405150L,49165491375L,12417798393000L,3981456609755625L,1579311121869731250L,BigInteger.Parse("759174856282779811875"),BigInteger.Parse("434800144961955710437500"),BigInteger.Parse("292511797523155704196828125"),BigInteger.Parse("228384211143079261353677343750"),BigInteger.Parse("204811697921525723306815646484375"),BigInteger.Parse("209071781238293458351597411931250000"),BigInteger.Parse("241020562808770177455950891441994140625"),BigInteger.Parse("311597054671244174125111099536008660156250") };
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
public class A291561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291561Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291561.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A291561.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291561Inst Instance=new A291561Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291567
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,7L,7L,5L,7L,6L,7L,7L,5L,7L,7L,6L,7L,5L,7L,7L,7L,6L,5L,7L,7L,7L,7L,5L,7L,7L,7L,7L,5L,6L,7L,7L,7L,5L,7L,6L,7L,7L,5L,7L,7L,6L,7L,5L,7L,7L,7L,6L,5L,7L,7L,7L,7L,5L,7L,7L,7L,7L,5L,6L,7L,7L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291567Inst : IEnumerable<long>
{
public static readonly long[] Value=A291567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291567.Bytes);
public long this[int i]=>Value[i];

public static A291567Inst Instance=new A291567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291568
{
public static readonly long[] Value={ 1L,1L,1L,1L,-3L,1L,1L,1L,1L,-3L,1L,1L,1L,1L,-3L,1L,1L,1L,1L,-3L,1L,1L,1L,1L,-3L,1L,1L,1L,1L,-3L,1L,1L,1L,1L,-3L,1L,1L,1L,1L,-3L,1L,1L,1L,1L,-3L,1L,1L,1L,1L,-3L,1L,1L,1L,1L,-3L,1L,1L,1L,1L,-3L,1L,1L,1L,1L,-3L,1L,1L,1L,1L,-3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291568Inst : IEnumerable<long>
{
public static readonly long[] Value=A291568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291568.Bytes);
public long this[int i]=>Value[i];

public static A291568Inst Instance=new A291568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291569
{
public static readonly long[] Value={ -13L,-13L,-13L,-13L,-15L,-13L,-13L,-13L,-13L,-15L,-13L,-13L,-13L,-14L,-15L,-16L,-17L,-18L,-19L,-20L,-21L,-22L,-23L,-24L,-25L,-26L,-27L,-28L,-29L,-30L,-31L,-32L,-33L,-34L,-35L,-36L,-37L,-38L,-39L,-40L,-41L,-42L,-43L,-44L,-45L,-46L,-47L,-48L,-49L,-50L,-51L,-52L,-53L,-54L,-55L,-56L,-57L,-58L,-59L,-60L,-61L,-62L,-63L,-64L,-65L,-66L,-67L,-68L,-69L,-70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291569Inst : IEnumerable<long>
{
public static readonly long[] Value=A291569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291569.Bytes);
public long this[int i]=>Value[i];

public static A291569Inst Instance=new A291569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291604
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,8L,5L,7L,9L,10L,11L,22L,12L,18L,13L,19L,14L,23L,15L,24L,20L,25L,16L,28L,17L,26L,21L,27L,29L,30L,31L,32L,33L,34L,38L,35L,36L,40L,37L,41L,39L,58L,42L,43L,50L,59L,44L,62L,45L,63L,48L,66L,46L,72L,47L,67L,49L,73L,51L,78L,52L,74L,53L,75L,54L,76L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291604Inst : IEnumerable<long>
{
public static readonly long[] Value=A291604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291604.Bytes);
public long this[int i]=>Value[i];

public static A291604Inst Instance=new A291604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291605
{
public static readonly long[] Value={ 2L,5L,8L,24L,35L,116L,208L,231L,237L,303L,1451L,1512L,2235L,2612L,4433L,4499L,5408L,7331L,11896L,12821L,23679L,23900L,59650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291605Inst : IEnumerable<long>
{
public static readonly long[] Value=A291605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291605.Bytes);
public long this[int i]=>Value[i];

public static A291605Inst Instance=new A291605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291606
{
public static readonly long[] Value={ 0L,1L,6L,7L,27L,51L,67L,69L,115L,153L,346L,351L,1152L,1807L,2508L,4470L,4875L,5277L,7527L,10339L,11407L,21807L,26199L,46473L,68368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291606Inst : IEnumerable<long>
{
public static readonly long[] Value=A291606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291606.Bytes);
public long this[int i]=>Value[i];

public static A291606Inst Instance=new A291606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291607
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,29L,43L,62L,85L,107L,172L,557L,1043L,2395L,4498L,5818L,7772L,9125L,12616L,17252L,23000L,64904L,71077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291607Inst : IEnumerable<long>
{
public static readonly long[] Value=A291607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291607.Bytes);
public long this[int i]=>Value[i];

public static A291607Inst Instance=new A291607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291608
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,18L,21L,34L,44L,105L,154L,163L,189L,382L,421L,2473L,2664L,4590L,9804L,19950L,29992L,38457L,40249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291608Inst : IEnumerable<long>
{
public static readonly long[] Value=A291608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291608.Bytes);
public long this[int i]=>Value[i];

public static A291608Inst Instance=new A291608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291609
{
public static readonly long[] Value={ 1L,3L,4L,7L,10L,24L,37L,46L,63L,64L,91L,114L,367L,453L,1156L,1347L,1524L,7153L,10893L,13548L,15153L,43093L,61167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291609Inst : IEnumerable<long>
{
public static readonly long[] Value=A291609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291609.Bytes);
public long this[int i]=>Value[i];

public static A291609Inst Instance=new A291609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291610
{
public static readonly long[] Value={ 1L,2L,3L,9L,10L,11L,26L,29L,30L,31L,32L,33L,34L,108L,112L,113L,114L,115L,119L,143L,375L,376L,377L,384L,389L,390L,391L,392L,393L,394L,395L,406L,407L,410L,411L,412L,415L,1218L,1219L,1220L,1223L,1224L,1227L,1228L,1229L,1230L,1231L,1232L,1237L,1238L,1239L,1240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291610Inst : IEnumerable<long>
{
public static readonly long[] Value=A291610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291610.Bytes);
public long this[int i]=>Value[i];

public static A291610Inst Instance=new A291610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291611
{
public static readonly long[] Value={ 1L,3L,6L,16L,30L,33L,36L,37L,85L,288L,561L,805L,850L,2571L,4579L,5223L,5940L,10191L,18756L,24564L,29595L,1057L,1192L,1312L,43891L,65905L,89118L,97963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291611Inst : IEnumerable<long>
{
public static readonly long[] Value=A291611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291611.Bytes);
public long this[int i]=>Value[i];

public static A291611Inst Instance=new A291611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291612
{
public static readonly long[] Value={ 1105L,852841L,3828001L,17098369L,118901521L,150846961L,172947529L,186393481L,200753281L,686059921L,771043201L,1001152801L,1207252621L,1269295201L,1632785701L,1772267281L,2301745249L,4765950001L,4897161361L,5278692481L,6030849889L,8251854001L,12121569601L,12456671569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291612Inst : IEnumerable<long>
{
public static readonly long[] Value=A291612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291612.Bytes);
public long this[int i]=>Value[i];

public static A291612Inst Instance=new A291612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291613
{
public static readonly long[] Value={ 1L,1L,1L,3L,8L,24L,70L,213L,661L,2096L,6744L,21979L,72372L,240466L,805176L,2714323L,9204564L,31377860L,107466778L,369613444L,1276043914L,4420532404L,15361787448L,53536660741L,187068856364L,655243469070L,2300251841691L,8091866659762L,28520644071194L,100704832499918L,356180684577830L,1261749324207915L,4476270738313695L,15902368898751100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291613Inst : IEnumerable<long>
{
public static readonly long[] Value=A291613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291613.Bytes);
public long this[int i]=>Value[i];

public static A291613Inst Instance=new A291613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291614
{
public static readonly long[] Value={ 1L,1L,-1L,2L,-5L,13L,-40L,126L,-409L,1363L,-4617L,15896L,-55444L,195480L,-695636L,2495118L,-9011281L,32741839L,-119601339L,438968354L,-1618006837L,5986803522L,-22229028994L,82798248894L,-309299225632L,1158483827048L,-4349740078410L,16368842606820L,-61727972554068L,233233590724532L,-882851162632794L,3347489178793192L,-12712739206990305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291614Inst : IEnumerable<long>
{
public static readonly long[] Value=A291614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291614.Bytes);
public long this[int i]=>Value[i];

public static A291614Inst Instance=new A291614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291615
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,3L,3L,3L,2L,3L,3L,2L,3L,1L,3L,3L,3L,2L,5L,3L,2L,2L,4L,5L,5L,5L,2L,3L,3L,3L,4L,2L,6L,3L,11L,4L,3L,8L,9L,8L,10L,7L,6L,3L,9L,6L,6L,6L,11L,10L,11L,9L,9L,9L,12L,11L,13L,3L,6L,10L,7L,15L,5L,6L,7L,13L,7L,8L,14L,10L,13L,19L,12L,14L,11L,18L,15L,11L,15L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291615Inst : IEnumerable<long>
{
public static readonly long[] Value=A291615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291615.Bytes);
public long this[int i]=>Value[i];

public static A291615Inst Instance=new A291615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291616
{
public static readonly long[] Value={ 1105L,294409L,852841L,3828001L,17098369L,118901521L,150846961L,172947529L,186393481L,200753281L,686059921L,771043201L,1001152801L,1207252621L,1269295201L,1299963601L,1632785701L,1772267281L,2301745249L,4215885697L,4562359201L,4765950001L,4897161361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291616Inst : IEnumerable<long>
{
public static readonly long[] Value=A291616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291616.Bytes);
public long this[int i]=>Value[i];

public static A291616Inst Instance=new A291616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291617
{
public static readonly long[] Value={ 230L,341L,1387L,2047L,2701L,3277L,4033L,4369L,4681L,5461L,7957L,8321L,10261L,13747L,14491L,15709L,18721L,19951L,23377L,31323L,31417L,31609L,31621L,35333L,38193L,42799L,49141L,49981L,60701L,60787L,65077L,65281L,80581L,83333L,85489L,88357L,90751L,104653L,123251L,129889L,130561L,150851L,162193L,164737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291617Inst : IEnumerable<long>
{
public static readonly long[] Value=A291617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291617.Bytes);
public long this[int i]=>Value[i];

public static A291617Inst Instance=new A291617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291618
{
public static readonly long[] Value={ 14L,22L,24L,32L,42L,202L,402L,1012L,20008L,30004L,30008L,80001L,80002L,100012L,200008L,300004L,400001L,400008L,1000012L,1000080L,3000012L,4000001L,4000002L,5000016L,6000001L,20000012L,30000004L,40000001L,40000008L,50000016L,60000004L,80000001L,100000012L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291618Inst : IEnumerable<long>
{
public static readonly long[] Value=A291618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291618.Bytes);
public long this[int i]=>Value[i];

public static A291618Inst Instance=new A291618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291619
{
public static readonly long[] Value={ 15L,143L,869L,16727L,17017L,26791L,31135L,32399L,36863L,57599L,58609L,63145L,65535L,106327L,124241L,137863L,176399L,186623L,206111L,416111L,435599L,546407L,571097L,788839L,1040399L,1065023L,1101047L,1240001L,1301189L,1665799L,2108303L,2617871L,2643503L,2713621L,3161413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291619Inst : IEnumerable<long>
{
public static readonly long[] Value=A291619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291619.Bytes);
public long this[int i]=>Value[i];

public static A291619Inst Instance=new A291619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291788
{
public static readonly long[] Value={ 45L,48L,50L,55L,56L,60L,68L,69L,70L,72L,74L,75L,76L,77L,78L,80L,84L,85L,86L,87L,88L,90L,91L,92L,93L,94L,95L,96L,98L,99L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291788Inst : IEnumerable<long>
{
public static readonly long[] Value=A291788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291788.Bytes);
public long this[int i]=>Value[i];

public static A291788Inst Instance=new A291788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291789
{
public static readonly long[] Value={ 270L,396L,606L,712L,851L,852L,1148L,1416L,2032L,2488L,2960L,4110L,5512L,6918L,8076L,10780L,16044L,23784L,33720L,55240L,73230L,97672L,118470L,169840L,247224L,350260L,442848L,728448L,1213440L,2124864L,4080384L,8159616L,13515078L,15767596L,18626016L,29239504L,39012864L,62623600L,92580308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291789Inst : IEnumerable<long>
{
public static readonly long[] Value=A291789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291789.Bytes);
public long this[int i]=>Value[i];

public static A291789Inst Instance=new A291789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291790
{
public static readonly long[] Value={ 270L,290L,308L,326L,327L,328L,352L,369L,393L,394L,395L,396L,410L,440L,458L,459L,465L,496L,504L,510L,525L,559L,560L,570L,606L,616L,620L,685L,686L,702L,712L,725L,734L,735L,737L,738L,745L,746L,747L,783L,791L,792L,805L,806L,813L,814L,815L,816L,828L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291790Inst : IEnumerable<long>
{
public static readonly long[] Value=A291790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291790.Bytes);
public long this[int i]=>Value[i];

public static A291790Inst Instance=new A291790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291791
{
public static readonly long[] Value={ 4L,8L,9L,12L,14L,15L,16L,18L,20L,24L,25L,28L,32L,33L,34L,35L,36L,42L,48L,49L,50L,54L,55L,56L,62L,63L,64L,69L,70L,72L,76L,77L,78L,81L,84L,85L,86L,87L,88L,90L,93L,94L,95L,96L,98L,99L,100L,102L,104L,105L,108L,110L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291791Inst : IEnumerable<long>
{
public static readonly long[] Value=A291791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291791.Bytes);
public long this[int i]=>Value[i];

public static A291791Inst Instance=new A291791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291806
{
public static readonly long[] Value={ 1L,5L,216L,212987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291806Inst : IEnumerable<long>
{
public static readonly long[] Value=A291806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291806.Bytes);
public long this[int i]=>Value[i];

public static A291806Inst Instance=new A291806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291807
{
public static readonly long[] Value={ 1L,5L,64L,2759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291807Inst : IEnumerable<long>
{
public static readonly long[] Value=A291807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291807.Bytes);
public long this[int i]=>Value[i];

public static A291807Inst Instance=new A291807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291808
{
public static readonly long[] Value={ 1L,2L,44L,10066L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291808Inst : IEnumerable<long>
{
public static readonly long[] Value=A291808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291808.Bytes);
public long this[int i]=>Value[i];

public static A291808Inst Instance=new A291808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291809
{
public static readonly long[] Value={ 1L,2L,35L,6563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291809Inst : IEnumerable<long>
{
public static readonly long[] Value=A291809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291809.Bytes);
public long this[int i]=>Value[i];

public static A291809Inst Instance=new A291809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291810
{
public static readonly long[] Value={ 0L,2L,4L,7L,7L,11L,12L,14L,16L,17L,19L,21L,24L,23L,28L,26L,31L,29L,36L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291810Inst : IEnumerable<long>
{
public static readonly long[] Value=A291810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291810.Bytes);
public long this[int i]=>Value[i];

public static A291810Inst Instance=new A291810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291811
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,5L,6L,7L,8L,9L,10L,12L,13L,11L,12L,12L,13L,14L,15L,16L,17L,17L,18L,19L,20L,21L,22L,24L,25L,23L,24L,24L,25L,26L,27L,28L,29L,29L,30L,31L,32L,33L,34L,36L,37L,35L,36L,36L,37L,38L,39L,40L,41L,41L,42L,43L,44L,45L,46L,48L,49L,47L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291811Inst : IEnumerable<long>
{
public static readonly long[] Value=A291811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291811.Bytes);
public long this[int i]=>Value[i];

public static A291811Inst Instance=new A291811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291813
{
public static readonly BigInteger[] Value={ 1L,1L,5L,35L,297L,2873L,30657L,353727L,4355497L,56709337L,775575269L,11085971235L,164979882033L,2548461481105L,40762085472929L,673751263927071L,11489101983573105L,201838769635965969L,3648620371959258149L,BigInteger.Parse("67795012307507004291"),BigInteger.Parse("1293607920940368319641"),BigInteger.Parse("25326486746707799668105"),BigInteger.Parse("508368313083167614599201"),BigInteger.Parse("10454499119633293760277151"),BigInteger.Parse("220120546753823908307191769"),BigInteger.Parse("4742197866143368618862457641") };
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
public class A291813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291813Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291813.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A291813.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291813Inst Instance=new A291813Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291814
{
public static readonly BigInteger[] Value={ 1L,1L,7L,67L,769L,10009L,143359L,2218255L,36625657L,639659737L,11741022235L,225390779647L,4508109360985L,93665093491381L,2016669357747667L,44905700922069463L,1032419000661778213L,BigInteger.Parse("24472819932819733957"),BigInteger.Parse("597384952530618840715"),BigInteger.Parse("15000294032677574361955"),BigInteger.Parse("387082666821619977435277"),BigInteger.Parse("10256260095368150955828565"),BigInteger.Parse("278811213889895147327704519"),BigInteger.Parse("7770474960716476086765483619") };
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
public class A291814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291814Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291814.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A291814.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291814Inst Instance=new A291814Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291815
{
public static readonly BigInteger[] Value={ 1L,1L,9L,109L,1569L,25481L,454105L,8730373L,178996865L,3881556561L,88477557289L,2109927671453L,52443846331297L,1354646602217945L,36275862587452281L,1005099719255707829L,BigInteger.Parse("28765965099599741953"),BigInteger.Parse("849204340574458575777"),BigInteger.Parse("25827102287376124267593"),BigInteger.Parse("808349897942417046805197"),BigInteger.Parse("26011340193853765710238241"),BigInteger.Parse("859773626049480606121078057"),BigInteger.Parse("29168437337569276216572259097") };
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
public class A291815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291815Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291815.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A291815.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291815Inst Instance=new A291815Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291816
{
public static readonly BigInteger[] Value={ 1L,2L,16L,182L,2524L,39992L,699520L,13231034L,266985280L,5694001172L,127481465536L,2981125793144L,72532301230672L,1830526849868000L,47802726801684544L,1289123410465365782L,BigInteger.Parse("35841130838977837348"),BigInteger.Parse("1025903099063974343984"),BigInteger.Parse("30195807234087904770952"),BigInteger.Parse("912951678159786641659796"),BigInteger.Parse("28327442752528049524839856"),BigInteger.Parse("901289532361030971832330544"),BigInteger.Parse("29382621186595702051011638128") };
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
public class A291816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291816Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291816.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A291816.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291816Inst Instance=new A291816Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291817
{
public static readonly BigInteger[] Value={ 1L,4L,40L,580L,10312L,209752L,4707952L,114128308L,2946787192L,80268150808L,2290811949904L,68149759850680L,2105074730357968L,67308231895605520L,2222306773263886624L,BigInteger.Parse("75615701295449074084"),BigInteger.Parse("2647156154616207962920"),BigInteger.Parse("95215874465318554556776"),BigInteger.Parse("3514739264129342710455184"),BigInteger.Parse("133012394550946993742673304"),BigInteger.Parse("5156112210399927390763631056"),BigInteger.Parse("204570581814658024128260509360") };
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
public class A291817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291817Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291817.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A291817.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291817Inst Instance=new A291817Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291818
{
public static readonly BigInteger[] Value={ 1L,3L,33L,519L,9969L,218907L,5307201L,139123215L,3889995297L,114928234611L,3563543673825L,115375173490839L,3885328265571345L,135675583665864843L,4900856792035006593L,BigInteger.Parse("182756242210436579871"),BigInteger.Parse("7023982500750575903553"),BigInteger.Parse("277842871320960134512611"),BigInteger.Parse("11297961688442941015761825"),BigInteger.Parse("471773677417286920645721895"),BigInteger.Parse("20211597594930636918024401457"),BigInteger.Parse("887652829316087359743197592315") };
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
public class A291818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291818Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291818.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A291818.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291818Inst Instance=new A291818Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019870
{
public static readonly long[] Value={ 8L,7L,4L,6L,1L,9L,7L,0L,7L,1L,3L,9L,3L,9L,5L,8L,0L,0L,2L,8L,4L,6L,3L,6L,9L,5L,8L,6L,6L,1L,0L,7L,9L,5L,0L,6L,8L,5L,6L,3L,0L,6L,3L,8L,5L,1L,1L,3L,2L,1L,0L,2L,7L,8L,4L,2L,7L,6L,1L,8L,0L,7L,3L,3L,9L,2L,0L,7L,6L,4L,0L,7L,4L,0L,1L,6L,1L,0L,0L,1L,0L,5L,9L,1L,6L,6L,1L,0L,3L,7L,7L,8L,8L,3L,6L,3L,8L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019870Inst : IEnumerable<long>
{
public static readonly long[] Value=A019870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019870.Bytes);
public long this[int i]=>Value[i];

public static A019870Inst Instance=new A019870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019871
{
public static readonly long[] Value={ 8L,8L,2L,9L,4L,7L,5L,9L,2L,8L,5L,8L,9L,2L,6L,9L,4L,2L,0L,3L,2L,1L,7L,1L,3L,6L,0L,3L,1L,5L,7L,1L,9L,3L,8L,6L,0L,8L,3L,5L,3L,6L,6L,3L,1L,9L,9L,9L,5L,4L,2L,2L,3L,0L,4L,7L,6L,8L,6L,7L,7L,2L,8L,0L,7L,0L,3L,9L,7L,2L,8L,2L,8L,1L,0L,2L,4L,6L,2L,4L,8L,2L,9L,9L,1L,7L,1L,6L,8L,0L,5L,0L,3L,7L,5L,6L,2L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019871Inst : IEnumerable<long>
{
public static readonly long[] Value=A019871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019871.Bytes);
public long this[int i]=>Value[i];

public static A019871Inst Instance=new A019871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019872
{
public static readonly long[] Value={ 8L,9L,1L,0L,0L,6L,5L,2L,4L,1L,8L,8L,3L,6L,7L,8L,6L,2L,3L,5L,9L,7L,0L,9L,5L,7L,1L,4L,1L,3L,6L,2L,6L,3L,1L,2L,7L,7L,0L,5L,1L,8L,5L,1L,9L,0L,3L,6L,0L,8L,8L,7L,4L,5L,4L,0L,5L,5L,2L,2L,2L,8L,4L,5L,2L,2L,4L,9L,2L,2L,7L,4L,1L,7L,6L,1L,3L,5L,2L,2L,4L,3L,7L,7L,9L,3L,8L,5L,8L,2L,7L,3L,4L,8L,6L,1L,4L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019872Inst : IEnumerable<long>
{
public static readonly long[] Value=A019872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019872.Bytes);
public long this[int i]=>Value[i];

public static A019872Inst Instance=new A019872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019873
{
public static readonly long[] Value={ 8L,9L,8L,7L,9L,4L,0L,4L,6L,2L,9L,9L,1L,6L,6L,9L,9L,2L,7L,8L,2L,2L,9L,5L,6L,7L,6L,6L,9L,5L,7L,8L,5L,3L,5L,4L,9L,2L,9L,9L,7L,3L,4L,1L,3L,8L,1L,8L,4L,2L,1L,8L,6L,9L,9L,3L,8L,1L,9L,6L,9L,6L,4L,4L,6L,1L,0L,4L,3L,0L,2L,7L,0L,9L,8L,9L,1L,4L,8L,9L,9L,9L,9L,1L,4L,8L,1L,5L,1L,3L,3L,9L,2L,2L,2L,3L,9L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019873Inst : IEnumerable<long>
{
public static readonly long[] Value=A019873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019873.Bytes);
public long this[int i]=>Value[i];

public static A019873Inst Instance=new A019873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019874
{
public static readonly long[] Value={ 9L,0L,6L,3L,0L,7L,7L,8L,7L,0L,3L,6L,6L,4L,9L,9L,6L,3L,2L,4L,2L,5L,5L,2L,6L,5L,6L,7L,5L,4L,3L,1L,6L,9L,8L,3L,2L,6L,7L,7L,1L,2L,6L,2L,5L,1L,7L,5L,8L,6L,4L,6L,8L,0L,8L,7L,1L,2L,9L,8L,4L,0L,8L,8L,2L,2L,6L,1L,8L,3L,8L,5L,9L,3L,6L,3L,6L,9L,4L,1L,1L,2L,9L,0L,3L,6L,3L,7L,0L,1L,0L,8L,5L,4L,5L,7L,7L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019874Inst : IEnumerable<long>
{
public static readonly long[] Value=A019874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019874.Bytes);
public long this[int i]=>Value[i];

public static A019874Inst Instance=new A019874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019875
{
public static readonly long[] Value={ 9L,1L,3L,5L,4L,5L,4L,5L,7L,6L,4L,2L,6L,0L,0L,8L,9L,5L,5L,0L,2L,1L,2L,7L,5L,7L,1L,9L,8L,5L,3L,1L,7L,1L,7L,7L,9L,4L,0L,8L,1L,0L,4L,5L,9L,3L,7L,7L,4L,7L,4L,5L,4L,5L,0L,6L,0L,9L,9L,9L,7L,8L,8L,0L,6L,5L,1L,1L,4L,8L,8L,2L,1L,0L,2L,6L,3L,1L,2L,7L,1L,6L,8L,1L,7L,8L,4L,0L,0L,0L,8L,9L,3L,2L,9L,9L,9L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019875Inst : IEnumerable<long>
{
public static readonly long[] Value=A019875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019875.Bytes);
public long this[int i]=>Value[i];

public static A019875Inst Instance=new A019875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019876
{
public static readonly long[] Value={ 9L,2L,0L,5L,0L,4L,8L,5L,3L,4L,5L,2L,4L,4L,0L,3L,2L,7L,3L,9L,6L,8L,9L,4L,7L,2L,3L,3L,0L,0L,4L,6L,1L,4L,2L,0L,2L,7L,9L,5L,0L,3L,2L,8L,0L,9L,7L,0L,2L,4L,0L,3L,0L,1L,2L,6L,2L,7L,0L,1L,7L,1L,1L,7L,8L,2L,9L,5L,3L,7L,9L,0L,0L,8L,7L,3L,1L,0L,3L,6L,5L,7L,5L,4L,5L,7L,3L,9L,7L,7L,6L,6L,2L,2L,6L,6L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019876Inst : IEnumerable<long>
{
public static readonly long[] Value=A019876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019876.Bytes);
public long this[int i]=>Value[i];

public static A019876Inst Instance=new A019876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019893
{
public static readonly long[] Value={ 9L,9L,4L,5L,2L,1L,8L,9L,5L,3L,6L,8L,2L,7L,3L,3L,3L,6L,9L,2L,2L,6L,9L,1L,9L,4L,4L,9L,8L,0L,5L,7L,0L,3L,8L,1L,5L,2L,0L,7L,9L,2L,0L,8L,8L,7L,0L,9L,3L,1L,9L,4L,2L,7L,3L,6L,6L,5L,5L,8L,8L,3L,3L,5L,7L,4L,3L,1L,6L,2L,5L,0L,6L,8L,6L,8L,9L,8L,3L,6L,2L,5L,7L,9L,3L,0L,6L,2L,2L,0L,3L,8L,3L,3L,6L,0L,9L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019893Inst : IEnumerable<long>
{
public static readonly long[] Value=A019893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019893.Bytes);
public long this[int i]=>Value[i];

public static A019893Inst Instance=new A019893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019894
{
public static readonly long[] Value={ 9L,9L,6L,1L,9L,4L,6L,9L,8L,0L,9L,1L,7L,4L,5L,5L,3L,2L,2L,9L,5L,0L,1L,0L,4L,0L,2L,4L,7L,3L,8L,8L,8L,0L,4L,6L,1L,8L,3L,5L,6L,2L,6L,7L,2L,6L,4L,5L,8L,5L,0L,9L,7L,4L,5L,2L,5L,4L,4L,2L,2L,7L,7L,3L,8L,0L,1L,1L,6L,7L,4L,9L,8L,3L,8L,2L,5L,1L,5L,9L,9L,6L,7L,4L,1L,8L,6L,3L,8L,6L,2L,5L,9L,6L,5L,1L,9L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019894Inst : IEnumerable<long>
{
public static readonly long[] Value=A019894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019894.Bytes);
public long this[int i]=>Value[i];

public static A019894Inst Instance=new A019894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019895
{
public static readonly long[] Value={ 9L,9L,7L,5L,6L,4L,0L,5L,0L,2L,5L,9L,8L,2L,4L,2L,4L,7L,6L,1L,3L,1L,6L,2L,6L,8L,0L,6L,4L,4L,2L,5L,5L,0L,2L,6L,3L,6L,9L,3L,7L,7L,6L,6L,0L,3L,8L,4L,2L,2L,1L,5L,3L,6L,2L,2L,5L,9L,9L,5L,6L,0L,8L,8L,9L,8L,2L,1L,9L,1L,8L,1L,4L,1L,1L,0L,8L,1L,8L,4L,3L,0L,8L,5L,2L,8L,9L,2L,1L,1L,6L,7L,5L,4L,7L,6L,0L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019895Inst : IEnumerable<long>
{
public static readonly long[] Value=A019895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019895.Bytes);
public long this[int i]=>Value[i];

public static A019895Inst Instance=new A019895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019896
{
public static readonly long[] Value={ 9L,9L,8L,6L,2L,9L,5L,3L,4L,7L,5L,4L,5L,7L,3L,8L,7L,3L,7L,8L,4L,4L,9L,2L,0L,5L,8L,4L,3L,9L,4L,3L,6L,5L,8L,0L,5L,9L,0L,9L,5L,2L,2L,9L,0L,7L,6L,7L,7L,8L,5L,5L,3L,2L,4L,4L,1L,4L,4L,1L,2L,5L,4L,8L,3L,1L,6L,4L,8L,9L,7L,3L,7L,3L,3L,4L,7L,8L,3L,1L,8L,6L,3L,5L,3L,3L,2L,0L,2L,8L,2L,3L,3L,2L,7L,5L,4L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019896Inst : IEnumerable<long>
{
public static readonly long[] Value=A019896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019896.Bytes);
public long this[int i]=>Value[i];

public static A019896Inst Instance=new A019896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019897
{
public static readonly long[] Value={ 9L,9L,9L,3L,9L,0L,8L,2L,7L,0L,1L,9L,0L,9L,5L,7L,3L,0L,0L,0L,6L,2L,4L,3L,4L,4L,0L,0L,4L,3L,9L,2L,9L,9L,6L,4L,4L,9L,5L,2L,3L,6L,3L,0L,6L,6L,6L,9L,9L,9L,6L,7L,7L,3L,1L,0L,3L,9L,0L,0L,4L,0L,8L,0L,1L,0L,9L,4L,8L,6L,1L,8L,9L,1L,8L,3L,3L,2L,6L,5L,2L,5L,4L,9L,5L,0L,4L,5L,3L,4L,4L,6L,4L,2L,2L,3L,6L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019897Inst : IEnumerable<long>
{
public static readonly long[] Value=A019897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019897.Bytes);
public long this[int i]=>Value[i];

public static A019897Inst Instance=new A019897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019898
{
public static readonly long[] Value={ 9L,9L,9L,8L,4L,7L,6L,9L,5L,1L,5L,6L,3L,9L,1L,2L,3L,9L,1L,5L,7L,0L,1L,1L,5L,5L,8L,8L,1L,3L,9L,1L,4L,8L,5L,1L,6L,9L,2L,7L,4L,0L,3L,1L,0L,5L,8L,3L,1L,8L,5L,9L,3L,9L,6L,5L,8L,3L,2L,0L,7L,1L,4L,5L,1L,1L,5L,3L,9L,1L,8L,1L,1L,0L,3L,3L,3L,7L,2L,1L,5L,3L,9L,7L,2L,9L,9L,3L,9L,5L,2L,8L,8L,1L,1L,0L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019898Inst : IEnumerable<long>
{
public static readonly long[] Value=A019898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019898.Bytes);
public long this[int i]=>Value[i];

public static A019898Inst Instance=new A019898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019899
{
public static readonly long[] Value={ 0L,1L,7L,4L,5L,5L,0L,6L,4L,9L,2L,8L,2L,1L,7L,5L,8L,5L,7L,6L,5L,1L,2L,8L,8L,9L,5L,2L,1L,9L,7L,2L,7L,8L,2L,4L,3L,1L,4L,1L,0L,1L,5L,8L,8L,8L,3L,9L,8L,7L,5L,2L,7L,6L,9L,0L,4L,7L,1L,1L,4L,2L,7L,1L,0L,2L,1L,0L,4L,8L,5L,4L,8L,5L,6L,4L,6L,2L,3L,6L,7L,6L,2L,2L,8L,8L,9L,6L,8L,9L,1L,5L,8L,2L,9L,9L,2L,0L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019899Inst : IEnumerable<long>
{
public static readonly long[] Value=A019899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019899.Bytes);
public long this[int i]=>Value[i];

public static A019899Inst Instance=new A019899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019900
{
public static readonly long[] Value={ 0L,3L,4L,9L,2L,0L,7L,6L,9L,4L,9L,1L,7L,4L,7L,7L,3L,0L,5L,0L,0L,4L,0L,2L,6L,2L,5L,7L,7L,3L,7L,2L,5L,3L,1L,5L,8L,7L,9L,1L,7L,4L,2L,9L,7L,7L,8L,4L,6L,1L,5L,2L,5L,0L,5L,0L,4L,9L,7L,0L,0L,8L,3L,1L,9L,0L,3L,5L,2L,5L,3L,4L,1L,8L,7L,0L,5L,8L,9L,9L,8L,7L,1L,5L,5L,1L,4L,5L,1L,9L,6L,9L,5L,0L,5L,9L,7L,3L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019900Inst : IEnumerable<long>
{
public static readonly long[] Value=A019900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019900.Bytes);
public long this[int i]=>Value[i];

public static A019900Inst Instance=new A019900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019917
{
public static readonly long[] Value={ 3L,4L,4L,3L,2L,7L,6L,1L,3L,2L,8L,9L,6L,6L,5L,2L,4L,1L,9L,5L,7L,2L,6L,5L,8L,3L,9L,3L,8L,3L,1L,0L,8L,8L,6L,9L,7L,8L,4L,9L,5L,8L,1L,5L,1L,3L,0L,5L,3L,0L,2L,9L,0L,6L,9L,6L,2L,4L,4L,2L,5L,1L,9L,1L,1L,2L,8L,9L,5L,8L,6L,3L,7L,1L,2L,6L,3L,0L,7L,1L,9L,9L,2L,9L,4L,3L,0L,2L,2L,1L,8L,9L,2L,0L,0L,1L,4L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019917Inst : IEnumerable<long>
{
public static readonly long[] Value=A019917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019917.Bytes);
public long this[int i]=>Value[i];

public static A019917Inst Instance=new A019917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019918
{
public static readonly long[] Value={ 3L,6L,3L,9L,7L,0L,2L,3L,4L,2L,6L,6L,2L,0L,2L,3L,6L,1L,3L,5L,1L,0L,4L,7L,8L,8L,2L,7L,7L,6L,8L,3L,4L,0L,4L,3L,8L,9L,0L,4L,7L,1L,7L,8L,3L,7L,5L,3L,7L,3L,8L,1L,1L,4L,1L,9L,5L,6L,1L,2L,9L,8L,8L,7L,1L,3L,0L,7L,3L,9L,6L,2L,1L,0L,0L,4L,8L,9L,6L,3L,8L,8L,2L,4L,3L,8L,5L,4L,5L,7L,4L,0L,3L,1L,4L,6L,3L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019918Inst : IEnumerable<long>
{
public static readonly long[] Value=A019918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019918.Bytes);
public long this[int i]=>Value[i];

public static A019918Inst Instance=new A019918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019919
{
public static readonly long[] Value={ 3L,8L,3L,8L,6L,4L,0L,3L,5L,0L,3L,5L,4L,1L,5L,7L,9L,5L,9L,7L,1L,4L,4L,8L,4L,0L,8L,1L,0L,3L,2L,7L,0L,1L,2L,0L,9L,3L,9L,3L,6L,8L,2L,4L,7L,1L,6L,1L,4L,7L,6L,9L,2L,7L,3L,8L,3L,2L,0L,6L,5L,2L,7L,4L,2L,2L,4L,8L,3L,1L,9L,3L,8L,3L,3L,9L,2L,8L,9L,3L,5L,2L,2L,7L,8L,0L,6L,3L,3L,7L,4L,0L,8L,8L,4L,6L,1L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019919Inst : IEnumerable<long>
{
public static readonly long[] Value=A019919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019919.Bytes);
public long this[int i]=>Value[i];

public static A019919Inst Instance=new A019919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019920
{
public static readonly long[] Value={ 4L,0L,4L,0L,2L,6L,2L,2L,5L,8L,3L,5L,1L,5L,6L,8L,1L,1L,3L,2L,2L,3L,4L,8L,1L,4L,3L,5L,7L,9L,9L,1L,0L,2L,7L,1L,4L,7L,2L,3L,7L,9L,8L,2L,0L,0L,7L,4L,7L,8L,6L,6L,2L,8L,5L,7L,1L,5L,3L,7L,1L,4L,7L,8L,8L,9L,3L,8L,4L,6L,3L,3L,3L,9L,8L,4L,1L,0L,0L,4L,2L,7L,7L,0L,1L,1L,9L,7L,9L,6L,9L,8L,5L,9L,0L,3L,1L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019920Inst : IEnumerable<long>
{
public static readonly long[] Value=A019920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019920.Bytes);
public long this[int i]=>Value[i];

public static A019920Inst Instance=new A019920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019921
{
public static readonly long[] Value={ 4L,2L,4L,4L,7L,4L,8L,1L,6L,2L,0L,9L,6L,0L,4L,7L,4L,2L,0L,2L,3L,5L,3L,2L,0L,6L,2L,9L,4L,2L,5L,2L,0L,4L,0L,1L,0L,1L,8L,6L,5L,8L,6L,9L,8L,2L,4L,5L,0L,6L,0L,1L,1L,4L,0L,1L,0L,6L,7L,6L,2L,8L,2L,4L,5L,2L,7L,9L,8L,5L,3L,6L,6L,4L,5L,8L,1L,7L,7L,5L,8L,0L,6L,9L,0L,6L,9L,8L,5L,0L,3L,3L,4L,9L,5L,4L,0L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019921Inst : IEnumerable<long>
{
public static readonly long[] Value=A019921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019921.Bytes);
public long this[int i]=>Value[i];

public static A019921Inst Instance=new A019921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019922
{
public static readonly long[] Value={ 4L,4L,5L,2L,2L,8L,6L,8L,5L,3L,0L,8L,5L,3L,6L,1L,6L,3L,9L,2L,2L,3L,6L,7L,0L,3L,0L,6L,4L,5L,6L,6L,5L,7L,5L,4L,9L,8L,7L,4L,3L,0L,6L,7L,8L,4L,2L,7L,9L,2L,6L,5L,1L,6L,5L,5L,6L,2L,7L,0L,1L,8L,7L,0L,0L,0L,5L,2L,8L,5L,5L,7L,3L,3L,3L,7L,8L,8L,3L,4L,9L,5L,1L,0L,8L,1L,6L,3L,7L,5L,0L,4L,3L,5L,1L,8L,5L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019922Inst : IEnumerable<long>
{
public static readonly long[] Value=A019922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019922.Bytes);
public long this[int i]=>Value[i];

public static A019922Inst Instance=new A019922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019923
{
public static readonly long[] Value={ 4L,6L,6L,3L,0L,7L,6L,5L,8L,1L,5L,4L,9L,9L,8L,5L,9L,2L,8L,3L,0L,0L,0L,6L,1L,9L,4L,7L,9L,9L,5L,5L,9L,4L,5L,1L,3L,1L,1L,0L,6L,3L,0L,0L,8L,2L,5L,1L,3L,7L,5L,9L,1L,7L,8L,1L,0L,9L,3L,2L,4L,4L,8L,2L,3L,9L,2L,1L,8L,3L,8L,3L,3L,8L,8L,9L,0L,6L,5L,3L,6L,5L,5L,3L,1L,2L,6L,8L,2L,3L,2L,5L,7L,2L,7L,2L,8L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019923Inst : IEnumerable<long>
{
public static readonly long[] Value=A019923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019923.Bytes);
public long this[int i]=>Value[i];

public static A019923Inst Instance=new A019923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019924
{
public static readonly long[] Value={ 4L,8L,7L,7L,3L,2L,5L,8L,8L,5L,6L,5L,8L,6L,1L,4L,2L,2L,7L,7L,3L,1L,1L,1L,1L,2L,6L,6L,1L,6L,9L,6L,0L,4L,3L,3L,5L,9L,6L,6L,0L,0L,8L,2L,2L,0L,4L,0L,0L,2L,7L,0L,9L,0L,8L,2L,3L,9L,2L,1L,4L,2L,4L,6L,9L,5L,4L,5L,6L,0L,4L,0L,2L,8L,4L,8L,2L,1L,6L,3L,3L,8L,8L,3L,6L,2L,0L,4L,3L,5L,3L,8L,1L,2L,8L,7L,6L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019924Inst : IEnumerable<long>
{
public static readonly long[] Value=A019924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019924.Bytes);
public long this[int i]=>Value[i];

public static A019924Inst Instance=new A019924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019925
{
public static readonly long[] Value={ 5L,0L,9L,5L,2L,5L,4L,4L,9L,4L,9L,4L,4L,2L,8L,8L,1L,0L,5L,1L,3L,7L,0L,6L,9L,1L,1L,2L,5L,0L,6L,5L,7L,4L,8L,5L,8L,2L,4L,5L,2L,5L,9L,6L,6L,6L,4L,6L,3L,1L,7L,2L,6L,1L,5L,2L,0L,8L,3L,0L,9L,1L,8L,0L,6L,4L,7L,7L,1L,5L,3L,3L,7L,9L,2L,1L,2L,1L,8L,1L,0L,9L,9L,3L,8L,3L,6L,8L,8L,6L,1L,6L,2L,6L,4L,2L,1L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019925Inst : IEnumerable<long>
{
public static readonly long[] Value=A019925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019925.Bytes);
public long this[int i]=>Value[i];

public static A019925Inst Instance=new A019925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019926
{
public static readonly long[] Value={ 5L,3L,1L,7L,0L,9L,4L,3L,1L,6L,6L,1L,4L,7L,8L,7L,4L,8L,0L,7L,5L,9L,1L,5L,8L,7L,1L,8L,4L,0L,0L,5L,8L,9L,8L,0L,3L,0L,5L,4L,6L,4L,3L,1L,5L,1L,4L,2L,6L,5L,7L,0L,5L,0L,8L,5L,9L,2L,5L,5L,9L,6L,5L,0L,2L,8L,8L,0L,3L,7L,0L,6L,7L,7L,6L,5L,3L,1L,9L,9L,1L,4L,5L,2L,2L,9L,5L,9L,4L,9L,6L,2L,0L,4L,9L,1L,5L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019926Inst : IEnumerable<long>
{
public static readonly long[] Value=A019926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019926.Bytes);
public long this[int i]=>Value[i];

public static A019926Inst Instance=new A019926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019927
{
public static readonly long[] Value={ 5L,5L,4L,3L,0L,9L,0L,5L,1L,4L,5L,2L,7L,6L,8L,9L,1L,7L,8L,2L,0L,7L,6L,3L,0L,9L,2L,3L,3L,8L,1L,3L,4L,4L,0L,7L,6L,9L,3L,9L,1L,6L,6L,5L,0L,0L,1L,3L,1L,1L,1L,8L,3L,5L,9L,2L,9L,3L,6L,3L,1L,0L,3L,9L,1L,5L,5L,7L,8L,0L,0L,4L,8L,0L,0L,4L,3L,5L,2L,2L,3L,2L,8L,2L,0L,5L,7L,5L,3L,5L,0L,5L,5L,6L,5L,0L,9L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019927Inst : IEnumerable<long>
{
public static readonly long[] Value=A019927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019927.Bytes);
public long this[int i]=>Value[i];

public static A019927Inst Instance=new A019927Inst();

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