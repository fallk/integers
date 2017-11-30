using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A277762
{
public static readonly long[] Value={ 0L,4L,17L,330L,3666L,46289L,560809L,6883464L,84161576L,1030163755L,12605295745L,154256946272L,1887655962034L,23099627259711L,282674025688925L,3459132503499606L,42330011144976582L,517999809756567289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277762Inst : IEnumerable<long>
{
public static readonly long[] Value=A277762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277762.Bytes);
public long this[int i]=>Value[i];

public static A277762Inst Instance=new A277762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277763
{
public static readonly BigInteger[] Value={ 0L,18L,204L,9741L,270291L,8971150L,280603511L,8946059000L,283436060320L,8998418743638L,285487168951921L,9059457397078866L,287466089870053015L,9121814912567142070L,BigInteger.Parse("289449332145382072648"),BigInteger.Parse("9184699258737221554558") };
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
public class A277763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277763Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277763.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277763.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277763Inst Instance=new A277763Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277764
{
public static readonly BigInteger[] Value={ 0L,80L,1989L,275018L,20049229L,1762881313L,145416104585L,12253138042478L,1025207978301185L,85977721285058269L,7204885193038036176L,BigInteger.Parse("603918178598058203435"),BigInteger.Parse("50616585384840289440801"),BigInteger.Parse("4242477668915521353604820") };
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
public class A277764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277764Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277764.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277764.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277764Inst Instance=new A277764Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277765
{
public static readonly BigInteger[] Value={ 0L,356L,21141L,7824415L,1487830718L,343944986355L,74591651561541L,16513537201433122L,3631417278822015869L,BigInteger.Parse("800314315609344769958"),BigInteger.Parse("176252542616326417994974"),BigInteger.Parse("38825002002696841996583880") };
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
public class A277765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277765Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277765.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277765.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277765Inst Instance=new A277765Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277766
{
public static readonly BigInteger[] Value={ 0L,1584L,220549L,221983169L,110036582827L,67079817376928L,38224184451654485L,BigInteger.Parse("22257182633194608078"),BigInteger.Parse("12869705874813306766481"),BigInteger.Parse("7458446559929491293690613"),BigInteger.Parse("4319259920844964071189461906"),BigInteger.Parse("2501924582698962860252708115060") };
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
public class A277766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277766Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277766.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277766.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277766Inst Instance=new A277766Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277767
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,4L,2L,0L,0L,18L,17L,14L,0L,0L,80L,204L,330L,56L,0L,0L,356L,1989L,9741L,3666L,284L,0L,0L,1584L,21141L,275018L,270291L,46289L,1304L,0L,0L,7048L,220549L,7824415L,20049229L,8971150L,560809L,6248L,0L,0L,31360L,2292380L,221983169L,1487830718L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277767Inst : IEnumerable<long>
{
public static readonly long[] Value=A277767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277767.Bytes);
public long this[int i]=>Value[i];

public static A277767Inst Instance=new A277767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277768
{
public static readonly long[] Value={ 0L,2L,17L,204L,1989L,21141L,220549L,2292380L,23911889L,249253583L,2597767946L,27078215723L,282249897665L,2942003150449L,30665850885332L,319644266438138L,3331797339053418L,34728844714392948L,361994612635214032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277768Inst : IEnumerable<long>
{
public static readonly long[] Value=A277768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277768.Bytes);
public long this[int i]=>Value[i];

public static A277768Inst Instance=new A277768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277769
{
public static readonly BigInteger[] Value={ 0L,14L,330L,9741L,275018L,7824415L,221983169L,6298326387L,178728649865L,5071423132367L,143902812077769L,4083281399156407L,115864087742823865L,3287671351656190808L,BigInteger.Parse("93288470977649320614"),BigInteger.Parse("2647082885606708742103") };
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
public class A277769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277769Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277769.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277769.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277769Inst Instance=new A277769Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277770
{
public static readonly BigInteger[] Value={ 0L,56L,3666L,270291L,20049229L,1487830718L,110036582827L,8144355400488L,602835463794197L,44616311792079721L,3302197502743906336L,BigInteger.Parse("244405001824291326112"),BigInteger.Parse("18089091210686721809130"),BigInteger.Parse("1338824653239265489456655") };
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
public class A277770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277770Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277770.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277770.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277770Inst Instance=new A277770Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277771
{
public static readonly BigInteger[] Value={ 0L,284L,46289L,8971150L,1762881313L,343944986355L,67079817376928L,13082674671680942L,2551870774231153918L,BigInteger.Parse("497725696443014836641"),BigInteger.Parse("97078962056423037413261"),BigInteger.Parse("18934823123149797267341357") };
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
public class A277771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277771Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277771.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277771.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277771Inst Instance=new A277771Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277772
{
public static readonly BigInteger[] Value={ 0L,1304L,560809L,280603511L,145416104585L,74591651561541L,38224184451654485L,BigInteger.Parse("19594056304528558357"),BigInteger.Parse("10045114847567207328081"),BigInteger.Parse("5149301096028551482379853"),BigInteger.Parse("2639661525564889493885834000"),BigInteger.Parse("1353158899116458615963424246675") };
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
public class A277772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277772Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277772.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277772.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277772Inst Instance=new A277772Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277773
{
public static readonly long[] Value={ 1L,0L,4L,3L,16L,15L,64L,47L,256L,191L,1024L,767L,4096L,2815L,16384L,11007L,65536L,44031L,262144L,176127L,1048576L,704511L,4194304L,2818047L,16777216L,11206655L,67108864L,44761087L,268435456L,178978815L,1073741824L,715849727L,4294967296L,2863398911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277773Inst : IEnumerable<long>
{
public static readonly long[] Value=A277773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277773.Bytes);
public long this[int i]=>Value[i];

public static A277773Inst Instance=new A277773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277774
{
public static readonly long[] Value={ 1L,0L,9L,7L,8L,5L,1L,0L,3L,9L,6L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277774Inst : IEnumerable<long>
{
public static readonly long[] Value=A277774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277774.Bytes);
public long this[int i]=>Value[i];

public static A277774Inst Instance=new A277774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277775
{
public static readonly long[] Value={ 8L,3L,7L,1L,1L,3L,2L,1L,2L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277775Inst : IEnumerable<long>
{
public static readonly long[] Value=A277775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277775.Bytes);
public long this[int i]=>Value[i];

public static A277775Inst Instance=new A277775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277776
{
public static readonly long[] Value={ 3L,5L,5L,7L,4L,11L,7L,9L,9L,11L,8L,13L,5L,7L,11L,13L,17L,19L,13L,15L,11L,19L,15L,17L,10L,23L,6L,29L,17L,19L,14L,25L,9L,11L,19L,21L,29L,31L,13L,29L,21L,23L,19L,26L,7L,17L,23L,25L,31L,41L,16L,35L,25L,27L,21L,34L,13L,15L,27L,29L,41L,43L,20L,37L,11L,19L,29L,31L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277776Inst : IEnumerable<long>
{
public static readonly long[] Value=A277776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277776.Bytes);
public long this[int i]=>Value[i];

public static A277776Inst Instance=new A277776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277777
{
public static readonly long[] Value={ 5L,7L,11L,9L,11L,13L,19L,15L,19L,17L,23L,29L,19L,25L,31L,29L,23L,26L,41L,35L,27L,34L,43L,37L,49L,55L,33L,51L,43L,35L,47L,41L,55L,49L,39L,43L,53L,71L,71L,69L,59L,67L,71L,64L,47L,61L,56L,79L,89L,51L,67L,79L,76L,55L,89L,73L,97L,77L,91L,59L,64L,69L,109L,83L,63L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277777Inst : IEnumerable<long>
{
public static readonly long[] Value=A277777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277777.Bytes);
public long this[int i]=>Value[i];

public static A277777Inst Instance=new A277777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277778
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,-1L,0L,0L,1L,0L,1L,2L,1L,-1L,-1L,0L,0L,-1L,0L,1L,1L,-1L,0L,-1L,1L,1L,2L,2L,1L,0L,-1L,-1L,-1L,0L,0L,1L,0L,-1L,-1L,-1L,0L,0L,1L,2L,1L,-1L,-1L,1L,0L,-2L,-1L,0L,1L,-1L,1L,0L,2L,1L,2L,1L,1L,1L,0L,0L,-1L,0L,-1L,-1L,-1L,0L,0L,-1L,0L,1L,1L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277778Inst : IEnumerable<long>
{
public static readonly long[] Value=A277778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277778.Bytes);
public long this[int i]=>Value[i];

public static A277778Inst Instance=new A277778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277779
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,12L,14L,15L,16L,22L,24L,30L,36L,42L,44L,48L,60L,63L,72L,80L,90L,96L,120L,156L,158L,160L,186L,192L,212L,214L,216L,222L,240L,288L,312L,420L,432L,468L,474L,480L,484L,618L,620L,624L,840L,942L,948L,960L,996L,1124L,1200L,1224L,1494L,1560L,1656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277779Inst : IEnumerable<long>
{
public static readonly long[] Value=A277779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277779.Bytes);
public long this[int i]=>Value[i];

public static A277779Inst Instance=new A277779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277780
{
public static readonly long[] Value={ 8L,16L,24L,32L,40L,48L,56L,27L,72L,80L,88L,96L,104L,112L,120L,54L,136L,144L,152L,160L,168L,176L,184L,81L,200L,208L,64L,224L,232L,240L,248L,108L,264L,272L,280L,288L,296L,304L,312L,135L,328L,336L,344L,352L,360L,368L,376L,162L,392L,400L,408L,416L,424L,128L,440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277780Inst : IEnumerable<long>
{
public static readonly long[] Value=A277780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277780.Bytes);
public long this[int i]=>Value[i];

public static A277780Inst Instance=new A277780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277781
{
public static readonly long[] Value={ 8L,4L,9L,16L,25L,36L,49L,27L,24L,80L,88L,18L,104L,112L,120L,32L,136L,96L,152L,50L,168L,176L,184L,72L,40L,208L,64L,98L,232L,240L,248L,54L,264L,272L,280L,48L,296L,304L,312L,135L,328L,336L,344L,242L,75L,368L,376L,162L,56L,160L,408L,338L,424L,108L,440L,189L,456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277781Inst : IEnumerable<long>
{
public static readonly long[] Value=A277781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277781.Bytes);
public long this[int i]=>Value[i];

public static A277781Inst Instance=new A277781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277782
{
public static readonly long[] Value={ 0L,3L,12L,84L,498L,3090L,18930L,116382L,714810L,4391526L,26977818L,165732438L,1018135578L,6254670486L,38424042426L,236048762550L,1450108129242L,8908386492054L,54726504918906L,336198967755510L,2065356559176474L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277782Inst : IEnumerable<long>
{
public static readonly long[] Value=A277782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277782.Bytes);
public long this[int i]=>Value[i];

public static A277782Inst Instance=new A277782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277783
{
public static readonly long[] Value={ 0L,12L,80L,1434L,20663L,309612L,4604554L,68632481L,1022176517L,15228316440L,226848548570L,3379346295547L,50341485804399L,749929176699858L,11171570766745821L,166421064692483298L,2479147307681739840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277783Inst : IEnumerable<long>
{
public static readonly long[] Value=A277783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277783.Bytes);
public long this[int i]=>Value[i];

public static A277783Inst Instance=new A277783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277784
{
public static readonly BigInteger[] Value={ 0L,84L,1434L,79092L,3182256L,137510661L,5841628899L,249237125709L,10621140577245L,452773767226254L,19299515119524711L,822668369531493813L,BigInteger.Parse("35067058171919508894"),BigInteger.Parse("1494772106584270234932"),BigInteger.Parse("63716265812296128694056") };
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
public class A277784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277784Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277784.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277784.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277784Inst Instance=new A277784Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277785
{
public static readonly BigInteger[] Value={ 0L,498L,20663L,3182256L,352957610L,42007318111L,4917756016412L,578187054139243L,67894823921434433L,7975637730610293845L,BigInteger.Parse("936797683441112730176"),BigInteger.Parse("110037452200711077976009"),BigInteger.Parse("12925015739480417486637641") };
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
public class A277785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277785Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277785.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277785.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277785Inst Instance=new A277785Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277786
{
public static readonly BigInteger[] Value={ 0L,3090L,309612L,137510661L,42007318111L,13899171401510L,4515609963711003L,1473737617518590407L,BigInteger.Parse("480374435720722263006"),BigInteger.Parse("156638672145036363867108"),BigInteger.Parse("51070564234004691535574722"),BigInteger.Parse("16651612907609136712725059664") };
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
public class A277786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277786Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277786.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277786.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277786Inst Instance=new A277786Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277787
{
public static readonly BigInteger[] Value={ 0L,18930L,4604554L,5841628899L,4917756016412L,4515609963711003L,4064896184452097744L,BigInteger.Parse("3677191006496347808276"),BigInteger.Parse("3322023493506438374911424"),BigInteger.Parse("3002319024317622656410038946"),BigInteger.Parse("2713074413212233626315688367138") };
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
public class A277787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277787Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277787.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277787.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277787Inst Instance=new A277787Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277788
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,0L,0L,12L,12L,0L,0L,84L,80L,84L,0L,0L,498L,1434L,1434L,498L,0L,0L,3090L,20663L,79092L,20663L,3090L,0L,0L,18930L,309612L,3182256L,3182256L,309612L,18930L,0L,0L,116382L,4604554L,137510661L,352957610L,137510661L,4604554L,116382L,0L,0L,714810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277788Inst : IEnumerable<long>
{
public static readonly long[] Value=A277788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277788.Bytes);
public long this[int i]=>Value[i];

public static A277788Inst Instance=new A277788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277789
{
public static readonly long[] Value={ 1L,-1L,4L,-10L,23L,-59L,138L,-340L,813L,-1973L,4752L,-11486L,27715L,-66927L,161558L,-390056L,941657L,-2273385L,5488412L,-13250226L,31988847L,-77227939L,186444706L,-450117372L,1086679429L,-2623476253L,6333631912L,-15290740102L,36915112091L,-89120964311L,215157040686L,-519435045712L,1254027132081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277789Inst : IEnumerable<long>
{
public static readonly long[] Value=A277789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277789.Bytes);
public long this[int i]=>Value[i];

public static A277789Inst Instance=new A277789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277790
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,11L,1L,7L,4L,17L,1L,9L,1L,23L,23L,15L,1L,19L,1L,41L,31L,35L,1L,59L,6L,41L,13L,55L,1L,71L,1L,31L,47L,53L,47L,5L,1L,59L,55L,89L,1L,95L,1L,83L,77L,71L,1L,41L,8L,46L,71L,97L,1L,119L,71L,17L,79L,89L,1L,167L,1L,95L,103L,63L,83L,13L,1L,125L,95L,143L,1L,97L,1L,113L,41L,139L,95L,167L,1L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277790Inst : IEnumerable<long>
{
public static readonly long[] Value=A277790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277790.Bytes);
public long this[int i]=>Value[i];

public static A277790Inst Instance=new A277790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277791
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,6L,1L,4L,3L,10L,1L,4L,1L,14L,15L,8L,1L,9L,1L,20L,21L,22L,1L,24L,5L,26L,9L,28L,1L,30L,1L,16L,33L,34L,35L,2L,1L,38L,39L,40L,1L,42L,1L,44L,45L,46L,1L,16L,7L,25L,51L,52L,1L,54L,55L,8L,57L,58L,1L,60L,1L,62L,63L,32L,65L,6L,1L,68L,69L,70L,1L,36L,1L,74L,25L,76L,77L,78L,1L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277791Inst : IEnumerable<long>
{
public static readonly long[] Value=A277791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277791.Bytes);
public long this[int i]=>Value[i];

public static A277791Inst Instance=new A277791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277792
{
public static readonly long[] Value={ 0L,1L,196L,2601L,15376L,60025L,181476L,461041L,1032256L,2099601L,3960100L,7027801L,11861136L,19193161L,29964676L,45360225L,66846976L,96216481L,135629316L,187662601L,255360400L,342287001L,452583076L,591024721L,763085376L,975000625L,1233835876L,1547556921L,1925103376L,2376465001L,2912760900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277792Inst : IEnumerable<long>
{
public static readonly long[] Value=A277792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277792.Bytes);
public long this[int i]=>Value[i];

public static A277792Inst Instance=new A277792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277793
{
public static readonly long[] Value={ 1L,49L,169L,361L,961L,1369L,1849L,3721L,4489L,5329L,6241L,8281L,9409L,10609L,11881L,14641L,16129L,17689L,19321L,22801L,24649L,26569L,32761L,37249L,39601L,44521L,47089L,49729L,52441L,58081L,61009L,67081L,73441L,76729L,80089L,87616L,90601L,94249L,97969L,109561L,113569L,121801L,134689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277793Inst : IEnumerable<long>
{
public static readonly long[] Value=A277793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277793.Bytes);
public long this[int i]=>Value[i];

public static A277793Inst Instance=new A277793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277794
{
public static readonly long[] Value={ 4L,21L,85L,129L,201L,237L,324L,325L,517L,549L,669L,837L,865L,1081L,1137L,1161L,1165L,1309L,1389L,1677L,1765L,2169L,2233L,2304L,2305L,2469L,2709L,2737L,2761L,3265L,3297L,3745L,3961L,4161L,4285L,4693L,4705L,4741L,4989L,5061L,5221L,5349L,5817L,5949L,6249L,6457L,6517L,6685L,6789L,6813L,6853L,6921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277794Inst : IEnumerable<long>
{
public static readonly long[] Value=A277794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277794.Bytes);
public long this[int i]=>Value[i];

public static A277794Inst Instance=new A277794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277795
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,6L,11L,23L,47L,103L,223L,503L,1132L,2602L,5986L,13922L,32433L,75994L,178354L,419945L,990134L,2339033L,5531459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277795Inst : IEnumerable<long>
{
public static readonly long[] Value=A277795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277795.Bytes);
public long this[int i]=>Value[i];

public static A277795Inst Instance=new A277795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277796
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,6L,11L,23L,47L,105L,231L,537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277796Inst : IEnumerable<long>
{
public static readonly long[] Value=A277796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277796.Bytes);
public long this[int i]=>Value[i];

public static A277796Inst Instance=new A277796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277797
{
public static readonly BigInteger[] Value={ 1L,0L,1L,1100L,1L,111100L,1L,11111100L,1L,1111111100L,1L,111111111100L,1L,11111111111100L,1L,1111111111111100L,1L,111111111111111100L,1L,11111111111111111100UL,1L,BigInteger.Parse("1111111111111111111100"),1L,BigInteger.Parse("111111111111111111111100"),1L,BigInteger.Parse("11111111111111111111111100"),1L };
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
public class A277797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277797Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277797.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277797.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277797Inst Instance=new A277797Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277798
{
public static readonly BigInteger[] Value={ 1L,0L,100L,11L,10000L,1111L,1000000L,111111L,100000000L,11111111L,10000000000L,1111111111L,1000000000000L,111111111111L,100000000000000L,11111111111111L,10000000000000000L,1111111111111111L,1000000000000000000L,111111111111111111L,BigInteger.Parse("100000000000000000000") };
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
public class A277798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277798Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277798.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277798.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277798Inst Instance=new A277798Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277799
{
public static readonly long[] Value={ 1L,0L,1L,12L,1L,60L,1L,252L,1L,1020L,1L,4092L,1L,16380L,1L,65532L,1L,262140L,1L,1048572L,1L,4194300L,1L,16777212L,1L,67108860L,1L,268435452L,1L,1073741820L,1L,4294967292L,1L,17179869180L,1L,68719476732L,1L,274877906940L,1L,1099511627772L,1L,4398046511100L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277799Inst : IEnumerable<long>
{
public static readonly long[] Value=A277799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277799.Bytes);
public long this[int i]=>Value[i];

public static A277799Inst Instance=new A277799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277800
{
public static readonly long[] Value={ 1L,0L,4L,3L,16L,15L,64L,63L,256L,255L,1024L,1023L,4096L,4095L,16384L,16383L,65536L,65535L,262144L,262143L,1048576L,1048575L,4194304L,4194303L,16777216L,16777215L,67108864L,67108863L,268435456L,268435455L,1073741824L,1073741823L,4294967296L,4294967295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277800Inst : IEnumerable<long>
{
public static readonly long[] Value=A277800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277800.Bytes);
public long this[int i]=>Value[i];

public static A277800Inst Instance=new A277800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277801
{
public static readonly long[] Value={ -1L,-1L,-1L,1L,5L,19L,47L,109L,233L,483L,993L,2011L,4055L,8149L,16337L,32715L,65477L,131011L,262077L,524217L,1048503L,2097073L,4194221L,8388519L,16777119L,33554331L,67108761L,134217621L,268435347L,536870799L,1073741697L,2147483517L,4294967159L,8589934453L,17179869035L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277801Inst : IEnumerable<long>
{
public static readonly long[] Value=A277801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277801.Bytes);
public long this[int i]=>Value[i];

public static A277801Inst Instance=new A277801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277802
{
public static readonly long[] Value={ 1L,4L,9L,2L,25L,36L,49L,3L,100L,121L,18L,169L,196L,225L,289L,12L,361L,50L,441L,484L,529L,5L,676L,98L,841L,900L,961L,1089L,1156L,1225L,6L,1369L,1444L,1521L,1681L,1764L,1849L,242L,75L,2116L,2209L,7L,20L,2601L,338L,2809L,3025L,3249L,3364L,3481L,450L,3721L,3844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277802Inst : IEnumerable<long>
{
public static readonly long[] Value=A277802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277802.Bytes);
public long this[int i]=>Value[i];

public static A277802Inst Instance=new A277802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277803
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,6L,7L,3L,10L,11L,12L,13L,14L,15L,17L,12L,19L,20L,21L,22L,23L,5L,26L,28L,29L,30L,31L,33L,34L,35L,6L,37L,38L,39L,41L,42L,43L,44L,45L,46L,47L,7L,20L,51L,52L,53L,55L,57L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,73L,74L,45L,76L,77L,78L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277803Inst : IEnumerable<long>
{
public static readonly long[] Value=A277803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277803.Bytes);
public long this[int i]=>Value[i];

public static A277803Inst Instance=new A277803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277804
{
public static readonly long[] Value={ 1L,2L,8L,12L,24L,36L,128L,288L,384L,864L,972L,1152L,1944L,3456L,6144L,6912L,13122L,18432L,26244L,31104L,62208L,69984L,209952L,279936L,294912L,497664L,839808L,884736L,1679616L,3538944L,4478976L,13436928L,22674816L,25165824L,31850496L,45349632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277804Inst : IEnumerable<long>
{
public static readonly long[] Value=A277804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277804.Bytes);
public long this[int i]=>Value[i];

public static A277804Inst Instance=new A277804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277805
{
public static readonly long[] Value={ 57L,209L,228L,217L,233L,801L,836L,809L,912L,793L,868L,785L,1009L,932L,1017L,969L,3137L,3204L,3145L,3344L,3193L,3236L,3185L,3648L,3217L,3172L,3225L,3472L,3241L,3140L,3233L,3937L,4036L,3945L,3728L,3929L,4068L,3921L,4017L,3876L,4025L,3977L,12417L,12548L,12425L,12816L,12473L,12580L,12465L,13376L,12369L,12772L,12377L,12944L,12393L,12740L,12385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277805Inst : IEnumerable<long>
{
public static readonly long[] Value=A277805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277805.Bytes);
public long this[int i]=>Value[i];

public static A277805Inst Instance=new A277805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277806
{
public static readonly long[] Value={ 115L,230L,460L,461L,920L,922L,1840L,1844L,3680L,3688L,7360L,7376L,14720L,14752L,29440L,29504L,56757L,58880L,59008L,113514L,117760L,118016L,130057L,227028L,235520L,236032L,260114L,454056L,454933L,471040L,472064L,472533L,520228L,908112L,909866L,942080L,944128L,945066L,1040456L,1816224L,1819732L,1884160L,1888256L,1890132L,2034537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277806Inst : IEnumerable<long>
{
public static readonly long[] Value=A277806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277806.Bytes);
public long this[int i]=>Value[i];

public static A277806Inst Instance=new A277806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277807
{
public static readonly long[] Value={ 83L,166L,332L,365L,664L,730L,1328L,1460L,2656L,2920L,5312L,5840L,10624L,11680L,21248L,23360L,33051L,42496L,46720L,66102L,84992L,93440L,115785L,132204L,169984L,186880L,231570L,264408L,279099L,339968L,373760L,388731L,463140L,528816L,558198L,679936L,747520L,777462L,926280L,1057632L,1116396L,1359872L,1495040L,1554924L,1677591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277807Inst : IEnumerable<long>
{
public static readonly long[] Value=A277807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277807.Bytes);
public long this[int i]=>Value[i];

public static A277807Inst Instance=new A277807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277808
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,3L,0L,0L,1L,0L,1L,2L,0L,3L,0L,0L,1L,4L,0L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,3L,0L,0L,1L,4L,0L,0L,1L,0L,1L,2L,0L,5L,0L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,3L,0L,0L,1L,0L,1L,2L,0L,3L,0L,0L,1L,4L,0L,0L,1L,0L,1L,2L,0L,5L,0L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,3L,0L,0L,1L,6L,0L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,3L,0L,0L,1L,0L,1L,2L,0L,3L,0L,0L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277808Inst : IEnumerable<long>
{
public static readonly long[] Value=A277808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277808.Bytes);
public long this[int i]=>Value[i];

public static A277808Inst Instance=new A277808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277809
{
public static readonly long[] Value={ 2L,3L,6L,30L,15L,10L,5L,14L,21L,210L,70L,35L,462L,1155L,22L,105L,330L,55L,910L,39L,858L,42L,33L,2002L,5005L,72930L,3315L,1870L,7L,770L,2145L,714L,85L,2926L,5187L,9699690L,154L,77L,390L,3927L,248710L,11305L,238602L,111546435L,46L,231L,546L,91L,3094L,440895L,152490L,21505L,93763670L,87L,4002L,2310L,1365L,170170L,17017L,114114L,9867L,2306486L,1078282205L,620310L,13485L,7130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277809Inst : IEnumerable<long>
{
public static readonly long[] Value=A277809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277809.Bytes);
public long this[int i]=>Value[i];

public static A277809Inst Instance=new A277809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277810
{
public static readonly long[] Value={ 2L,6L,3L,10L,15L,30L,210L,21L,14L,5L,22L,1155L,462L,35L,70L,858L,39L,910L,55L,330L,105L,1870L,3315L,72930L,5005L,2002L,33L,42L,9699690L,5187L,2926L,85L,714L,2145L,770L,7L,46L,111546435L,238602L,11305L,248710L,3927L,390L,77L,154L,4002L,87L,93763670L,21505L,152490L,440895L,3094L,91L,546L,231L,7130L,13485L,620310L,1078282205L,2306486L,9867L,114114L,17017L,170170L,1365L,2310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277810Inst : IEnumerable<long>
{
public static readonly long[] Value=A277810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277810.Bytes);
public long this[int i]=>Value[i];

public static A277810Inst Instance=new A277810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277811
{
public static readonly long[] Value={ 2L,3L,30L,5L,70L,105L,42L,7L,154L,231L,2310L,385L,110L,165L,66L,11L,286L,429L,4290L,715L,10010L,15015L,6006L,1001L,182L,273L,2730L,455L,130L,195L,78L,13L,442L,663L,6630L,1105L,15470L,23205L,9282L,1547L,34034L,51051L,510510L,85085L,24310L,36465L,14586L,2431L,374L,561L,5610L,935L,13090L,19635L,7854L,1309L,238L,357L,3570L,595L,170L,255L,102L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277811Inst : IEnumerable<long>
{
public static readonly long[] Value=A277811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277811.Bytes);
public long this[int i]=>Value[i];

public static A277811Inst Instance=new A277811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277812
{
public static readonly long[] Value={ 1L,2L,1L,4L,2L,1L,7L,8L,4L,2L,11L,1L,13L,14L,7L,16L,8L,4L,19L,2L,21L,22L,11L,1L,25L,26L,13L,28L,14L,7L,31L,32L,16L,8L,35L,4L,37L,38L,19L,2L,41L,42L,21L,44L,22L,11L,47L,1L,49L,50L,25L,52L,26L,13L,55L,56L,28L,14L,59L,7L,61L,62L,31L,64L,32L,16L,67L,8L,69L,70L,35L,4L,73L,74L,37L,76L,38L,19L,79L,2L,81L,82L,41L,84L,42L,21L,87L,88L,44L,22L,91L,11L,93L,94L,47L,1L,97L,98L,49L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277812Inst : IEnumerable<long>
{
public static readonly long[] Value=A277812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277812.Bytes);
public long this[int i]=>Value[i];

public static A277812Inst Instance=new A277812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277813
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,4L,5L,3L,2L,6L,1L,7L,8L,4L,9L,5L,3L,10L,2L,11L,12L,6L,1L,13L,14L,7L,15L,8L,4L,16L,17L,9L,5L,18L,3L,19L,20L,10L,2L,21L,22L,11L,23L,12L,6L,24L,1L,25L,26L,13L,27L,14L,7L,28L,29L,15L,8L,30L,4L,31L,32L,16L,33L,17L,9L,34L,5L,35L,36L,18L,3L,37L,38L,19L,39L,20L,10L,40L,2L,41L,42L,21L,43L,22L,11L,44L,45L,23L,12L,46L,6L,47L,48L,24L,1L,49L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277813Inst : IEnumerable<long>
{
public static readonly long[] Value=A277813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277813.Bytes);
public long this[int i]=>Value[i];

public static A277813Inst Instance=new A277813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277814
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,4L,5L,6L,7L,8L,8L,8L,9L,9L,10L,11L,12L,13L,14L,14L,14L,14L,14L,15L,16L,16L,16L,16L,17L,17L,18L,19L,20L,21L,22L,22L,23L,23L,23L,23L,23L,23L,23L,23L,23L,23L,24L,25L,26L,27L,27L,27L,27L,27L,27L,27L,28L,28L,28L,28L,29L,29L,30L,31L,32L,33L,34L,34L,35L,35L,35L,35L,36L,37L,37L,37L,37L,37L,37L,37L,37L,38L,38L,38L,38L,38L,38L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277814Inst : IEnumerable<long>
{
public static readonly long[] Value=A277814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277814.Bytes);
public long this[int i]=>Value[i];

public static A277814Inst Instance=new A277814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277815
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,2L,7L,0L,5L,0L,0L,0L,0L,0L,11L,4L,9L,14L,0L,0L,17L,10L,15L,0L,13L,0L,0L,0L,0L,0L,19L,0L,25L,22L,3L,8L,29L,18L,23L,28L,21L,0L,0L,0L,0L,34L,27L,20L,37L,30L,47L,0L,33L,26L,31L,0L,41L,0L,0L,0L,0L,0L,35L,0L,57L,38L,55L,0L,0L,50L,39L,44L,53L,6L,43L,16L,0L,58L,79L,36L,61L,46L,0L,56L,73L,42L,71L,0L,45L,0L,0L,0L,0L,0L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277815Inst : IEnumerable<long>
{
public static readonly long[] Value=A277815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277815.Bytes);
public long this[int i]=>Value[i];

public static A277815Inst Instance=new A277815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277816
{
public static readonly long[] Value={ 0L,5L,10L,39L,20L,13L,78L,11L,40L,21L,26L,19L,156L,29L,22L,27L,80L,25L,42L,35L,52L,45L,38L,43L,312L,37L,58L,51L,44L,41L,54L,59L,160L,57L,50L,67L,84L,53L,70L,75L,104L,61L,90L,79L,76L,93L,86L,55L,624L,101L,74L,99L,116L,77L,102L,71L,88L,69L,82L,115L,108L,85L,118L,123L,320L,121L,114L,131L,100L,117L,134L,91L,168L,89L,106L,147L,140L,109L,150L,83L,208L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277816Inst : IEnumerable<long>
{
public static readonly long[] Value=A277816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277816.Bytes);
public long this[int i]=>Value[i];

public static A277816Inst Instance=new A277816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277817
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,9L,12L,14L,15L,16L,17L,18L,23L,24L,28L,30L,31L,32L,33L,34L,36L,46L,47L,48L,49L,56L,60L,62L,63L,64L,65L,66L,68L,72L,73L,81L,87L,92L,94L,95L,96L,97L,98L,111L,112L,120L,124L,126L,127L,128L,129L,130L,132L,135L,136L,137L,143L,144L,145L,146L,153L,159L,162L,174L,175L,177L,184L,188L,190L,191L,192L,193L,194L,196L,222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277817Inst : IEnumerable<long>
{
public static readonly long[] Value=A277817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277817.Bytes);
public long this[int i]=>Value[i];

public static A277817Inst Instance=new A277817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277818
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,1L,2L,3L,1L,2L,1L,1L,4L,1L,5L,2L,1L,3L,1L,1L,2L,2L,1L,1L,3L,1L,2L,4L,1L,1L,2L,5L,1L,2L,1L,1L,3L,3L,1L,1L,2L,1L,4L,2L,1L,2L,1L,1L,6L,1L,2L,3L,1L,1L,3L,2L,1L,4L,1L,1L,2L,1L,3L,2L,1L,5L,1L,1L,2L,2L,1L,1L,4L,1L,2L,3L,1L,3L,1L,1L,2L,1L,7L,2L,1L,1L,2L,4L,1L,2L,1L,1L,3L,2L,1L,1L,3L,1L,2L,6L,1L,1L,4L,2L,1L,3L,1L,1L,2L,1L,2L,3L,1L,2L,1L,1L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277818Inst : IEnumerable<long>
{
public static readonly long[] Value=A277818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277818.Bytes);
public long this[int i]=>Value[i];

public static A277818Inst Instance=new A277818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277819
{
public static readonly long[] Value={ 1L,2L,3L,7L,6L,5L,4L,9L,10L,15L,13L,12L,27L,30L,17L,14L,23L,20L,45L,34L,51L,11L,18L,57L,60L,119L,102L,85L,8L,29L,54L,75L,68L,153L,170L,255L,25L,24L,39L,90L,221L,204L,427L,510L,257L,26L,43L,40L,105L,238L,359L,340L,765L,514L,771L,31L,46L,125L,120L,187L,306L,937L,1020L,1799L,1542L,1285L,28L,33L,114L,135L,136L,461L,854L,1275L,1028L,2313L,2570L,3855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277819Inst : IEnumerable<long>
{
public static readonly long[] Value=A277819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277819.Bytes);
public long this[int i]=>Value[i];

public static A277819Inst Instance=new A277819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277820
{
public static readonly long[] Value={ 1L,3L,2L,5L,6L,7L,15L,10L,9L,4L,17L,30L,27L,12L,13L,51L,34L,45L,20L,23L,14L,85L,102L,119L,60L,57L,18L,11L,255L,170L,153L,68L,75L,54L,29L,8L,257L,510L,427L,204L,221L,90L,39L,24L,25L,771L,514L,765L,340L,359L,238L,105L,40L,43L,26L,1285L,1542L,1799L,1020L,937L,306L,187L,120L,125L,46L,31L,3855L,2570L,2313L,1028L,1275L,854L,461L,136L,135L,114L,33L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277820Inst : IEnumerable<long>
{
public static readonly long[] Value=A277820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277820.Bytes);
public long this[int i]=>Value[i];

public static A277820Inst Instance=new A277820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277821
{
public static readonly long[] Value={ 1L,3L,2L,10L,4L,5L,6L,36L,9L,8L,28L,14L,15L,21L,7L,136L,11L,27L,120L,19L,91L,105L,20L,44L,45L,55L,13L,78L,35L,12L,66L,528L,77L,17L,496L,90L,435L,465L,43L,53L,325L,351L,54L,406L,18L,65L,378L,152L,153L,171L,16L,210L,135L,34L,190L,300L,26L,119L,276L,25L,231L,253L,104L,2080L,118L,275L,2016L,32L,1891L,1953L,252L,324L,1653L,1711L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277821Inst : IEnumerable<long>
{
public static readonly long[] Value=A277821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277821.Bytes);
public long this[int i]=>Value[i];

public static A277821Inst Instance=new A277821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277822
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,3L,1L,1L,2L,3L,1L,4L,1L,1L,2L,1L,2L,3L,1L,4L,1L,1L,2L,5L,1L,1L,2L,1L,2L,3L,1L,1L,2L,3L,1L,4L,1L,1L,2L,5L,1L,1L,2L,1L,2L,3L,1L,6L,1L,1L,2L,1L,2L,3L,1L,1L,2L,3L,1L,4L,1L,1L,2L,1L,2L,3L,1L,4L,1L,1L,2L,5L,1L,1L,2L,1L,2L,3L,1L,6L,1L,1L,2L,1L,2L,3L,1L,1L,2L,3L,1L,4L,1L,1L,2L,7L,1L,1L,2L,1L,2L,3L,1L,1L,2L,3L,1L,4L,1L,1L,2L,1L,2L,3L,1L,4L,1L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277822Inst : IEnumerable<long>
{
public static readonly long[] Value=A277822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277822.Bytes);
public long this[int i]=>Value[i];

public static A277822Inst Instance=new A277822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277823
{
public static readonly long[] Value={ 3L,6L,9L,12L,23L,18L,29L,24L,43L,46L,33L,36L,63L,58L,53L,48L,83L,86L,89L,92L,71L,66L,77L,72L,123L,126L,113L,116L,111L,106L,101L,96L,163L,166L,169L,172L,183L,178L,189L,184L,139L,142L,129L,132L,159L,154L,149L,144L,243L,246L,249L,252L,231L,226L,237L,232L,219L,222L,209L,212L,207L,202L,197L,192L,323L,326L,329L,332L,343L,338L,349L,344L,363L,366L,353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277823Inst : IEnumerable<long>
{
public static readonly long[] Value=A277823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277823.Bytes);
public long this[int i]=>Value[i];

public static A277823Inst Instance=new A277823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277824
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,3L,1L,1L,1L,1L,1L,3L,2L,2L,2L,1L,1L,2L,3L,2L,1L,4L,1L,1L,1L,1L,1L,4L,1L,3L,3L,2L,2L,5L,2L,2L,2L,3L,1L,1L,1L,1L,2L,3L,3L,4L,2L,2L,1L,2L,4L,2L,1L,6L,1L,1L,1L,1L,1L,5L,1L,3L,4L,3L,1L,1L,3L,3L,3L,5L,2L,3L,2L,1L,5L,4L,2L,7L,2L,1L,2L,2L,3L,4L,1L,4L,1L,1L,1L,1L,1L,4L,2L,2L,3L,5L,3L,2L,4L,5L,2L,6L,2L,1L,1L,2L,2L,3L,4L,4L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277824Inst : IEnumerable<long>
{
public static readonly long[] Value=A277824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277824.Bytes);
public long this[int i]=>Value[i];

public static A277824Inst Instance=new A277824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277825
{
public static readonly long[] Value={ 5L,10L,27L,20L,57L,54L,39L,40L,125L,114L,99L,108L,65L,78L,95L,80L,245L,250L,235L,228L,201L,198L,215L,216L,141L,130L,147L,156L,177L,190L,175L,160L,485L,490L,507L,500L,473L,470L,455L,456L,413L,402L,387L,396L,417L,430L,447L,432L,277L,282L,267L,260L,297L,294L,311L,312L,365L,354L,371L,380L,337L,350L,335L,320L,965L,970L,987L,980L,1017L,1014L,999L,1000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277825Inst : IEnumerable<long>
{
public static readonly long[] Value=A277825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277825.Bytes);
public long this[int i]=>Value[i];

public static A277825Inst Instance=new A277825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277826
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,1L,6L,7L,8L,9L,2L,7L,12L,1L,14L,15L,16L,17L,18L,7L,4L,9L,14L,23L,24L,17L,2L,15L,28L,1L,30L,31L,32L,33L,34L,7L,36L,17L,14L,3L,8L,1L,18L,23L,28L,9L,46L,47L,48L,49L,34L,15L,4L,17L,30L,47L,56L,33L,2L,31L,60L,1L,62L,63L,64L,65L,66L,7L,68L,33L,14L,47L,72L,73L,34L,3L,28L,17L,6L,23L,16L,81L,2L,23L,36L,1L,46L,87L,56L,73L,18L,47L,92L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277826Inst : IEnumerable<long>
{
public static readonly long[] Value=A277826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277826.Bytes);
public long this[int i]=>Value[i];

public static A277826Inst Instance=new A277826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277827
{
public static readonly long[] Value={ 3L,8L,9L,4L,9L,1L,6L,4L,5L,2L,1L,1L,1L,5L,5L,4L,2L,4L,8L,6L,3L,4L,3L,6L,6L,3L,0L,6L,5L,8L,8L,0L,1L,3L,8L,6L,1L,3L,1L,1L,1L,4L,9L,8L,2L,1L,3L,3L,4L,6L,2L,7L,6L,0L,0L,7L,7L,7L,4L,2L,2L,9L,1L,4L,7L,7L,9L,1L,9L,9L,9L,9L,9L,9L,4L,5L,2L,3L,4L,1L,8L,0L,0L,8L,3L,7L,6L,5L,1L,8L,7L,7L,2L,6L,0L,6L,1L,1L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277827Inst : IEnumerable<long>
{
public static readonly long[] Value=A277827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277827.Bytes);
public long this[int i]=>Value[i];

public static A277827Inst Instance=new A277827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277828
{
public static readonly long[] Value={ 1L,2L,5L,11L,23L,45L,90L,179L,357L,712L,1422L,2842L,5681L,11360L,22716L,45430L,90856L,181709L,363413L,726822L,1453640L,2907276L,5814546L,11629086L,23258166L,46516327L,93032647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277828Inst : IEnumerable<long>
{
public static readonly long[] Value=A277828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277828.Bytes);
public long this[int i]=>Value[i];

public static A277828Inst Instance=new A277828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277829
{
public static readonly BigInteger[] Value={ 1L,1L,9L,1035L,1686931L,40768984675L,14961837668926225L,BigInteger.Parse("84566159505295329041875"),BigInteger.Parse("7428544024130633312561150929275"),BigInteger.Parse("10204389867956705680354458767618278532475"),BigInteger.Parse("220168039594282987862502167563496178988004727093379"),BigInteger.Parse("74853381374809235976722939648065921771360016655877341808897465") };
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
public class A277829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277829Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277829.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277829.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277829Inst Instance=new A277829Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277830
{
public static readonly BigInteger[] Value={ 1L,1L,2L,23L,344L,4665L,58986L,713307L,8367628L,96021949L,1083676270L,12071330591L,133058984912L,1454046639233L,15775034293554L,170096021947875L,1824417009602196L,19478737997256517L,207133058984910838L,2194787379972565159L,BigInteger.Parse("23182441700960219480") };
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
public class A277830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277830Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277830.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277830.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277830Inst Instance=new A277830Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277831
{
public static readonly BigInteger[] Value={ 0L,1L,5L,57L,689L,8121L,93553L,1058985L,11824417L,130589849L,1429355281L,15528120716L,167626886179L,1799725651922L,19231824420465L,204663923217008L,2170096022293551L,22935528124170094L,241700960254046637L,2540466392663923180L,BigInteger.Parse("26639231827873799724") };
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
public class A277831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277831Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277831.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277831.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277831Inst Instance=new A277831Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277832
{
public static readonly BigInteger[] Value={ 0L,0L,2L,27L,389L,5121L,63553L,758985L,8824417L,100589849L,1129355281L,12528120713L,137626886149L,1499725651622L,16231824417465L,174663923187008L,1870096021993551L,19935528121170094L,211700960224046637L,2240466392363923180L,BigInteger.Parse("23639231824873799723") };
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
public class A277832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277832Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277832.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277832.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277832Inst Instance=new A277832Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277833
{
public static readonly BigInteger[] Value={ 0L,0L,1L,23L,349L,4721L,59553L,718985L,8424417L,96589849L,1089355281L,12128120713L,133626886145L,1459725651582L,15831824417065L,170663923183008L,1830096021953551L,19535528120770094L,207700960220046637L,2200466392323923180L,BigInteger.Parse("23239231824473799723") };
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
public class A277833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277833Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277833.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277833.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277833Inst Instance=new A277833Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277834
{
public static readonly BigInteger[] Value={ 0L,0L,1L,22L,344L,4671L,59053L,713985L,8374417L,96089849L,1084355281L,12078120713L,133126886145L,1454725651577L,15781824417015L,170163923182508L,1825096021948551L,19485528120720094L,207200960219546637L,2195466392318923180L,BigInteger.Parse("23189231824423799723") };
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
public class A277834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277834Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277834.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277834.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277834Inst Instance=new A277834Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277835
{
public static readonly BigInteger[] Value={ 0L,0L,1L,22L,343L,4665L,58993L,713385L,8368417L,96029849L,1083755281L,12072120713L,133066886145L,1454125651577L,15775824417009L,170103923182448L,1824496021947951L,19479528120714094L,207140960219486637L,2194866392318323180L,BigInteger.Parse("23183231824417799723") };
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
public class A277835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277835Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277835.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277835.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277835Inst Instance=new A277835Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277836
{
public static readonly BigInteger[] Value={ 0L,0L,1L,22L,343L,4664L,58986L,713315L,8367717L,96022849L,1083685281L,12071420713L,133059886145L,1454055651577L,15775124417009L,170096923182441L,1824426021947881L,19478828120713394L,207133960219479637L,2194796392318253180L,BigInteger.Parse("23182531824417099723") };
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
public class A277836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277836Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277836.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277836.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277836Inst Instance=new A277836Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277837
{
public static readonly BigInteger[] Value={ 0L,0L,1L,22L,343L,4664L,58985L,713307L,8367637L,96022049L,1083677281L,12071340713L,133059086145L,1454047651577L,15775044417009L,170096123182441L,1824418021947873L,19478748120713314L,207133160219478837L,2194788392318245180L,BigInteger.Parse("23182451824417019723") };
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
public class A277837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277837Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277837.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277837.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277837Inst Instance=new A277837Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277838
{
public static readonly BigInteger[] Value={ 0L,0L,1L,22L,343L,4664L,58985L,713306L,8367628L,96021959L,1083676380L,12071331701L,133058996022L,1454046750343L,15775035404664L,170096033058985L,1824417120713306L,19478739108367627L,207133070096021958L,2194787491083676380L,BigInteger.Parse("23182442812071331701") };
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
public class A277838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277838Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277838.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277838.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277838Inst Instance=new A277838Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277839
{
public static readonly BigInteger[] Value={ 1L,7L,638L,7643021L,20762461502595L,BigInteger.Parse("19903050866658120066632"),BigInteger.Parse("10114722264843500593900485682759058"),BigInteger.Parse("3861169308385212945415179151162048048461447621051"),BigInteger.Parse("1493197448612892660867776325903488655508569676879420405667824079327") };
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
public class A277839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277839Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277839.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277839.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277839Inst Instance=new A277839Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277840
{
public static readonly BigInteger[] Value={ 1L,44L,142336L,244698934716L,BigInteger.Parse("347256965617453111707"),BigInteger.Parse("683647218221456315461840833799588"),BigInteger.Parse("2846969183281612697167894035560332610102537605107"),BigInteger.Parse("35612941825082950044316879351953518880328546726186269125209259942000"),BigInteger.Parse("1805164781998352977708541832242375664226097624365740577986086562708182817353463604362494621") };
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
public class A277840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277840Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277840.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277840.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277840Inst Instance=new A277840Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277841
{
public static readonly BigInteger[] Value={ 1L,74L,1804128L,53512221536494L,BigInteger.Parse("2922627429145967591227933"),BigInteger.Parse("497730359833453928180319002991414602093"),BigInteger.Parse("403397426941463986598664115278880491308873007636372427413"),BigInteger.Parse("2209668743041973325985756217800328983151637526070225333484395817216844313778044") };
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
public class A277841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277841Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277841.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277841.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277841Inst Instance=new A277841Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277842
{
public static readonly BigInteger[] Value={ 1L,81L,6064606L,1334647986999812L,BigInteger.Parse("970906913413864886205472630"),BigInteger.Parse("3914970565374711299589044295533654728633307"),BigInteger.Parse("133558404360787903168869516536280931557107488047811301767090944"),BigInteger.Parse("54745234941096457415294245370001308972451724232455240696557887565208148810995582605398") };
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
public class A277842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277842Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277842.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277842.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277842Inst Instance=new A277842Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277843
{
public static readonly BigInteger[] Value={ 1L,81L,9875766L,9508729532667775L,BigInteger.Parse("51400728418762283743166947873"),BigInteger.Parse("2412787002750586428934439397030434799264061139"),BigInteger.Parse("1497241493787657622590696899117249253525915361372369634716838093562"),BigInteger.Parse("17442838191172723332310678848004599133452884005515399679140805741625547114446168989072880538") };
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
public class A277843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277843Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277843.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277843.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277843Inst Instance=new A277843Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277844
{
public static readonly BigInteger[] Value={ 1L,81L,11328242L,29902254119865429L,BigInteger.Parse("817701868164546859278494745163"),BigInteger.Parse("285033249600409431428643990739291312182972084132"),BigInteger.Parse("1892438067444572851650149500498661434054764424790064535313952779756847"),BigInteger.Parse("339676614862729029614552301296020122485910436927008569295805654935518977116532247635480871741432") };
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
public class A277844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277844Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277844.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277844.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277844Inst Instance=new A277844Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277845
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,10L,9L,18L,17L,24L,20L,22L,44L,40L,36L,30L,27L,25L,23L,21L,19L,28L,26L,32L,29L,31L,34L,37L,74L,67L,60L,54L,49L,45L,41L,42L,38L,35L,70L,63L,57L,50L,55L,110L,99L,90L,81L,73L,66L,72L,65L,59L,64L,58L,53L,48L,52L,47L,43L,39L,78L,71L,142L,100L,101L,91L,82L,80L,88L,96L,87L,79L,86L,92L,83L,75L,68L,62L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277845Inst : IEnumerable<long>
{
public static readonly long[] Value=A277845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277845.Bytes);
public long this[int i]=>Value[i];

public static A277845Inst Instance=new A277845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277846
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,10L,9L,18L,17L,24L,20L,22L,44L,40L,36L,30L,27L,25L,23L,21L,19L,28L,26L,32L,29L,31L,34L,37L,74L,67L,60L,54L,49L,45L,41L,42L,38L,35L,70L,63L,57L,50L,55L,110L,99L,90L,81L,73L,66L,72L,65L,59L,64L,58L,53L,48L,52L,47L,43L,39L,78L,71L,88L,80L,160L,100L,101L,91L,82L,84L,76L,69L,75L,68L,62L,56L,51L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277846Inst : IEnumerable<long>
{
public static readonly long[] Value=A277846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277846.Bytes);
public long this[int i]=>Value[i];

public static A277846Inst Instance=new A277846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277847
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,4L,4L,2L,4L,4L,6L,4L,4L,8L,4L,2L,2L,8L,10L,4L,8L,12L,12L,4L,6L,8L,10L,8L,8L,8L,16L,2L,12L,4L,8L,8L,10L,20L,8L,4L,6L,16L,22L,12L,8L,24L,24L,4L,22L,12L,4L,8L,14L,20L,12L,8L,20L,16L,30L,8L,16L,32L,16L,2L,8L,24L,34L,4L,24L,16L,36L,8L,10L,20L,12L,20L,24L,16L,40L,4L,28L,12L,42L,16L,4L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277847Inst : IEnumerable<long>
{
public static readonly long[] Value=A277847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277847.Bytes);
public long this[int i]=>Value[i];

public static A277847Inst Instance=new A277847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277848
{
public static readonly long[] Value={ 1L,7L,2L,5L,18L,21L,11L,8L,28L,35L,46L,74L,54L,25L,3L,129L,32L,39L,78L,58L,133L,43L,62L,6L,95L,91L,152L,171L,87L,71L,190L,16L,148L,328L,19L,181L,167L,51L,227L,405L,618L,355L,344L,254L,440L,83L,926L,22L,67L,277L,100L,157L,1400L,195L,333L,186L,1144L,232L,259L,445L,282L,105L,12L,237L,110L,115L,388L,211L,468L,383L,492L,144L,594L,307L,366L,206L,126L,533L,324L,9L,463L,642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277848Inst : IEnumerable<long>
{
public static readonly long[] Value=A277848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277848.Bytes);
public long this[int i]=>Value[i];

public static A277848Inst Instance=new A277848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277849
{
public static readonly BigInteger[] Value={ 0L,0L,1L,22L,343L,4664L,58985L,713306L,8367627L,96021949L,1083676281L,12071330713L,133058986145L,1454046651577L,15775034417009L,170096023182441L,1824417021947873L,19478738120713305L,207133060219478737L,2194787392318244180L,BigInteger.Parse("23182441824417009723") };
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
public class A277849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277849Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277849.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277849.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277849Inst Instance=new A277849Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277850
{
public static readonly BigInteger[] Value={ 0L,1L,2L,4L,16L,3L,9L,81L,5L,25L,625L,7L,49L,2401L,8L,64L,4096L,16777216L,17L,289L,6L,36L,1296L,1679616L,15L,225L,50625L,11L,121L,14641L,10L,100L,10000L,100000000L,19L,361L,130321L,12L,144L,20736L,429981696L,20L,400L,160000L,25600000000L,24L,576L,331776L,13L,169L,28561L,815730721L,21L,441L,194481L,37822859361L,BigInteger.Parse("1430568690241985328321") };
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
public class A277850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277850Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277850.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277850.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277850Inst Instance=new A277850Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277851
{
public static readonly long[] Value={ 3L,6L,7L,8L,11L,13L,14L,18L,19L,20L,21L,22L,23L,25L,26L,29L,30L,32L,34L,35L,38L,39L,40L,43L,44L,45L,47L,51L,53L,54L,56L,58L,62L,67L,68L,69L,70L,71L,72L,74L,75L,77L,78L,80L,82L,83L,87L,89L,90L,91L,92L,94L,97L,98L,99L,102L,103L,104L,105L,106L,107L,108L,110L,111L,112L,115L,117L,118L,119L,120L,122L,123L,125L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277851Inst : IEnumerable<long>
{
public static readonly long[] Value=A277851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277851.Bytes);
public long this[int i]=>Value[i];

public static A277851Inst Instance=new A277851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277852
{
public static readonly long[] Value={ 1L,2L,4L,5L,9L,15L,16L,24L,59L,61L,81L,100L,124L,129L,152L,169L,196L,249L,305L,400L,425L,475L,520L,556L,565L,676L,771L,795L,904L,939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277852Inst : IEnumerable<long>
{
public static readonly long[] Value=A277852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277852.Bytes);
public long this[int i]=>Value[i];

public static A277852Inst Instance=new A277852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277853
{
public static readonly long[] Value={ 1L,2L,4L,5L,21L,27L,44L,104L,173L,365L,369L,500L,590L,735L,840L,987L,1564L,1797L,2415L,3368L,3545L,4025L,4466L,5018L,5477L,6686L,7239L,8025L,8182L,9369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277853Inst : IEnumerable<long>
{
public static readonly long[] Value=A277853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277853.Bytes);
public long this[int i]=>Value[i];

public static A277853Inst Instance=new A277853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277854
{
public static readonly long[] Value={ 1L,2L,4L,5L,9L,15L,16L,48L,64L,86L,100L,144L,169L,3364L,3969L,4096L,195364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277854Inst : IEnumerable<long>
{
public static readonly long[] Value=A277854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277854.Bytes);
public long this[int i]=>Value[i];

public static A277854Inst Instance=new A277854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277855
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,2L,1L,1L,1L,4L,3L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,4L,4L,4L,4L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277855Inst : IEnumerable<long>
{
public static readonly long[] Value=A277855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277855.Bytes);
public long this[int i]=>Value[i];

public static A277855Inst Instance=new A277855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277856
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,111L,212L,216L,612L,1111L,1113L,1131L,1311L,2112L,3111L,4224L,4416L,6144L,11111L,11133L,11313L,11331L,11711L,13113L,13131L,13311L,21112L,21132L,21312L,23112L,23424L,31113L,31131L,31311L,33111L,42432L,42624L,111111L,211112L,211116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277856Inst : IEnumerable<long>
{
public static readonly long[] Value=A277856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277856.Bytes);
public long this[int i]=>Value[i];

public static A277856Inst Instance=new A277856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277857
{
public static readonly long[] Value={ 1L,2L,8L,9L,10L,16L,17L,29L,36L,64L,72L,73L,80L,81L,128L,136L,153L,160L,197L,218L,232L,244L,277L,281L,288L,314L,349L,397L,405L,433L,466L,468L,512L,514L,521L,557L,576L,577L,584L,586L,593L,637L,640L,648L,701L,738L,757L,794L,801L,853L,857L,881L,882L,953L,980L,1024L,1028L,1088L,1152L,1217L,1224L,1249L,1268L,1280L,1332L,1341L,1396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277857Inst : IEnumerable<long>
{
public static readonly long[] Value=A277857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277857.Bytes);
public long this[int i]=>Value[i];

public static A277857Inst Instance=new A277857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277858
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,10L,9L,18L,17L,24L,20L,22L,44L,40L,36L,30L,27L,25L,23L,21L,19L,28L,26L,32L,29L,31L,34L,37L,74L,67L,60L,54L,49L,45L,41L,42L,38L,35L,70L,63L,57L,50L,55L,110L,99L,90L,81L,73L,66L,72L,65L,59L,64L,58L,53L,48L,52L,47L,43L,39L,78L,71L,142L,100L,101L,91L,82L,80L,88L,96L,87L,79L,86L,92L,83L,75L,68L,62L,56L,51L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277858Inst : IEnumerable<long>
{
public static readonly long[] Value=A277858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277858.Bytes);
public long this[int i]=>Value[i];

public static A277858Inst Instance=new A277858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277859
{
public static readonly long[] Value={ 2L,3L,2L,4L,2L,7L,2L,3L,2L,11L,2L,4L,2L,3L,2L,4L,2L,19L,2L,3L,2L,23L,2L,4L,2L,3L,2L,4L,2L,31L,2L,3L,2L,5L,2L,4L,2L,3L,2L,4L,2L,9L,2L,3L,2L,47L,2L,4L,2L,3L,2L,4L,2L,5L,2L,3L,2L,59L,2L,4L,2L,3L,2L,4L,2L,45L,2L,3L,2L,15L,2L,4L,2L,3L,2L,4L,2L,9L,2L,3L,2L,83L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277859Inst : IEnumerable<long>
{
public static readonly long[] Value=A277859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277859.Bytes);
public long this[int i]=>Value[i];

public static A277859Inst Instance=new A277859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277860
{
public static readonly BigInteger[] Value={ 0L,8L,720L,50400L,3220000L,196885920L,11756961216L,692835631488L,40536961717824L,2363784447147552L,137716866109432896L,8030173585594013568L,BigInteger.Parse("469162781054378536320"),BigInteger.Parse("27486632292027996114560"),BigInteger.Parse("1615617140290621588826880"),BigInteger.Parse("95302760085090826490672640") };
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
public class A277860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277860Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277860.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A277860.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277860Inst Instance=new A277860Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277861
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,20L,22L,23L,24L,25L,26L,27L,28L,29L,30L,13L,32L,33L,34L,35L,36L,37L,38L,39L,40L,14L,15L,16L,42L,43L,44L,45L,46L,47L,48L,49L,50L,17L,18L,19L,21L,52L,53L,54L,55L,56L,57L,58L,59L,60L,62L,63L,64L,65L,66L,67L,68L,69L,70L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277861Inst : IEnumerable<long>
{
public static readonly long[] Value=A277861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277861.Bytes);
public long this[int i]=>Value[i];

public static A277861Inst Instance=new A277861Inst();

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