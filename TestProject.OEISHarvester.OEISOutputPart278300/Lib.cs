using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A086679
{
public static readonly long[] Value={ 22L,43L,85L,94L,105L,106L,148L,169L,187L,209L,211L,218L,232L,274L,280L,295L,313L,316L,337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086679Inst : IEnumerable<long>
{
public static readonly long[] Value=A086679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086679.Bytes);
public long this[int i]=>Value[i];

public static A086679Inst Instance=new A086679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086680
{
public static readonly long[] Value={ 0L,2L,6L,18L,54L,172L,564L,1900L,6542L,23000L,82025L,295947L,1077871L,3957809L,14630843L,54400028L,203280221L,762939111L,2874398515L,10866266172L,41203088796L,156661034233L,597116381732L,2280998753949L,8731188863470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086680Inst : IEnumerable<long>
{
public static readonly long[] Value=A086680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086680.Bytes);
public long this[int i]=>Value[i];

public static A086680Inst Instance=new A086680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086681
{
public static readonly long[] Value={ 0L,4L,18L,97L,564L,3512L,23000L,155611L,1077871L,7603553L,54400028L,393615806L,2874398515L,21151907950L,156661034233L,1166746786182L,8731188863470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086681Inst : IEnumerable<long>
{
public static readonly long[] Value=A086681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086681.Bytes);
public long this[int i]=>Value[i];

public static A086681Inst Instance=new A086681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086682
{
public static readonly BigInteger[] Value={ 0L,4L,22L,129L,847L,5968L,43934L,334349L,2607165L,20700806L,166677978L,1357200840L,11152818693L,92349038518L,769616513836L,6449247674296L,54301968156067L,459127968423610L,3896275288090795L,33173029388942512L,283263365236063678L,2425147728864084536L,BigInteger.Parse("20812271380294281933"),BigInteger.Parse("178994690348530706578"),BigInteger.Parse("1542475966907198337529") };
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
public class A086682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086682Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086682.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086682Inst Instance=new A086682Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086683
{
public static readonly long[] Value={ 3L,45L,6579L,10763361L,169457722083L,25015772614247325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086683Inst : IEnumerable<long>
{
public static readonly long[] Value=A086683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086683.Bytes);
public long this[int i]=>Value[i];

public static A086683Inst Instance=new A086683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086684
{
public static readonly BigInteger[] Value={ 1L,0L,0L,20L,0L,712L,0L,40312L,362844L,3628678L,0L,479001590L,0L,87178286158L,1307674367874L,20922789887984L,0L,6402373705727962L,0L,2432902008176639876L,BigInteger.Parse("51090942171709434954"),BigInteger.Parse("1124000727777567763198"),0L,BigInteger.Parse("620448401733239439359986") };
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
public class A086684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086684Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086684.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086684Inst Instance=new A086684Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086685
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,4L,2L,2L,3L,5L,3L,6L,4L,5L,5L,5L,3L,10L,2L,6L,6L,9L,4L,9L,5L,9L,7L,11L,4L,17L,3L,10L,9L,12L,9L,15L,4L,9L,11L,13L,5L,21L,7L,11L,10L,16L,8L,19L,6L,18L,13L,17L,5L,23L,10L,18L,9L,16L,8L,27L,7L,15L,13L,16L,13L,29L,9L,18L,13L,27L,9L,26L,10L,19L,18L,17L,11L,29L,11L,23L,18L,22L,11L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086685Inst : IEnumerable<long>
{
public static readonly long[] Value=A086685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086685.Bytes);
public long this[int i]=>Value[i];

public static A086685Inst Instance=new A086685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086686
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,5L,2L,4L,3L,5L,2L,8L,1L,7L,5L,7L,3L,10L,4L,9L,6L,10L,3L,13L,6L,8L,7L,11L,5L,19L,6L,9L,7L,9L,6L,18L,5L,13L,9L,16L,5L,22L,7L,16L,13L,12L,9L,19L,7L,16L,11L,15L,8L,21L,12L,16L,14L,14L,6L,33L,8L,18L,14L,15L,10L,27L,10L,21L,13L,29L,10L,29L,3L,18L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086686Inst : IEnumerable<long>
{
public static readonly long[] Value=A086686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086686.Bytes);
public long this[int i]=>Value[i];

public static A086686Inst Instance=new A086686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086687
{
public static readonly BigInteger[] Value={ 1L,1L,1L,20L,10626L,190578024L,189492294437160L,BigInteger.Parse("16321981448897949868560"),BigInteger.Parse("173117930575796585984663510371920"),BigInteger.Parse("300649979042426162195454856425990347600496000"),BigInteger.Parse("109109335363647915965076917082046041529603540914857910625920") };
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
public class A086687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086687Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086687.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086687Inst Instance=new A086687Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086688
{
public static readonly long[] Value={ 4L,9L,30L,68L,217L,327L,656L,882L,1457L,2707L,3228L,5194L,6850L,7789L,9916L,13746L,18411L,20179L,26062L,30597L,32984L,40991L,46959L,56924L,72217L,80725L,85182L,94695L,99669L,110127L,152280L,165951L,187910L,195660L,237427L,246434L,274614L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086688Inst : IEnumerable<long>
{
public static readonly long[] Value=A086688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086688.Bytes);
public long this[int i]=>Value[i];

public static A086688Inst Instance=new A086688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086689
{
public static readonly long[] Value={ 1L,13L,67L,227L,602L,1358L,2730L,5034L,8679L,14179L,22165L,33397L,48776L,69356L,96356L,131172L,175389L,230793L,299383L,383383L,485254L,607706L,753710L,926510L,1129635L,1366911L,1642473L,1960777L,2326612L,2745112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086689Inst : IEnumerable<long>
{
public static readonly long[] Value=A086689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086689.Bytes);
public long this[int i]=>Value[i];

public static A086689Inst Instance=new A086689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086690
{
public static readonly BigInteger[] Value={ 2L,4L,11L,31L,309L,1028L,12251L,43390L,564163L,28192750L,105097565L,5586502348L,80316571436L,305761713237L,4461632979717L,252252704148404L,14458792895301660L,55890484045084135L,3249254387052557215L,BigInteger.Parse("48995571600129458363"),BigInteger.Parse("190499823401327905601") };
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
public class A086690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086690Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086690.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086690Inst Instance=new A086690Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086691
{
public static readonly long[] Value={ 152024L,1331302L,1654692L,1665259L,2498121L,2498182L,3539725L,3767628L,4880306L,5372892L,5372899L,5589360L,8754741L,9011136L,9023611L,9023613L,9023616L,9136605L,9136630L,9136660L,9194561L,9196454L,9412864L,9462431L,9749651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086691Inst : IEnumerable<long>
{
public static readonly long[] Value=A086691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086691.Bytes);
public long this[int i]=>Value[i];

public static A086691Inst Instance=new A086691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086692
{
public static readonly BigInteger[] Value={ 4L,9L,53L,327L,16097L,120739L,7332159L,58648288L,3886548158L,2226457080707L,18703411700669L,11364488265762429L,828569015819923142L,7102411822168379213L,BigInteger.Parse("525323427853694627277") };
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
public class A086692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086692Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086692.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086692Inst Instance=new A086692Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086693
{
public static readonly ulong[] Value={ 2L,9L,445L,65685L,11262113374L,9373678643933L,17547676024364306476UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086693Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A086693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086693.Bytes);
public ulong this[int i]=>Value[i];

public static A086693Inst Instance=new A086693Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086694
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086694Inst : IEnumerable<long>
{
public static readonly long[] Value=A086694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086694.Bytes);
public long this[int i]=>Value[i];

public static A086694Inst Instance=new A086694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086695
{
public static readonly BigInteger[] Value={ 89L,9899L,998999L,99989999L,9999899999L,999998999999L,99999989999999L,9999999899999999L,999999998999999999L,BigInteger.Parse("99999999989999999999") };
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
public class A086695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086695Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086695.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086695Inst Instance=new A086695Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086696
{
public static readonly long[] Value={ 3L,0L,5L,1L,1L,1L,1L,1L,5L,3L,2L,5L,6L,21L,2L,9L,2L,8L,4L,1L,5L,9L,34L,23L,4L,12L,5L,8L,17L,9L,10L,1L,12L,11L,10L,3L,0L,37L,26L,3L,20L,29L,16L,21L,38L,41L,18L,11L,6L,21L,8L,7L,2L,31L,30L,12L,38L,69L,2L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086696Inst : IEnumerable<long>
{
public static readonly long[] Value=A086696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086696.Bytes);
public long this[int i]=>Value[i];

public static A086696Inst Instance=new A086696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086697
{
public static readonly long[] Value={ 4L,6L,9L,14L,26L,34L,39L,46L,49L,69L,74L,86L,94L,134L,146L,169L,194L,214L,226L,249L,274L,314L,326L,334L,339L,346L,386L,394L,446L,469L,514L,526L,586L,614L,626L,634L,649L,669L,674L,694L,734L,746L,749L,794L,849L,869L,886L,914L,926L,934L,939L,949L,974L,1169L,1214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086697Inst : IEnumerable<long>
{
public static readonly long[] Value=A086697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086697.Bytes);
public long this[int i]=>Value[i];

public static A086697Inst Instance=new A086697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086698
{
public static readonly long[] Value={ 4L,6L,9L,46L,49L,69L,94L,469L,626L,694L,914L,934L,939L,949L,4694L,4934L,4939L,9134L,9346L,9586L,62386L,62614L,91346L,959939L,6998339L,91439939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086698Inst : IEnumerable<long>
{
public static readonly long[] Value=A086698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086698.Bytes);
public long this[int i]=>Value[i];

public static A086698Inst Instance=new A086698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086699
{
public static readonly BigInteger[] Value={ 1L,9L,294L,37800L,19373760L,39687459840L,325139829719040L,10654345790226432000UL,BigInteger.Parse("1396491759480328106803200"),BigInteger.Parse("732164571206732295657278668800"),BigInteger.Parse("1535460761275478347250381697633484800") };
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
public class A086699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086699Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086699.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086699Inst Instance=new A086699Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086700
{
public static readonly long[] Value={ 1L,2L,2L,4L,8L,12L,12L,12L,24L,40L,20L,24L,72L,48L,32L,64L,96L,108L,72L,48L,120L,220L,88L,80L,240L,216L,108L,168L,224L,240L,240L,160L,320L,384L,144L,216L,648L,432L,192L,320L,480L,504L,420L,240L,528L,1012L,368L,336L,840L,640L,384L,624L,936L,720L,480L,432L,1008L,1624L,464L,480L,1800L,1080L,576L,768L,960L,1320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086700Inst : IEnumerable<long>
{
public static readonly long[] Value=A086700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086700.Bytes);
public long this[int i]=>Value[i];

public static A086700Inst Instance=new A086700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086701
{
public static readonly BigInteger[] Value={ 16L,729L,390625L,40353607L,25937424601L,23298085122481L,168377826559400929L,15181127029874798299UL,BigInteger.Parse("6132610415680998648961"),BigInteger.Parse("210457284365172120330305161"),BigInteger.Parse("671790528819082282036142601601"),BigInteger.Parse("855531895666462872887391390111637"),BigInteger.Parse("302862043149743582494593171234930481") };
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
public class A086701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086701Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086701.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086701Inst Instance=new A086701Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086702
{
public static readonly long[] Value={ 3L,2L,7L,5L,8L,2L,2L,9L,1L,8L,7L,2L,1L,8L,1L,1L,1L,5L,9L,7L,8L,7L,6L,8L,1L,8L,8L,2L,4L,5L,3L,8L,4L,3L,8L,6L,3L,6L,0L,8L,4L,7L,5L,5L,2L,5L,9L,8L,2L,3L,7L,4L,1L,4L,9L,4L,0L,5L,1L,9L,8L,9L,2L,4L,1L,9L,0L,7L,2L,3L,2L,1L,5L,6L,4L,4L,9L,6L,0L,3L,5L,5L,1L,8L,1L,2L,7L,7L,5L,4L,0L,4L,7L,9L,1L,7L,4L,5L,2L,9L,4L,9L,2L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086702Inst : IEnumerable<long>
{
public static readonly long[] Value=A086702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086702.Bytes);
public long this[int i]=>Value[i];

public static A086702Inst Instance=new A086702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086703
{
public static readonly long[] Value={ 3L,3L,1L,1L,1L,2L,29L,1L,130L,1L,12L,3L,8L,2L,4L,1L,3L,55L,2L,4L,2L,2L,1L,797L,1L,1L,6L,2L,4L,1L,13L,2L,1L,6L,1L,4L,2L,1L,9L,3L,2L,2L,2L,2L,4L,1L,2L,5L,1L,1L,1L,6L,2L,2L,1L,32L,1L,2L,1L,3L,2L,1L,15L,3L,1L,1L,1L,2L,1L,1L,105L,1L,79L,1L,4L,2L,3L,11L,1L,6L,1L,7L,2L,1L,3L,1L,9L,1L,4L,9L,1L,1L,3L,1L,1L,15L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086703Inst : IEnumerable<long>
{
public static readonly long[] Value=A086703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086703.Bytes);
public long this[int i]=>Value[i];

public static A086703Inst Instance=new A086703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086704
{
public static readonly BigInteger[] Value={ 125L,16807L,1792160394037L,BigInteger.Parse("5480386857784802185939"),BigInteger.Parse("17761887753093897979823770061456102763834271"),BigInteger.Parse("9380082945933081406113456619151991432292083579779389915131296484043") };
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
public class A086704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086704Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086704.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086704Inst Instance=new A086704Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086705
{
public static readonly long[] Value={ 1L,1L,9L,3L,9L,3L,3L,0L,1L,1L,1L,8L,2L,0L,9L,7L,7L,6L,2L,0L,8L,3L,4L,0L,2L,9L,7L,6L,5L,0L,3L,0L,0L,3L,6L,6L,3L,2L,0L,0L,5L,7L,1L,1L,4L,2L,2L,5L,1L,9L,5L,6L,3L,5L,7L,9L,4L,3L,2L,0L,7L,0L,5L,9L,7L,6L,0L,9L,6L,3L,5L,7L,5L,3L,8L,8L,2L,5L,6L,8L,4L,1L,6L,0L,3L,8L,5L,0L,4L,0L,2L,6L,3L,9L,0L,5L,0L,9L,6L,9L,5L,1L,0L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086705Inst : IEnumerable<long>
{
public static readonly long[] Value=A086705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086705.Bytes);
public long this[int i]=>Value[i];

public static A086705Inst Instance=new A086705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086706
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,10L,11L,11L,11L,11L,11L,11L,12L,12L,13L,14L,14L,14L,15L,15L,15L,16L,16L,16L,17L,17L,17L,17L,17L,17L,18L,18L,18L,18L,19L,19L,20L,20L,20L,21L,21L,21L,22L,22L,23L,23L,23L,23L,24L,24L,24L,24L,24L,24L,25L,25L,25L,26L,26L,26L,26L,26L,26L,26L,27L,27L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086706Inst : IEnumerable<long>
{
public static readonly long[] Value=A086706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086706.Bytes);
public long this[int i]=>Value[i];

public static A086706Inst Instance=new A086706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086707
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,11L,11L,11L,11L,12L,12L,12L,13L,13L,13L,13L,14L,14L,14L,14L,15L,15L,15L,16L,16L,16L,16L,17L,17L,17L,18L,18L,18L,18L,19L,19L,19L,19L,20L,20L,20L,21L,21L,21L,21L,22L,22L,22L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086707Inst : IEnumerable<long>
{
public static readonly long[] Value=A086707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086707.Bytes);
public long this[int i]=>Value[i];

public static A086707Inst Instance=new A086707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086756
{
public static readonly long[] Value={ 1L,4L,27L,256L,3125L,46656L,823543L,16777216L,387420489L,0L,85311670611L,916100448256L,2875106592253L,12006825558016L,893890380859375L,6744073709551616L,40261886336764177L,408075296537575424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086756Inst : IEnumerable<long>
{
public static readonly long[] Value=A086756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086756.Bytes);
public long this[int i]=>Value[i];

public static A086756Inst Instance=new A086756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086757
{
public static readonly long[] Value={ 2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,13L,5L,3L,13L,2L,3L,2L,5L,23L,3L,2L,23L,3L,5L,29L,3L,2L,3L,31L,29L,2L,7L,2L,37L,37L,5L,41L,37L,41L,3L,5L,13L,47L,43L,2L,5L,53L,7L,53L,7L,2L,3L,59L,17L,59L,3L,5L,59L,61L,11L,67L,5L,2L,7L,2L,67L,5L,3L,71L,13L,7L,5L,2L,73L,79L,37L,79L,5L,83L,3L,83L,3L,5L,11L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086757Inst : IEnumerable<long>
{
public static readonly long[] Value=A086757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086757.Bytes);
public long this[int i]=>Value[i];

public static A086757Inst Instance=new A086757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086758
{
public static readonly BigInteger[] Value={ 2L,5L,13L,31L,631L,173L,409L,967L,3450844193L,39661481813L,2076849234433L,52134281654579L,14838980942616539L,260230524377962793L,4563650703502319197L,BigInteger.Parse("80032531899785490253"),BigInteger.Parse("172111744128569095516889") };
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
public class A086758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086758Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086758.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086758Inst Instance=new A086758Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086759
{
public static readonly BigInteger[] Value={ 0L,1L,9L,164L,5050L,227508L,14064519L,1146668608L,119249333028L,15400125776000L,2417814003691405L,453536611741073664L,BigInteger.Parse("100178077459552487070"),BigInteger.Parse("25735749696251388478720"),BigInteger.Parse("7608415981499790110521875"),BigInteger.Parse("2564724413131659780025106432") };
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
public class A086759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086759Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086759.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086759Inst Instance=new A086759Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086760
{
public static readonly long[] Value={ 43L,139L,251L,379L,523L,683L,859L,1051L,1259L,1483L,1723L,1979L,2251L,2539L,2843L,3163L,3499L,3851L,4219L,4603L,5003L,5419L,5851L,6299L,6763L,7243L,7739L,8251L,8779L,9323L,9883L,10459L,11051L,11659L,12283L,12923L,13579L,14251L,14939L,15643L,16363L,17099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086760Inst : IEnumerable<long>
{
public static readonly long[] Value=A086760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086760.Bytes);
public long this[int i]=>Value[i];

public static A086760Inst Instance=new A086760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086761
{
public static readonly long[] Value={ 5L,10L,20L,25L,40L,50L,80L,100L,125L,160L,200L,250L,320L,400L,500L,625L,640L,800L,1000L,1250L,1280L,1600L,2000L,2500L,2560L,3125L,3200L,4000L,5000L,5120L,6250L,6400L,8000L,10000L,10240L,12500L,12800L,15625L,16000L,20000L,20480L,25000L,25600L,31250L,32000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086761Inst : IEnumerable<long>
{
public static readonly long[] Value=A086761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086761.Bytes);
public long this[int i]=>Value[i];

public static A086761Inst Instance=new A086761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086762
{
public static readonly long[] Value={ 7L,11L,17L,13L,5L,1L,5L,1L,1L,1L,3L,5L,1L,11L,17L,13L,5L,1L,1L,5L,1L,5L,1L,17L,13L,5L,1L,3L,5L,1L,5L,1L,7L,11L,17L,13L,5L,1L,1L,1L,13L,5L,1L,9L,5L,1L,29L,11L,17L,13L,5L,1L,5L,1L,11L,17L,13L,5L,1L,11L,17L,13L,5L,1L,35L,9L,5L,1L,3L,5L,1L,13L,5L,1L,13L,5L,1L,7L,11L,17L,13L,5L,1L,7L,11L,17L,13L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086762Inst : IEnumerable<long>
{
public static readonly long[] Value=A086762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086762.Bytes);
public long this[int i]=>Value[i];

public static A086762Inst Instance=new A086762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086763
{
public static readonly long[] Value={ 17L,7L,2L,5L,8L,16L,3L,7L,6L,14L,9L,9L,17L,5L,4L,12L,8L,20L,7L,16L,15L,12L,10L,11L,10L,19L,18L,18L,6L,15L,5L,14L,13L,10L,9L,21L,21L,9L,8L,3L,17L,18L,16L,14L,13L,13L,11L,13L,12L,12L,11L,11L,20L,20L,19L,20L,19L,32L,7L,16L,1L,7L,6L,16L,15L,27L,14L,12L,11L,11L,10L,23L,22L,23L,22L,11L,10L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086763Inst : IEnumerable<long>
{
public static readonly long[] Value=A086763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086763.Bytes);
public long this[int i]=>Value[i];

public static A086763Inst Instance=new A086763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086764
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,3L,2L,1L,9L,11L,7L,3L,1L,44L,53L,32L,13L,4L,1L,265L,309L,181L,71L,21L,5L,1L,1854L,2119L,1214L,465L,134L,31L,6L,1L,14833L,16687L,9403L,3539L,1001L,227L,43L,7L,1L,133496L,148329L,82508L,30637L,8544L,1909L,356L,57L,8L,1L,1334961L,1468457L,808393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086764Inst : IEnumerable<long>
{
public static readonly long[] Value=A086764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086764.Bytes);
public long this[int i]=>Value[i];

public static A086764Inst Instance=new A086764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086765
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,2L,7L,2L,3L,3L,11L,2L,13L,4L,4L,2L,17L,2L,19L,3L,5L,6L,23L,2L,5L,7L,3L,4L,29L,4L,31L,2L,8L,9L,9L,2L,37L,10L,9L,3L,41L,5L,43L,6L,4L,12L,47L,2L,7L,3L,12L,7L,53L,2L,9L,4L,13L,15L,59L,4L,61L,16L,5L,2L,16L,8L,67L,9L,16L,9L,71L,2L,73L,19L,4L,10L,16L,9L,79L,3L,3L,21L,83L,5L,21L,22L,20L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086765Inst : IEnumerable<long>
{
public static readonly long[] Value=A086765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086765.Bytes);
public long this[int i]=>Value[i];

public static A086765Inst Instance=new A086765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086766
{
public static readonly long[] Value={ 1L,3L,1L,1L,11L,1L,1L,2L,2L,1L,9L,3L,1L,5L,1L,3L,15L,1L,1L,2L,1L,60L,3L,1L,1L,2L,1L,1L,5L,5L,1L,2L,1L,6L,12L,3L,12L,3L,5L,1L,2L,1L,1L,5L,3L,1L,0L,2L,1L,9L,2L,1L,6L,1L,6L,18L,1L,3L,45L,1L,6L,3L,1L,1L,2L,1L,0L,3L,1L,1L,2L,3L,4L,8L,1L,1L,6L,2L,36L,96L,1L,1L,5L,304L,6L,2L,6L,1L,2L,2L,1L,2L,5L,1L,6L,5L,1L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086766Inst : IEnumerable<long>
{
public static readonly long[] Value=A086766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086766.Bytes);
public long this[int i]=>Value[i];

public static A086766Inst Instance=new A086766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086767
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,1L,1L,5L,1L,3L,1L,7L,1L,1L,1L,9L,1L,5L,1L,11L,1L,3L,1L,13L,1L,7L,1L,15L,1L,1L,1L,17L,1L,9L,1L,19L,1L,5L,1L,21L,1L,11L,1L,23L,1L,3L,1L,25L,1L,13L,1L,27L,1L,7L,1L,29L,1L,15L,1L,31L,1L,1L,1L,33L,1L,17L,1L,35L,1L,9L,1L,37L,1L,19L,1L,39L,1L,5L,1L,41L,1L,21L,1L,43L,1L,11L,1L,45L,1L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086767Inst : IEnumerable<long>
{
public static readonly long[] Value=A086767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086767.Bytes);
public long this[int i]=>Value[i];

public static A086767Inst Instance=new A086767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086768
{
public static readonly long[] Value={ 1L,6L,24L,60L,120L,144L,336L,536L,714L,720L,1320L,1440L,2184L,2016L,2880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086768Inst : IEnumerable<long>
{
public static readonly long[] Value=A086768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086768.Bytes);
public long this[int i]=>Value[i];

public static A086768Inst Instance=new A086768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086769
{
public static readonly long[] Value={ 1L,3L,5L,13L,15L,23L,25L,33L,65L,67L,99L,107L,109L,117L,149L,181L,183L,215L,223L,225L,257L,265L,297L,425L,433L,435L,443L,445L,453L,8645L,8653L,8685L,8687L,9199L,9201L,9233L,9265L,9273L,9305L,9337L,9339L,9851L,9853L,9861L,9863L,11911L,13959L,13967L,13969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086769Inst : IEnumerable<long>
{
public static readonly long[] Value=A086769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086769.Bytes);
public long this[int i]=>Value[i];

public static A086769Inst Instance=new A086769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086770
{
public static readonly long[] Value={ 1L,15L,20L,30L,35L,50L,112L,143L,168L,189L,252L,280L,315L,323L,378L,392L,420L,441L,525L,588L,630L,700L,735L,882L,899L,980L,1029L,1050L,1372L,1470L,1750L,1763L,2058L,2450L,2816L,3430L,3599L,3773L,4224L,4802L,5183L,5929L,6336L,7040L,9317L,9504L,9856L,10403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086770Inst : IEnumerable<long>
{
public static readonly long[] Value=A086770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086770.Bytes);
public long this[int i]=>Value[i];

public static A086770Inst Instance=new A086770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086771
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,9L,16L,50L,132L,452L,1559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086771Inst : IEnumerable<long>
{
public static readonly long[] Value=A086771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086771.Bytes);
public long this[int i]=>Value[i];

public static A086771Inst Instance=new A086771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086916
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,6L,6L,6L,6L,6L,6L,7L,7L,9L,9L,10L,10L,10L,10L,10L,10L,12L,13L,14L,15L,18L,20L,21L,23L,23L,23L,25L,28L,28L,29L,29L,32L,33L,35L,37L,38L,39L,41L,43L,45L,47L,50L,55L,57L,62L,62L,66L,73L,79L,92L,101L,106L,108L,115L,121L,123L,126L,131L,140L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086916Inst : IEnumerable<long>
{
public static readonly long[] Value=A086916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086916.Bytes);
public long this[int i]=>Value[i];

public static A086916Inst Instance=new A086916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086917
{
public static readonly long[] Value={ 2L,4L,6L,10L,11L,15L,16L,19L,24L,25L,30L,32L,33L,36L,40L,45L,46L,50L,53L,53L,57L,60L,64L,70L,72L,73L,75L,75L,77L,89L,91L,95L,95L,103L,103L,107L,111L,113L,117L,121L,121L,129L,129L,130L,130L,140L,150L,151L,151L,153L,156L,156L,164L,167L,171L,175L,174L,178L,179L,179L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086917Inst : IEnumerable<long>
{
public static readonly long[] Value=A086917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086917.Bytes);
public long this[int i]=>Value[i];

public static A086917Inst Instance=new A086917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086918
{
public static readonly long[] Value={ 101L,111L,112L,113L,114L,115L,116L,117L,118L,119L,121L,123L,131L,135L,141L,147L,151L,159L,202L,210L,212L,222L,223L,224L,225L,226L,227L,228L,229L,232L,234L,242L,246L,252L,258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086918Inst : IEnumerable<long>
{
public static readonly long[] Value=A086918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086918.Bytes);
public long this[int i]=>Value[i];

public static A086918Inst Instance=new A086918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086919
{
public static readonly long[] Value={ 11L,10L,13L,14L,15L,16L,17L,18L,19L,90L,101L,131L,141L,151L,161L,171L,181L,191L,909L,1001L,1010L,1021L,1032L,1043L,1054L,1065L,1076L,1087L,1098L,1331L,1320L,1313L,1302L,1375L,1386L,1397L,2075L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086919Inst : IEnumerable<long>
{
public static readonly long[] Value=A086919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086919.Bytes);
public long this[int i]=>Value[i];

public static A086919Inst Instance=new A086919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086920
{
public static readonly long[] Value={ 1L,3L,2L,3L,3L,3L,3L,30L,6L,4L,5L,5L,25L,42L,17L,19L,2L,1L,7L,6L,6L,1L,50L,29L,138L,153L,4L,45L,54L,7L,15L,9L,78L,147L,95L,58L,102L,18L,3L,115L,54L,6L,46L,9L,24L,64L,183L,120L,3L,33L,112L,46L,105L,4L,279L,122L,68L,75L,3L,22L,294L,56L,92L,76L,6L,19L,94L,71L,12L,75L,30L,16L,78L,320L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086920Inst : IEnumerable<long>
{
public static readonly long[] Value=A086920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086920.Bytes);
public long this[int i]=>Value[i];

public static A086920Inst Instance=new A086920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086921
{
public static readonly long[] Value={ 1L,4L,12L,24L,36L,60L,120L,120L,180L,240L,360L,360L,720L,720L,720L,840L,1260L,1260L,1680L,1680L,2520L,2520L,2520L,2520L,5040L,5040L,5040L,5040L,5040L,5040L,7560L,7560L,10080L,10080L,10080L,10080L,15120L,15120L,15120L,15120L,20160L,20160L,25200L,25200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086921Inst : IEnumerable<long>
{
public static readonly long[] Value=A086921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086921.Bytes);
public long this[int i]=>Value[i];

public static A086921Inst Instance=new A086921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086922
{
public static readonly long[] Value={ 2L,8L,50L,452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086922Inst : IEnumerable<long>
{
public static readonly long[] Value=A086922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086922.Bytes);
public long this[int i]=>Value[i];

public static A086922Inst Instance=new A086922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086923
{
public static readonly BigInteger[] Value={ 11L,331L,2221L,33331L,333331L,3333331L,33333331L,30303030303030301L,6666666661L,44444444441L,555555555551L,5555555555551L,BigInteger.Parse("252525252525252525252525251"),BigInteger.Parse("42424242424242424242424242421"),BigInteger.Parse("1717171717171717171717171717171") };
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
public class A086923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086923Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086923.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086923Inst Instance=new A086923Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086924
{
public static readonly long[] Value={ 2L,13L,31L,79L,97L,103L,113L,163L,173L,193L,227L,257L,277L,311L,331L,613L,643L,653L,673L,683L,709L,719L,739L,769L,811L,821L,881L,907L,937L,947L,967L,977L,997L,1013L,1033L,1063L,1093L,1103L,1123L,1153L,1163L,1193L,1213L,1223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086924Inst : IEnumerable<long>
{
public static readonly long[] Value=A086924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086924.Bytes);
public long this[int i]=>Value[i];

public static A086924Inst Instance=new A086924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086925
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,3L,4L,4L,6L,4L,6L,5L,2L,3L,5L,3L,6L,6L,8L,5L,4L,7L,2L,4L,8L,6L,8L,7L,3L,7L,5L,5L,6L,10L,6L,10L,7L,5L,7L,7L,7L,8L,8L,9L,4L,9L,5L,8L,10L,8L,11L,2L,5L,9L,6L,11L,3L,8L,12L,7L,9L,7L,10L,9L,8L,13L,2L,6L,12L,8L,14L,8L,15L,6L,13L,3L,9L,9L,10L,10L,11L,4L,10L,12L,9L,11L,5L,10L,13L,4L,11L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086925Inst : IEnumerable<long>
{
public static readonly long[] Value=A086925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086925.Bytes);
public long this[int i]=>Value[i];

public static A086925Inst Instance=new A086925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086926
{
public static readonly long[] Value={ 0L,0L,1L,6L,18L,50L,120L,273L,588L,1224L,2475L,4895L,9504L,18174L,34307L,64050L,118440L,217192L,395352L,714951L,1285350L,2298660L,4091241L,7250221L,12797568L,22507500L,39452725L,68942718L,120132558L,208776974L,361937400L,626015085L,1080441264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086926Inst : IEnumerable<long>
{
public static readonly long[] Value=A086926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086926.Bytes);
public long this[int i]=>Value[i];

public static A086926Inst Instance=new A086926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086927
{
public static readonly long[] Value={ 2L,10L,102L,1030L,10402L,105050L,1060902L,10714070L,108201602L,1092730090L,11035502502L,111447755110L,1125513053602L,11366578291130L,114791295964902L,1159279537940150L,11707586675366402L,118235146291604170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086927Inst : IEnumerable<long>
{
public static readonly long[] Value=A086927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086927.Bytes);
public long this[int i]=>Value[i];

public static A086927Inst Instance=new A086927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086928
{
public static readonly long[] Value={ 2L,12L,146L,1764L,21314L,257532L,3111698L,37597908L,454286594L,5489037036L,66322731026L,801361809348L,9682664443202L,116993335127772L,1413602685976466L,17080225566845364L,206376309488120834L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086928Inst : IEnumerable<long>
{
public static readonly long[] Value=A086928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086928.Bytes);
public long this[int i]=>Value[i];

public static A086928Inst Instance=new A086928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086929
{
public static readonly BigInteger[] Value={ 1L,2L,9L,84L,345L,864L,35217L,180504L,5586408L,43430850L,530676234L,9780239700L,1055666381913L,18372986892414L,818136466402365L,314063593211808L,139031163059145687L,9080662161749058738L,BigInteger.Parse("64855015790195124351") };
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
public class A086929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086929Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086929.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086929Inst Instance=new A086929Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086930
{
public static readonly long[] Value={ 2L,4L,2L,10L,3L,16L,18L,22L,28L,2L,36L,40L,6L,46L,52L,58L,60L,66L,70L,8L,78L,82L,88L,96L,100L,102L,106L,108L,112L,2L,130L,136L,138L,148L,150L,12L,162L,166L,172L,178L,180L,190L,192L,196L,198L,14L,222L,226L,228L,232L,238L,15L,250L,256L,262L,268L,270L,276L,280L,282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086930Inst : IEnumerable<long>
{
public static readonly long[] Value=A086930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086930.Bytes);
public long this[int i]=>Value[i];

public static A086930Inst Instance=new A086930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086931
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,8L,7L,16L,24L,32L,11L,64L,13L,128L,192L,256L,17L,512L,19L,1024L,1536L,2048L,23L,4096L,5120L,8192L,12288L,16384L,29L,32768L,31L,65536L,98304L,131072L,163840L,262144L,37L,524288L,786432L,1048576L,41L,2097152L,43L,4194304L,6291456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086931Inst : IEnumerable<long>
{
public static readonly long[] Value=A086931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086931.Bytes);
public long this[int i]=>Value[i];

public static A086931Inst Instance=new A086931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086932
{
public static readonly long[] Value={ 1L,2L,4L,0L,4L,8L,8L,0L,12L,8L,12L,0L,12L,16L,16L,0L,16L,24L,20L,0L,32L,24L,24L,0L,20L,24L,36L,0L,28L,32L,32L,0L,48L,32L,32L,0L,36L,40L,48L,0L,40L,64L,44L,0L,48L,48L,48L,0L,56L,40L,64L,0L,52L,72L,48L,0L,80L,56L,60L,0L,60L,64L,96L,0L,48L,96L,68L,0L,96L,64L,72L,0L,72L,72L,80L,0L,96L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086932Inst : IEnumerable<long>
{
public static readonly long[] Value=A086932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086932.Bytes);
public long this[int i]=>Value[i];

public static A086932Inst Instance=new A086932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086933
{
public static readonly long[] Value={ 1L,2L,1L,4L,9L,2L,1L,8L,9L,18L,1L,4L,25L,2L,9L,16L,33L,18L,1L,36L,1L,2L,1L,8L,65L,50L,9L,4L,57L,18L,1L,32L,1L,66L,9L,36L,73L,2L,25L,72L,81L,2L,1L,4L,81L,2L,1L,16L,49L,130L,33L,100L,105L,18L,9L,8L,1L,114L,1L,36L,121L,2L,9L,64L,225L,2L,1L,132L,1L,18L,1L,72L,145L,146L,65L,4L,1L,50L,1L,144L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086933Inst : IEnumerable<long>
{
public static readonly long[] Value=A086933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086933.Bytes);
public long this[int i]=>Value[i];

public static A086933Inst Instance=new A086933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086934
{
public static readonly long[] Value={ 0L,-1L,-1L,0L,6L,34L,150L,548L,1064L,-9620L,-190980L,-2379408L,-26412408L,-281137848L,-2923819080L,-29496805392L,-277842087360L,-2151448802448L,-5085750338064L,334794720634752L,11987850975483360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086934Inst : IEnumerable<long>
{
public static readonly long[] Value=A086934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086934.Bytes);
public long this[int i]=>Value[i];

public static A086934Inst Instance=new A086934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086935
{
public static readonly long[] Value={ 0L,1L,25L,36L,4L,25L,16L,576L,81L,9L,100L,1156L,121L,1369L,144L,1156L,16L,1764L,1849L,196L,2025L,121L,225L,2304L,324L,25L,2601L,2704L,289L,529L,2304L,3136L,324L,3364L,3481L,4356L,36L,3721L,3844L,3969L,400L,441L,4225L,4356L,144L,13456L,4624L,4761L,484L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086935Inst : IEnumerable<long>
{
public static readonly long[] Value=A086935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086935.Bytes);
public long this[int i]=>Value[i];

public static A086935Inst Instance=new A086935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086936
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,3L,4L,4L,5L,6L,7L,7L,8L,8L,9L,10L,11L,11L,12L,12L,13L,14L,15L,15L,16L,17L,18L,19L,20L,20L,21L,21L,22L,23L,24L,25L,26L,26L,27L,28L,29L,29L,30L,30L,31L,32L,33L,33L,34L,35L,36L,37L,38L,38L,39L,40L,41L,42L,43L,43L,44L,44L,45L,46L,47L,48L,49L,49L,50L,51L,52L,52L,53L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086936Inst : IEnumerable<long>
{
public static readonly long[] Value=A086936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086936.Bytes);
public long this[int i]=>Value[i];

public static A086936Inst Instance=new A086936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086937
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,0L,0L,2L,0L,2L,2L,0L,2L,0L,0L,0L,2L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,0L,2L,0L,0L,2L,0L,2L,2L,2L,0L,0L,0L,0L,2L,2L,2L,0L,0L,2L,2L,0L,0L,2L,0L,2L,2L,2L,0L,0L,2L,2L,0L,2L,0L,0L,0L,2L,0L,0L,2L,0L,0L,2L,0L,2L,0L,0L,2L,0L,2L,0L,2L,2L,2L,2L,2L,0L,2L,0L,2L,0L,2L,0L,0L,2L,0L,2L,2L,0L,2L,2L,0L,2L,0L,0L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086937Inst : IEnumerable<long>
{
public static readonly long[] Value=A086937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086937.Bytes);
public long this[int i]=>Value[i];

public static A086937Inst Instance=new A086937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086938
{
public static readonly long[] Value={ 1L,4L,3L,8L,5L,18L,7L,16L,27L,20L,11L,48L,13L,28L,15L,64L,17L,54L,19L,40L,21L,44L,23L,96L,25L,52L,81L,56L,29L,90L,31L,128L,33L,68L,35L,144L,37L,76L,39L,200L,41L,126L,43L,88L,135L,92L,47L,192L,49L,250L,51L,104L,53L,162L,55L,112L,57L,116L,59L,360L,61L,124L,189L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086938Inst : IEnumerable<long>
{
public static readonly long[] Value=A086938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086938.Bytes);
public long this[int i]=>Value[i];

public static A086938Inst Instance=new A086938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086939
{
public static readonly long[] Value={ 2L,6L,9L,12L,10L,24L,14L,32L,36L,30L,22L,60L,26L,42L,45L,80L,34L,72L,38L,100L,63L,66L,46L,120L,50L,78L,108L,84L,58L,150L,62L,160L,99L,102L,70L,180L,74L,114L,117L,240L,82L,168L,86L,132L,225L,138L,94L,288L,98L,300L,153L,156L,106L,216L,110L,224L,171L,174L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086939Inst : IEnumerable<long>
{
public static readonly long[] Value=A086939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086939.Bytes);
public long this[int i]=>Value[i];

public static A086939Inst Instance=new A086939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086940
{
public static readonly long[] Value={ 16L,196L,1996L,19996L,199996L,1999996L,19999996L,199999996L,1999999996L,19999999996L,199999999996L,1999999999996L,19999999999996L,199999999999996L,1999999999999996L,19999999999999996L,199999999999999996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086940Inst : IEnumerable<long>
{
public static readonly long[] Value=A086940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086940.Bytes);
public long this[int i]=>Value[i];

public static A086940Inst Instance=new A086940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086941
{
public static readonly long[] Value={ 24L,294L,2994L,29994L,299994L,2999994L,29999994L,299999994L,2999999994L,29999999994L,299999999994L,2999999999994L,29999999999994L,299999999999994L,2999999999999994L,29999999999999994L,299999999999999994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086941Inst : IEnumerable<long>
{
public static readonly long[] Value=A086941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086941.Bytes);
public long this[int i]=>Value[i];

public static A086941Inst Instance=new A086941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086942
{
public static readonly long[] Value={ 32L,392L,3992L,39992L,399992L,3999992L,39999992L,399999992L,3999999992L,39999999992L,399999999992L,3999999999992L,39999999999992L,399999999999992L,3999999999999992L,39999999999999992L,399999999999999992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086942Inst : IEnumerable<long>
{
public static readonly long[] Value=A086942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086942.Bytes);
public long this[int i]=>Value[i];

public static A086942Inst Instance=new A086942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086943
{
public static readonly long[] Value={ 23L,293L,2993L,29993L,299993L,2999993L,29999993L,299999993L,2999999993L,29999999993L,299999999993L,2999999999993L,29999999999993L,299999999999993L,2999999999999993L,29999999999999993L,299999999999999993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086943Inst : IEnumerable<long>
{
public static readonly long[] Value=A086943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086943.Bytes);
public long this[int i]=>Value[i];

public static A086943Inst Instance=new A086943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086944
{
public static readonly long[] Value={ 42L,492L,4992L,49992L,499992L,4999992L,49999992L,499999992L,4999999992L,49999999992L,499999999992L,4999999999992L,49999999999992L,499999999999992L,4999999999999992L,49999999999999992L,499999999999999992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086944Inst : IEnumerable<long>
{
public static readonly long[] Value=A086944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086944.Bytes);
public long this[int i]=>Value[i];

public static A086944Inst Instance=new A086944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086945
{
public static readonly long[] Value={ 61L,691L,6991L,69991L,699991L,6999991L,69999991L,699999991L,6999999991L,69999999991L,699999999991L,6999999999991L,69999999999991L,699999999999991L,6999999999999991L,69999999999999991L,699999999999999991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086945Inst : IEnumerable<long>
{
public static readonly long[] Value=A086945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086945.Bytes);
public long this[int i]=>Value[i];

public static A086945Inst Instance=new A086945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086946
{
public static readonly long[] Value={ 14L,194L,1994L,19994L,199994L,1999994L,19999994L,199999994L,1999999994L,19999999994L,199999999994L,1999999999994L,19999999999994L,199999999999994L,1999999999999994L,19999999999999994L,199999999999999994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086946Inst : IEnumerable<long>
{
public static readonly long[] Value=A086946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086946.Bytes);
public long this[int i]=>Value[i];

public static A086946Inst Instance=new A086946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086947
{
public static readonly long[] Value={ 21L,291L,2991L,29991L,299991L,2999991L,29999991L,299999991L,2999999991L,29999999991L,299999999991L,2999999999991L,29999999999991L,299999999999991L,2999999999999991L,29999999999999991L,299999999999999991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086947Inst : IEnumerable<long>
{
public static readonly long[] Value=A086947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086947.Bytes);
public long this[int i]=>Value[i];

public static A086947Inst Instance=new A086947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086964
{
public static readonly long[] Value={ 2L,1L,3L,6L,10L,4L,14L,8L,12L,5L,22L,9L,26L,7L,15L,20L,34L,30L,38L,16L,21L,11L,46L,24L,25L,13L,45L,42L,58L,18L,62L,40L,33L,17L,245L,36L,74L,19L,39L,32L,82L,28L,86L,66L,27L,23L,94L,48L,98L,60L,51L,78L,106L,54L,110L,56L,57L,29L,118L,50L,122L,31L,147L,80L,130L,44L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086964Inst : IEnumerable<long>
{
public static readonly long[] Value=A086964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086964.Bytes);
public long this[int i]=>Value[i];

public static A086964Inst Instance=new A086964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086965
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,0L,1L,1L,2L,0L,0L,1L,0L,1L,0L,1L,3L,1L,1L,0L,0L,1L,1L,1L,1L,3L,1L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,3L,3L,0L,1L,1L,0L,0L,1L,3L,3L,1L,1L,0L,0L,1L,1L,0L,1L,0L,3L,0L,1L,1L,1L,3L,0L,1L,3L,0L,1L,3L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,3L,1L,0L,3L,1L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086965Inst : IEnumerable<long>
{
public static readonly long[] Value=A086965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086965.Bytes);
public long this[int i]=>Value[i];

public static A086965Inst Instance=new A086965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086966
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,2L,0L,1L,1L,0L,2L,1L,0L,0L,2L,1L,1L,2L,0L,0L,2L,4L,1L,1L,0L,1L,2L,0L,0L,0L,2L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,2L,2L,2L,1L,1L,0L,0L,2L,1L,2L,2L,1L,1L,1L,1L,1L,0L,0L,3L,1L,1L,0L,0L,1L,2L,1L,0L,1L,1L,2L,2L,1L,1L,0L,1L,0L,2L,2L,1L,1L,0L,1L,0L,1L,0L,1L,0L,2L,0L,0L,1L,0L,1L,2L,2L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086966Inst : IEnumerable<long>
{
public static readonly long[] Value=A086966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086966.Bytes);
public long this[int i]=>Value[i];

public static A086966Inst Instance=new A086966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086967
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,2L,1L,1L,1L,1L,0L,2L,2L,2L,2L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,2L,0L,2L,1L,1L,0L,0L,0L,2L,1L,3L,0L,1L,2L,2L,2L,3L,0L,0L,0L,1L,3L,2L,0L,1L,1L,1L,0L,1L,1L,0L,0L,2L,0L,2L,3L,2L,1L,2L,1L,0L,2L,2L,0L,1L,0L,2L,0L,0L,1L,0L,0L,2L,0L,1L,0L,1L,1L,1L,0L,2L,0L,2L,3L,1L,3L,1L,3L,0L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086967Inst : IEnumerable<long>
{
public static readonly long[] Value=A086967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086967.Bytes);
public long this[int i]=>Value[i];

public static A086967Inst Instance=new A086967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086968
{
public static readonly long[] Value={ 4L,7L,23L,26L,35L,39L,41L,42L,57L,64L,77L,98L,102L,103L,108L,111L,140L,156L,161L,163L,167L,184L,185L,186L,216L,228L,267L,269L,302L,317L,318L,324L,327L,331L,333L,334L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086968Inst : IEnumerable<long>
{
public static readonly long[] Value=A086968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086968.Bytes);
public long this[int i]=>Value[i];

public static A086968Inst Instance=new A086968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086969
{
public static readonly long[] Value={ 2L,2L,3L,4L,7L,8L,11L,12L,15L,20L,21L,26L,29L,30L,33L,38L,43L,44L,49L,52L,53L,58L,61L,66L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086969Inst : IEnumerable<long>
{
public static readonly long[] Value=A086969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086969.Bytes);
public long this[int i]=>Value[i];

public static A086969Inst Instance=new A086969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086970
{
public static readonly long[] Value={ 1L,5L,3L,9L,7L,13L,11L,17L,15L,21L,19L,25L,23L,29L,27L,33L,31L,37L,35L,41L,39L,45L,43L,49L,47L,53L,51L,57L,55L,61L,59L,65L,63L,69L,67L,73L,71L,77L,75L,81L,79L,85L,83L,89L,87L,93L,91L,97L,95L,101L,99L,105L,103L,109L,107L,113L,111L,117L,115L,121L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086970Inst : IEnumerable<long>
{
public static readonly long[] Value=A086970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086970.Bytes);
public long this[int i]=>Value[i];

public static A086970Inst Instance=new A086970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086971
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,2L,0L,1L,1L,1L,0L,2L,0L,2L,1L,1L,0L,2L,1L,1L,1L,2L,0L,3L,0L,1L,1L,1L,1L,3L,0L,1L,1L,2L,0L,3L,0L,2L,2L,1L,0L,2L,1L,2L,1L,2L,0L,2L,1L,2L,1L,1L,0L,4L,0L,1L,2L,1L,1L,3L,0L,2L,1L,3L,0L,3L,0L,1L,2L,2L,1L,3L,0L,2L,1L,1L,0L,4L,1L,1L,1L,2L,0L,4L,1L,2L,1L,1L,1L,2L,0L,2L,2L,3L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086971Inst : IEnumerable<long>
{
public static readonly long[] Value=A086971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086971.Bytes);
public long this[int i]=>Value[i];

public static A086971Inst Instance=new A086971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086972
{
public static readonly long[] Value={ 1L,3L,11L,41L,149L,527L,1823L,6197L,20777L,68891L,226355L,738113L,2391485L,7705895L,24712007L,78918989L,251105873L,796364339L,2518233179L,7942120025L,24988621541L,78452649023L,245818300271L,768835960421L,2400651060089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086972Inst : IEnumerable<long>
{
public static readonly long[] Value=A086972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086972.Bytes);
public long this[int i]=>Value[i];

public static A086972Inst Instance=new A086972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086973
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,2L,2L,2L,4L,2L,2L,6L,6L,8L,8L,14L,14L,2L,2L,28L,28L,6L,6L,62L,62L,16L,16L,126L,126L,28L,28L,112L,60L,6L,6L,10L,30L,2L,56L,2640L,2L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086973Inst : IEnumerable<long>
{
public static readonly long[] Value=A086973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086973.Bytes);
public long this[int i]=>Value[i];

public static A086973Inst Instance=new A086973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086974
{
public static readonly long[] Value={ 60L,84L,90L,126L,132L,140L,156L,198L,204L,220L,228L,234L,260L,276L,306L,308L,315L,340L,342L,348L,364L,372L,380L,414L,444L,460L,476L,492L,495L,516L,522L,532L,558L,564L,572L,580L,585L,620L,636L,644L,650L,666L,693L,708L,732L,738L,740L,748L,765L,774L,804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086974Inst : IEnumerable<long>
{
public static readonly long[] Value=A086974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086974.Bytes);
public long this[int i]=>Value[i];

public static A086974Inst Instance=new A086974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086975
{
public static readonly long[] Value={ 60L,84L,132L,140L,156L,204L,220L,228L,260L,276L,308L,315L,340L,348L,364L,372L,380L,444L,460L,476L,492L,495L,516L,532L,564L,572L,580L,585L,620L,636L,644L,693L,708L,732L,740L,748L,765L,804L,812L,819L,820L,836L,852L,855L,860L,868L,876L,884L,940L,948L,988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086975Inst : IEnumerable<long>
{
public static readonly long[] Value=A086975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086975.Bytes);
public long this[int i]=>Value[i];

public static A086975Inst Instance=new A086975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086976
{
public static readonly long[] Value={ 2L,19L,712L,87685L,31102080L,28757840751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086976Inst : IEnumerable<long>
{
public static readonly long[] Value=A086976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086976.Bytes);
public long this[int i]=>Value[i];

public static A086976Inst Instance=new A086976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086977
{
public static readonly long[] Value={ 199L,1831L,5591L,30593L,81463L,82073L,162143L,173359L,404597L,542603L,544279L,1100977L,1444309L,2238823L,5845193L,6752623L,6958667L,11981443L,13626257L,49269581L,83751121L,147684137L,166726367L,378043979L,895858039L,1872851947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086977Inst : IEnumerable<long>
{
public static readonly long[] Value=A086977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086977.Bytes);
public long this[int i]=>Value[i];

public static A086977Inst Instance=new A086977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086978
{
public static readonly long[] Value={ 211L,1847L,5623L,30631L,81509L,82129L,162209L,173429L,404671L,542683L,544367L,1101071L,1444411L,2238931L,5845309L,6752747L,6958801L,11981587L,13626407L,49269739L,83751287L,147684323L,166726561L,378044179L,895858267L,1872852203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086978Inst : IEnumerable<long>
{
public static readonly long[] Value=A086978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086978.Bytes);
public long this[int i]=>Value[i];

public static A086978Inst Instance=new A086978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086979
{
public static readonly long[] Value={ 46L,282L,738L,3302L,7970L,8028L,14862L,15783L,34202L,44773L,44903L,85787L,110224L,165326L,402884L,460883L,474029L,786922L,887313L,2959782L,4875380L,8321465L,9330121L,20226285L,45808557L,92276646L,114867712L,201745031L,265878477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086979Inst : IEnumerable<long>
{
public static readonly long[] Value=A086979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086979.Bytes);
public long this[int i]=>Value[i];

public static A086979Inst Instance=new A086979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086980
{
public static readonly long[] Value={ 12L,16L,32L,38L,46L,56L,66L,70L,74L,80L,88L,94L,102L,108L,116L,124L,134L,144L,150L,158L,166L,186L,194L,200L,228L,256L,264L,278L,294L,298L,316L,328L,334L,362L,370L,388L,422L,436L,442L,452L,466L,472L,482L,488L,510L,520L,536L,568L,576L,580L,590L,608L,628L,632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086980Inst : IEnumerable<long>
{
public static readonly long[] Value=A086980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086980.Bytes);
public long this[int i]=>Value[i];

public static A086980Inst Instance=new A086980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086981
{
public static readonly long[] Value={ 0L,0L,0L,21L,11L,39L,136L,171L,253L,406L,0L,0L,0L,0L,1081L,0L,1711L,1830L,0L,0L,292L,0L,0L,1958L,4656L,202L,1751L,0L,5886L,6328L,2667L,8515L,548L,3197L,11026L,0L,6123L,0L,13861L,0L,15931L,16290L,0L,18528L,9653L,0L,3165L,24753L,0L,26106L,27028L,0L,3615L,6275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086981Inst : IEnumerable<long>
{
public static readonly long[] Value=A086981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086981.Bytes);
public long this[int i]=>Value[i];

public static A086981Inst Instance=new A086981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086982
{
public static readonly long[] Value={ 11L,21L,33L,39L,55L,63L,77L,99L,105L,117L,121L,136L,143L,147L,165L,171L,187L,189L,195L,202L,209L,231L,243L,253L,273L,275L,292L,297L,315L,319L,341L,351L,357L,363L,385L,399L,406L,407L,408L,429L,441L,451L,473L,483L,495L,507L,513L,517L,525L,539L,548L,561L,567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086982Inst : IEnumerable<long>
{
public static readonly long[] Value=A086982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086982.Bytes);
public long this[int i]=>Value[i];

public static A086982Inst Instance=new A086982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086983
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,31L,37L,43L,47L,53L,61L,67L,71L,73L,79L,97L,103L,107L,127L,151L,157L,163L,191L,193L,199L,211L,223L,241L,271L,277L,283L,313L,331L,337L,367L,383L,397L,421L,431L,457L,463L,487L,499L,523L,541L,547L,577L,607L,613L,631L,647L,661L,673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086983Inst : IEnumerable<long>
{
public static readonly long[] Value=A086983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086983.Bytes);
public long this[int i]=>Value[i];

public static A086983Inst Instance=new A086983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086984
{
public static readonly BigInteger[] Value={ 1L,6L,60L,696L,9120L,134640L,2227680L,41005440L,833172480L,18546796800L,449223667200L,11766674304000L,331501679308800L,9997170543360000L,321355745238528000L,10969253822951424000UL,BigInteger.Parse("396269940892041216000") };
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
public class A086984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086984Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086984.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086984Inst Instance=new A086984Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086985
{
public static readonly BigInteger[] Value={ 0L,0L,0L,144L,6000L,198000L,6420960L,218453760L,7988440320L,316674489600L,13630070361600L,635880851020800L,32050874586931200L,1738651147833600000L,BigInteger.Parse("101100246720625152000"),BigInteger.Parse("6277170099060596736000"),BigInteger.Parse("414620927349422137344000") };
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
public class A086985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086985Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086985.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086985Inst Instance=new A086985Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086986
{
public static readonly long[] Value={ 3L,4L,7L,8L,9L,10L,12L,13L,16L,17L,19L,20L,21L,22L,24L,25L,26L,27L,28L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,73L,75L,76L,77L,78L,81L,82L,83L,84L,85L,86L,87L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086986Inst : IEnumerable<long>
{
public static readonly long[] Value=A086986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086986.Bytes);
public long this[int i]=>Value[i];

public static A086986Inst Instance=new A086986Inst();

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