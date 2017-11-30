using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A245982
{
public static readonly BigInteger[] Value={ 1L,1L,6L,87L,2200L,159245L,22460976L,3841485235L,725338311552L,150719206127769L,35342379764876800L,9829163373723941951UL,BigInteger.Parse("3429714088052022223872"),BigInteger.Parse("1523614487096970692512933"),BigInteger.Parse("823050850772773045911871488"),BigInteger.Parse("507838824721407879972472444875") };
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
public class A245982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245982Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245982.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245982Inst Instance=new A245982Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245983
{
public static readonly BigInteger[] Value={ 1L,1L,10L,267L,12040L,826245L,86252976L,12661148311L,2428606888576L,585229569018921L,172640322717932800L,BigInteger.Parse("60933514918456147011"),BigInteger.Parse("25283156000087876668416"),BigInteger.Parse("12189356237264450125373869"),BigInteger.Parse("6769905753950075837079906304"),BigInteger.Parse("4297777320612236566890778059375") };
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
public class A245983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245983Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245983.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245983Inst Instance=new A245983Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245984
{
public static readonly BigInteger[] Value={ 1L,1L,6L,87L,2200L,84245L,4492656L,908888155L,357260391552L,135745499491209L,49743738690284800L,18418196210352315311UL,BigInteger.Parse("7088670872640238205952"),BigInteger.Parse("2879857079508362958098653"),BigInteger.Parse("1254944121383140772128247808"),BigInteger.Parse("610054332530467361553695923875") };
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
public class A245984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245984Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245984.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245984Inst Instance=new A245984Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245985
{
public static readonly BigInteger[] Value={ 1L,1L,10L,213L,9592L,682545L,69119136L,9284636221L,1682479423360L,410336706483873L,129022118179494400L,BigInteger.Parse("49380786699038009061"),BigInteger.Parse("22121770547251791968256"),BigInteger.Parse("11386670423628468306437905"),BigInteger.Parse("6678552357682831880750669824"),BigInteger.Parse("4435028805132706191344837902125") };
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
public class A245985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245985Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245985.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245985Inst Instance=new A245985Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245986
{
public static readonly BigInteger[] Value={ 1L,1L,6L,141L,6184L,387545L,33404256L,3891981205L,592320594048L,128805405787953L,43012267760166400L,BigInteger.Parse("19329826195760619341"),BigInteger.Parse("10086545470056599549952"),BigInteger.Parse("5787171311384573282516617"),BigInteger.Parse("3623228151360430287454531584"),BigInteger.Parse("2480483584581055916081566933125") };
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
public class A245986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245986Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245986.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245986Inst Instance=new A245986Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245987
{
public static readonly BigInteger[] Value={ 1L,1L,10L,213L,8056L,540945L,55791936L,7976641981L,1469902760320L,332703236420577L,93998774487116800L,BigInteger.Parse("34310097895273565541"),BigInteger.Parse("16097501586129903138816"),BigInteger.Parse("9217140995822760715385905"),BigInteger.Parse("6076268404868213191347785728"),BigInteger.Parse("4448129862114255651329796526125") };
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
public class A245987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245987Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245987.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245987Inst Instance=new A245987Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245988
{
public static readonly BigInteger[] Value={ 1L,1L,10L,141L,9592L,159245L,86252976L,908888155L,1682479423360L,128805405787953L,93998774487116800L,1099662085349496911L,BigInteger.Parse("44830846497021739693056"),BigInteger.Parse("147548082727234113659293"),BigInteger.Parse("3534565745374740945151080448"),BigInteger.Parse("1613371163531618738559582856125") };
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
public class A245988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245988Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245988.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245988Inst Instance=new A245988Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245989
{
public static readonly long[] Value={ 8L,12L,18L,26L,38L,56L,82L,120L,176L,258L,378L,554L,812L,1190L,1744L,2556L,3746L,5490L,8046L,11792L,17282L,25328L,37120L,54402L,79730L,116850L,171252L,250982L,367832L,539084L,790066L,1157898L,1696982L,2487048L,3644946L,5341928L,7828976L,11473922L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245989Inst : IEnumerable<long>
{
public static readonly long[] Value=A245989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245989.Bytes);
public long this[int i]=>Value[i];

public static A245989Inst Instance=new A245989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245990
{
public static readonly long[] Value={ 28L,68L,164L,396L,956L,2308L,5572L,13452L,32476L,78404L,189284L,456972L,1103228L,2663428L,6430084L,15523596L,37477276L,90478148L,218433572L,527345292L,1273124156L,3073593604L,7420311364L,17914216332L,43248744028L,104411704388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245990Inst : IEnumerable<long>
{
public static readonly long[] Value=A245990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245990.Bytes);
public long this[int i]=>Value[i];

public static A245990Inst Instance=new A245990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245991
{
public static readonly long[] Value={ 64L,208L,676L,2196L,7132L,23168L,75260L,244464L,794096L,2579500L,8379052L,27217860L,88412560L,287192948L,932896352L,3030352272L,9843575108L,31975148500L,103865731612L,337389844512L,1095952482460L,3560011839440L,11564081956784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245991Inst : IEnumerable<long>
{
public static readonly long[] Value=A245991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245991.Bytes);
public long this[int i]=>Value[i];

public static A245991Inst Instance=new A245991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245992
{
public static readonly long[] Value={ 126L,534L,2262L,9582L,40590L,171942L,728358L,3085374L,13069854L,55364790L,234529014L,993480846L,4208452398L,17827290438L,75517614150L,319897747038L,1355108602302L,5740332156246L,24316437227286L,103006081065390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245992Inst : IEnumerable<long>
{
public static readonly long[] Value=A245992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245992.Bytes);
public long this[int i]=>Value[i];

public static A245992Inst Instance=new A245992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245993
{
public static readonly long[] Value={ 216L,1116L,5766L,29790L,153906L,795144L,4108062L,21223992L,109652160L,566509902L,2926831878L,15121261374L,78122885724L,403616150730L,2085253182384L,10773307330236L,55659500700198L,287560720444278L,1485661331645130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245993Inst : IEnumerable<long>
{
public static readonly long[] Value=A245993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245993.Bytes);
public long this[int i]=>Value[i];

public static A245993Inst Instance=new A245993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245994
{
public static readonly long[] Value={ 344L,2120L,13064L,80504L,496088L,3057032L,18838280L,116086712L,715358552L,4408238024L,27164786696L,167396958200L,1031546535896L,6356676173576L,39171603577352L,241386297637688L,1487489389403480L,9166322634058568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245994Inst : IEnumerable<long>
{
public static readonly long[] Value=A245994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245994.Bytes);
public long this[int i]=>Value[i];

public static A245994Inst Instance=new A245994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245995
{
public static readonly long[] Value={ 2L,8L,2L,28L,12L,2L,64L,68L,18L,2L,126L,208L,164L,26L,2L,216L,534L,676L,396L,38L,2L,344L,1116L,2262L,2196L,956L,56L,2L,512L,2120L,5766L,9582L,7132L,2308L,82L,2L,730L,3648L,13064L,29790L,40590L,23168L,5572L,120L,2L,1000L,5930L,25992L,80504L,153906L,171942L,75260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245995Inst : IEnumerable<long>
{
public static readonly long[] Value=A245995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245995.Bytes);
public long this[int i]=>Value[i];

public static A245995Inst Instance=new A245995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245996
{
public static readonly long[] Value={ 2L,8L,28L,64L,126L,216L,344L,512L,730L,1000L,1332L,1728L,2198L,2744L,3376L,4096L,4914L,5832L,6860L,8000L,9262L,10648L,12168L,13824L,15626L,17576L,19684L,21952L,24390L,27000L,29792L,32768L,35938L,39304L,42876L,46656L,50654L,54872L,59320L,64000L,68922L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245996Inst : IEnumerable<long>
{
public static readonly long[] Value=A245996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245996.Bytes);
public long this[int i]=>Value[i];

public static A245996Inst Instance=new A245996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245997
{
public static readonly long[] Value={ 2L,12L,68L,208L,534L,1116L,2120L,3648L,5930L,9100L,13452L,19152L,26558L,35868L,47504L,61696L,78930L,99468L,123860L,152400L,185702L,224092L,268248L,318528L,375674L,440076L,512540L,593488L,683790L,783900L,894752L,1016832L,1151138L,1298188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245997Inst : IEnumerable<long>
{
public static readonly long[] Value=A245997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245997.Bytes);
public long this[int i]=>Value[i];

public static A245997Inst Instance=new A245997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245998
{
public static readonly long[] Value={ 2L,18L,164L,676L,2262L,5766L,13064L,25992L,48170L,82810L,135852L,212268L,320894L,468846L,668432L,929296L,1267794L,1696482L,2236340L,2903220L,3723302L,4716118L,5913624L,7339416L,9031802L,11018826L,13345724L,16045372L,19170510L,22759230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245998Inst : IEnumerable<long>
{
public static readonly long[] Value=A245998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245998.Bytes);
public long this[int i]=>Value[i];

public static A245998Inst Instance=new A245998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245999
{
public static readonly long[] Value={ 2L,26L,396L,2196L,9582L,29790L,80504L,185192L,391290L,753570L,1371972L,2352636L,3877286L,6128486L,9405552L,13997520L,20363634L,28934442L,40377980L,55306340L,74651742L,99252846L,130367976L,169112376L,217138922L,275894450L,347501364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245999Inst : IEnumerable<long>
{
public static readonly long[] Value=A245999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245999.Bytes);
public long this[int i]=>Value[i];

public static A245999Inst Instance=new A245999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246000
{
public static readonly long[] Value={ 2L,38L,956L,7132L,40590L,153906L,496088L,1319480L,3178490L,6857470L,13855572L,26075028L,46848326L,80108042L,132346160L,210837616L,327085938L,493492950L,729039980L,1053585740L,1496758142L,2088821218L,2874009096L,3896630952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246000Inst : IEnumerable<long>
{
public static readonly long[] Value=A246000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246000.Bytes);
public long this[int i]=>Value[i];

public static A246000Inst Instance=new A246000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246001
{
public static readonly long[] Value={ 2L,56L,2308L,23168L,171942L,795144L,3057032L,9401216L,25819210L,62402840L,139927692L,288998016L,566057198L,1047126248L,1862251792L,3175741184L,5253738642L,8416795896L,13163097620L,20070807680L,30009814582L,43960191176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246001Inst : IEnumerable<long>
{
public static readonly long[] Value=A246001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246001.Bytes);
public long this[int i]=>Value[i];

public static A246001Inst Instance=new A246001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246002
{
public static readonly long[] Value={ 2L,82L,5572L,75260L,728358L,4108062L,18838280L,66983128L,209732170L,567864650L,1413132492L,3203059092L,6839534702L,13687432150L,26203871248L,47834595632L,84386904210L,143553121218L,237664797140L,382348873900L,601693049782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246002Inst : IEnumerable<long>
{
public static readonly long[] Value=A246002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246002.Bytes);
public long this[int i]=>Value[i];

public static A246002Inst Instance=new A246002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246003
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,9L,0L,4L,20L,64L,0L,6L,48L,204L,625L,0L,10L,121L,682L,2604L,7776L,0L,18L,312L,2340L,11160L,39990L,117649L,0L,32L,820L,8192L,48828L,209952L,720600L,2097152L,0L,56L,2187L,29127L,217013L,1119744L,4483734L,14913080L,43046721L,0L,102L,5904L,104857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246003Inst : IEnumerable<long>
{
public static readonly long[] Value=A246003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246003.Bytes);
public long this[int i]=>Value[i];

public static A246003Inst Instance=new A246003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246004
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,0L,6L,0L,0L,4L,1L,0L,2L,6L,4L,0L,16L,0L,6L,4L,6L,1L,11L,0L,20L,2L,0L,6L,4L,4L,30L,0L,1L,16L,12L,0L,9L,6L,2L,4L,40L,6L,42L,1L,4L,11L,23L,0L,42L,20L,16L,2L,52L,0L,4L,6L,6L,4L,29L,4L,15L,30L,6L,0L,4L,1L,66L,16L,11L,12L,35L,0L,36L,9L,20L,6L,6L,2L,26L,4L,0L,40L,41L,6L,16L,42L,4L,1L,8L,4L,6L,11L,30L,23L,12L,0L,16L,42L,1L,20L,100L,16L,102L,2L,12L,52L,53L,0L,54L,4L,9L,6L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246004Inst : IEnumerable<long>
{
public static readonly long[] Value=A246004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246004.Bytes);
public long this[int i]=>Value[i];

public static A246004Inst Instance=new A246004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246005
{
public static readonly long[] Value={ 3L,3L,5L,0L,17L,5L,3L,3L,19L,3L,5L,0L,3L,5L,7L,3L,313L,13L,349L,3L,5L,19L,127L,0L,4229L,11L,17L,3L,3L,7L,5L,19L,19L,3L,3L,5L,3L,3L,5L,0L,5L,5L,7L,3L,4421L,7L,7L,17L,3L,3L,19L,3L,17L,17L,3L,23L,7L,3L,3L,0L,43L,0L,5L,5L,3L,13L,1171L,11L,163L,3L,3L,5L,3L,7L,13L,3L,3L,17L,13L,3L,7L,5L,3L,0L,181L,3L,5L,5L,19L,17L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246005Inst : IEnumerable<long>
{
public static readonly long[] Value=A246005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246005.Bytes);
public long this[int i]=>Value[i];

public static A246005Inst Instance=new A246005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246006
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,5L,1L,61L,1L,1385L,5L,50521L,691L,2702765L,7L,199360981L,3617L,19391512145L,43867L,2404879675441L,174611L,370371188237525L,854513L,69348874393137901L,236364091L,15514534163557086905UL,8553103L,BigInteger.Parse("4087072509293123892361"),23749461029L,BigInteger.Parse("1252259641403629865468285") };
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
public class A246006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246006Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246006.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246006Inst Instance=new A246006Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246007
{
public static readonly long[] Value={ 2L,5L,3L,6L,7L,7L,19L,5L,4L,11L,7L,15L,10L,9L,14L,17L,12L,8L,21L,20L,16L,15L,11L,33L,36L,36L,18L,10L,14L,31L,26L,22L,21L,13L,26L,34L,16L,12L,21L,42L,25L,16L,16L,37L,20L,29L,19L,24L,32L,90L,28L,28L,19L,19L,85L,23L,40L,14L,36L,27L,22L,49L,17L,31L,31L,40L,13L,44L,43L,26L,66L,43L,25L,25L,25L,30L,21L,30L,30L,51L,20L,25L,25L,33L,47L,16L,47L,91L,46L,46L,29L,46L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246007Inst : IEnumerable<long>
{
public static readonly long[] Value=A246007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246007.Bytes);
public long this[int i]=>Value[i];

public static A246007Inst Instance=new A246007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246008
{
public static readonly BigInteger[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,33L,252L,15451L,54533545L,445335474533544L,BigInteger.Parse("34533547453354645335474533543"),BigInteger.Parse("245335474533546453354745335454533547453354645335474533542"),BigInteger.Parse("14533547453354645335474533545453354745335464533547453354445335474533546453354745335454533547453354645335474533541") };
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
public class A246008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246008Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246008.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246008Inst Instance=new A246008Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246009
{
public static readonly long[] Value={ 2L,8L,6L,17L,15L,10L,13L,21L,16L,19L,107L,22L,110L,30L,105L,12L,33L,20L,28L,103L,116L,36L,111L,31L,119L,26L,88L,101L,114L,13L,47L,29L,91L,42L,24L,16L,37L,24L,68L,32L,32L,19L,45L,120L,27L,120L,40L,71L,14L,35L,84L,53L,22L,66L,123L,79L,30L,43L,17L,43L,61L,118L,38L,87L,131L,38L,25L,113L,126L,33L,126L,51L,46L,20L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246009Inst : IEnumerable<long>
{
public static readonly long[] Value=A246009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246009.Bytes);
public long this[int i]=>Value[i];

public static A246009Inst Instance=new A246009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246010
{
public static readonly long[] Value={ 5L,11L,31L,61L,151L,211L,361L,451L,661L,1051L,1201L,1711L,2101L,2311L,2761L,3511L,4351L,4651L,5611L,6301L,6661L,7801L,8611L,9901L,11761L,12751L,13261L,14311L,14851L,15961L,20161L,21451L,23461L,24151L,27751L,28501L,30811L,33211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246010Inst : IEnumerable<long>
{
public static readonly long[] Value=A246010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246010.Bytes);
public long this[int i]=>Value[i];

public static A246010Inst Instance=new A246010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246011
{
public static readonly long[] Value={ 1L,3L,3L,4L,3L,9L,4L,7L,3L,9L,9L,12L,4L,12L,7L,11L,3L,9L,9L,12L,9L,27L,12L,21L,4L,12L,12L,16L,7L,21L,11L,18L,3L,9L,9L,12L,9L,27L,12L,21L,9L,27L,27L,36L,12L,36L,21L,33L,4L,12L,12L,16L,12L,36L,16L,28L,7L,21L,21L,28L,11L,33L,18L,29L,3L,9L,9L,12L,9L,27L,12L,21L,9L,27L,27L,36L,12L,36L,21L,33L,9L,27L,27L,36L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246011Inst : IEnumerable<long>
{
public static readonly long[] Value=A246011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246011.Bytes);
public long this[int i]=>Value[i];

public static A246011Inst Instance=new A246011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246012
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,13L,50L,229L,1238L,7614L,52706L,405581L,3432022L,31684445L,316889938L,3413091138L,39387068998L,484828126705L,6340895228354L,87808618184425L,1283526229013174L,19749165195159006L,319067116612263218L,5400310536601145705L,BigInteger.Parse("95556575226489750694"),BigInteger.Parse("1764354398252386630937") };
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
public class A246012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246012Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246012.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246012Inst Instance=new A246012Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246013
{
public static readonly BigInteger[] Value={ 0L,1L,1L,3L,9L,34L,159L,853L,5249L,36369L,279711L,2367212L,21854625L,218570717L,2354163631L,27167018427L,334407123969L,4373595961678L,60565476185919L,885304614118777L,13621870369734689L,220074660203753961L,3724832321188825551L,BigInteger.Parse("65909583942401516528") };
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
public class A246013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246013Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246013.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246013Inst Instance=new A246013Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246014
{
public static readonly BigInteger[] Value={ 0L,0L,1L,1L,4L,16L,70L,385L,2365L,16337L,125870L,1064810L,9829820L,98319221L,1058927507L,12220050571L,150421002736L,1967299266676L,27243141998506L,398221614894397L,6127294825424317L,98992456408509257L,1675478215412320154L,BigInteger.Parse("29646991284088234166") };
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
public class A246014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246014Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246014.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246014Inst Instance=new A246014Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246015
{
public static readonly BigInteger[] Value={ 0L,1L,1L,3L,4L,34L,70L,853L,2365L,36369L,125870L,2367212L,9829820L,218570717L,1058927507L,27167018427L,150421002736L,4373595961678L,27243141998506L,885304614118777L,6127294825424317L,220074660203753961L,1675478215412320154L,BigInteger.Parse("65909583942401516528"),BigInteger.Parse("547401364007816870552"),BigInteger.Parse("23406034074310130665241") };
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
public class A246015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246015Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246015.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246015Inst Instance=new A246015Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246016
{
public static readonly long[] Value={ 1L,1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,1L,-1L,-1L,1L,-1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246016Inst : IEnumerable<long>
{
public static readonly long[] Value=A246016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246016.Bytes);
public long this[int i]=>Value[i];

public static A246016Inst Instance=new A246016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246017
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,2L,3L,4L,3L,4L,3L,2L,3L,4L,3L,4L,5L,4L,5L,6L,5L,4L,5L,4L,5L,6L,5L,6L,7L,6L,7L,8L,7L,8L,7L,6L,7L,8L,7L,8L,7L,6L,7L,6L,5L,6L,5L,4L,5L,6L,5L,6L,7L,6L,7L,8L,7L,8L,7L,6L,7L,8L,7L,8L,9L,8L,9L,10L,9L,8L,9L,8L,9L,10L,9L,10L,11L,10L,11L,12L,11L,10L,11L,10L,9L,10L,9L,8L,9L,8L,9L,10L,9L,8L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246017Inst : IEnumerable<long>
{
public static readonly long[] Value=A246017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246017.Bytes);
public long this[int i]=>Value[i];

public static A246017Inst Instance=new A246017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246018
{
public static readonly long[] Value={ 1L,1L,2L,12L,80L,640L,9216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246018Inst : IEnumerable<long>
{
public static readonly long[] Value=A246018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246018.Bytes);
public long this[int i]=>Value[i];

public static A246018Inst Instance=new A246018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246019
{
public static readonly long[] Value={ 1L,2L,6L,20L,66L,220L,732L,2440L,8134L,27124L,90452L,301656L,1006036L,3355224L,11190040L,37320144L,124467394L,415114844L,1384462172L,4617363016L,15399513116L,51359405064L,171290386824L,571276030192L,1905280915036L,6354363191688L,21192639534984L,70680248726256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246019Inst : IEnumerable<long>
{
public static readonly long[] Value=A246019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246019.Bytes);
public long this[int i]=>Value[i];

public static A246019Inst Instance=new A246019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246020
{
public static readonly long[] Value={ 1L,3L,15L,81L,435L,2349L,12681L,68499L,370023L,1998945L,10798821L,58338495L,315162657L,1702608147L,9198028791L,49690672857L,268444806483L,1450224181197L,7834572084033L,42324849273915L,228652292458773L,1235252381526711L,6673226101644267L,36050889090859101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246020Inst : IEnumerable<long>
{
public static readonly long[] Value=A246020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246020.Bytes);
public long this[int i]=>Value[i];

public static A246020Inst Instance=new A246020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246021
{
public static readonly long[] Value={ 1L,4L,28L,208L,1540L,11440L,84976L,631360L,4690972L,34854352L,258971536L,1924189120L,14296956112L,106228114624L,789287772352L,5864503926016L,43573975930372L,323759929988272L,2405575577105392L,17873718523387456L,132803898120114352L,986749082625941824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246021Inst : IEnumerable<long>
{
public static readonly long[] Value=A246021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246021.Bytes);
public long this[int i]=>Value[i];

public static A246021Inst Instance=new A246021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246022
{
public static readonly long[] Value={ 1L,4L,6L,10L,12L,1L,516L,18L,202122L,242L,28L,30L,3L,3L,6L,3L,94041L,444546L,4849L,52535455L,58L,60L,6L,646566L,686L,0L,72L,74L,78L,8L,848L,888990L,9495L,98L,0L,102L,104L,6L,108L,1L,112L,1141L,16L,201L,22L,26L,1L,29130L,3L,4L,6L,138L,1L,411L,44L,47148L,150L,531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246022Inst : IEnumerable<long>
{
public static readonly long[] Value=A246022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246022.Bytes);
public long this[int i]=>Value[i];

public static A246022Inst Instance=new A246022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246023
{
public static readonly long[] Value={ 3L,3L,4L,7L,15L,26L,64L,132L,253L,498L,1033L,2027L,4089L,8141L,16416L,32715L,65722L,131374L,262159L,524211L,1048630L,2097291L,4195039L,8387885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246023Inst : IEnumerable<long>
{
public static readonly long[] Value=A246023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246023.Bytes);
public long this[int i]=>Value[i];

public static A246023Inst Instance=new A246023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246024
{
public static readonly long[] Value={ 1L,2L,1L,3L,0L,4L,-1L,5L,-1L,3L,1L,3L,0L,6L,-1L,7L,-1L,2L,2L,5L,1L,2L,1L,5L,2L,2L,0L,6L,2L,5L,1L,8L,-6L,6L,-5L,11L,-4L,7L,0L,6L,7L,0L,3L,6L,-6L,10L,-4L,4L,-4L,4L,-7L,8L,0L,7L,-5L,10L,1L,3L,-2L,10L,1L,9L,-3L,15L,0L,-9L,-1L,2L,1L,-2L,7L,7L,1L,-5L,9L,3L,2L,10L,2L,7L,8L,-2L,-1L,11L,-3L,16L,-8L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246024Inst : IEnumerable<long>
{
public static readonly long[] Value=A246024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246024.Bytes);
public long this[int i]=>Value[i];

public static A246024Inst Instance=new A246024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246025
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,11L,15L,16L,22L,24L,27L,33L,35L,42L,51L,53L,54L,58L,64L,78L,104L,132L,133L,139L,151L,164L,168L,204L,223L,242L,249L,256L,261L,289L,349L,385L,404L,438L,456L,460L,565L,579L,641L,661L,747L,800L,921L,929L,1012L,1053L,1112L,1249L,1251L,1384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246025Inst : IEnumerable<long>
{
public static readonly long[] Value=A246025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246025.Bytes);
public long this[int i]=>Value[i];

public static A246025Inst Instance=new A246025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246026
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,13L,15L,31L,35L,63L,85L,91L,171L,179L,267L,315L,355L,526L,614L,699L,819L,1355L,1443L,1827L,1987L,5306L,5506L,5690L,5882L,6112L,7295L,10266L,12506L,13303L,13518L,17007L,18382L,20430L,23166L,24898L,34322L,36126L,42526L,43390L,43630L,48046L,75118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246026Inst : IEnumerable<long>
{
public static readonly long[] Value=A246026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246026.Bytes);
public long this[int i]=>Value[i];

public static A246026Inst Instance=new A246026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246027
{
public static readonly long[] Value={ -1L,-1L,-1L,0L,-1L,2L,1L,1L,0L,4L,4L,3L,4L,5L,3L,4L,3L,8L,7L,8L,7L,7L,6L,9L,10L,12L,13L,10L,6L,9L,14L,14L,8L,14L,20L,16L,11L,19L,18L,14L,16L,22L,18L,12L,17L,19L,22L,25L,16L,18L,22L,27L,23L,19L,24L,24L,19L,23L,24L,23L,25L,27L,27L,27L,21L,25L,30L,29L,31L,30L,30L,27L,28L,31L,29L,27L,33L,30L,42L,42L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246027Inst : IEnumerable<long>
{
public static readonly long[] Value=A246027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246027.Bytes);
public long this[int i]=>Value[i];

public static A246027Inst Instance=new A246027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246028
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,3L,1L,1L,1L,2L,2L,2L,3L,5L,1L,1L,1L,2L,1L,1L,2L,3L,2L,2L,2L,4L,3L,3L,5L,8L,1L,1L,1L,2L,1L,1L,2L,3L,1L,1L,1L,2L,2L,2L,3L,5L,2L,2L,2L,4L,2L,2L,4L,6L,3L,3L,3L,6L,5L,5L,8L,13L,1L,1L,1L,2L,1L,1L,2L,3L,1L,1L,1L,2L,2L,2L,3L,5L,1L,1L,1L,2L,1L,1L,2L,3L,2L,2L,2L,4L,3L,3L,5L,8L,2L,2L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246028Inst : IEnumerable<long>
{
public static readonly long[] Value=A246028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246028.Bytes);
public long this[int i]=>Value[i];

public static A246028Inst Instance=new A246028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246029
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,3L,5L,2L,4L,4L,6L,3L,6L,5L,7L,2L,4L,4L,6L,4L,8L,6L,10L,3L,6L,6L,9L,5L,10L,7L,11L,2L,4L,4L,6L,4L,8L,6L,10L,4L,8L,8L,12L,6L,12L,10L,14L,3L,6L,6L,9L,6L,12L,9L,15L,5L,10L,10L,15L,7L,14L,11L,13L,2L,4L,4L,6L,4L,8L,6L,10L,4L,8L,8L,12L,6L,12L,10L,14L,4L,8L,8L,12L,8L,16L,12L,20L,6L,12L,12L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246029Inst : IEnumerable<long>
{
public static readonly long[] Value=A246029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246029.Bytes);
public long this[int i]=>Value[i];

public static A246029Inst Instance=new A246029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246030
{
public static readonly long[] Value={ 1L,8L,24L,112L,416L,1728L,6784L,27392L,109056L,437248L,1746944L,6991872L,27959296L,111853568L,447381504L,1789591552L,7158235136L,28633202688L,114532286464L,458130194432L,1832518680576L,7330078916608L,29320307277824L,117281245888512L,469124949999616L,1876499867107328L,7505999334211584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246030Inst : IEnumerable<long>
{
public static readonly long[] Value=A246030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246030.Bytes);
public long this[int i]=>Value[i];

public static A246030Inst Instance=new A246030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246031
{
public static readonly long[] Value={ 1L,26L,26L,124L,26L,676L,124L,1400L,26L,676L,676L,3224L,124L,3224L,1400L,10000L,26L,676L,676L,3224L,676L,17576L,3224L,36400L,124L,3224L,3224L,15376L,1400L,36400L,10000L,89504L,26L,676L,676L,3224L,676L,17576L,3224L,36400L,676L,17576L,17576L,83824L,3224L,83824L,36400L,260000L,124L,3224L,3224L,15376L,3224L,83824L,15376L,173600L,1400L,36400L,36400L,173600L,10000L,260000L,89504L,707008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246031Inst : IEnumerable<long>
{
public static readonly long[] Value=A246031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246031.Bytes);
public long this[int i]=>Value[i];

public static A246031Inst Instance=new A246031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246032
{
public static readonly BigInteger[] Value={ 1L,26L,124L,1400L,10000L,89504L,707008L,5924480L,47900416L,393069824L,3189761536L,25963397888L,210468531712L,1706090904320L,13803141607936L,111595408530176L,901164713600512L,7271581998320384L,58625571435837952L,472335388734974720L,3803021424555945472L,BigInteger.Parse("30602681612309510912"),BigInteger.Parse("246127842107210007040") };
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
public class A246032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246032Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246032.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246032Inst Instance=new A246032Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246033
{
public static readonly long[] Value={ 2L,3L,7L,19L,47L,73L,113L,199L,283L,467L,661L,887L,1129L,1327L,1627L,2803L,3947L,4297L,5881L,6379L,7043L,9949L,10343L,13187L,15823L,18461L,24137L,33647L,34763L,37663L,42863L,43067L,59753L,59797L,82619L,96017L,102679L,129643L,130699L,142237L,155893L,187477L,194119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246033Inst : IEnumerable<long>
{
public static readonly long[] Value=A246033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246033.Bytes);
public long this[int i]=>Value[i];

public static A246033Inst Instance=new A246033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246034
{
public static readonly long[] Value={ 1L,21L,21L,85L,21L,233L,85L,321L,21L,441L,233L,761L,85L,1137L,321L,1545L,21L,441L,441L,1785L,233L,2925L,761L,3589L,85L,1785L,1137L,3977L,321L,4549L,1545L,5909L,21L,441L,441L,1785L,441L,4893L,1785L,6741L,233L,4893L,2925L,9949L,761L,11301L,3589L,13181L,85L,1785L,1785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246034Inst : IEnumerable<long>
{
public static readonly long[] Value=A246034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246034.Bytes);
public long this[int i]=>Value[i];

public static A246034Inst Instance=new A246034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246035
{
public static readonly long[] Value={ 1L,9L,9L,25L,9L,81L,25L,121L,9L,81L,81L,225L,25L,225L,121L,441L,9L,81L,81L,225L,81L,729L,225L,1089L,25L,225L,225L,625L,121L,1089L,441L,1849L,9L,81L,81L,225L,81L,729L,225L,1089L,81L,729L,729L,2025L,225L,2025L,1089L,3969L,25L,225L,225L,625L,225L,2025L,625L,3025L,121L,1089L,1089L,3025L,441L,3969L,1849L,7225L,9L,81L,81L,225L,81L,729L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246035Inst : IEnumerable<long>
{
public static readonly long[] Value=A246035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246035.Bytes);
public long this[int i]=>Value[i];

public static A246035Inst Instance=new A246035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246036
{
public static readonly long[] Value={ 1L,6L,20L,88L,336L,1376L,5440L,21888L,87296L,349696L,1397760L,5593088L,22368256L,89481216L,357908480L,1431666688L,5726601216L,22906535936L,91625881600L,366504050688L,1466015154176L,5864062713856L,23456246661120L,93824995033088L,375299963355136L,1501199886974976L,6004799480791040L,24019198057381888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246036Inst : IEnumerable<long>
{
public static readonly long[] Value=A246036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246036.Bytes);
public long this[int i]=>Value[i];

public static A246036Inst Instance=new A246036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246037
{
public static readonly long[] Value={ 1L,6L,6L,20L,6L,36L,20L,88L,6L,36L,36L,120L,20L,120L,88L,336L,6L,36L,36L,120L,36L,216L,120L,528L,20L,120L,120L,400L,88L,528L,336L,1376L,6L,36L,36L,120L,36L,216L,120L,528L,36L,216L,216L,720L,120L,720L,528L,2016L,20L,120L,120L,400L,120L,720L,400L,1760L,88L,528L,528L,1760L,336L,2016L,1376L,5440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246037Inst : IEnumerable<long>
{
public static readonly long[] Value=A246037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246037.Bytes);
public long this[int i]=>Value[i];

public static A246037Inst Instance=new A246037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246038
{
public static readonly long[] Value={ 1L,7L,29L,103L,373L,1407L,5277L,19639L,73157L,272943L,1018157L,3796839L,14159317L,52806751L,196940221L,734469911L,2739138277L,10215390607L,38097452877L,142081224135L,529879903477L,1976142458303L,7369856791005L,27485259393911L,102503957075973L,382279865222383L,1425680525146477L,5316955307198503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246038Inst : IEnumerable<long>
{
public static readonly long[] Value=A246038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246038.Bytes);
public long this[int i]=>Value[i];

public static A246038Inst Instance=new A246038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246039
{
public static readonly long[] Value={ 1L,7L,7L,29L,7L,49L,29L,103L,7L,49L,49L,203L,29L,203L,103L,373L,7L,49L,49L,203L,49L,343L,203L,721L,29L,203L,203L,841L,103L,721L,373L,1407L,7L,49L,49L,203L,49L,343L,203L,721L,49L,343L,343L,1421L,203L,1421L,721L,2611L,29L,203L,203L,841L,203L,1421L,841L,2987L,103L,721L,721L,2987L,373L,2611L,1407L,5277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246039Inst : IEnumerable<long>
{
public static readonly long[] Value=A246039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246039.Bytes);
public long this[int i]=>Value[i];

public static A246039Inst Instance=new A246039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246040
{
public static readonly BigInteger[] Value={ 1L,-1L,5L,-47L,719L,-16299L,513253L,-21430513L,1145710573L,-76317960163L,6197399680779L,-602640663660199L,69134669061681469L,BigInteger.Parse("-9239224408001877873"),BigInteger.Parse("1422887941494773642817"),BigInteger.Parse("-250160794466824215921275"),BigInteger.Parse("49797413478450579190546203"),BigInteger.Parse("-11142367835115998962269070519"),BigInteger.Parse("2784355004138005473128335461749") };
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
public class A246040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246040Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246040.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246040Inst Instance=new A246040Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246041
{
public static readonly long[] Value={ 6L,9L,4L,8L,1L,9L,3L,0L,0L,8L,6L,6L,7L,3L,0L,5L,3L,6L,2L,6L,7L,1L,9L,2L,7L,5L,0L,6L,2L,0L,3L,5L,2L,5L,1L,2L,7L,7L,0L,2L,1L,1L,6L,9L,6L,8L,6L,7L,2L,4L,4L,1L,5L,2L,8L,8L,9L,4L,4L,2L,3L,3L,8L,9L,0L,2L,6L,6L,9L,5L,9L,2L,3L,9L,8L,3L,0L,6L,5L,4L,5L,6L,1L,0L,6L,6L,5L,9L,6L,4L,6L,1L,4L,3L,9L,8L,0L,3L,3L,9L,9L,6L,6L,2L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246041Inst : IEnumerable<long>
{
public static readonly long[] Value=A246041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246041.Bytes);
public long this[int i]=>Value[i];

public static A246041Inst Instance=new A246041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246042
{
public static readonly long[] Value={ 15774L,67880L,101340L,482434L,91710898L,268436480L,877362668L,4832460192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246042Inst : IEnumerable<long>
{
public static readonly long[] Value=A246042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246042.Bytes);
public long this[int i]=>Value[i];

public static A246042Inst Instance=new A246042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246043
{
public static readonly long[] Value={ 13L,17L,31L,37L,71L,73L,79L,97L,107L,118L,119L,124L,125L,127L,128L,133L,139L,142L,146L,152L,164L,169L,170L,172L,181L,182L,191L,193L,196L,214L,215L,217L,218L,238L,239L,241L,251L,271L,277L,281L,283L,293L,313L,319L,328L,329L,331L,346L,347L,349L,356L,364L,365L,367L,368L,374L,376L,382L,386L,391L,392L,394L,412L,416L,421L,436L,437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246043Inst : IEnumerable<long>
{
public static readonly long[] Value=A246043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246043.Bytes);
public long this[int i]=>Value[i];

public static A246043Inst Instance=new A246043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246044
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,19L,23L,29L,41L,43L,47L,53L,59L,61L,67L,83L,89L,101L,103L,109L,151L,211L,223L,227L,229L,233L,257L,263L,269L,307L,353L,383L,401L,409L,431L,433L,443L,449L,487L,499L,503L,509L,523L,541L,557L,599L,601L,607L,661L,677L,773L,809L,827L,829L,853L,859L,881L,883L,887L,929L,997L,1447L,1451L,1481L,2003L,2017L,2029L,2087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246044Inst : IEnumerable<long>
{
public static readonly long[] Value=A246044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246044.Bytes);
public long this[int i]=>Value[i];

public static A246044Inst Instance=new A246044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246045
{
public static readonly long[] Value={ 13L,17L,31L,37L,71L,73L,79L,97L,107L,127L,139L,181L,191L,193L,239L,241L,251L,271L,277L,281L,283L,293L,313L,331L,347L,349L,367L,421L,439L,457L,461L,463L,467L,479L,521L,547L,563L,569L,577L,587L,619L,641L,643L,647L,653L,659L,673L,683L,691L,701L,709L,727L,743L,757L,769L,787L,797L,811L,821L,823L,857L,863L,877L,907L,911L,947L,967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246045Inst : IEnumerable<long>
{
public static readonly long[] Value=A246045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246045.Bytes);
public long this[int i]=>Value[i];

public static A246045Inst Instance=new A246045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246046
{
public static readonly long[] Value={ 2L,3L,5L,6L,8L,9L,11L,12L,13L,15L,16L,18L,19L,21L,22L,24L,25L,27L,28L,30L,31L,33L,34L,35L,37L,38L,40L,41L,43L,44L,46L,47L,49L,50L,52L,53L,55L,56L,57L,59L,60L,62L,63L,65L,66L,68L,69L,71L,72L,74L,75L,77L,78L,79L,81L,82L,84L,85L,87L,88L,90L,91L,93L,94L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246046Inst : IEnumerable<long>
{
public static readonly long[] Value=A246046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246046.Bytes);
public long this[int i]=>Value[i];

public static A246046Inst Instance=new A246046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246047
{
public static readonly long[] Value={ 1L,0L,2L,4L,4L,16L,8L,16L,48L,16L,96L,128L,64L,32L,384L,320L,512L,64L,1280L,256L,768L,2560L,128L,3840L,2560L,1792L,10240L,1024L,256L,10752L,15360L,4096L,35840L,12288L,512L,28672L,71680L,4096L,9216L,114688L,86016L,1024L,73728L,286720L,57344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246047Inst : IEnumerable<long>
{
public static readonly long[] Value=A246047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246047.Bytes);
public long this[int i]=>Value[i];

public static A246047Inst Instance=new A246047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246048
{
public static readonly long[] Value={ 6L,12L,14L,15L,21L,22L,24L,26L,28L,30L,35L,38L,39L,42L,44L,45L,46L,48L,50L,51L,52L,54L,55L,56L,57L,58L,60L,62L,63L,69L,70L,74L,75L,76L,77L,78L,82L,84L,85L,86L,87L,88L,90L,91L,92L,93L,94L,95L,96L,98L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246048Inst : IEnumerable<long>
{
public static readonly long[] Value=A246048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246048.Bytes);
public long this[int i]=>Value[i];

public static A246048Inst Instance=new A246048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246049
{
public static readonly long[] Value={ 1L,0L,1L,0L,3L,1L,0L,19L,6L,2L,0L,175L,51L,24L,6L,0L,2101L,580L,300L,120L,24L,0L,31031L,8265L,4360L,2160L,720L,120L,0L,543607L,141246L,74130L,41160L,17640L,5040L,720L,0L,11012415L,2810437L,1456224L,861420L,430080L,161280L,40320L,5040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246049Inst : IEnumerable<long>
{
public static readonly long[] Value=A246049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246049.Bytes);
public long this[int i]=>Value[i];

public static A246049Inst Instance=new A246049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246050
{
public static readonly BigInteger[] Value={ 1L,3L,51L,4360L,861420L,302472576L,165549605760L,130241382036480L,139296260790086400L,BigInteger.Parse("194427690066299289600"),BigInteger.Parse("343266609438110040883200"),BigInteger.Parse("747889929370001008617062400"),BigInteger.Parse("1971026055567996899374212710400"),BigInteger.Parse("6180432763819774878006029844480000") };
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
public class A246050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246050Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246050.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246050Inst Instance=new A246050Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246051
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,49L,49L,1L,1L,310L,343L,310L,1L,1L,4191L,341L,341L,4191L,1L,1L,1162525L,2669667L,1374230L,2669667L,1162525L,1L,1L,1414477L,46501L,562991L,562991L,46501L,1414477L,1L,1L,13924700L,48092218L,1613300L,117628797L,1613300L,48092218L,13924700L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246051Inst : IEnumerable<long>
{
public static readonly long[] Value=A246051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246051.Bytes);
public long this[int i]=>Value[i];

public static A246051Inst Instance=new A246051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246052
{
public static readonly long[] Value={ 2L,2L,2L,2L,7L,2L,2L,62L,62L,2L,2L,381L,381L,381L,2L,2L,5110L,365L,365L,5110L,2L,2L,1414477L,2828954L,1414477L,2828954L,1414477L,2L,2L,1720110L,49146L,573370L,573370L,49146L,1720110L,2L,2L,16931177L,50793531L,1638501L,118518239L,1638501L,50793531L,16931177L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246052Inst : IEnumerable<long>
{
public static readonly long[] Value=A246052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246052.Bytes);
public long this[int i]=>Value[i];

public static A246052Inst Instance=new A246052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246053
{
public static readonly BigInteger[] Value={ 2L,2L,7L,62L,381L,365L,1414477L,573370L,118518239L,5749691557L,274638832071L,768018339627L,29741482024668555L,860983513348179L,65053034220152267L,BigInteger.Parse("1850237821952082716222"),BigInteger.Parse("16555640865486520478399"),BigInteger.Parse("962703047799452264039"),BigInteger.Parse("29167285342563717499865628061") };
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
public class A246053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246053Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246053.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246053Inst Instance=new A246053Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246054
{
public static readonly BigInteger[] Value={ 2911001L,339L,56346353L,BigInteger.Parse("90028408624696264845"),120193266020529L,BigInteger.Parse("90022305806716382445") };
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
public class A246054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246054Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246054.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246054Inst Instance=new A246054Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246055
{
public static readonly BigInteger[] Value={ 5684610L,662L,110033282L,BigInteger.Parse("175783207694477729162"),234681009773714L,BigInteger.Parse("175771291756643579978") };
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
public class A246055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246055Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246055.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246055Inst Instance=new A246055Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246056
{
public static readonly ulong[] Value={ 1L,3L,16L,99L,681L,4950L,37303L,288399L,2272318L,18167553L,146950227L,1199921310L,9875193549L,81811617237L,681621711306L,5706874227051L,47985527200311L,405002888376840L,3429714479025247L,29130993220171449L,248095567594494634L,2118053534177686959L,18122259456592141785UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246056Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A246056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246056.Bytes);
public ulong this[int i]=>Value[i];

public static A246056Inst Instance=new A246056Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246057
{
public static readonly ulong[] Value={ 1L,16L,166L,1666L,16666L,166666L,1666666L,16666666L,166666666L,1666666666L,16666666666L,166666666666L,1666666666666L,16666666666666L,166666666666666L,1666666666666666L,16666666666666666L,166666666666666666L,1666666666666666666L,16666666666666666666UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246057Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A246057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246057.Bytes);
public ulong this[int i]=>Value[i];

public static A246057Inst Instance=new A246057Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246058
{
public static readonly ulong[] Value={ 1L,17L,177L,1777L,17777L,177777L,1777777L,17777777L,177777777L,1777777777L,17777777777L,177777777777L,1777777777777L,17777777777777L,177777777777777L,1777777777777777L,17777777777777777L,177777777777777777L,1777777777777777777L,17777777777777777777UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246058Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A246058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246058.Bytes);
public ulong this[int i]=>Value[i];

public static A246058Inst Instance=new A246058Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246059
{
public static readonly BigInteger[] Value={ 1L,18L,188L,1888L,18888L,188888L,1888888L,18888888L,188888888L,1888888888L,18888888888L,188888888888L,1888888888888L,18888888888888L,188888888888888L,1888888888888888L,18888888888888888L,188888888888888888L,1888888888888888888L,BigInteger.Parse("18888888888888888888") };
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
public class A246059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246059Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246059.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246059Inst Instance=new A246059Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246060
{
public static readonly long[] Value={ 1L,1L,1L,5L,4L,5L,4L,7L,2L,8L,3L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246060Inst : IEnumerable<long>
{
public static readonly long[] Value=A246060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246060.Bytes);
public long this[int i]=>Value[i];

public static A246060Inst Instance=new A246060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246061
{
public static readonly long[] Value={ 1L,2L,0L,1L,3L,0L,3L,5L,5L,9L,9L,6L,7L,3L,6L,2L,2L,4L,1L,2L,4L,7L,5L,5L,5L,9L,5L,9L,2L,0L,7L,3L,8L,3L,4L,8L,2L,4L,5L,3L,8L,3L,8L,4L,4L,9L,4L,2L,7L,1L,1L,3L,0L,8L,5L,1L,8L,1L,9L,5L,5L,9L,7L,4L,1L,4L,8L,0L,0L,9L,9L,7L,7L,9L,4L,3L,7L,7L,5L,2L,2L,5L,9L,6L,7L,0L,6L,4L,3L,1L,8L,4L,8L,6L,1L,9L,7L,6L,0L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246061Inst : IEnumerable<long>
{
public static readonly long[] Value=A246061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246061.Bytes);
public long this[int i]=>Value[i];

public static A246061Inst Instance=new A246061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246062
{
public static readonly long[] Value={ 1L,2L,2L,28L,54L,860L,2004L,33720L,86054L,1492908L,4019452L,71101832L,198310460L,3555617432L,10168382696L,184127171952L,536496907782L,9788598556876L,28937139277804L,531135371147368L,1588378827366868L,29295861148032584L,88439788292856856L,1637711104368641552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246062Inst : IEnumerable<long>
{
public static readonly long[] Value=A246062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246062.Bytes);
public long this[int i]=>Value[i];

public static A246062Inst Instance=new A246062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246063
{
public static readonly long[] Value={ 2L,1L,3L,9L,15L,64L,45L,256L,96L,144L,192L,4096L,240L,16384L,768L,576L,480L,262144L,720L,1048576L,960L,2304L,12288L,16777216L,1440L,5184L,49152L,3600L,3840L,1073741824L,2880L,4294967296L,3360L,36864L,786432L,20736L,5040L,274877906944L,3145728L,147456L,6720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246063Inst : IEnumerable<long>
{
public static readonly long[] Value=A246063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246063.Bytes);
public long this[int i]=>Value[i];

public static A246063Inst Instance=new A246063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246064
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,1L,1L,3L,4L,1L,1L,2L,1L,1L,4L,5L,1L,1L,1L,1L,2L,1L,1L,1L,1L,5L,6L,1L,1L,1L,2L,1L,3L,1L,2L,1L,1L,1L,6L,7L,1L,1L,1L,1L,1L,2L,1L,1L,3L,1L,1L,2L,1L,1L,1L,1L,1L,7L,8L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,4L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246064Inst : IEnumerable<long>
{
public static readonly long[] Value=A246064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246064.Bytes);
public long this[int i]=>Value[i];

public static A246064Inst Instance=new A246064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246065
{
public static readonly long[] Value={ -1L,1L,9L,39L,177L,927L,5463L,34857L,234657L,1641471L,11820135L,87080265L,653499135L,4979882385L,38441107305L,300027646647L,2364113123073L,18784242756927L,150351698420247L,1211310469545081L,9816017765368671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246065Inst : IEnumerable<long>
{
public static readonly long[] Value=A246065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246065.Bytes);
public long this[int i]=>Value[i];

public static A246065Inst Instance=new A246065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246066
{
public static readonly long[] Value={ 4L,4L,8L,8L,8L,8L,16L,16L,16L,16L,16L,16L,16L,16L,25L,25L,25L,25L,25L,25L,27L,27L,27L,27L,32L,32L,32L,32L,32L,32L,49L,49L,49L,49L,49L,49L,49L,49L,49L,49L,49L,49L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,81L,81L,81L,81L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246066Inst : IEnumerable<long>
{
public static readonly long[] Value=A246066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246066.Bytes);
public long this[int i]=>Value[i];

public static A246066Inst Instance=new A246066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246067
{
public static readonly long[] Value={ 4L,8L,16L,25L,27L,32L,49L,64L,81L,121L,125L,128L,169L,243L,256L,289L,343L,361L,512L,625L,729L,841L,961L,1024L,1331L,1369L,1681L,1849L,2048L,2187L,2401L,2809L,3125L,3481L,3721L,4096L,4489L,4913L,5041L,5329L,6241L,6561L,6859L,7921L,8192L,9409L,10201L,10609L,11449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246067Inst : IEnumerable<long>
{
public static readonly long[] Value=A246067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246067.Bytes);
public long this[int i]=>Value[i];

public static A246067Inst Instance=new A246067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246068
{
public static readonly long[] Value={ 0L,2L,6L,14L,20L,24L,30L,42L,62L,78L,110L,120L,126L,156L,240L,254L,272L,336L,342L,510L,620L,726L,812L,930L,1022L,1320L,1332L,1640L,1806L,2046L,2184L,2394L,2756L,3120L,3422L,3660L,4094L,4422L,4896L,4970L,5256L,6162L,6558L,6840L,7832L,8190L,9312L,10100L,10506L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246068Inst : IEnumerable<long>
{
public static readonly long[] Value=A246068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246068.Bytes);
public long this[int i]=>Value[i];

public static A246068Inst Instance=new A246068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246069
{
public static readonly BigInteger[] Value={ 0L,1L,1L,3L,6L,35L,120L,105L,1120L,19089L,362880L,133595L,39916800L,148397535L,458313856L,2027025L,1307674368000L,6133352225L,355687428096000L,40549021532019L,4139906028544000L,464463124401214575L,BigInteger.Parse("51090942171709440000"),1173011341727225L };
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
public class A246069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246069Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246069.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246069Inst Instance=new A246069Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246070
{
public static readonly BigInteger[] Value={ 1L,1L,4L,1L,2L,256L,1L,3L,16L,46656L,1L,2L,50L,216L,16777216L,1L,3L,36L,1626L,4096L,10000000000L,1L,2L,56L,1440L,83736L,100000L,8916100448256L,1L,3L,16L,2688L,84624L,6026120L,2985984L,11112006825558016L,1L,2L,70L,720L,215760L,7675200L,571350096L,105413504L,BigInteger.Parse("18446744073709551616") };
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
public class A246070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246070Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246070.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246070Inst Instance=new A246070Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246071
{
public static readonly BigInteger[] Value={ 1L,2L,50L,1440L,215760L,11218000L,8859219696L,549669946784L,797599992178688L,195297824029876992L,BigInteger.Parse("225830701916170080000"),BigInteger.Parse("33538442785393084937728"),BigInteger.Parse("478648537323384927696592896"),BigInteger.Parse("26649057768458576467019134976"),BigInteger.Parse("207869233649005397144301933676544") };
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
public class A246071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246071Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246071.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246071Inst Instance=new A246071Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246072
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,24L,1L,2L,2L,720L,1L,1L,10L,6L,40320L,1L,2L,10L,84L,24L,3628800L,1L,1L,16L,108L,1032L,120L,479001600L,1L,2L,2L,264L,1800L,17040L,720L,87178291200L,1L,1L,18L,150L,6672L,47520L,359280L,5040L,20922789888000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246072Inst : IEnumerable<long>
{
public static readonly long[] Value=A246072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246072.Bytes);
public long this[int i]=>Value[i];

public static A246072Inst Instance=new A246072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246073
{
public static readonly BigInteger[] Value={ 1L,1L,10L,108L,6672L,109200L,45007920L,983324160L,665546434560L,60174422501760L,32648180513760000L,4656975300322329600L,BigInteger.Parse("13859947861644771532800"),BigInteger.Parse("1193599114668580293273600"),BigInteger.Parse("1257285172911535450293811200"),BigInteger.Parse("766119340152013216053484800000") };
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
public class A246073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246073Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A246073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246073.Bytes);
public BigInteger this[int i]=>Value[i];

public static A246073Inst Instance=new A246073Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246074
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,14L,16L,18L,20L,22L,24L,28L,32L,36L,40L,44L,48L,56L,64L,72L,80L,88L,96L,112L,128L,144L,160L,176L,192L,224L,256L,288L,320L,352L,384L,448L,512L,576L,640L,704L,768L,896L,1024L,1152L,1280L,1408L,1536L,1792L,2048L,2304L,2560L,2816L,3072L,3584L,4096L,4608L,5120L,5632L,6144L,7168L,8192L,9216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246074Inst : IEnumerable<long>
{
public static readonly long[] Value=A246074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246074.Bytes);
public long this[int i]=>Value[i];

public static A246074Inst Instance=new A246074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246075
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,16L,18L,20L,22L,24L,26L,28L,32L,36L,40L,44L,48L,52L,56L,64L,72L,80L,88L,96L,104L,112L,128L,144L,160L,176L,192L,208L,224L,256L,288L,320L,352L,384L,416L,448L,512L,576L,640L,704L,768L,832L,896L,1024L,1152L,1280L,1408L,1536L,1664L,1792L,2048L,2304L,2560L,2816L,3072L,3328L,3584L,4096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246075Inst : IEnumerable<long>
{
public static readonly long[] Value=A246075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246075.Bytes);
public long this[int i]=>Value[i];

public static A246075Inst Instance=new A246075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246076
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,18L,20L,22L,24L,26L,28L,30L,33L,36L,40L,44L,48L,52L,56L,60L,66L,72L,80L,88L,96L,104L,112L,120L,132L,144L,160L,176L,192L,208L,224L,240L,264L,288L,320L,352L,384L,416L,448L,480L,528L,576L,640L,704L,768L,832L,896L,960L,1056L,1152L,1280L,1408L,1536L,1664L,1792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246076Inst : IEnumerable<long>
{
public static readonly long[] Value=A246076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246076.Bytes);
public long this[int i]=>Value[i];

public static A246076Inst Instance=new A246076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246077
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,14L,16L,18L,21L,24L,28L,32L,36L,42L,48L,56L,64L,72L,84L,96L,112L,128L,144L,168L,192L,224L,256L,288L,336L,384L,448L,512L,576L,672L,768L,896L,1024L,1152L,1344L,1536L,1792L,2048L,2304L,2688L,3072L,3584L,4096L,4608L,5376L,6144L,7168L,8192L,9216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246077Inst : IEnumerable<long>
{
public static readonly long[] Value=A246077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246077.Bytes);
public long this[int i]=>Value[i];

public static A246077Inst Instance=new A246077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246078
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,16L,18L,20L,22L,24L,27L,30L,33L,36L,40L,44L,48L,54L,60L,66L,72L,81L,90L,99L,108L,120L,132L,144L,162L,180L,198L,216L,243L,270L,297L,324L,360L,396L,432L,486L,540L,594L,648L,729L,810L,891L,972L,1080L,1188L,1296L,1458L,1620L,1782L,1944L,2187L,2430L,2673L,2916L,3240L,3564L,3888L,4374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246078Inst : IEnumerable<long>
{
public static readonly long[] Value=A246078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246078.Bytes);
public long this[int i]=>Value[i];

public static A246078Inst Instance=new A246078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246079
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,20L,22L,24L,26L,28L,30L,33L,36L,39L,42L,45L,48L,52L,56L,60L,66L,72L,78L,84L,90L,99L,108L,117L,126L,135L,144L,156L,168L,180L,198L,216L,234L,252L,270L,297L,324L,351L,378L,405L,432L,468L,504L,540L,594L,648L,702L,756L,810L,891L,972L,1053L,1134L,1215L,1296L,1404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246079Inst : IEnumerable<long>
{
public static readonly long[] Value=A246079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246079.Bytes);
public long this[int i]=>Value[i];

public static A246079Inst Instance=new A246079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246080
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,10L,12L,15L,18L,21L,24L,30L,36L,45L,54L,63L,72L,90L,108L,135L,162L,189L,216L,270L,324L,405L,486L,567L,648L,810L,972L,1215L,1458L,1701L,1944L,2430L,2916L,3645L,4374L,5103L,5832L,7290L,8748L,10935L,13122L,15309L,17496L,21870L,26244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246080Inst : IEnumerable<long>
{
public static readonly long[] Value=A246080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246080.Bytes);
public long this[int i]=>Value[i];

public static A246080Inst Instance=new A246080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A246081
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,14L,16L,18L,21L,24L,27L,30L,33L,36L,42L,48L,54L,63L,72L,81L,90L,99L,108L,126L,144L,162L,189L,216L,243L,270L,297L,324L,378L,432L,486L,567L,648L,729L,810L,891L,972L,1134L,1296L,1458L,1701L,1944L,2187L,2430L,2673L,2916L,3402L,3888L,4374L,5103L,5832L,6561L,7290L,8019L,8748L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A246081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A246081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A246081Inst : IEnumerable<long>
{
public static readonly long[] Value=A246081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A246081.Bytes);
public long this[int i]=>Value[i];

public static A246081Inst Instance=new A246081Inst();

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