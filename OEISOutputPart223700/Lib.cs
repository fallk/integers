using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A274362
{
public static readonly long[] Value={ 5984L,11780L,20349L,22815L,24794L,26144L,27675L,29799L,31724L,33579L,33824L,34335L,34748L,36764L,37323L,37664L,38324L,38367L,38675L,38709L,40544L,41624L,42020L,44505L,44954L,47564L,47684L,48950L,50024L,51204L,52155L,52767L,53703L,53955L,54495L,55419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274362Inst : IEnumerable<long>
{
public static readonly long[] Value=A274362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274362.Bytes);
public long this[int i]=>Value[i];

public static A274362Inst Instance=new A274362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274363
{
public static readonly long[] Value={ 689278976L,38492803071L,100821266432L,147331919871L,421606494207L,560920563711L,732088143872L,753855967232L,918212890624L,1218308829183L,1414219239423L,1485254832128L,1544826179583L,1566594002943L,1671079555071L,1675433119743L,1681165242368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274363Inst : IEnumerable<long>
{
public static readonly long[] Value=A274363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274363.Bytes);
public long this[int i]=>Value[i];

public static A274363Inst Instance=new A274363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274364
{
public static readonly long[] Value={ 156735L,809919L,1276479L,1429568L,1649727L,1836351L,2269376L,2489535L,2549312L,2769471L,2922560L,3202496L,3236031L,4449087L,4729023L,4915647L,5068736L,5288895L,5441984L,5628608L,5721920L,6035391L,6281792L,6468416L,6595263L,6841664L,7028288L,7248447L,7528383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274364Inst : IEnumerable<long>
{
public static readonly long[] Value=A274364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274364.Bytes);
public long this[int i]=>Value[i];

public static A274364Inst Instance=new A274364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274365
{
public static readonly long[] Value={ 180224L,257499L,579375L,1075599L,1990575L,2353616L,5598800L,10320624L,11560400L,13975983L,16951599L,17213552L,17651600L,17672499L,17784207L,20626991L,20660624L,21041775L,21912848L,22252400L,24533199L,24953103L,26161875L,26604207L,29232175L,29253392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274365Inst : IEnumerable<long>
{
public static readonly long[] Value=A274365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274365.Bytes);
public long this[int i]=>Value[i];

public static A274365Inst Instance=new A274365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274366
{
public static readonly long[] Value={ 2200933376L,3724751871L,4982377472L,5055007743L,5828903936L,6506195967L,9771369471L,12238318592L,13810439168L,15213325311L,15503492096L,15624424448L,17027310591L,20703583232L,22590198783L,23194860543L,27596727296L,28274019327L,30136306688L,30450801663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274366Inst : IEnumerable<long>
{
public static readonly long[] Value=A274366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274366.Bytes);
public long this[int i]=>Value[i];

public static A274366Inst Instance=new A274366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274367
{
public static readonly long[] Value={ 27445392L,1644443281L,2367885312L,5687433577L,112416325632L,208265121792L,900069054976L,1976398601697L,6735639678976L,9698858237952L,9911785815477L,14585606569872L,15283760730112L,18156501172017L,23295727931392L,29871321586561L,33510832422912L,67250060669952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274367Inst : IEnumerable<long>
{
public static readonly long[] Value=A274367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274367.Bytes);
public long this[int i]=>Value[i];

public static A274367Inst Instance=new A274367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274368
{
public static readonly long[] Value={ 45L,48L,231L,121116L,159229L,11985489L,17514256L,51624256L,88172137L,228523729L,467597425L,11112111412L,4329279198937L,3716589421762641L,23228676113127556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274368Inst : IEnumerable<long>
{
public static readonly long[] Value=A274368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274368.Bytes);
public long this[int i]=>Value[i];

public static A274368Inst Instance=new A274368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274369
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,0L,-1L,-1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,2L,2L,1L,1L,2L,2L,3L,3L,2L,2L,1L,1L,2L,2L,3L,3L,4L,4L,3L,3L,2L,2L,3L,3L,2L,2L,3L,3L,2L,2L,1L,1L,0L,0L,-1L,-1L,0L,0L,-1L,-1L,0L,0L,-1L,-1L,-2L,-2L,-1L,-1L,-2L,-2L,-3L,-3L,-2L,-2L,-1L,-1L,-2L,-2L,-3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274369Inst : IEnumerable<long>
{
public static readonly long[] Value=A274369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274369.Bytes);
public long this[int i]=>Value[i];

public static A274369Inst Instance=new A274369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274370
{
public static readonly long[] Value={ 0L,1L,1L,0L,0L,-1L,-1L,0L,0L,-1L,-1L,-2L,-2L,-1L,-1L,0L,0L,-1L,-1L,-2L,-2L,-3L,-3L,-2L,-2L,-1L,-1L,-2L,-2L,-1L,-1L,-2L,-2L,-1L,-1L,0L,0L,-1L,-1L,0L,0L,1L,1L,0L,0L,-1L,-1L,0L,0L,1L,1L,0L,0L,1L,1L,2L,2L,1L,1L,0L,0L,1L,1L,2L,2L,3L,3L,2L,2L,1L,1L,2L,2L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274370Inst : IEnumerable<long>
{
public static readonly long[] Value=A274370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274370.Bytes);
public long this[int i]=>Value[i];

public static A274370Inst Instance=new A274370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274371
{
public static readonly long[] Value={ 1L,2L,3L,6L,8L,21L,24L,42L,126L,144L,168L,432L,504L,987L,1008L,1974L,3024L,5922L,7896L,23688L,46368L,47376L,139104L,142128L,973728L,2178309L,4356618L,13069854L,17426472L,45765216L,52279416L,104558832L,313676496L,4807526976L,14422580928L,100958066496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274371Inst : IEnumerable<long>
{
public static readonly long[] Value=A274371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274371.Bytes);
public long this[int i]=>Value[i];

public static A274371Inst Instance=new A274371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274372
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,0L,2L,1L,1L,0L,1L,1L,0L,3L,2L,3L,1L,3L,2L,2L,1L,1L,0L,1L,1L,0L,4L,3L,7L,4L,7L,5L,8L,6L,6L,3L,5L,4L,3L,2L,2L,1L,1L,0L,1L,1L,0L,5L,4L,12L,10L,17L,12L,20L,18L,22L,14L,19L,16L,18L,14L,14L,12L,12L,7L,8L,7L,5L,4L,3L,2L,2L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274372Inst : IEnumerable<long>
{
public static readonly long[] Value=A274372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274372.Bytes);
public long this[int i]=>Value[i];

public static A274372Inst Instance=new A274372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274373
{
public static readonly long[] Value={ 0L,1L,6L,35L,188L,989L,5131L,26411L,135229L,689814L,3509014L,17811637L,90256685L,456719880L,2308440442L,11656409995L,58809893357L,296500180806L,1493924791698L,7523064390774L,37866103978109L,190510720248534L,958122016323881L,4816944544836927L,24209532464417585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274373Inst : IEnumerable<long>
{
public static readonly long[] Value=A274373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274373.Bytes);
public long this[int i]=>Value[i];

public static A274373Inst Instance=new A274373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274374
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,7L,8L,10L,11L,12L,13L,15L,16L,18L,21L,24L,26L,28L,29L,33L,34L,39L,40L,42L,44L,47L,54L,55L,63L,65L,68L,72L,76L,77L,87L,89L,102L,104L,105L,110L,116L,123L,126L,141L,144L,165L,168L,170L,178L,188L,198L,199L,203L,228L,233L,267L,272L,273L,275L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274374Inst : IEnumerable<long>
{
public static readonly long[] Value=A274374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274374.Bytes);
public long this[int i]=>Value[i];

public static A274374Inst Instance=new A274374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274375
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,7L,8L,10L,11L,12L,13L,14L,15L,16L,18L,21L,22L,24L,26L,28L,29L,33L,34L,36L,39L,40L,42L,44L,47L,54L,55L,58L,63L,65L,68L,72L,76L,77L,87L,89L,94L,102L,104L,105L,110L,116L,123L,126L,141L,144L,152L,165L,168L,170L,178L,188L,198L,199L,203L,228L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274375Inst : IEnumerable<long>
{
public static readonly long[] Value=A274375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274375.Bytes);
public long this[int i]=>Value[i];

public static A274375Inst Instance=new A274375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274376
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,5L,8L,12L,20L,32L,52L,84L,135L,219L,353L,572L,924L,1495L,2419L,3912L,6331L,10240L,16570L,26807L,43374L,70178L,113546L,183721L,297258L,480974L,778220L,1259184L,2037389L,3296554L,5333923L,8630446L,13964340L,22594740L,36559034L,59153708L,95712668L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274376Inst : IEnumerable<long>
{
public static readonly long[] Value=A274376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274376.Bytes);
public long this[int i]=>Value[i];

public static A274376Inst Instance=new A274376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274377
{
public static readonly BigInteger[] Value={ 1L,1L,0L,1L,0L,16L,0L,736L,0L,67096L,0L,10163176L,0L,2306198896L,0L,732199108096L,0L,309860700130816L,0L,168568765338224896L,0L,BigInteger.Parse("114619705107961862656"),0L,BigInteger.Parse("95251358122177791486976"),0L,BigInteger.Parse("94984793274454431691503616"),0L,BigInteger.Parse("111939507886837612683516276736"),0L,BigInteger.Parse("153907136552991217284274400567296"),0L,BigInteger.Parse("244164979570216285201628515234840576"),0L,BigInteger.Parse("442692827509235885935744380253757341696"),0L,BigInteger.Parse("909667081143908558901949811564629988048896") };
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
public class A274377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274377Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274377.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274377Inst Instance=new A274377Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274378
{
public static readonly BigInteger[] Value={ 1L,2L,6L,24L,111L,552L,2873L,15458L,85312L,480314L,2747845L,15928080L,93347153L,552181372L,3292571913L,19769887128L,119430685503L,725375643416L,4426786390959L,27131644746326L,166932630227613L,1030684209393288L,6383992918008611L,39657230694169284L,247008096338698523L,1542292860296588558L,9651791500807437834UL,BigInteger.Parse("60528789932966226468"),BigInteger.Parse("380333245334293851637"),BigInteger.Parse("2394179659042901060436"),BigInteger.Parse("15096873553004201457425") };
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
public class A274378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274378Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274378.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274378Inst Instance=new A274378Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274379
{
public static readonly BigInteger[] Value={ 1L,3L,13L,70L,429L,2842L,19794L,142758L,1056655L,7980280L,61251261L,476387379L,3746317414L,29738316330L,237968639936L,1917578268288L,15546796822656L,126728260011920L,1037987924978125L,8538459191677170L,70509828893263474L,584310452973463242L,4857624566855734836L,BigInteger.Parse("40501472981905806550"),BigInteger.Parse("338594135314564168494"),BigInteger.Parse("2837641019938074131463"),BigInteger.Parse("23835438376045780734390"),BigInteger.Parse("200633658871150345742269"),BigInteger.Parse("1692132786239339256115050"),BigInteger.Parse("14297391426538004065333910"),BigInteger.Parse("121009206594941545408186768") };
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
public class A274379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274379Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274379.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274379Inst Instance=new A274379Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274380
{
public static readonly long[] Value={ 34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L,34L,54L,42L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274380Inst : IEnumerable<long>
{
public static readonly long[] Value=A274380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274380.Bytes);
public long this[int i]=>Value[i];

public static A274380Inst Instance=new A274380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274381
{
public static readonly long[] Value={ 23L,59L,83L,359L,479L,563L,839L,863L,1283L,2039L,2879L,2999L,3779L,4259L,4679L,5483L,7703L,10079L,12203L,13103L,23603L,26903L,27803L,30323L,31583L,33623L,35339L,41519L,43403L,44519L,44939L,53759L,55079L,57119L,57899L,58043L,65123L,66359L,70139L,70199L,76379L,77723L,79943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274381Inst : IEnumerable<long>
{
public static readonly long[] Value=A274381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274381.Bytes);
public long this[int i]=>Value[i];

public static A274381Inst Instance=new A274381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274382
{
public static readonly long[] Value={ 1L,2L,1L,1L,1L,3L,1L,1L,1L,1L,1L,2L,1L,1L,3L,1L,1L,6L,1L,4L,1L,1L,1L,24L,1L,1L,1L,14L,1L,3L,1L,1L,3L,1L,1L,1L,1L,1L,1L,10L,1L,3L,1L,2L,3L,1L,1L,4L,1L,2L,3L,4L,1L,3L,1L,4L,1L,1L,1L,6L,1L,1L,1L,1L,1L,3L,1L,4L,3L,1L,1L,3L,1L,1L,1L,2L,1L,3L,1L,2L,1L,1L,1L,14L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274382Inst : IEnumerable<long>
{
public static readonly long[] Value=A274382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274382.Bytes);
public long this[int i]=>Value[i];

public static A274382Inst Instance=new A274382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274383
{
public static readonly long[] Value={ 4L,7L,10L,15L,18L,23L,29L,35L,40L,47L,54L,60L,68L,75L,83L,90L,99L,107L,116L,125L,134L,143L,152L,162L,172L,182L,193L,203L,214L,225L,236L,248L,259L,271L,283L,295L,307L,320L,332L,345L,358L,372L,385L,398L,412L,426L,440L,454L,469L,483L,498L,513L,528L,543L,559L,574L,590L,606L,622L,638L,654L,671L,688L,704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274383Inst : IEnumerable<long>
{
public static readonly long[] Value=A274383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274383.Bytes);
public long this[int i]=>Value[i];

public static A274383Inst Instance=new A274383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274384
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,11L,13L,14L,16L,17L,19L,20L,22L,23L,25L,26L,28L,29L,31L,32L,34L,37L,40L,43L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274384Inst : IEnumerable<long>
{
public static readonly long[] Value=A274384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274384.Bytes);
public long this[int i]=>Value[i];

public static A274384Inst Instance=new A274384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274385
{
public static readonly BigInteger[] Value={ 2L,3L,7L,47L,383L,10321919L,51011754393599L,BigInteger.Parse("1130138339199322632554990773529330319359999999"),BigInteger.Parse("73562883979319395645666688474019139929848516028923903999999999"),BigInteger.Parse("4208832729023498248022825567687608993477547383960134557368319999999999") };
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
public class A274385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274385Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274385.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274385Inst Instance=new A274385Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274386
{
public static readonly BigInteger[] Value={ 2L,3L,5L,11L,17L,19L,29L,79L,163L,281L,881L,209441L,4188799L,264539521L,2504902399L,72642169601L,254561089305599L,9927882482918401L,26582634158080001L,BigInteger.Parse("13106744139423334399999"),BigInteger.Parse("141383412854531380076544001"),BigInteger.Parse("427380210218181008588800001") };
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
public class A274386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274386Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274386.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274386Inst Instance=new A274386Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274387
{
public static readonly BigInteger[] Value={ 1L,1L,3L,43L,1345L,71721L,5787931L,656778529L,99609347825L,19451450431009L,4752356577301171L,1419957082098657081L,BigInteger.Parse("509327639955159790777"),BigInteger.Parse("215968308944943346029577"),BigInteger.Parse("106859555896120941092549371"),BigInteger.Parse("61015970334444558798467062801"),BigInteger.Parse("39820542372512292977427634794721"),BigInteger.Parse("29454908124155520098406206592241281"),BigInteger.Parse("24512125500202005940687498958550124771"),BigInteger.Parse("22799363145943007981544986753209784020249"),BigInteger.Parse("23563018240183207044471748499194925348436201") };
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
public class A274387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274387Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274387.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274387Inst Instance=new A274387Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274388
{
public static readonly BigInteger[] Value={ 1L,1L,5L,82L,2729L,151376L,12567187L,1457297878L,224869459201L,44538286061152L,11011493721321251L,3323602336722922574L,BigInteger.Parse("1202633627172086804257"),BigInteger.Parse("513869583003728865617848"),BigInteger.Parse("255985770924976071728925555"),BigInteger.Parse("147050140379016992236158750526"),BigInteger.Parse("96489590122440823908683879560193"),BigInteger.Parse("71722476615114676804476795900453248"),BigInteger.Parse("59952692198711311645811325484552353091"),BigInteger.Parse("55990325778560798795385664699772933184190"),BigInteger.Parse("58081532846176563089250398770056580653829601") };
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
public class A274388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274388Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274388.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274388Inst Instance=new A274388Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274389
{
public static readonly BigInteger[] Value={ 1L,2L,30L,948L,50680L,4090980L,463975764L,70311813880L,13718193268896L,3348658563980040L,999698412743754460L,BigInteger.Parse("358297471515195652308"),BigInteger.Parse("151813934699349280088328"),BigInteger.Parse("75064081768759279536110316"),BigInteger.Parse("42833194538353991390132088540"),BigInteger.Parse("27937122503026656234469859408880"),BigInteger.Parse("20653210428143999114034181337343616"),BigInteger.Parse("17178393944175652034128269331788145680"),BigInteger.Parse("15970217696130529428248774113884778921452"),BigInteger.Parse("16497536217367322285994072192399435877530380"),BigInteger.Parse("18836957575278690757486149667782477659475272520") };
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
public class A274389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274389Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274389.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274389Inst Instance=new A274389Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274390
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,0L,1L,4L,9L,0L,1L,6L,30L,64L,0L,1L,8L,63L,332L,625L,0L,1L,10L,108L,948L,4880L,7776L,0L,1L,12L,165L,2056L,18645L,89742L,117649L,0L,1L,14L,234L,3800L,50680L,454158L,1986124L,2097152L,0L,1L,16L,315L,6324L,112625L,1537524L,13221075L,51471800L,43046721L,0L,1L,18L,408L,9772L,219000L,4090980L,55494712L,448434136L,1530489744L,1000000000L,0L,1L,20L,513L,14288L,387205L,9266706L,176238685L,2325685632L,17386204761L,51395228090L,25937424601L,0L,1L,22L,630L,20016L,637520L,18704322L,463975764L,8793850560L,111107380464L,759123121050L,1924687118684L,743008370688L,0L,1L,24L,759L,27100L,993105L,34617288L,1067280319L,26858490392L,499217336145L,5964692819140L,36882981687519L,79553145323940L,23298085122481L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274390Inst : IEnumerable<long>
{
public static readonly long[] Value=A274390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274390.Bytes);
public long this[int i]=>Value[i];

public static A274390Inst Instance=new A274390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274391
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,5L,16L,1L,1L,1L,7L,43L,125L,1L,1L,1L,9L,82L,525L,1296L,1L,1L,1L,11L,133L,1345L,8321L,16807L,1L,1L,1L,13L,196L,2729L,28396L,162463L,262144L,1L,1L,1L,15L,271L,4821L,71721L,734149L,3774513L,4782969L,1L,1L,1L,17L,358L,7765L,151376L,2300485L,22485898L,101808185L,100000000L,1L,1L,1L,19L,457L,11705L,283321L,5787931L,87194689L,796769201L,3129525793L,2357947691L,1L,1L,1L,21L,568L,16785L,486396L,12567187L,261066156L,3815719969L,32084546824L,108063152091L,61917364224L,1L,1L,1L,23L,691L,23149L,782321L,24539593L,656778529L,13577077401L,189440927857L,1447917011461L,4143297446729L,1792160394037L,1L,1L,1L,25L,826L,30941L,1195696L,44223529L,1457297878L,39536713209L,800175234736L,10525328121221L,72411962077126L,174723134310277L,56693912375296L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274391Inst : IEnumerable<long>
{
public static readonly long[] Value=A274391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274391.Bytes);
public long this[int i]=>Value[i];

public static A274391Inst Instance=new A274391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274392
{
public static readonly BigInteger[] Value={ 1L,4L,63L,2056L,112625L,9266706L,1067280319L,163802295616L,32300931452769L,7956776354536450L,2394142654816299431L,BigInteger.Parse("863996246301971667600"),BigInteger.Parse("368314015001746325448313"),BigInteger.Parse("183100281424495288847092386"),BigInteger.Parse("104989565698848905178879275775"),BigInteger.Parse("68778360046311927838608116567296"),BigInteger.Parse("51049027217135211093037275781929857"),BigInteger.Parse("42614907995326324626989103964953188610"),BigInteger.Parse("39750079580111447237206552931429888023399"),BigInteger.Parse("41188867531604111691413161924808444678694800"),BigInteger.Parse("47163303540183246052916530453746351377795346681") };
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
public class A274392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274392Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274392.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274392Inst Instance=new A274392Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274393
{
public static readonly BigInteger[] Value={ 1L,2L,9L,56L,545L,6696L,100009L,1756112L,35480673L,811332080L,20696592521L,583009540488L,17972297981521L,601961695890296L,21765379980020265L,844991974575946016L,BigInteger.Parse("35056808550027808961"),BigInteger.Parse("1547900555791042958688"),BigInteger.Parse("72474037424646843142153"),BigInteger.Parse("3586609339433026549298840"),BigInteger.Parse("187062738581835989450074161"),BigInteger.Parse("10255505482370456224398408872"),BigInteger.Parse("589611389520200188085133153449") };
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
public class A274393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274393Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274393.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274393Inst Instance=new A274393Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274394
{
public static readonly BigInteger[] Value={ 1L,2L,9L,64L,595L,7416L,111979L,1989632L,40695561L,941667040L,24323649361L,693818707968L,21661372820971L,734712173277824L,26902827107293635L,1057724890214957056L,BigInteger.Parse("44442356900221356241"),BigInteger.Parse("1987370544970750468608"),BigInteger.Parse("94240073170115929379161"),BigInteger.Parse("4723448516579307027169280"),BigInteger.Parse("249510355552473169494452931"),BigInteger.Parse("13854414947224528743034304512"),BigInteger.Parse("806733172355775780726416256859") };
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
public class A274394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274394Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274394.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274394Inst Instance=new A274394Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274395
{
public static readonly BigInteger[] Value={ 1L,2L,9L,64L,625L,7632L,115633L,2060864L,42272577L,981100000L,25420901209L,727392785472L,22781551770289L,775174385740496L,28475611427390625L,1123174379270470528L,BigInteger.Parse("47345176946662808833"),BigInteger.Parse("2124056646149570472384"),BigInteger.Parse("101049649535116764217513"),BigInteger.Parse("5081280208216339430000000"),BigInteger.Parse("269289663191356712678537841"),BigInteger.Parse("15001629187601225176466619952"),BigInteger.Parse("876397229390129697388339920049") };
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
public class A274395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274395Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274395.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274395Inst Instance=new A274395Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274396
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,52L,246L,1224L,6300L,33300L,179643L,985014L,5473611L,30756638L,174460232L,997620618L,5744867987L,33286011182L,193909247415L,1135089596103L,6673249089811L,39385246833252L,233269982839202L,1386037324968892L,8259646628699352L,49352953593386343L,295622321452540572L,1774808912507223393L,10677836739621878302UL,BigInteger.Parse("64367558119301035734"),BigInteger.Parse("388726705119505499253"),BigInteger.Parse("2351595589979028349894") };
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
public class A274396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274396Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274396.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274396Inst Instance=new A274396Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274397
{
public static readonly long[] Value={ 8L,19L,24L,27L,29L,38L,40L,54L,56L,57L,58L,59L,72L,76L,79L,87L,88L,89L,95L,104L,108L,109L,114L,116L,118L,120L,128L,133L,135L,136L,139L,145L,149L,152L,158L,168L,171L,174L,177L,178L,179L,184L,189L,190L,199L,200L,203L,209L,216L,218L,228L,229L,232L,236L,237L,239L,247L,248L,261L,264L,266L,267L,269L,270L,278L,280L,285L,290L,295L,296L,297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274397Inst : IEnumerable<long>
{
public static readonly long[] Value=A274397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274397.Bytes);
public long this[int i]=>Value[i];

public static A274397Inst Instance=new A274397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274398
{
public static readonly long[] Value={ 1L,13L,-83L,649L,-59L,2089L,-7379L,8829L,-410479L,84273L,-4091L,2032897L,-867947L,951417L,-47224023L,2228469L,-262139L,19669687769L,-1048571L,1461748549L,-1500199283L,746586657L,-16777211L,747004180629L,-6777994779L,7113541809L,-13667368865299L,29908738140693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274398Inst : IEnumerable<long>
{
public static readonly long[] Value=A274398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274398.Bytes);
public long this[int i]=>Value[i];

public static A274398Inst Instance=new A274398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274399
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,67L,68L,69L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274399Inst : IEnumerable<long>
{
public static readonly long[] Value=A274399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274399.Bytes);
public long this[int i]=>Value[i];

public static A274399Inst Instance=new A274399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274400
{
public static readonly long[] Value={ 0L,3L,9L,0L,1L,2L,7L,2L,6L,3L,6L,0L,1L,6L,7L,1L,6L,6L,0L,1L,7L,5L,6L,6L,9L,4L,1L,3L,5L,4L,5L,0L,0L,4L,6L,1L,7L,5L,7L,4L,7L,5L,8L,5L,7L,1L,3L,8L,6L,1L,3L,0L,9L,9L,0L,1L,4L,9L,3L,8L,9L,6L,7L,3L,9L,5L,4L,0L,3L,8L,9L,2L,7L,5L,0L,1L,8L,5L,6L,5L,4L,8L,7L,1L,8L,1L,2L,1L,8L,8L,1L,2L,8L,2L,8L,4L,2L,6L,1L,2L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274400Inst : IEnumerable<long>
{
public static readonly long[] Value=A274400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274400.Bytes);
public long this[int i]=>Value[i];

public static A274400Inst Instance=new A274400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274401
{
public static readonly long[] Value={ 0L,1L,8L,3L,16L,7L,32L,13L,48L,19L,80L,29L,96L,41L,144L,49L,176L,65L,224L,83L,256L,95L,336L,117L,368L,137L,464L,155L,512L,183L,576L,213L,640L,233L,768L,257L,816L,293L,960L,317L,1024L,357L,1120L,399L,1200L,423L,1376L,469L,1440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274401Inst : IEnumerable<long>
{
public static readonly long[] Value=A274401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274401.Bytes);
public long this[int i]=>Value[i];

public static A274401Inst Instance=new A274401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274402
{
public static readonly long[] Value={ 2L,6L,0L,4L,3L,4L,1L,3L,7L,6L,3L,2L,1L,6L,2L,0L,9L,8L,9L,5L,5L,7L,2L,9L,1L,4L,3L,2L,0L,8L,0L,3L,0L,7L,8L,5L,4L,5L,5L,0L,4L,4L,7L,7L,8L,8L,4L,8L,4L,2L,8L,4L,7L,3L,4L,0L,7L,3L,6L,6L,6L,8L,7L,6L,5L,5L,6L,2L,8L,9L,9L,4L,8L,8L,3L,8L,7L,2L,7L,3L,9L,3L,6L,4L,2L,8L,9L,8L,5L,6L,9L,4L,4L,0L,6L,9L,9L,5L,3L,6L,7L,3L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274402Inst : IEnumerable<long>
{
public static readonly long[] Value=A274402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274402.Bytes);
public long this[int i]=>Value[i];

public static A274402Inst Instance=new A274402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274403
{
public static readonly long[] Value={ 3L,36L,361L,3503L,34065L,332712L,3252966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274403Inst : IEnumerable<long>
{
public static readonly long[] Value=A274403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274403.Bytes);
public long this[int i]=>Value[i];

public static A274403Inst Instance=new A274403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274404
{
public static readonly long[] Value={ 1L,1L,2L,5L,1L,14L,6L,42L,28L,3L,132L,120L,28L,1L,429L,495L,180L,20L,1430L,2002L,990L,195L,10L,4862L,8008L,5005L,1430L,165L,4L,16796L,31824L,24024L,9009L,1650L,117L,1L,58786L,125970L,111384L,51688L,13013L,1617L,70L,208012L,497420L,503880L,278460L,89180L,16016L,1386L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274404Inst : IEnumerable<long>
{
public static readonly long[] Value=A274404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274404.Bytes);
public long this[int i]=>Value[i];

public static A274404Inst Instance=new A274404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274405
{
public static readonly long[] Value={ 0L,0L,0L,1L,6L,34L,179L,915L,4607L,22988L,114090L,564359L,2785921L,13735074L,67665208L,333211828L,1640575047L,8077199130L,39770520844L,195852723348L,964689515033L,4752800817185L,23422061819883L,115456855588378L,569293729146929L,2807864888917275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274405Inst : IEnumerable<long>
{
public static readonly long[] Value=A274405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274405.Bytes);
public long this[int i]=>Value[i];

public static A274405Inst Instance=new A274405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274406
{
public static readonly long[] Value={ 0L,8L,9L,17L,18L,26L,27L,35L,36L,44L,45L,53L,54L,62L,63L,71L,72L,80L,81L,89L,90L,98L,99L,107L,108L,116L,117L,125L,126L,134L,135L,143L,144L,152L,153L,161L,162L,170L,171L,179L,180L,188L,189L,197L,198L,206L,207L,215L,216L,224L,225L,233L,234L,242L,243L,251L,252L,260L,261L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274406Inst : IEnumerable<long>
{
public static readonly long[] Value=A274406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274406.Bytes);
public long this[int i]=>Value[i];

public static A274406Inst Instance=new A274406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274407
{
public static readonly long[] Value={ 13L,19L,23L,26L,29L,39L,46L,49L,59L,69L,79L,89L,101L,102L,104L,105L,148L,167L,201L,202L,204L,205L,208L,257L,301L,302L,303L,304L,305L,306L,313L,323L,326L,346L,347L,348L,401L,402L,404L,405L,408L,437L,501L,502L,504L,505L,527L,548L,601L,602L,603L,604L,605L,606L,608L,613L,617L,623L,626L,646L,701L,702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274407Inst : IEnumerable<long>
{
public static readonly long[] Value=A274407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274407.Bytes);
public long this[int i]=>Value[i];

public static A274407Inst Instance=new A274407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274408
{
public static readonly long[] Value={ 2L,11L,13L,23L,29L,31L,17L,41L,211L,19L,53L,223L,101L,103L,227L,229L,107L,109L,233L,113L,239L,241L,251L,257L,37L,43L,59L,47L,307L,311L,127L,131L,137L,263L,269L,139L,271L,277L,149L,151L,157L,401L,409L,419L,281L,163L,167L,283L,173L,179L,293L,2003L,2011L,2017L,181L,2027L,2029L,191L,313L,2039L,193L,421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274408Inst : IEnumerable<long>
{
public static readonly long[] Value=A274408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274408.Bytes);
public long this[int i]=>Value[i];

public static A274408Inst Instance=new A274408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274409
{
public static readonly long[] Value={ 2L,2L,8L,12L,32L,18L,128L,24L,336L,992L,2048L,1348L,8192L,16256L,6060L,43680L,131072L,20160L,524288L,429528L,39248L,4192256L,8388608L,15632L,24165120L,67100672L,133432320L,54894172L,536870912L,555642580L,2147483648L,518918400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274409Inst : IEnumerable<long>
{
public static readonly long[] Value=A274409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274409.Bytes);
public long this[int i]=>Value[i];

public static A274409Inst Instance=new A274409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274410
{
public static readonly long[] Value={ 3067L,4088L,4089L,5742L,6135L,7151L,8179L,8263L,8614L,9979L,10904L,10905L,11016L,11017L,11485L,12922L,13304L,13305L,14303L,14538L,14539L,14689L,15303L,15313L,16527L,16891L,17229L,19384L,19385L,19386L,19585L,19959L,20417L,21482L,21791L,21808L,21811L,22035L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274410Inst : IEnumerable<long>
{
public static readonly long[] Value=A274410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274410.Bytes);
public long this[int i]=>Value[i];

public static A274410Inst Instance=new A274410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274411
{
public static readonly long[] Value={ 3067L,4088L,6135L,7151L,8179L,9979L,10904L,13304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274411Inst : IEnumerable<long>
{
public static readonly long[] Value=A274411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274411.Bytes);
public long this[int i]=>Value[i];

public static A274411Inst Instance=new A274411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274412
{
public static readonly long[] Value={ 1L,0L,4L,5L,9L,3L,1L,1L,1L,2L,0L,0L,9L,0L,9L,8L,0L,2L,8L,6L,9L,4L,6L,4L,4L,0L,0L,5L,8L,6L,9L,2L,2L,0L,3L,6L,5L,2L,9L,1L,4L,1L,7L,0L,6L,0L,9L,7L,9L,9L,1L,7L,4L,0L,1L,3L,8L,0L,2L,5L,5L,7L,9L,7L,8L,3L,8L,3L,3L,9L,1L,0L,8L,3L,2L,7L,8L,7L,8L,5L,0L,8L,0L,7L,8L,9L,4L,6L,4L,1L,4L,9L,4L,8L,1L,1L,1L,1L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274412Inst : IEnumerable<long>
{
public static readonly long[] Value=A274412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274412.Bytes);
public long this[int i]=>Value[i];

public static A274412Inst Instance=new A274412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274413
{
public static readonly long[] Value={ 1L,8L,0L,0L,7L,2L,5L,2L,5L,0L,4L,0L,1L,8L,7L,4L,7L,5L,4L,8L,1L,8L,4L,1L,0L,4L,8L,6L,3L,6L,2L,8L,6L,0L,4L,3L,0L,7L,1L,6L,1L,6L,2L,9L,9L,4L,4L,4L,9L,3L,5L,8L,7L,5L,2L,3L,3L,8L,7L,4L,8L,2L,5L,4L,8L,3L,0L,4L,2L,6L,1L,5L,3L,7L,8L,3L,0L,3L,4L,3L,0L,8L,3L,3L,4L,1L,8L,7L,0L,6L,1L,9L,4L,7L,5L,1L,1L,9L,6L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274413Inst : IEnumerable<long>
{
public static readonly long[] Value=A274413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274413.Bytes);
public long this[int i]=>Value[i];

public static A274413Inst Instance=new A274413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274414
{
public static readonly long[] Value={ 1L,1L,2L,0L,2L,4L,8L,3L,9L,7L,0L,3L,9L,2L,4L,2L,0L,8L,2L,2L,7L,2L,5L,1L,6L,5L,4L,8L,2L,2L,4L,2L,0L,9L,5L,2L,6L,2L,7L,5L,7L,7L,6L,6L,7L,1L,9L,7L,9L,0L,6L,8L,8L,9L,7L,3L,9L,2L,2L,4L,5L,8L,6L,6L,4L,9L,8L,4L,1L,4L,0L,3L,9L,1L,8L,3L,6L,7L,2L,3L,4L,4L,4L,4L,8L,4L,3L,6L,5L,7L,9L,8L,9L,6L,6L,6L,2L,8L,4L,7L,9L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274414Inst : IEnumerable<long>
{
public static readonly long[] Value=A274414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274414.Bytes);
public long this[int i]=>Value[i];

public static A274414Inst Instance=new A274414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274415
{
public static readonly long[] Value={ 2L,5L,2L,8L,5L,6L,7L,6L,8L,4L,4L,4L,2L,6L,7L,8L,0L,1L,1L,2L,4L,5L,6L,0L,4L,2L,9L,9L,8L,0L,1L,8L,1L,1L,1L,8L,0L,3L,8L,2L,8L,4L,0L,8L,1L,3L,2L,2L,5L,5L,4L,8L,8L,7L,8L,3L,9L,3L,1L,5L,6L,6L,0L,6L,9L,4L,6L,0L,5L,6L,3L,1L,0L,9L,6L,4L,8L,4L,1L,0L,7L,7L,8L,9L,3L,4L,5L,1L,4L,8L,1L,8L,1L,9L,2L,8L,7L,7L,0L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274415Inst : IEnumerable<long>
{
public static readonly long[] Value=A274415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274415.Bytes);
public long this[int i]=>Value[i];

public static A274415Inst Instance=new A274415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274416
{
public static readonly long[] Value={ 2L,8L,6L,0L,8L,6L,2L,2L,2L,4L,1L,3L,9L,3L,2L,7L,3L,5L,0L,2L,7L,2L,7L,8L,4L,5L,6L,7L,7L,7L,3L,2L,4L,1L,9L,1L,7L,5L,6L,1L,4L,4L,1L,4L,6L,2L,0L,2L,0L,1L,0L,0L,0L,3L,9L,5L,0L,0L,1L,6L,6L,1L,1L,9L,6L,6L,7L,1L,7L,8L,3L,1L,2L,4L,1L,1L,5L,2L,0L,3L,7L,5L,8L,3L,6L,2L,8L,4L,1L,4L,8L,7L,0L,9L,2L,5L,4L,4L,4L,9L,8L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274416Inst : IEnumerable<long>
{
public static readonly long[] Value=A274416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274416.Bytes);
public long this[int i]=>Value[i];

public static A274416Inst Instance=new A274416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274417
{
public static readonly long[] Value={ 3L,0L,2L,7L,0L,0L,9L,4L,9L,3L,9L,8L,7L,6L,5L,2L,0L,1L,9L,7L,8L,6L,3L,7L,4L,7L,0L,1L,7L,5L,8L,9L,5L,7L,2L,8L,6L,1L,5L,0L,7L,4L,1L,7L,8L,6L,4L,1L,7L,3L,7L,5L,6L,2L,0L,0L,5L,3L,6L,7L,0L,8L,7L,6L,0L,2L,7L,7L,3L,9L,3L,1L,3L,1L,3L,4L,8L,6L,0L,0L,2L,4L,8L,0L,7L,7L,0L,0L,4L,8L,2L,1L,5L,4L,2L,3L,7L,8L,2L,1L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274417Inst : IEnumerable<long>
{
public static readonly long[] Value=A274417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274417.Bytes);
public long this[int i]=>Value[i];

public static A274417Inst Instance=new A274417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274418
{
public static readonly long[] Value={ 5L,9L,1L,3L,2L,0L,4L,7L,8L,3L,8L,8L,4L,0L,2L,0L,5L,3L,0L,4L,9L,5L,7L,1L,7L,8L,9L,2L,5L,3L,5L,4L,0L,5L,0L,2L,6L,8L,8L,3L,4L,1L,0L,9L,9L,1L,5L,3L,3L,9L,8L,0L,7L,0L,7L,2L,0L,8L,2L,7L,4L,1L,1L,7L,2L,1L,2L,0L,6L,0L,9L,5L,6L,3L,0L,0L,1L,1L,0L,2L,8L,2L,2L,9L,2L,7L,9L,2L,8L,4L,4L,6L,6L,5L,4L,3L,7L,6L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274418Inst : IEnumerable<long>
{
public static readonly long[] Value=A274418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274418.Bytes);
public long this[int i]=>Value[i];

public static A274418Inst Instance=new A274418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274419
{
public static readonly long[] Value={ 6L,0L,5L,4L,1L,6L,7L,8L,5L,8L,5L,9L,0L,2L,1L,9L,7L,3L,9L,3L,6L,9L,3L,9L,9L,5L,6L,9L,1L,6L,1L,4L,4L,8L,7L,9L,4L,8L,1L,3L,1L,1L,5L,3L,6L,2L,0L,0L,3L,5L,8L,2L,4L,0L,3L,6L,5L,2L,1L,1L,3L,8L,1L,4L,4L,9L,8L,3L,2L,1L,7L,7L,2L,5L,3L,7L,5L,0L,2L,6L,9L,8L,7L,7L,8L,7L,7L,1L,7L,1L,7L,8L,0L,4L,3L,8L,5L,7L,7L,0L,2L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274419Inst : IEnumerable<long>
{
public static readonly long[] Value=A274419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274419.Bytes);
public long this[int i]=>Value[i];

public static A274419Inst Instance=new A274419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274420
{
public static readonly long[] Value={ 8L,2L,1L,6L,8L,5L,9L,8L,1L,7L,5L,0L,8L,7L,3L,8L,0L,6L,2L,9L,1L,3L,3L,9L,8L,3L,3L,8L,6L,0L,1L,0L,8L,5L,8L,2L,4L,9L,6L,9L,5L,0L,8L,3L,3L,9L,1L,7L,2L,5L,7L,5L,0L,3L,6L,8L,3L,5L,5L,7L,5L,7L,9L,1L,1L,5L,3L,3L,5L,1L,9L,6L,8L,1L,6L,3L,1L,9L,2L,6L,2L,3L,1L,2L,2L,4L,2L,9L,9L,0L,3L,4L,1L,4L,0L,6L,1L,1L,9L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274420Inst : IEnumerable<long>
{
public static readonly long[] Value=A274420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274420.Bytes);
public long this[int i]=>Value[i];

public static A274420Inst Instance=new A274420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274421
{
public static readonly long[] Value={ 1L,0L,0L,3L,5L,2L,7L,8L,4L,7L,9L,7L,6L,8L,7L,8L,9L,1L,7L,1L,9L,1L,4L,7L,0L,0L,6L,8L,5L,1L,5L,8L,9L,0L,0L,2L,3L,8L,6L,5L,0L,3L,3L,3L,4L,9L,6L,0L,0L,2L,7L,5L,1L,3L,4L,0L,5L,4L,4L,5L,2L,5L,8L,0L,0L,6L,6L,3L,9L,1L,4L,1L,2L,4L,1L,3L,2L,6L,9L,5L,4L,1L,9L,0L,6L,3L,4L,9L,2L,4L,4L,6L,4L,1L,0L,3L,0L,3L,0L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274421Inst : IEnumerable<long>
{
public static readonly long[] Value=A274421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274421.Bytes);
public long this[int i]=>Value[i];

public static A274421Inst Instance=new A274421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274422
{
public static readonly long[] Value={ 13L,17L,20L,23L,24L,34L,40L,82L,126L,200L,612L,1154L,1692L,2434L,2806L,3060L,3142L,4052L,4460L,4596L,5020L,5908L,6424L,7304L,7596L,8030L,8040L,9044L,11398L,12254L,12914L,13412L,13716L,16006L,16800L,18560L,22438L,23140L,24424L,24746L,25706L,28318L,29272L,30580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274422Inst : IEnumerable<long>
{
public static readonly long[] Value=A274422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274422.Bytes);
public long this[int i]=>Value[i];

public static A274422Inst Instance=new A274422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274423
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,44L,48L,66L,90L,108L,156L,206L,284L,854L,1002L,1188L,1194L,1212L,1320L,2234L,2460L,2792L,3336L,3478L,7096L,7164L,7218L,7236L,7752L,8304L,9164L,10272L,12090L,12594L,13322L,15530L,17038L,17162L,18026L,18212L,20412L,20494L,21966L,23374L,23518L,24664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274423Inst : IEnumerable<long>
{
public static readonly long[] Value=A274423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274423.Bytes);
public long this[int i]=>Value[i];

public static A274423Inst Instance=new A274423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274424
{
public static readonly long[] Value={ 13L,19L,48L,63L,67L,76L,94L,99L,123L,141L,143L,150L,179L,193L,247L,249L,285L,339L,404L,445L,517L,693L,711L,798L,969L,982L,1054L,1138L,1233L,1245L,1257L,1262L,1364L,1524L,1531L,1569L,1613L,1694L,1701L,1743L,1745L,1928L,2018L,2070L,2114L,2224L,2339L,2461L,2770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274424Inst : IEnumerable<long>
{
public static readonly long[] Value=A274424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274424.Bytes);
public long this[int i]=>Value[i];

public static A274424Inst Instance=new A274424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274425
{
public static readonly long[] Value={ 4L,6L,21L,18L,13L,11L,67L,48L,25L,149L,45L,174L,122L,31L,36L,139L,42L,64L,90L,57L,106L,325L,102L,216L,111L,258L,143L,321L,226L,472L,73L,60L,82L,184L,540L,135L,93L,264L,169L,130L,549L,53L,200L,180L,229L,99L,298L,622L,671L,358L,157L,117L,1487L,476L,1478L,85L,513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274425Inst : IEnumerable<long>
{
public static readonly long[] Value=A274425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274425.Bytes);
public long this[int i]=>Value[i];

public static A274425Inst Instance=new A274425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274426
{
public static readonly long[] Value={ 6L,10L,12L,15L,16L,21L,24L,26L,28L,33L,39L,40L,42L,44L,54L,63L,65L,68L,72L,77L,87L,102L,104L,105L,110L,116L,126L,141L,165L,168L,170L,178L,188L,198L,203L,228L,267L,272L,273L,275L,288L,304L,319L,329L,369L,432L,440L,442L,445L,466L,492L,517L,522L,532L,597L,699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274426Inst : IEnumerable<long>
{
public static readonly long[] Value=A274426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274426.Bytes);
public long this[int i]=>Value[i];

public static A274426Inst Instance=new A274426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274427
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,11L,12L,13L,16L,17L,18L,22L,23L,24L,25L,29L,30L,31L,32L,37L,38L,39L,40L,41L,46L,47L,48L,49L,50L,56L,57L,58L,59L,60L,61L,67L,68L,69L,70L,71L,72L,79L,80L,81L,82L,83L,84L,85L,92L,93L,94L,95L,96L,97L,98L,106L,107L,108L,109L,110L,111L,112L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274427Inst : IEnumerable<long>
{
public static readonly long[] Value=A274427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274427.Bytes);
public long this[int i]=>Value[i];

public static A274427Inst Instance=new A274427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274428
{
public static readonly long[] Value={ 3L,6L,9L,10L,14L,15L,19L,20L,21L,26L,27L,28L,33L,34L,35L,36L,42L,43L,44L,45L,51L,52L,53L,54L,55L,62L,63L,64L,65L,66L,73L,74L,75L,76L,77L,78L,86L,87L,88L,89L,90L,91L,99L,100L,101L,102L,103L,104L,105L,114L,115L,116L,117L,118L,119L,120L,129L,130L,131L,132L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274428Inst : IEnumerable<long>
{
public static readonly long[] Value=A274428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274428.Bytes);
public long this[int i]=>Value[i];

public static A274428Inst Instance=new A274428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274429
{
public static readonly long[] Value={ 3L,4L,6L,7L,10L,11L,12L,15L,16L,18L,21L,24L,26L,28L,29L,33L,39L,40L,42L,44L,47L,54L,63L,65L,68L,72L,76L,77L,87L,102L,104L,105L,110L,116L,123L,126L,141L,165L,168L,170L,178L,188L,198L,199L,203L,228L,267L,272L,273L,275L,288L,304L,319L,322L,329L,369L,432L,440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274429Inst : IEnumerable<long>
{
public static readonly long[] Value=A274429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274429.Bytes);
public long this[int i]=>Value[i];

public static A274429Inst Instance=new A274429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274430
{
public static readonly long[] Value={ 3L,5L,8L,9L,12L,13L,17L,18L,19L,23L,24L,25L,30L,31L,32L,33L,38L,39L,40L,41L,47L,48L,49L,50L,51L,57L,58L,59L,60L,61L,68L,69L,70L,71L,72L,73L,80L,81L,82L,83L,84L,85L,93L,94L,95L,96L,97L,98L,99L,107L,108L,109L,110L,111L,112L,113L,122L,123L,124L,125L,126L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274430Inst : IEnumerable<long>
{
public static readonly long[] Value=A274430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274430.Bytes);
public long this[int i]=>Value[i];

public static A274430Inst Instance=new A274430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274431
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,10L,11L,14L,15L,16L,20L,21L,22L,26L,27L,28L,29L,34L,35L,36L,37L,42L,43L,44L,45L,46L,52L,53L,54L,55L,56L,62L,63L,64L,65L,66L,67L,74L,75L,76L,77L,78L,79L,86L,87L,88L,89L,90L,91L,92L,100L,101L,102L,103L,104L,105L,106L,114L,115L,116L,117L,118L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274431Inst : IEnumerable<long>
{
public static readonly long[] Value=A274431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274431.Bytes);
public long this[int i]=>Value[i];

public static A274431Inst Instance=new A274431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274432
{
public static readonly long[] Value={ 3L,5L,9L,15L,17L,27L,31L,45L,51L,57L,85L,93L,105L,135L,153L,155L,171L,193L,255L,279L,285L,315L,355L,459L,465L,513L,525L,527L,579L,653L,765L,837L,855L,945L,965L,969L,1065L,1201L,1395L,1539L,1575L,1581L,1737L,1767L,1775L,1785L,1959L,2209L,2295L,2565L,2635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274432Inst : IEnumerable<long>
{
public static readonly long[] Value=A274432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274432.Bytes);
public long this[int i]=>Value[i];

public static A274432Inst Instance=new A274432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274433
{
public static readonly long[] Value={ 15L,27L,45L,51L,85L,93L,153L,155L,171L,279L,285L,315L,513L,525L,527L,579L,945L,965L,969L,1065L,1737L,1767L,1775L,1785L,1959L,3195L,3255L,3265L,3281L,3603L,5877L,5983L,5985L,6005L,6035L,6627L,10809L,11001L,11005L,11045L,11101L,12189L,19881L,20235L,20243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274433Inst : IEnumerable<long>
{
public static readonly long[] Value=A274433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274433.Bytes);
public long this[int i]=>Value[i];

public static A274433Inst Instance=new A274433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274434
{
public static readonly long[] Value={ 135L,255L,459L,465L,765L,837L,855L,1395L,1539L,1575L,1581L,2565L,2635L,2835L,2895L,2907L,4725L,4743L,4845L,5211L,5301L,5325L,5355L,8685L,8721L,8835L,8925L,9585L,9765L,9795L,9843L,15903L,15975L,16065L,16275L,16405L,17631L,17949L,17955L,18015L,18105L,29295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274434Inst : IEnumerable<long>
{
public static readonly long[] Value=A274434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274434.Bytes);
public long this[int i]=>Value[i];

public static A274434Inst Instance=new A274434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274435
{
public static readonly long[] Value={ 1L,3L,9L,14L,26L,27L,28L,35L,38L,42L,52L,56L,62L,65L,74L,76L,77L,78L,81L,84L,86L,95L,98L,104L,105L,112L,114L,119L,122L,124L,126L,134L,143L,146L,148L,152L,155L,156L,158L,161L,168L,172L,175L,185L,186L,194L,195L,196L,203L,206L,208L,209L,215L,218L,221L,222L,224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274435Inst : IEnumerable<long>
{
public static readonly long[] Value=A274435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274435.Bytes);
public long this[int i]=>Value[i];

public static A274435Inst Instance=new A274435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274436
{
public static readonly long[] Value={ 2L,4L,5L,6L,8L,10L,11L,12L,15L,16L,17L,18L,20L,22L,23L,24L,25L,29L,30L,32L,33L,34L,36L,40L,41L,44L,45L,46L,47L,48L,50L,51L,53L,54L,55L,58L,59L,60L,64L,66L,68L,69L,70L,71L,72L,75L,80L,82L,83L,85L,87L,88L,89L,90L,92L,94L,96L,99L,100L,101L,102L,106L,107L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274436Inst : IEnumerable<long>
{
public static readonly long[] Value=A274436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274436.Bytes);
public long this[int i]=>Value[i];

public static A274436Inst Instance=new A274436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274437
{
public static readonly long[] Value={ 7L,13L,19L,21L,31L,37L,39L,43L,49L,57L,61L,63L,67L,73L,79L,91L,93L,97L,103L,109L,111L,117L,127L,129L,133L,139L,147L,151L,157L,163L,169L,171L,181L,182L,183L,189L,193L,199L,201L,211L,217L,219L,223L,229L,237L,241L,247L,259L,266L,271L,273L,277L,279L,283L,291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274437Inst : IEnumerable<long>
{
public static readonly long[] Value=A274437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274437.Bytes);
public long this[int i]=>Value[i];

public static A274437Inst Instance=new A274437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274438
{
public static readonly long[] Value={ 4L,1L,2L,0L,4L,2L,5L,8L,5L,7L,6L,8L,5L,6L,3L,3L,0L,0L,9L,3L,3L,3L,1L,9L,3L,2L,0L,5L,8L,6L,5L,5L,1L,8L,3L,9L,6L,8L,9L,0L,2L,2L,8L,9L,8L,0L,5L,1L,0L,0L,9L,5L,3L,3L,7L,9L,9L,7L,4L,2L,6L,2L,6L,6L,7L,7L,5L,5L,4L,4L,1L,5L,8L,1L,0L,1L,0L,7L,0L,2L,6L,0L,8L,9L,2L,0L,1L,6L,3L,9L,2L,6L,8L,5L,9L,1L,6L,4L,5L,3L,9L,8L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274438Inst : IEnumerable<long>
{
public static readonly long[] Value=A274438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274438.Bytes);
public long this[int i]=>Value[i];

public static A274438Inst Instance=new A274438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274439
{
public static readonly long[] Value={ 2L,6L,3L,6L,1L,8L,5L,7L,2L,5L,2L,2L,4L,8L,7L,2L,2L,2L,6L,5L,4L,6L,4L,0L,2L,0L,4L,7L,9L,1L,9L,8L,6L,8L,6L,8L,5L,5L,3L,3L,9L,5L,2L,4L,3L,7L,4L,0L,8L,5L,4L,6L,5L,0L,4L,9L,6L,2L,6L,1L,4L,3L,4L,0L,2L,7L,6L,6L,5L,5L,4L,3L,8L,2L,5L,1L,8L,2L,0L,4L,0L,7L,9L,4L,7L,0L,6L,6L,7L,0L,6L,1L,6L,0L,6L,2L,2L,0L,5L,4L,7L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274439Inst : IEnumerable<long>
{
public static readonly long[] Value=A274439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274439.Bytes);
public long this[int i]=>Value[i];

public static A274439Inst Instance=new A274439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274440
{
public static readonly long[] Value={ 2L,2L,6L,0L,3L,9L,9L,2L,4L,8L,1L,2L,0L,4L,6L,3L,6L,8L,9L,9L,6L,0L,9L,2L,9L,0L,6L,6L,2L,4L,0L,8L,9L,5L,0L,3L,1L,9L,3L,0L,7L,6L,1L,5L,0L,0L,1L,6L,3L,3L,2L,1L,3L,8L,8L,8L,9L,4L,8L,8L,9L,0L,4L,2L,3L,2L,9L,0L,8L,5L,7L,4L,8L,5L,6L,8L,7L,2L,5L,7L,0L,5L,8L,8L,7L,5L,0L,4L,7L,0L,4L,6L,7L,8L,6L,2L,0L,3L,7L,4L,5L,0L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274440Inst : IEnumerable<long>
{
public static readonly long[] Value=A274440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274440.Bytes);
public long this[int i]=>Value[i];

public static A274440Inst Instance=new A274440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274441
{
public static readonly long[] Value={ 2L,0L,3L,4L,3L,6L,8L,9L,7L,1L,3L,1L,7L,2L,0L,4L,4L,4L,7L,1L,5L,4L,1L,0L,0L,4L,8L,2L,3L,2L,7L,0L,6L,9L,9L,8L,1L,9L,7L,6L,9L,5L,0L,4L,7L,3L,6L,5L,1L,2L,8L,6L,4L,5L,7L,0L,8L,4L,4L,3L,7L,2L,3L,9L,3L,8L,0L,6L,5L,7L,3L,4L,1L,9L,6L,4L,9L,6L,6L,2L,4L,5L,6L,2L,2L,3L,9L,0L,3L,6L,7L,8L,3L,6L,5L,5L,0L,1L,4L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274441Inst : IEnumerable<long>
{
public static readonly long[] Value=A274441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274441.Bytes);
public long this[int i]=>Value[i];

public static A274441Inst Instance=new A274441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274442
{
public static readonly long[] Value={ 1L,8L,7L,4L,4L,7L,1L,6L,6L,9L,4L,9L,0L,0L,8L,2L,6L,0L,1L,1L,8L,0L,9L,5L,0L,9L,9L,9L,4L,8L,9L,6L,8L,0L,2L,9L,7L,0L,5L,7L,3L,9L,7L,6L,5L,8L,9L,2L,0L,3L,7L,9L,5L,3L,4L,8L,0L,7L,6L,9L,8L,4L,5L,1L,1L,9L,0L,4L,5L,2L,6L,4L,7L,5L,6L,8L,0L,0L,7L,0L,0L,3L,7L,5L,8L,4L,7L,0L,6L,5L,3L,3L,9L,9L,9L,8L,9L,8L,0L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274442Inst : IEnumerable<long>
{
public static readonly long[] Value=A274442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274442.Bytes);
public long this[int i]=>Value[i];

public static A274442Inst Instance=new A274442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274443
{
public static readonly long[] Value={ 561L,21L,85L,15L,21L,35L,33L,21L,65L,91L,57L,91L,133L,55L,161L,91L,57L,133L,33L,253L,65L,91L,145L,115L,217L,451L,161L,703L,253L,551L,561L,253L,481L,217L,129L,451L,301L,1081L,161L,1189L,145L,989L,217L,235L,481L,703L,649L,329L,265L,1081L,1121L,1219L,145L,1037L,721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274443Inst : IEnumerable<long>
{
public static readonly long[] Value=A274443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274443.Bytes);
public long this[int i]=>Value[i];

public static A274443Inst Instance=new A274443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274444
{
public static readonly long[] Value={ 15L,65L,35L,15L,21L,35L,15L,35L,35L,77L,35L,55L,55L,143L,119L,51L,95L,155L,55L,323L,95L,119L,39L,391L,87L,209L,119L,299L,143L,341L,319L,629L,259L,899L,407L,185L,119L,299L,287L,1517L,203L,799L,159L,155L,407L,1189L,119L,517L,341L,1763L,1363L,629L,335L,2491L,493L,3599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274444Inst : IEnumerable<long>
{
public static readonly long[] Value=A274444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274444.Bytes);
public long this[int i]=>Value[i];

public static A274444Inst Instance=new A274444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274445
{
public static readonly long[] Value={ 385L,91L,65L,451L,33L,170171L,145L,1261L,161L,78409L,469L,294061L,649L,13051L,1921L,5251L,721L,8453501L,145L,300243L,1121L,47611L,3601L,1915801L,1057L,41311L,545L,5671L,1261L,19723133L,4321L,37759L,6913L,451L,4033L,102821L,1513L,40891L,11521L,1259497L,721L,364781L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274445Inst : IEnumerable<long>
{
public static readonly long[] Value=A274445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274445.Bytes);
public long this[int i]=>Value[i];

public static A274445Inst Instance=new A274445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274446
{
public static readonly long[] Value={ 399L,299L,55L,611L,143L,5549L,39L,155L,493L,615383L,713L,3247L,119L,1304489L,1333L,31415L,2599L,749L,2183L,440153L,155L,75499L,119L,168600949L,4223L,223649L,559L,66299L,6407L,15157L,3431L,85499L,799L,31589L,7313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274446Inst : IEnumerable<long>
{
public static readonly long[] Value=A274446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274446.Bytes);
public long this[int i]=>Value[i];

public static A274446Inst Instance=new A274446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274447
{
public static readonly BigInteger[] Value={ 1L,1L,1L,-1L,-1L,13L,-47L,-73L,2447L,-16811L,-15551L,1726511L,-18994849L,10979677L,2983409137L,-48421103257L,135002366063L,778870772857L,-232033147779359L,1305952009204319L,58740282660173759L,-1862057132555380307L,16905219421196907793UL,BigInteger.Parse("527257187244811805207") };
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
public class A274447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274447Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274447.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274447Inst Instance=new A274447Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274448
{
public static readonly BigInteger[] Value={ 1L,2L,16L,192L,3072L,61440L,1474560L,41287680L,1321205760L,47563407360L,1902536294400L,83711596953600L,4018156653772800L,208944145996185600L,11700872175786393600UL,BigInteger.Parse("702052330547183616000"),BigInteger.Parse("44931349155019751424000"),BigInteger.Parse("235025518657026392064000"),BigInteger.Parse("219983885462976702971904000"),BigInteger.Parse("16718775295186229425864704000"),BigInteger.Parse("1337502023614898354069176320000") };
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
public class A274448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274448Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274448.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274448Inst Instance=new A274448Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274449
{
public static readonly long[] Value={ 2L,2L,8L,4L,32L,2L,128L,16L,176L,32L,2048L,4L,8192L,128L,2348L,256L,131072L,8L,524288L,424L,47824L,2048L,8388608L,16L,9389312L,8192L,785408L,11680L,536870912L,2L,2147483648L,65536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274449Inst : IEnumerable<long>
{
public static readonly long[] Value=A274449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274449.Bytes);
public long this[int i]=>Value[i];

public static A274449Inst Instance=new A274449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274450
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,3L,1L,3L,2L,2L,1L,4L,1L,2L,3L,3L,1L,4L,1L,4L,3L,2L,1L,6L,2L,2L,2L,4L,1L,5L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274450Inst : IEnumerable<long>
{
public static readonly long[] Value=A274450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274450.Bytes);
public long this[int i]=>Value[i];

public static A274450Inst Instance=new A274450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274451
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,4L,1L,3L,2L,2L,1L,6L,1L,2L,4L,3L,1L,5L,1L,6L,4L,2L,1L,11L,2L,2L,2L,6L,1L,10L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274451Inst : IEnumerable<long>
{
public static readonly long[] Value=A274451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274451.Bytes);
public long this[int i]=>Value[i];

public static A274451Inst Instance=new A274451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274452
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,9L,12L,13L,18L,19L,24L,26L,27L,28L,36L,38L,39L,41L,48L,52L,54L,56L,57L,60L,72L,76L,78L,82L,84L,88L,104L,108L,112L,114L,117L,120L,123L,129L,144L,152L,156L,162L,164L,168L,171L,176L,180L,189L,216L,224L,228L,234L,240L,246L,247L,252L,258L,264L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274452Inst : IEnumerable<long>
{
public static readonly long[] Value=A274452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274452.Bytes);
public long this[int i]=>Value[i];

public static A274452Inst Instance=new A274452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274453
{
public static readonly long[] Value={ 2L,5L,10L,14L,28L,40L,70L,80L,115L,140L,200L,230L,331L,400L,560L,575L,662L,953L,1120L,1150L,1610L,1655L,1906L,2744L,2800L,3220L,3310L,4600L,4634L,4765L,5488L,5600L,7901L,8050L,9200L,9268L,9530L,13240L,13342L,13720L,15802L,16100L,22750L,23000L,23170L,26480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274453Inst : IEnumerable<long>
{
public static readonly long[] Value=A274453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274453.Bytes);
public long this[int i]=>Value[i];

public static A274453Inst Instance=new A274453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274454
{
public static readonly long[] Value={ 2L,5L,10L,12L,24L,29L,58L,60L,70L,120L,140L,145L,169L,290L,338L,348L,350L,408L,696L,700L,816L,840L,845L,985L,1680L,1690L,1740L,1970L,2028L,2030L,2040L,2378L,3480L,4056L,4060L,4080L,4200L,4756L,4896L,4901L,4925L,5741L,8400L,9792L,9802L,9850L,10140L,10150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274454Inst : IEnumerable<long>
{
public static readonly long[] Value=A274454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274454.Bytes);
public long this[int i]=>Value[i];

public static A274454Inst Instance=new A274454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274455
{
public static readonly long[] Value={ 1L,0L,2L,-1L,4L,-2L,3L,8L,-3L,-4L,6L,7L,16L,-6L,-5L,-8L,5L,12L,14L,15L,32L,-7L,-12L,-10L,-9L,-16L,10L,11L,24L,13L,28L,30L,31L,64L,-14L,-13L,-24L,-11L,-20L,-18L,-17L,-32L,9L,20L,22L,23L,48L,26L,27L,56L,29L,60L,62L,63L,128L,-15L,-28L,-26L,-25L,-48L,-22L,-21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274455Inst : IEnumerable<long>
{
public static readonly long[] Value=A274455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274455.Bytes);
public long this[int i]=>Value[i];

public static A274455Inst Instance=new A274455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274456
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,19L,27L,37L,56L,66L,136L,148L,387L,534L,536L,1273L,1593L,1796L,2026L,2164L,2502L,6128L,18714L,23327L,25427L,46461L,88182L,88377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274456Inst : IEnumerable<long>
{
public static readonly long[] Value=A274456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274456.Bytes);
public long this[int i]=>Value[i];

public static A274456Inst Instance=new A274456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274457
{
public static readonly long[] Value={ 1L,1L,3L,2L,5L,2L,7L,2L,3L,5L,11L,3L,13L,7L,3L,4L,17L,3L,19L,4L,3L,11L,23L,3L,5L,13L,9L,4L,29L,5L,31L,4L,11L,17L,5L,4L,37L,19L,13L,4L,41L,6L,43L,4L,5L,23L,47L,4L,7L,5L,17L,4L,53L,6L,5L,4L,19L,29L,59L,4L,61L,31L,7L,4L,5L,6L,67L,17L,23L,5L,71L,6L,73L,37L,5L,19L,7L,6L,79L,5L,9L,41L,83L,6L,5L,43L,29L,8L,89L,5L,7L,23L,31L,47L,5L,6L,97L,7L,9L,5L,101L,6L,103L,8L,5L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274457Inst : IEnumerable<long>
{
public static readonly long[] Value=A274457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274457.Bytes);
public long this[int i]=>Value[i];

public static A274457Inst Instance=new A274457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274458
{
public static readonly long[] Value={ 20L,6L,3L,8L,3L,2L,6L,5L,5L,4L,0L,1L,3L,1L,3L,6L,5L,0L,5L,3L,6L,2L,1L,3L,1L,1L,1L,6L,11L,7L,4L,3L,9L,3L,3L,2L,3L,2L,2L,7L,7L,0L,5L,1L,1L,0L,0L,0L,1L,3L,2L,0L,1L,2L,2L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,3L,2L,1L,2L,0L,1L,1L,3L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,2L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274458Inst : IEnumerable<long>
{
public static readonly long[] Value=A274458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274458.Bytes);
public long this[int i]=>Value[i];

public static A274458Inst Instance=new A274458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274459
{
public static readonly long[] Value={ 1L,2L,3L,1L,2L,3L,4L,1L,1L,2L,3L,2L,2L,3L,4L,1L,2L,2L,3L,2L,3L,3L,4L,2L,1L,2L,1L,2L,2L,3L,2L,1L,2L,2L,2L,1L,2L,3L,3L,2L,2L,3L,2L,2L,2L,3L,3L,2L,1L,2L,3L,2L,2L,2L,3L,3L,2L,2L,2L,3L,2L,3L,2L,1L,2L,3L,3L,2L,3L,3L,3L,2L,2L,2L,3L,2L,3L,3L,3L,2L,1L,2L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274459Inst : IEnumerable<long>
{
public static readonly long[] Value=A274459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274459.Bytes);
public long this[int i]=>Value[i];

public static A274459Inst Instance=new A274459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274460
{
public static readonly long[] Value={ 63L,119L,135L,156L,191L,240L,252L,271L,343L,367L,383L,423L,439L,448L,479L,496L,503L,535L,540L,559L,567L,575L,591L,604L,624L,631L,639L,687L,695L,711L,732L,751L,783L,791L,828L,839L,847L,863L,871L,880L,887L,903L,919L,927L,983L,988L,991L,999L,1007L,1008L,1052L,1055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274460Inst : IEnumerable<long>
{
public static readonly long[] Value=A274460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274460.Bytes);
public long this[int i]=>Value[i];

public static A274460Inst Instance=new A274460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274461
{
public static readonly BigInteger[] Value={ 1L,4L,8L,72L,144L,3600L,10800L,21600L,1058400L,2116800L,6350400L,768398400L,3841992000L,7683984000L,1298593296000L,3895779888000L,7791559776000L,2251760775264000L,15762325426848000L,5690199479092128000L,11380398958184256000UL,BigInteger.Parse("6020231048879471424000"),BigInteger.Parse("30101155244397357120000"),BigInteger.Parse("90303465733192071360000") };
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
public class A274461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274461Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274461.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274461Inst Instance=new A274461Inst();

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