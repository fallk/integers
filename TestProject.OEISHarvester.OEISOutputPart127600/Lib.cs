using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A156905
{
public static readonly BigInteger[] Value={ 1L,1L,4L,184L,69568L,238298048L,10444630574080L,6785507740131518464L,BigInteger.Parse("63569094414156159478579200"),BigInteger.Parse("8469123482983731772132032235429888"),BigInteger.Parse("16127763920864889230376762555181238559440896") };
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
public class A156905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156905Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156905.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156905Inst Instance=new A156905Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156906
{
public static readonly long[] Value={ 1L,0L,1L,-1L,0L,0L,2L,-2L,-3L,3L,11L,-11L,-31L,31L,101L,-101L,-328L,328L,1102L,-1102L,-3760L,3760L,13036L,-13036L,-45750L,45750L,162262L,-162262L,-580638L,580638L,2093802L,-2093802L,-7601043L,7601043L,27756627L,-27756627L,-101888163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156906Inst : IEnumerable<long>
{
public static readonly long[] Value=A156906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156906.Bytes);
public long this[int i]=>Value[i];

public static A156906Inst Instance=new A156906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156907
{
public static readonly BigInteger[] Value={ 1L,1L,2L,18L,476L,38358L,11363548L,15060027956L,92500603618872L,2483766272252845670L,BigInteger.Parse("279689176516909339664044"),BigInteger.Parse("129570236404446129260308225372"),BigInteger.Parse("244562582019257683819447274838128648") };
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
public class A156907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156907Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156907.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156907Inst Instance=new A156907Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156908
{
public static readonly BigInteger[] Value={ 1L,1L,3L,72L,10899L,13775400L,185126087574L,25804839804745266L,BigInteger.Parse("34576186149297464460939"),BigInteger.Parse("431016348991655088520874274528"),BigInteger.Parse("49345807665910247245278532420622266770") };
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
public class A156908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156908Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156908.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156908Inst Instance=new A156908Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156909
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,10L,18L,70L,135L,566L,1134L,4972L,10206L,46098L,96228L,443946L,938223L,4397730L,9382230L,44523232L,95698746L,458639492L,991787004L,4791683932L,10413763542L,50652087010L,110546105292L,540758574440L,1184422556700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156909Inst : IEnumerable<long>
{
public static readonly long[] Value=A156909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156909.Bytes);
public long this[int i]=>Value[i];

public static A156909Inst Instance=new A156909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156910
{
public static readonly BigInteger[] Value={ 1L,2L,14L,268L,21462L,7872396L,12585797612L,84949155244024L,2379063526056509734L,BigInteger.Parse("273414369715003663482380"),BigInteger.Parse("128009001272184822673783879332"),BigInteger.Parse("242979321424122460096958142064785384") };
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
public class A156910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156910Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156910.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156910Inst Instance=new A156910Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156911
{
public static readonly BigInteger[] Value={ 1L,3L,54L,7470L,11326446L,173007630594L,25222890606413004L,BigInteger.Parse("34295263336258106333292"),BigInteger.Parse("429734207324188407742780371030"),BigInteger.Parse("49292144072318945019920850119049478578") };
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
public class A156911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156911Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156911.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156911Inst Instance=new A156911Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156912
{
public static readonly BigInteger[] Value={ 1L,-17L,-60L,11033L,35340L,-5897657L,-56300580L,53084692201L,168821419980L,-51212605971047L,-814290036255300L,603883438551408443L,5761078665923973420L,BigInteger.Parse("-2524662819650079910637"),BigInteger.Parse("-56199253474221473102820"),BigInteger.Parse("227336182671030705694314617"),BigInteger.Parse("722932337025828180552747660") };
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
public class A156912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156912Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156912.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156912Inst Instance=new A156912Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156913
{
public static readonly long[] Value={ 2L,4L,6L,11L,14L,21L,37L,75L,81L,176L,194L,310L,324L,332L,345L,399L,447L,612L,1122L,1209L,1614L,1874L,1921L,2186L,2329L,2482L,2509L,2874L,2940L,2975L,3230L,3611L,4185L,4650L,4923L,5172L,5248L,5543L,5587L,5673L,5714L,5764L,6038L,6078L,6250L,6430L,6976L,7023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156913Inst : IEnumerable<long>
{
public static readonly long[] Value=A156913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156913.Bytes);
public long this[int i]=>Value[i];

public static A156913Inst Instance=new A156913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156914
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,6L,1L,4L,35L,20L,1L,5L,130L,1395L,70L,1L,6L,357L,33880L,200787L,252L,1L,7L,806L,376805L,75913222L,109221651L,924L,1L,8L,1591L,2558556L,6221613541L,1506472167928L,230674393235L,3432L,1L,9L,2850L,12485095L,200525284806L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156914Inst : IEnumerable<long>
{
public static readonly long[] Value=A156914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156914.Bytes);
public long this[int i]=>Value[i];

public static A156914Inst Instance=new A156914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156915
{
public static readonly long[] Value={ 4L,1L,2L,3L,4L,1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,1L,1L,2L,1L,1L,2L,1L,2L,3L,1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,2L,3L,1L,1L,1L,2L,1L,1L,2L,1L,2L,3L,1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,2L,3L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156915Inst : IEnumerable<long>
{
public static readonly long[] Value=A156915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156915.Bytes);
public long this[int i]=>Value[i];

public static A156915Inst Instance=new A156915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156916
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,1L,1L,35L,35L,1L,1L,155L,775L,155L,1L,1L,651L,14415L,14415L,651L,1L,1L,2667L,248031L,1098423L,248031L,2667L,1L,1L,10795L,4112895L,76499847L,76499847L,4112895L,10795L,1L,1L,43435L,66982975L,5104102695L,21437231319L,5104102695L,66982975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156916Inst : IEnumerable<long>
{
public static readonly long[] Value=A156916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156916.Bytes);
public long this[int i]=>Value[i];

public static A156916Inst Instance=new A156916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156917
{
public static readonly long[] Value={ 1L,1L,1L,1L,40L,1L,1L,1210L,1210L,1L,1L,33880L,1024870L,33880L,1L,1L,925771L,784128037L,784128037L,925771L,1L,1L,25095280L,580812061522L,16262737722616L,580812061522L,25095280L,1L,1L,678468820L,425659125229240L,325671796712891524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156917Inst : IEnumerable<long>
{
public static readonly long[] Value=A156917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156917.Bytes);
public long this[int i]=>Value[i];

public static A156917Inst Instance=new A156917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156918
{
public static readonly long[] Value={ 1L,1L,-1L,1L,1L,-6L,7L,-2L,1L,1L,-23L,46L,-47L,26L,-3L,1L,1L,-76L,306L,-536L,459L,-232L,82L,-4L,1L,1L,-237L,1919L,-5046L,6965L,-5995L,3109L,-958L,247L,-5L,1L,1L,-722L,11265L,-44634L,91730L,-113538L,90417L,-49398L,17778L,-3630L,737L,-6L,1L,1L,-2179L,62836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156918Inst : IEnumerable<long>
{
public static readonly long[] Value=A156918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156918.Bytes);
public long this[int i]=>Value[i];

public static A156918Inst Instance=new A156918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156919
{
public static readonly long[] Value={ 1L,2L,1L,4L,10L,1L,8L,60L,36L,1L,16L,296L,516L,116L,1L,32L,1328L,5168L,3508L,358L,1L,64L,5664L,42960L,64240L,21120L,1086L,1L,128L,23488L,320064L,900560L,660880L,118632L,3272L,1L,256L,95872L,2225728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156919Inst : IEnumerable<long>
{
public static readonly long[] Value=A156919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156919.Bytes);
public long this[int i]=>Value[i];

public static A156919Inst Instance=new A156919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156920
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,15L,18L,1L,1L,37L,129L,58L,1L,1L,83L,646L,877L,179L,1L,1L,177L,2685L,8030L,5280L,543L,1L,1L,367L,10002L,56285L,82610L,29658L,1636L,1L,1L,749L,34777L,335162L,919615L,756218L,159742L,4916L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156920Inst : IEnumerable<long>
{
public static readonly long[] Value=A156920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156920.Bytes);
public long this[int i]=>Value[i];

public static A156920Inst Instance=new A156920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156921
{
public static readonly long[] Value={ 1L,1L,1L,1L,-6L,1L,7L,-79L,119L,126L,-270L,1L,28L,-515L,1654L,8689L,-65864L,142371L,-82242L,-99090L,113400L,1L,86L,-2255L,5784L,300930L,-3904584L,20663714L,-41517272L,-80232259L,657717054L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156921Inst : IEnumerable<long>
{
public static readonly long[] Value=A156921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156921.Bytes);
public long this[int i]=>Value[i];

public static A156921Inst Instance=new A156921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156922
{
public static readonly long[] Value={ 1L,15L,129L,877L,5280L,29658L,159742L,838038L,4323003L,22057825L,111750519L,563535483L,2833221970L,14216330916L,71243079660L,356731958812L,1785306330981L,8931761831331L,44675371382365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156922Inst : IEnumerable<long>
{
public static readonly long[] Value=A156922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156922.Bytes);
public long this[int i]=>Value[i];

public static A156922Inst Instance=new A156922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156923
{
public static readonly long[] Value={ 1L,37L,646L,8030L,82610L,756218L,6411720L,51586344L,400011435L,3020658295L,22373863774L,163379472214L,1180488191108L,8462445970580L,60305767988960L,427848087263712L,3025286818472661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156923Inst : IEnumerable<long>
{
public static readonly long[] Value=A156923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156923.Bytes);
public long this[int i]=>Value[i];

public static A156923Inst Instance=new A156923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156924
{
public static readonly long[] Value={ 1L,83L,2685L,56285L,919615L,12813843L,160206627L,1854550395L,20291056470L,212826091180L,2161547322134L,21414479565774L,208076662576370L,1991164206775450L,18825064380813450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156924Inst : IEnumerable<long>
{
public static readonly long[] Value=A156924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156924.Bytes);
public long this[int i]=>Value[i];

public static A156924Inst Instance=new A156924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156925
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,-11L,-6L,1L,38L,-108L,-242L,839L,-444L,-180L,1L,144L,-425L,-7382L,48451L,-96764L,-2559L,257002L,-312444L,88344L,30240L,1L,487L,720L,-130472L,1277794L,-4193514L,-6504496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156925Inst : IEnumerable<long>
{
public static readonly long[] Value=A156925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156925.Bytes);
public long this[int i]=>Value[i];

public static A156925Inst Instance=new A156925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156926
{
public static readonly BigInteger[] Value={ 1L,2L,-8L,-96L,4608L,1105920L,-1592524800L,-16052649984000L,1294485694709760000L,BigInteger.Parse("939485937792555417600000"),BigInteger.Parse("-6818413142123250198773760000000") };
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
public class A156926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156926Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156926.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156926Inst Instance=new A156926Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156927
{
public static readonly long[] Value={ 1L,1L,1L,-6L,29L,31L,-283L,245L,298L,-286L,-108L,119L,-3106L,29469L,-104585L,-220481L,3601363L,-15487305L,34949165L,-39821950L,4356011L,46881744L,-51274736L,9005908L,14663472L,-5205168L,-1456704L,-20736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156927Inst : IEnumerable<long>
{
public static readonly long[] Value=A156927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156927.Bytes);
public long this[int i]=>Value[i];

public static A156927Inst Instance=new A156927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156928
{
public static readonly long[] Value={ 1L,7L,28L,86L,227L,545L,1230L,2664L,5613L,11611L,23728L,48106L,97031L,195077L,391394L,784284L,1570353L,3142815L,6288100L,12579070L,25161451L,50326697L,100657718L,201320336L,402646197L,805298595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156928Inst : IEnumerable<long>
{
public static readonly long[] Value=A156928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156928.Bytes);
public long this[int i]=>Value[i];

public static A156928Inst Instance=new A156928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156929
{
public static readonly long[] Value={ -6L,-79L,-515L,-2255L,-7321L,-17280L,-20052L,73530L,683280L,3482667L,14574887L,55023247L,194872885L,661036370L,2174736558L,6996176016L,22133771190L,69145507605L,213941135265L,657095902685L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156929Inst : IEnumerable<long>
{
public static readonly long[] Value=A156929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156929.Bytes);
public long this[int i]=>Value[i];

public static A156929Inst Instance=new A156929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156930
{
public static readonly long[] Value={ 119L,1654L,5784L,-57421L,-974120L,-8191112L,-51264392L,-266367722L,-1204269647L,-4832097594L,-17187443308L,-52433219783L,-120342975558L,-58288009528L,1603731045044L,13940518848356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156930Inst : IEnumerable<long>
{
public static readonly long[] Value=A156930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156930.Bytes);
public long this[int i]=>Value[i];

public static A156930Inst Instance=new A156930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156931
{
public static readonly long[] Value={ 126L,8689L,300930L,5663483L,69028169L,613038531L,4234224501L,23275739871L,98332765273L,250304681662L,-554375755759L,-13379311589392L,-119762221369238L,-826135093245122L,-4949174987335110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156931Inst : IEnumerable<long>
{
public static readonly long[] Value=A156931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156931.Bytes);
public long this[int i]=>Value[i];

public static A156931Inst Instance=new A156931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156932
{
public static readonly BigInteger[] Value={ 1L,2L,-80L,-107520L,10218700800L,128549621071872000L,BigInteger.Parse("-362522272186301939712000000"),BigInteger.Parse("-359926496710320918207041372160000000000"),BigInteger.Parse("186528815537358278677575816954481496555520000000000000") };
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
public class A156932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156932Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156932.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156932Inst Instance=new A156932Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156933
{
public static readonly long[] Value={ 1L,1L,1L,-11L,156L,-627L,736L,591L,-1116L,-369L,-6L,106L,-2772L,76070L,-1087552L,8632650L,-40358780L,106452214L,-99774996L,-284430514L,1125952500L,-1581820542L,737716032L,414532350L,-357790500L,-81870750L,-1275750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156933Inst : IEnumerable<long>
{
public static readonly long[] Value=A156933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156933.Bytes);
public long this[int i]=>Value[i];

public static A156933Inst Instance=new A156933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156934
{
public static readonly long[] Value={ 1L,8L,38L,144L,487L,1552L,4796L,14592L,44061L,132568L,398210L,1195280L,3586659L,10760992L,32284216L,96854144L,290564217L,871694760L,2615086750L,7845263120L,23535792671L,70607381808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156934Inst : IEnumerable<long>
{
public static readonly long[] Value=A156934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156934.Bytes);
public long this[int i]=>Value[i];

public static A156934Inst Instance=new A156934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156935
{
public static readonly long[] Value={ -11L,-108L,-425L,720L,25678L,255048L,1901298L,12339600L,73794315L,418519612L,2289264465L,12207642976L,63925371180L,330387702160L,1691454191604L,8600517968736L,43516016460465L,219401923888740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156935Inst : IEnumerable<long>
{
public static readonly long[] Value=A156935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156935.Bytes);
public long this[int i]=>Value[i];

public static A156935Inst Instance=new A156935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156936
{
public static readonly long[] Value={ -6L,-242L,-7382L,-130472L,-1594852L,-15166900L,-119173924L,-788897224L,-4270968154L,-15821839894L,13226522262L,1056215331024L,14319250065624L,147391347765784L,1340374086462424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156936Inst : IEnumerable<long>
{
public static readonly long[] Value=A156936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156936.Bytes);
public long this[int i]=>Value[i];

public static A156936Inst Instance=new A156936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156937
{
public static readonly long[] Value={ 839L,48451L,1277794L,20499983L,217367668L,1310255037L,-3988076346L,-248575701031L,-4423141531241L,-58198384719342L,-649357370614484L,-6449481786729030L,-58156975255481312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156937Inst : IEnumerable<long>
{
public static readonly long[] Value=A156937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156937.Bytes);
public long this[int i]=>Value[i];

public static A156937Inst Instance=new A156937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156938
{
public static readonly BigInteger[] Value={ 1L,2L,-640L,-55050240L,2678771102515200L,BigInteger.Parse("138029104604220676374528000"),BigInteger.Parse("-12755118515091679234002154772496384000000"),BigInteger.Parse("-3319735985081076411622842555075338617937492705280000000000") };
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
public class A156938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156938Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156938.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156938Inst Instance=new A156938Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156939
{
public static readonly long[] Value={ 1L,1L,1L,1L,15L,1L,1L,155L,155L,1L,1L,1395L,14415L,1395L,1L,1L,11811L,1098423L,1098423L,11811L,1L,1L,97155L,76499847L,688498623L,76499847L,97155L,1L,1L,788035L,5104102695L,388932625359L,388932625359L,5104102695L,788035L,1L,1L,6347715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156939Inst : IEnumerable<long>
{
public static readonly long[] Value=A156939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156939.Bytes);
public long this[int i]=>Value[i];

public static A156939Inst Instance=new A156939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156940
{
public static readonly BigInteger[] Value={ 13L,19L,43L,139L,523L,32779L,8388619L,536870923L,2147483659L,36028797018963979L,BigInteger.Parse("2361183241434822606859"),BigInteger.Parse("151115727451828646838283"),BigInteger.Parse("254629497041810760783555711051172270131433549208242031329517556169297662470417088272924683") };
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
public class A156940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156940Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156940.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156940Inst Instance=new A156940Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156941
{
public static readonly BigInteger[] Value={ 1L,-15L,-76L,10215L,45980L,-5490375L,-73409236L,49447113495L,220167188060L,-47706250419225L,-1061972390305396L,562541361966308805L,7513441220176839740L,BigInteger.Parse("-2351825254027652790675"),BigInteger.Parse("-73293547498840521969556"),BigInteger.Parse("211772841767473901111735175"),BigInteger.Parse("942828841482814629497877020") };
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
public class A156941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156941Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156941.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156941Inst Instance=new A156941Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156942
{
public static readonly long[] Value={ 11025L,99225L,245025L,275625L,342225L,540225L,893025L,1334025L,1863225L,2205225L,2480625L,3080025L,3186225L,3980025L,4601025L,4862025L,5832225L,6125625L,6890625L,7868025L,8037225L,8555625L,9272025L,9828225L,10595025L,10989225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156942Inst : IEnumerable<long>
{
public static readonly long[] Value=A156942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156942.Bytes);
public long this[int i]=>Value[i];

public static A156942Inst Instance=new A156942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156943
{
public static readonly long[] Value={ 81162081L,138791961L,173369889L,441882441L,730458729L,1091179089L,1249127649L,1524043521L,1560329001L,1744649361L,2286465489L,2606204601L,3255501249L,3976941969L,4770526761L,5567099769L,6574128561L,6800806089L,7584145569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156943Inst : IEnumerable<long>
{
public static readonly long[] Value=A156943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156943.Bytes);
public long this[int i]=>Value[i];

public static A156943Inst Instance=new A156943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156944
{
public static readonly long[] Value={ 8L,1L,2L,7L,8L,7L,2L,7L,8L,7L,8L,2L,2L,8L,8L,2L,8L,1L,2L,1L,8L,8L,8L,7L,1L,8L,1L,2L,1L,2L,8L,8L,8L,8L,8L,2L,1L,1L,2L,1L,8L,8L,1L,8L,2L,1L,8L,2L,2L,2L,2L,2L,2L,1L,8L,2L,8L,8L,2L,8L,1L,8L,8L,1L,1L,8L,8L,8L,1L,8L,8L,1L,8L,1L,2L,1L,2L,8L,1L,2L,2L,8L,2L,1L,2L,1L,7L,8L,2L,1L,7L,2L,8L,2L,2L,8L,8L,8L,8L,1L,8L,8L,1L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156944Inst : IEnumerable<long>
{
public static readonly long[] Value=A156944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156944.Bytes);
public long this[int i]=>Value[i];

public static A156944Inst Instance=new A156944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156945
{
public static readonly long[] Value={ 1L,4L,12L,36L,108L,314L,906L,2576L,7280L,20352L,56664L,156570L,431238L,1180968L,3225940L,8773036L,23809148L,64388402L,173829458L,467950860L,1257901236L,3373450744L,9035758992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156945Inst : IEnumerable<long>
{
public static readonly long[] Value=A156945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156945.Bytes);
public long this[int i]=>Value[i];

public static A156945Inst Instance=new A156945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156946
{
public static readonly long[] Value={ 1L,4L,12L,36L,108L,324L,952L,2800L,8132L,23608L,67884L,195132L,556932L,1588836L,4507524L,12782560L,36088224L,101845032L,286372148L,804930196L,2255624360L,6318588308L,17654567968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156946Inst : IEnumerable<long>
{
public static readonly long[] Value=A156946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156946.Bytes);
public long this[int i]=>Value[i];

public static A156946Inst Instance=new A156946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156947
{
public static readonly BigInteger[] Value={ 1L,-13L,-90L,9217L,55710L,-4981093L,-89140770L,44888581049L,267408471870L,-43311229541203L,-1289870510004450L,510720217693590307L,9125841248810815230L,BigInteger.Parse("-2135177639698459001113"),BigInteger.Parse("-89022519968229449751330"),BigInteger.Parse("192264573569779283298436633"),BigInteger.Parse("1145162226463236921601433790") };
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
public class A156947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156947Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156947.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156947Inst Instance=new A156947Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156948
{
public static readonly BigInteger[] Value={ 1L,-11L,-102L,8063L,64362L,-4379771L,-103203702L,39494514631L,309665666922L,-38109468665741L,-1493739282968502L,449385406951534493L,10568242939834352682UL,BigInteger.Parse("-1878755744945825245511"),BigInteger.Parse("-103093170045575823968502"),BigInteger.Parse("169174780534960399488076007"),BigInteger.Parse("1326163404061745395490961642") };
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
public class A156948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156948Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156948.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156948Inst Instance=new A156948Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156949
{
public static readonly BigInteger[] Value={ 1L,-9L,-112L,6777L,71792L,-3697929L,-115338832L,33365774889L,346152459632L,-32197909552119L,-1669781464441552L,379679538201687387L,11813777423859564272UL,BigInteger.Parse("-1587336251116141480509"),BigInteger.Parse("-115243388514684566005072"),BigInteger.Parse("142933582086486567666092793"),BigInteger.Parse("1482460665337857454238617712") };
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
public class A156949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156949Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156949.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156949Inst Instance=new A156949Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156950
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,21L,21L,1L,1L,315L,2205L,315L,1L,1L,9765L,1025325L,1025325L,9765L,1L,1L,615195L,2002459725L,30036895875L,2002459725L,615195L,1L,1L,78129765L,16021680259725L,7450081320772125L,7450081320772125L,16021680259725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156950Inst : IEnumerable<long>
{
public static readonly long[] Value=A156950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156950.Bytes);
public long this[int i]=>Value[i];

public static A156950Inst Instance=new A156950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156951
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,4L,1L,1L,52L,52L,1L,1L,2080L,27040L,2080L,1L,1L,251680L,130873600L,130873600L,251680L,1L,1L,91611520L,5764196838400L,230567873536000L,5764196838400L,91611520L,1L,1L,100131391360L,2293297240551116800L,BigInteger.Parse("11099558644267405312000") };
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
public class A156951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156951Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156951.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156951Inst Instance=new A156951Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156952
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,5L,1L,1L,105L,105L,1L,1L,8925L,187425L,8925L,1L,1L,3043425L,5432513625L,5432513625L,3043425L,1L,1L,4154275125L,2528644954460625L,214934821129153125L,2528644954460625L,4154275125L,1L,1L,22686496457625L,BigInteger.Parse("18849189581462430815625") };
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
public class A156952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156952Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156952.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156952Inst Instance=new A156952Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156953
{
public static readonly ulong[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,3L,6L,1L,1L,4L,63L,24L,1L,1L,5L,208L,19845L,120L,1L,1L,6L,525L,432640L,193786425L,720L,1L,1L,7L,1116L,4685625L,108886835200L,119216439727875L,5040L,1L,1L,8L,2107L,32381856L,14260348265625L,9975288480661504000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156953Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A156953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156953.Bytes);
public ulong this[int i]=>Value[i];

public static A156953Inst Instance=new A156953Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156954
{
public static readonly long[] Value={ 736L,2592L,11664L,15617L,15618L,15622L,15624L,15632L,15642L,15645L,15656L,15662L,15667L,15698L,17536L,27639L,32785L,39363L,39369L,45947L,46633L,46644L,46648L,46655L,46660L,46663L,117635L,117638L,117639L,117642L,117643L,117647L,117650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156954Inst : IEnumerable<long>
{
public static readonly long[] Value=A156954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156954.Bytes);
public long this[int i]=>Value[i];

public static A156954Inst Instance=new A156954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156955
{
public static readonly BigInteger[] Value={ 1L,-7L,-120L,5383L,77880L,-2948407L,-125323560L,26616731351L,376190322360L,-25686697799497L,-1814718336714600L,302901133224550693L,12839243232438424440UL,BigInteger.Parse("-1266347767699067305987"),BigInteger.Parse("-125246840316843588099240"),BigInteger.Parse("114029802259144841041647367"),BigInteger.Parse("1611142488785956248768600120") };
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
public class A156955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156955Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156955.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156955Inst Instance=new A156955Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156956
{
public static readonly BigInteger[] Value={ 1L,-5L,-126L,3905L,82530L,-2145125L,-132975486L,19373108665L,399220962210L,-18697127429075L,-1925850683171646L,220480432805990435L,13625538417469240290UL,BigInteger.Parse("-921769705038763619225"),BigInteger.Parse("-132917180658162380887806"),BigInteger.Parse("83001863806137706672499225"),BigInteger.Parse("1709811776348530909197556770") };
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
public class A156956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156956Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156956.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156956Inst Instance=new A156956Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156957
{
public static readonly BigInteger[] Value={ 1L,-3L,-130L,2367L,85670L,-1302843L,-138155290L,11769651399L,414816521990L,-11359381346253L,-2001108958082650L,133952753515990557L,14158016295416976710UL,BigInteger.Parse("-560020888895209456263"),BigInteger.Parse("-138111526163646868112410"),BigInteger.Parse("50427758398224287080561383"),BigInteger.Parse("1776630506678835462703293830") };
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
public class A156957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156957Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156957.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156957Inst Instance=new A156957Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156958
{
public static readonly BigInteger[] Value={ 1L,-1L,-132L,793L,87252L,-436921L,-140768892L,3947647721L,422687372052L,-3810109655911L,-2039091735266652L,44929891907903803L,14426758204028393652UL,BigInteger.Parse("-187839991797725112301"),BigInteger.Parse("-140733116432941105153212"),BigInteger.Parse("16914279751678940247668857"),BigInteger.Parse("1810353973870094177898260052") };
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
public class A156958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156958Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156958.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156958Inst Instance=new A156958Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156959
{
public static readonly BigInteger[] Value={ 1L,-11L,-23L,3421L,13777L,-3946811L,-23818823L,9662765101L,77747254177L,-40597653164651L,-408311621397623L,260621490978697981L,3145444161956190577L,BigInteger.Parse("-2372776776728647969691"),BigInteger.Parse("-33409916827040236064423"),BigInteger.Parse("29080297194139431470874061"),BigInteger.Parse("467960606621237943982982977") };
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
public class A156959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156959Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156959.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156959Inst Instance=new A156959Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156960
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,7L,0L,1L,28L,0L,35L,0L,1L,0L,868L,0L,155L,0L,1L,13888L,0L,18228L,0L,651L,0L,1L,0L,1763776L,0L,330708L,0L,2667L,0L,1L,112881664L,0L,149920960L,0L,5622036L,0L,10795L,0L,1L,0L,57682530304L,0L,10944230080L,0L,92672916L,0L,43435L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156960Inst : IEnumerable<long>
{
public static readonly long[] Value=A156960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156960.Bytes);
public long this[int i]=>Value[i];

public static A156960Inst Instance=new A156960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156961
{
public static readonly BigInteger[] Value={ 1L,-7L,-95L,2681L,63745L,-3151687L,-111008735L,7730428601L,362578577665L,-32485422829447L,-1904310174842975L,208548540123990521L,14670031692604944385UL,BigInteger.Parse("-1898693409680238225607"),BigInteger.Parse("-155820577900257936731615"),BigInteger.Parse("23270028476826775276304441"),BigInteger.Parse("2182522600557853423794875905") };
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
public class A156961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156961Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156961.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156961Inst Instance=new A156961Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156962
{
public static readonly BigInteger[] Value={ 1L,-5L,-119L,2035L,82705L,-2415125L,-144599399L,5930847715L,472496522785L,-24926507404325L,-2481730783765079L,160024612101360595L,BigInteger.Parse("19118345091815106865"),BigInteger.Parse("-1456918380045434844725"),BigInteger.Parse("-203069316072098631813959"),BigInteger.Parse("17855720431999071247540675"),BigInteger.Parse("2844318807040517472572410945") };
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
public class A156962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156962Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156962.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156962Inst Instance=new A156962Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156963
{
public static readonly BigInteger[] Value={ 1L,-1L,-143L,431L,102817L,-516961L,-180591983L,1271389391L,590431841857L,-5344434717121L,-3101366777446223L,34311221287283951L,BigInteger.Parse("23891962452055766497"),BigInteger.Parse("-312381736724957870881"),BigInteger.Parse("-253773444779195937916463"),BigInteger.Parse("3828493412657940540740111"),BigInteger.Parse("3554513595972161589740996737") };
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
public class A156963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156963Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156963.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156963Inst Instance=new A156963Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156964
{
public static readonly BigInteger[] Value={ 1L,-23L,-24L,15479L,15576L,-9687623L,-29218824L,102940546183L,103486546776L,-117323007156473L,-589722909687624L,1634481375256483829L,4929419295450077976L,BigInteger.Parse("-8073357213342644250323"),BigInteger.Parse("-56812867238364266156424"),BigInteger.Parse("858902064560832986854606391"),BigInteger.Parse("863451885970473825109609176") };
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
public class A156964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156964Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156964.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156964Inst Instance=new A156964Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156965
{
public static readonly BigInteger[] Value={ 1L,50L,625L,62500L,390625L,19531250L,244140625L,48828125000L,152587890625L,7629394531250L,95367431640625L,9536743164062500L,59604644775390625L,2980232238769531250L,BigInteger.Parse("37252902984619140625"),BigInteger.Parse("14901161193847656250000") };
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
public class A156965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156965Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156965.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156965Inst Instance=new A156965Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156966
{
public static readonly BigInteger[] Value={ 1L,-21L,-46L,15057L,30866L,-9455061L,-57971086L,100495971849L,205339018706L,-114539909228451L,-1170144295531726L,1595713259829366867L,9781097564521728146UL,BigInteger.Parse("-7881868435057254330441"),BigInteger.Parse("-112729760168857069885966"),BigInteger.Parse("838530133784555195034887913"),BigInteger.Parse("1713286617447636818870543186") };
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
public class A156966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156966Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156966.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156966Inst Instance=new A156966Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156967
{
public static readonly BigInteger[] Value={ 1L,-19L,-66L,14383L,45606L,-9072139L,-85798746L,96465054071L,303949428486L,-109950265218109L,-1732109504588826L,1531779510574716013L,14478519965111693766UL,BigInteger.Parse("-7566077728374159654679"),BigInteger.Parse("-166868834738568539817306"),BigInteger.Parse("804934080056408933685284887"),BigInteger.Parse("2536101790943662435702093446") };
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
public class A156967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156967Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156967.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156967Inst Instance=new A156967Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156968
{
public static readonly BigInteger[] Value={ 1L,-17L,-84L,13481L,59556L,-8545577L,-112260204L,90912029497L,397761489636L,-103626535205687L,-2266755281406924L,1443688519679357291L,BigInteger.Parse("18947604662519194116"),BigInteger.Parse("-7130965366001830205597"),BigInteger.Parse("-218376284532852816803244"),BigInteger.Parse("758643733974514895994516809"),BigInteger.Parse("3318921118181461068350664996") };
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
public class A156968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156968Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156968.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156968Inst Instance=new A156968Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156969
{
public static readonly BigInteger[] Value={ 1L,-13L,-114L,11089L,84246L,-7099573L,-159442794L,75615595913L,565170779766L,-86201878430083L,-3220924920652074L,1200951434499713299L,BigInteger.Parse("26923552251773317686"),BigInteger.Parse("-5931997467397699386793"),BigInteger.Parse("-310301408687038259694954"),BigInteger.Parse("631088957663311674250980841"),BigInteger.Parse("4716015573399911410144086006") };
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
public class A156969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156969Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156969.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156969Inst Instance=new A156969Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156970
{
public static readonly BigInteger[] Value={ 1L,-11L,-126L,9647L,94626L,-6204011L,-179424126L,66114780919L,636129238626L,-75375923279261L,-3625401753288126L,1050133719554404397L,BigInteger.Parse("30304630399267822626"),BigInteger.Parse("-5187050519671339819511"),BigInteger.Parse("-349269369828136076592126"),BigInteger.Parse("551836144209660122120221463"),BigInteger.Parse("5308257688755110915395846626") };
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
public class A156970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156970Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156970.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156970Inst Instance=new A156970Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156971
{
public static readonly long[] Value={ 41L,103L,151L,157L,167L,173L,191L,331L,349L,353L,359L,421L,479L,487L,619L,677L,853L,883L,967L,1297L,1427L,1429L,1483L,1627L,2017L,2081L,2141L,2273L,2333L,2389L,2549L,2591L,2609L,2621L,2683L,2689L,2777L,3119L,3169L,4139L,4231L,4253L,4297L,4447L,4519L,4621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156971Inst : IEnumerable<long>
{
public static readonly long[] Value=A156971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156971.Bytes);
public long this[int i]=>Value[i];

public static A156971Inst Instance=new A156971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156972
{
public static readonly long[] Value={ 1L,2L,6L,60L,840L,18720L,559440L,22196160L,1092631680L,65768371200L,4703596128000L,393785778355200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156972Inst : IEnumerable<long>
{
public static readonly long[] Value=A156972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156972.Bytes);
public long this[int i]=>Value[i];

public static A156972Inst Instance=new A156972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156973
{
public static readonly BigInteger[] Value={ 19L,8209L,2097169L,8589934609L,BigInteger.Parse("2417851639229258349412369"),BigInteger.Parse("680564733841876926926749214863536422929"),BigInteger.Parse("62165404551223330269422781018352605012557018849668464680057997111644937126566671941649") };
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
public class A156973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156973Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156973.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156973Inst Instance=new A156973Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156974
{
public static readonly BigInteger[] Value={ 31L,37L,61L,157L,541L,8221L,32797L,131101L,8388637L,134217757L,8589934621L,137438953501L,8796093022237L,9223372036854775837UL,BigInteger.Parse("590295810358705651741"),BigInteger.Parse("9444732965739290427421"),BigInteger.Parse("604462909807314587353117"),BigInteger.Parse("618970019642690137449562141"),BigInteger.Parse("166153499473114484112975882535043101"),BigInteger.Parse("170141183460469231731687303715884105757"),BigInteger.Parse("883423532389192164791648750371459257913741948437809479060803100646309917") };
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
public class A156974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156974Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156974.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156974Inst Instance=new A156974Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156975
{
public static readonly BigInteger[] Value={ 1L,-9L,-136L,8073L,103496L,-5212089L,-196570456L,55573042041L,697053187016L,-63361464672519L,-3972702272849176L,882755107903532043L,BigInteger.Parse("33207784951792412936"),BigInteger.Parse("-4360300872679510389549"),BigInteger.Parse("-382729142471362457294296"),BigInteger.Parse("463880547308775813391124937"),BigInteger.Parse("5816785406158147709767069256") };
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
public class A156975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156975Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156975.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156975Inst Instance=new A156975Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156976
{
public static readonly long[] Value={ 29L,31L,59L,71L,79L,229L,239L,251L,271L,331L,359L,379L,521L,571L,739L,751L,2221L,2239L,2251L,2339L,2351L,2371L,2521L,2531L,2539L,2551L,2579L,2729L,2731L,3221L,3229L,3251L,3259L,3271L,3329L,3331L,3359L,3371L,3529L,3539L,3559L,3571L,3739L,3779L,5231L,5279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156976Inst : IEnumerable<long>
{
public static readonly long[] Value=A156976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156976.Bytes);
public long this[int i]=>Value[i];

public static A156976Inst Instance=new A156976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156977
{
public static readonly long[] Value={ 32043L,32286L,33144L,35172L,35337L,35757L,35853L,37176L,37905L,38772L,39147L,39336L,40545L,42744L,43902L,44016L,45567L,45624L,46587L,48852L,49314L,49353L,50706L,53976L,54918L,55446L,55524L,55581L,55626L,56532L,57321L,58413L,58455L,58554L,59403L,60984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156977Inst : IEnumerable<long>
{
public static readonly long[] Value=A156977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156977.Bytes);
public long this[int i]=>Value[i];

public static A156977Inst Instance=new A156977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156978
{
public static readonly BigInteger[] Value={ 1L,-7L,-144L,6391L,110736L,-4139527L,-210615984L,44156801927L,746983671696L,-50348004077497L,-4257350521714224L,701455303499302261L,BigInteger.Parse("35587232523796298256"),BigInteger.Parse("-3464786886497430699667"),BigInteger.Parse("-410153047417991816658864"),BigInteger.Parse("368609279555012342503240759"),BigInteger.Parse("6233578942096421437956406416") };
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
public class A156978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156978Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156978.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156978Inst Instance=new A156978Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156979
{
public static readonly long[] Value={ 23L,43L,67L,89L,113L,131L,157L,179L,197L,199L,223L,241L,263L,269L,311L,313L,331L,337L,353L,359L,373L,379L,397L,421L,449L,461L,463L,571L,593L,607L,641L,643L,661L,683L,719L,733L,739L,751L,809L,827L,829L,863L,881L,919L,937L,953L,971L,991L,1013L,1031L,1033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156979Inst : IEnumerable<long>
{
public static readonly long[] Value=A156979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156979.Bytes);
public long this[int i]=>Value[i];

public static A156979Inst Instance=new A156979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156980
{
public static readonly long[] Value={ 2L,13L,31L,53L,79L,97L,103L,163L,233L,251L,277L,349L,367L,383L,389L,433L,439L,457L,479L,503L,521L,547L,563L,569L,613L,619L,631L,653L,659L,673L,691L,709L,727L,839L,907L,929L,947L,983L,1063L,1069L,1151L,1223L,1249L,1283L,1289L,1423L,1429L,1447L,1481L,1511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156980Inst : IEnumerable<long>
{
public static readonly long[] Value=A156980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156980.Bytes);
public long this[int i]=>Value[i];

public static A156980Inst Instance=new A156980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156981
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,14L,19L,22L,29L,44L,77L,94L,264L,1414L,5477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156981Inst : IEnumerable<long>
{
public static readonly long[] Value=A156981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156981.Bytes);
public long this[int i]=>Value[i];

public static A156981Inst Instance=new A156981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156982
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,13L,15L,17L,23L,27L,33L,37L,43L,63L,69L,73L,79L,89L,117L,127L,239L,395L,409L,465L,837L,2543L,10465L,10837L,17005L,19285L,24749L,26473L,29879L,49197L,56673L,67119L,67689L,71007L,109393L,156403L,158757L,181913L,190945L,207865L,222943L,419637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156982Inst : IEnumerable<long>
{
public static readonly long[] Value=A156982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156982.Bytes);
public long this[int i]=>Value[i];

public static A156982Inst Instance=new A156982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156983
{
public static readonly BigInteger[] Value={ 23L,29L,37L,53L,149L,277L,2069L,32789L,65557L,524309L,17592186044437L,281474976710677L,2251799813685269L,4503599627370517L,2305843009213693973L,BigInteger.Parse("11692013098647223345629478661730264157247460343829") };
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
public class A156983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156983Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156983.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156983Inst Instance=new A156983Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156984
{
public static readonly long[] Value={ 1L,0L,2L,1L,1L,6L,2L,7L,8L,20L,9L,23L,47L,45L,70L,44L,121L,214L,281L,224L,252L,265L,719L,1312L,1602L,1554L,1050L,924L,1854L,5041L,9148L,11334L,10548L,8142L,4752L,3432L,14833L,40319L,73229L,90507L,84879L,63849L,41019L,21021L,12870L,133496L,362881L,659006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156984Inst : IEnumerable<long>
{
public static readonly long[] Value=A156984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156984.Bytes);
public long this[int i]=>Value[i];

public static A156984Inst Instance=new A156984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156985
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,4L,14L,4L,1L,1L,20L,175L,328L,175L,20L,1L,1L,72L,1708L,9784L,17190L,9784L,1708L,72L,1L,1L,232L,14189L,199616L,884498L,1431728L,884498L,199616L,14189L,232L,1L,1L,716L,108250L,3353948L,31986447L,115907544L,176287788L,115907544L,31986447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156985Inst : IEnumerable<long>
{
public static readonly long[] Value=A156985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156985.Bytes);
public long this[int i]=>Value[i];

public static A156985Inst Instance=new A156985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156986
{
public static readonly BigInteger[] Value={ 1L,2L,3L,384L,2027025L,BigInteger.Parse("10409396852733332453861621760000") };
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
public class A156986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156986Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156986.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156986Inst Instance=new A156986Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156987
{
public static readonly long[] Value={ 2357L,23357L,23557L,223577L,233357L,233557L,235577L,2235557L,2335577L,2355557L,22223557L,22233577L,22333357L,22335557L,22355777L,23333357L,222223357L,222233357L,222235777L,222333557L,222355577L,223335577L,223577777L,233357777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156987Inst : IEnumerable<long>
{
public static readonly long[] Value=A156987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156987.Bytes);
public long this[int i]=>Value[i];

public static A156987Inst Instance=new A156987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156988
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,2L,2L,1L,1L,2L,3L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,2L,2L,3L,2L,1L,2L,2L,1L,2L,2L,1L,2L,2L,2L,1L,3L,2L,2L,3L,1L,2L,1L,2L,1L,2L,3L,1L,2L,1L,2L,3L,1L,1L,1L,2L,2L,2L,2L,3L,2L,2L,1L,2L,3L,1L,3L,2L,1L,1L,2L,3L,2L,2L,3L,1L,3L,2L,2L,2L,2L,2L,2L,1L,3L,2L,2L,2L,2L,2L,2L,2L,1L,1L,2L,1L,2L,2L,1L,2L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156988Inst : IEnumerable<long>
{
public static readonly long[] Value=A156988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156988.Bytes);
public long this[int i]=>Value[i];

public static A156988Inst Instance=new A156988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156989
{
public static readonly long[] Value={ 1L,2L,6L,18L,52L,150L,450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156989Inst : IEnumerable<long>
{
public static readonly long[] Value=A156989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156989.Bytes);
public long this[int i]=>Value[i];

public static A156989Inst Instance=new A156989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156990
{
public static readonly BigInteger[] Value={ 1L,-3L,-154L,2799L,119966L,-1820523L,-228588514L,19431351543L,810907657406L,-22157451384093L,-4621797534474274L,308703302719636269L,BigInteger.Parse("38633760912291144446"),BigInteger.Parse("-1524818738952570521463"),BigInteger.Parse("-445265304377466491198434"),BigInteger.Parse("162221347544931591665536791"),BigInteger.Parse("6767221511370936096386145086") };
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
public class A156990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156990Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156990.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156990Inst Instance=new A156990Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156991
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,6L,0L,6L,24L,60L,0L,24L,120L,360L,840L,0L,120L,720L,2520L,6720L,15120L,0L,720L,5040L,20160L,60480L,151200L,332640L,0L,5040L,40320L,181440L,604800L,1663200L,3991680L,8648640L,0L,40320L,362880L,1814400L,6652800L,19958400L,51891840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156991Inst : IEnumerable<long>
{
public static readonly long[] Value=A156991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156991.Bytes);
public long this[int i]=>Value[i];

public static A156991Inst Instance=new A156991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156992
{
public static readonly long[] Value={ 1L,2L,2L,6L,12L,6L,24L,72L,72L,24L,120L,480L,720L,480L,120L,720L,3600L,7200L,7200L,3600L,720L,5040L,30240L,75600L,100800L,75600L,30240L,5040L,40320L,282240L,846720L,1411200L,1411200L,846720L,282240L,40320L,362880L,2903040L,10160640L,20321280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156992Inst : IEnumerable<long>
{
public static readonly long[] Value=A156992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156992.Bytes);
public long this[int i]=>Value[i];

public static A156992Inst Instance=new A156992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156993
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,6L,5L,9L,3L,2L,1L,4L,4L,2L,6L,1L,3L,2L,1L,3L,5L,3L,3L,2L,2L,1L,4L,14L,31L,25L,13L,23L,26L,8L,7L,19L,17L,4L,3L,2L,1L,11L,16L,9L,28L,14L,6L,11L,4L,3L,8L,12L,9L,19L,19L,16L,5L,3L,13L,2L,21L,18L,23L,8L,22L,4L,5L,12L,14L,5L,16L,13L,14L,1L,7L,118L,5L,7L,8L,2L,7L,5L,4L,3L,2L,3L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156993Inst : IEnumerable<long>
{
public static readonly long[] Value=A156993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156993.Bytes);
public long this[int i]=>Value[i];

public static A156993Inst Instance=new A156993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156994
{
public static readonly BigInteger[] Value={ 1L,-1L,-156L,937L,121836L,-609961L,-232238916L,6511231289L,823895988396L,-7424833305271L,-4695850684242276L,103444872822456427L,BigInteger.Parse("39252797974639532556"),BigInteger.Parse("-510958942368720753181"),BigInteger.Parse("-452399917462705756351236"),BigInteger.Parse("54359543181504300867805513"),BigInteger.Parse("6875654686564898985189950316") };
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
public class A156994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156994Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156994.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156994Inst Instance=new A156994Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156995
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,2L,6L,12L,9L,2L,24L,48L,40L,16L,2L,120L,240L,210L,100L,25L,2L,720L,1440L,1296L,672L,210L,36L,2L,5040L,10080L,9240L,5040L,1764L,392L,49L,2L,40320L,80640L,74880L,42240L,15840L,4032L,672L,64L,2L,362880L,725760L,680400L,393120L,154440L,42768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156995Inst : IEnumerable<long>
{
public static readonly long[] Value=A156995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156995.Bytes);
public long this[int i]=>Value[i];

public static A156995Inst Instance=new A156995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156996
{
public static readonly long[] Value={ -1L,2L,0L,0L,2L,1L,0L,3L,2L,2L,8L,4L,8L,2L,13L,30L,40L,20L,15L,2L,80L,192L,210L,152L,60L,24L,2L,579L,1344L,1477L,994L,469L,140L,35L,2L,4738L,10800L,11672L,7888L,3660L,1232L,280L,48L,2L,43387L,97434L,104256L,70152L,32958L,11268L,2856L,504L,63L,2L,439792L,976000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156996Inst : IEnumerable<long>
{
public static readonly long[] Value=A156996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156996.Bytes);
public long this[int i]=>Value[i];

public static A156996Inst Instance=new A156996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156997
{
public static readonly long[] Value={ 3L,6L,9L,12L,18L,24L,27L,36L,48L,54L,56L,60L,72L,81L,96L,108L,112L,120L,144L,162L,180L,192L,216L,224L,240L,243L,288L,300L,319L,324L,360L,384L,392L,399L,432L,448L,480L,486L,504L,540L,576L,600L,638L,648L,720L,728L,729L,768L,784L,798L,864L,896L,900L,957L,972L,1008L,1152L,1176L,1276L,1296L,1400L,1456L,1458L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156997Inst : IEnumerable<long>
{
public static readonly long[] Value=A156997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156997.Bytes);
public long this[int i]=>Value[i];

public static A156997Inst Instance=new A156997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156998
{
public static readonly long[] Value={ 302009L,370919L,448421L,461707L,480647L,492103L,507217L,542323L,561607L,604171L,619471L,623107L,645233L,648509L,668303L,682811L,710119L,736511L,745471L,753229L,783931L,809603L,815713L,872843L,873863L,922123L,948659L,963559L,979651L,1015207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156998Inst : IEnumerable<long>
{
public static readonly long[] Value=A156998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156998.Bytes);
public long this[int i]=>Value[i];

public static A156998Inst Instance=new A156998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156999
{
public static readonly long[] Value={ 302053L,370949L,448451L,461717L,480661L,492113L,507289L,542371L,561667L,604189L,619477L,623171L,645257L,648563L,668347L,682819L,710189L,736577L,745477L,753257L,783953L,809629L,815729L,872863L,873877L,922169L,948671L,963581L,979691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156999Inst : IEnumerable<long>
{
public static readonly long[] Value=A156999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156999.Bytes);
public long this[int i]=>Value[i];

public static A156999Inst Instance=new A156999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157000
{
public static readonly long[] Value={ 2L,3L,4L,2L,5L,5L,6L,9L,2L,7L,14L,7L,8L,20L,16L,2L,9L,27L,30L,9L,10L,35L,50L,25L,2L,11L,44L,77L,55L,11L,12L,54L,112L,105L,36L,2L,13L,65L,156L,182L,91L,13L,14L,77L,210L,294L,196L,49L,2L,15L,90L,275L,450L,378L,140L,15L,16L,104L,352L,660L,672L,336L,64L,2L,17L,119L,442L,935L,1122L,714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157000Inst : IEnumerable<long>
{
public static readonly long[] Value=A157000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157000.Bytes);
public long this[int i]=>Value[i];

public static A157000Inst Instance=new A157000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157001
{
public static readonly long[] Value={ 0L,1L,2L,5L,7L,11L,14L,21L,25L,32L,37L,47L,53L,63L,70L,85L,93L,106L,115L,132L,142L,158L,169L,191L,203L,222L,235L,259L,273L,295L,310L,341L,357L,382L,399L,430L,448L,476L,495L,532L,552L,583L,604L,642L,664L,698L,721L,767L,791L,828L,853L,898L,924L,964L,991L,1043L,1071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157001Inst : IEnumerable<long>
{
public static readonly long[] Value=A157001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157001.Bytes);
public long this[int i]=>Value[i];

public static A157001Inst Instance=new A157001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157002
{
public static readonly long[] Value={ 1L,0L,1L,2L,6L,17L,51L,156L,488L,1552L,5006L,16337L,53849L,179015L,599535L,2020924L,6851150L,23344138L,79902364L,274606264L,947240592L,3278404274L,11381240074L,39621423949L,138288477617L,483805404673L,1696318159457L,5959737806635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157002Inst : IEnumerable<long>
{
public static readonly long[] Value=A157002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157002.Bytes);
public long this[int i]=>Value[i];

public static A157002Inst Instance=new A157002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157003
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,27L,78L,234L,722L,2274L,7280L,23617L,77466L,256481L,856016L,2876940L,9728090L,33072228L,112974592L,387580856L,1334821448L,4613225722L,15994465796L,55615889745L,193904367362L,677709772035L,2374027931492L,8333765738127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157003Inst : IEnumerable<long>
{
public static readonly long[] Value=A157003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157003.Bytes);
public long this[int i]=>Value[i];

public static A157003Inst Instance=new A157003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157004
{
public static readonly long[] Value={ 1L,2L,6L,18L,58L,192L,650L,2232L,7746L,27096L,95376L,337404L,1198546L,4272308L,15273888L,54744268L,196646922L,707747988L,2551624304L,9213416524L,33313656888L,120604436624L,437112790668L,1585877246424L,5759085911154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157004Inst : IEnumerable<long>
{
public static readonly long[] Value=A157004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157004.Bytes);
public long this[int i]=>Value[i];

public static A157004Inst Instance=new A157004Inst();

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