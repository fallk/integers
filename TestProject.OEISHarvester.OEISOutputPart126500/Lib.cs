using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A155805
{
public static readonly BigInteger[] Value={ 1L,1L,3L,19L,191L,2656L,47392L,1034335L,26721781L,798018616L,27058991246L,1027237384009L,43172232488959L,1990253576425960L,99871804451808040L,5419775866582473211L,BigInteger.Parse("316301430225674131433"),BigInteger.Parse("19756213549154356027408") };
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
public class A155805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155805Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155805.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155805Inst Instance=new A155805Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155806
{
public static readonly BigInteger[] Value={ 1L,1L,3L,22L,269L,4616L,102847L,2824816L,92355769L,3506278528L,151720849691L,7375146930944L,398113181435653L,23640909385071616L,1532325553233566743L,BigInteger.Parse("107698939845869111296"),BigInteger.Parse("8162300091585206125553"),BigInteger.Parse("663836705760309127184384") };
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
public class A155806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155806Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155806.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155806Inst Instance=new A155806Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155807
{
public static readonly BigInteger[] Value={ 1L,1L,5L,55L,969L,23661L,741013L,28363707L,1284098609L,67149601273L,3984121444581L,264485848799679L,19426332734137849L,1564277403496216293L,BigInteger.Parse("137040382838351173301"),BigInteger.Parse("12977244383702330201731") };
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
public class A155807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155807Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155807.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155807Inst Instance=new A155807Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155808
{
public static readonly long[] Value={ 2L,8L,5L,4L,0L,4L,9L,8L,3L,0L,2L,0L,0L,2L,7L,1L,1L,0L,7L,4L,0L,3L,6L,3L,1L,7L,6L,4L,9L,4L,9L,2L,0L,7L,8L,8L,2L,7L,6L,3L,1L,8L,1L,6L,3L,7L,0L,5L,0L,4L,8L,9L,7L,6L,7L,1L,7L,3L,5L,1L,1L,7L,6L,7L,6L,5L,4L,7L,8L,5L,1L,4L,5L,4L,9L,9L,4L,8L,3L,4L,0L,1L,5L,3L,2L,4L,3L,2L,9L,1L,5L,4L,3L,2L,1L,8L,0L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155808Inst : IEnumerable<long>
{
public static readonly long[] Value=A155808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155808.Bytes);
public long this[int i]=>Value[i];

public static A155808Inst Instance=new A155808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155809
{
public static readonly long[] Value={ 0L,1953L,2310L,2583L,2688L,2730L,4095L,6510L,6993L,7245L,8967L,9870L,9975L,10332L,11613L,12327L,14868L,15057L,15603L,16758L,16800L,17052L,17157L,20160L,20643L,22008L,22533L,23058L,23877L,24150L,29925L,31122L,31710L,32655L,33432L,34020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155809Inst : IEnumerable<long>
{
public static readonly long[] Value=A155809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155809.Bytes);
public long this[int i]=>Value[i];

public static A155809Inst Instance=new A155809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155810
{
public static readonly BigInteger[] Value={ 1L,2L,1L,10L,6L,1L,188L,82L,14L,1L,16774L,4452L,490L,30L,1L,6745436L,1074934L,71108L,2602L,62L,1L,11466849412L,1082704500L,43173414L,951300L,13002L,126L,1L,80444398636280L,4411700155252L,104251164804L,1387446246L,11470404L,62538L,254L,1L,2306003967992402758L,72146891831948808L,989785148972932L,7803708940836L,38993810694L,129076164L,292810L,510L,1L,BigInteger.Parse("268654794629082985019564"),BigInteger.Parse("4724816968764733073446"),BigInteger.Parse("36967624172237518088"),169140002768370820L,500466007443108L,1001353593606L,1382564804L,1343434L,1022L,1L };
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
public class A155810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155810Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155810.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155810Inst Instance=new A155810Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155811
{
public static readonly BigInteger[] Value={ 1L,6L,82L,4452L,1074934L,1082704500L,4411700155252L,72146891831948808L,BigInteger.Parse("4724816968764733073446"),BigInteger.Parse("1238218148763614236043117508"),BigInteger.Parse("1298203457233136135837147642852956") };
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
public class A155811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155811Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155811.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155811Inst Instance=new A155811Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155812
{
public static readonly BigInteger[] Value={ 1L,3L,1L,45L,12L,1L,6687L,801L,39L,1L,10782369L,540720L,10764L,120L,1L,169490304819L,3499254081L,29275956L,129348L,363L,1L,25016281429306077L,206071208583660L,709664882337L,1321144632L,1459773L,1092L,1L,BigInteger.Parse("34185693516532070487615") };
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
public class A155812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155812Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155812.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155812Inst Instance=new A155812Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155813
{
public static readonly BigInteger[] Value={ 1L,12L,801L,540720L,3499254081L,206071208583660L,BigInteger.Parse("109444624780070083617"),BigInteger.Parse("523382147212408702381556928"),BigInteger.Parse("22528830325874782877760713232652641"),BigInteger.Parse("8728012905287889947187989190298586968026540") };
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
public class A155813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155813Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155813.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155813Inst Instance=new A155813Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155814
{
public static readonly long[] Value={ 79L,127L,203L,234L,243L,255L,324L,325L,326L,350L,361L,402L,406L,416L,430L,445L,447L,471L,490L,509L,513L,527L,531L,539L,548L,553L,561L,564L,572L,602L,604L,627L,630L,631L,633L,640L,653L,654L,656L,694L,695L,703L,704L,715L,720L,735L,783L,790L,791L,812L,813L,818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155814Inst : IEnumerable<long>
{
public static readonly long[] Value=A155814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155814.Bytes);
public long this[int i]=>Value[i];

public static A155814Inst Instance=new A155814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155815
{
public static readonly long[] Value={ 23L,97L,269L,587L,1123L,1973L,3257L,5119L,7727L,11273L,15973L,22067L,29819L,51473L,104369L,191123L,229637L,687787L,897473L,1018807L,1152119L,1631723L,2026069L,2488223L,2747023L,3025577L,3989723L,5614247L,7125947L,7692019L,8291237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155815Inst : IEnumerable<long>
{
public static readonly long[] Value=A155815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155815.Bytes);
public long this[int i]=>Value[i];

public static A155815Inst Instance=new A155815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155816
{
public static readonly long[] Value={ 7L,5L,3L,2L,1L,1L,8L,6L,4L,3L,2L,1L,1L,7L,5L,3L,2L,1L,1L,9L,6L,4L,3L,2L,1L,1L,8L,6L,4L,3L,2L,1L,1L,7L,5L,3L,2L,1L,1L,9L,6L,4L,3L,2L,1L,1L,8L,5L,4L,2L,2L,1L,1L,7L,5L,3L,2L,1L,1L,9L,6L,4L,3L,2L,1L,1L,8L,5L,4L,2L,2L,1L,1L,7L,5L,3L,2L,1L,1L,9L,6L,4L,3L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155816Inst : IEnumerable<long>
{
public static readonly long[] Value=A155816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155816.Bytes);
public long this[int i]=>Value[i];

public static A155816Inst Instance=new A155816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155817
{
public static readonly BigInteger[] Value={ 1L,10L,2L,4L,100L,101L,11L,12L,13L,14L,30L,1000L,10000L,40L,41L,100000L,102L,43L,60L,110L,1000000L,1001L,61L,80L,111L,100000000000L,90L,10000000L,103L,104L,10001L,1110L,112L,201L,108L,91L,95L,160L,161L,BigInteger.Parse("100000000000000000000000000000000000"),170L,1000001L };
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
public class A155817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155817Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155817.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155817Inst Instance=new A155817Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155818
{
public static readonly long[] Value={ 2L,2L,6L,1L,7L,8L,0L,9L,7L,8L,0L,2L,8L,5L,0L,6L,4L,3L,6L,1L,4L,7L,0L,7L,4L,1L,2L,2L,0L,8L,1L,3L,3L,4L,4L,2L,2L,2L,4L,9L,4L,1L,2L,5L,6L,2L,7L,2L,1L,2L,7L,7L,5L,2L,9L,7L,4L,7L,2L,2L,1L,8L,6L,6L,0L,0L,7L,3L,8L,9L,0L,7L,2L,7L,8L,1L,3L,8L,2L,3L,4L,8L,0L,5L,5L,3L,7L,7L,2L,6L,2L,9L,3L,1L,0L,4L,4L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155818Inst : IEnumerable<long>
{
public static readonly long[] Value=A155818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155818.Bytes);
public long this[int i]=>Value[i];

public static A155818Inst Instance=new A155818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155819
{
public static readonly long[] Value={ 14L,32L,60L,136L,192L,316L,396L,568L,888L,1020L,1432L,1756L,1932L,2296L,2904L,3588L,3840L,4612L,5176L,5472L,6388L,7048L,8088L,9588L,10396L,10812L,11656L,12096L,12988L,16356L,17416L,19032L,19596L,22480L,23100L,24952L,26884L,28216L,30264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155819Inst : IEnumerable<long>
{
public static readonly long[] Value=A155819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155819.Bytes);
public long this[int i]=>Value[i];

public static A155819Inst Instance=new A155819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155820
{
public static readonly long[] Value={ 13L,31L,59L,191L,887L,1019L,1931L,2903L,5471L,8087L,9587L,19031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155820Inst : IEnumerable<long>
{
public static readonly long[] Value=A155820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155820.Bytes);
public long this[int i]=>Value[i];

public static A155820Inst Instance=new A155820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155821
{
public static readonly long[] Value={ 1L,9L,4L,8L,1L,9L,2L,0L,9L,3L,4L,6L,6L,3L,7L,9L,5L,6L,7L,4L,5L,1L,5L,9L,6L,0L,5L,8L,8L,8L,9L,2L,2L,7L,4L,2L,3L,9L,8L,4L,6L,4L,8L,3L,6L,4L,8L,9L,6L,3L,8L,8L,0L,0L,8L,1L,3L,9L,6L,5L,3L,0L,1L,2L,3L,0L,3L,0L,6L,3L,3L,5L,7L,5L,3L,0L,4L,9L,4L,5L,7L,7L,4L,0L,2L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155821Inst : IEnumerable<long>
{
public static readonly long[] Value=A155821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155821.Bytes);
public long this[int i]=>Value[i];

public static A155821Inst Instance=new A155821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155822
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,4L,8L,9L,12L,21L,27L,37L,58L,78L,109L,164L,227L,319L,467L,656L,928L,1341L,1896L,2689L,3859L,5477L,7782L,11126L,15817L,22496L,32103L,45679L,65003L,92668L,131912L,187777L,267556L,380941L,542363L,772581L,1100098L,1566414L,2230997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155822Inst : IEnumerable<long>
{
public static readonly long[] Value=A155822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155822.Bytes);
public long this[int i]=>Value[i];

public static A155822Inst Instance=new A155822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155823
{
public static readonly long[] Value={ 1L,7L,4L,9L,9L,5L,2L,6L,4L,1L,4L,0L,0L,0L,2L,9L,4L,8L,1L,1L,6L,1L,6L,1L,0L,2L,0L,7L,7L,9L,7L,2L,9L,2L,6L,7L,3L,7L,6L,8L,0L,7L,7L,5L,9L,7L,7L,1L,2L,8L,6L,0L,4L,8L,5L,0L,8L,3L,2L,7L,0L,2L,0L,9L,0L,5L,9L,2L,4L,3L,9L,6L,5L,1L,3L,7L,2L,3L,5L,4L,1L,8L,7L,0L,9L,9L,5L,5L,3L,0L,4L,8L,4L,7L,0L,1L,4L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155823Inst : IEnumerable<long>
{
public static readonly long[] Value=A155823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155823.Bytes);
public long this[int i]=>Value[i];

public static A155823Inst Instance=new A155823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155824
{
public static readonly long[] Value={ 1L,6L,1L,1L,3L,2L,5L,2L,8L,0L,0L,7L,5L,9L,3L,1L,1L,7L,4L,9L,5L,2L,6L,9L,5L,5L,6L,1L,8L,6L,2L,5L,9L,4L,5L,1L,4L,2L,3L,1L,6L,0L,1L,2L,8L,4L,3L,9L,9L,0L,1L,9L,4L,2L,0L,9L,8L,4L,8L,0L,2L,5L,8L,4L,7L,2L,4L,1L,1L,6L,1L,7L,1L,8L,2L,1L,5L,1L,6L,4L,9L,3L,1L,2L,0L,8L,6L,1L,3L,3L,3L,4L,0L,9L,0L,3L,1L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155824Inst : IEnumerable<long>
{
public static readonly long[] Value=A155824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155824.Bytes);
public long this[int i]=>Value[i];

public static A155824Inst Instance=new A155824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155825
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,12L,12L,0L,0L,216L,484L,216L,0L,0L,5760L,21000L,21000L,5760L,0L,0L,216000L,1117920L,1822500L,1117920L,216000L,0L,0L,10886400L,74088000L,171884160L,171884160L,74088000L,10886400L,0L,0L,711244800L,6059370240L,18531878400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155825Inst : IEnumerable<long>
{
public static readonly long[] Value=A155825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155825.Bytes);
public long this[int i]=>Value[i];

public static A155825Inst Instance=new A155825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155826
{
public static readonly long[] Value={ 1L,1L,1L,4L,1L,1L,15L,15L,1L,1L,76L,249L,76L,1L,1L,485L,3516L,3516L,485L,1L,1L,3606L,46623L,101354L,46623L,3606L,1L,1L,30247L,617541L,2388107L,2388107L,617541L,30247L,1L,1L,282248L,8416315L,51483931L,91651662L,51483931L,8416315L,282248L,1L,1L,2903049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155826Inst : IEnumerable<long>
{
public static readonly long[] Value=A155826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155826.Bytes);
public long this[int i]=>Value[i];

public static A155826Inst Instance=new A155826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155827
{
public static readonly long[] Value={ 1L,5L,0L,7L,8L,5L,3L,9L,8L,5L,3L,5L,2L,3L,3L,7L,6L,2L,4L,0L,9L,8L,0L,4L,9L,4L,1L,4L,7L,2L,0L,8L,8L,9L,6L,1L,4L,8L,3L,2L,9L,4L,1L,7L,0L,8L,4L,8L,0L,8L,5L,1L,6L,8L,6L,4L,9L,8L,1L,4L,7L,9L,1L,0L,6L,7L,1L,5L,9L,2L,7L,1L,5L,1L,8L,7L,5L,8L,8L,2L,3L,2L,0L,3L,6L,9L,1L,8L,1L,7L,5L,2L,8L,7L,3L,6L,2L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155827Inst : IEnumerable<long>
{
public static readonly long[] Value=A155827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155827.Bytes);
public long this[int i]=>Value[i];

public static A155827Inst Instance=new A155827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155828
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,3L,3L,1L,1L,1L,3L,3L,1L,1L,7L,1L,1L,1L,3L,1L,3L,1L,3L,3L,1L,3L,3L,1L,1L,3L,7L,1L,3L,1L,3L,3L,1L,1L,7L,1L,1L,3L,3L,1L,1L,3L,7L,3L,1L,1L,7L,1L,1L,3L,3L,3L,3L,1L,3L,3L,3L,1L,7L,1L,1L,3L,3L,3L,3L,1L,7L,1L,1L,1L,7L,3L,1L,3L,7L,1L,3L,3L,3L,3L,1L,3L,7L,1L,1L,3L,3L,1L,3L,1L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155828Inst : IEnumerable<long>
{
public static readonly long[] Value=A155828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155828.Bytes);
public long this[int i]=>Value[i];

public static A155828Inst Instance=new A155828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155829
{
public static readonly long[] Value={ 1L,4L,2L,7L,0L,2L,4L,9L,1L,5L,1L,0L,0L,1L,3L,5L,5L,5L,3L,7L,0L,1L,8L,1L,5L,8L,8L,2L,4L,7L,4L,6L,0L,3L,9L,4L,1L,3L,8L,1L,5L,9L,0L,8L,1L,8L,5L,2L,5L,2L,4L,4L,8L,8L,3L,5L,8L,6L,7L,5L,5L,8L,8L,3L,8L,2L,7L,3L,9L,2L,5L,7L,2L,7L,4L,9L,7L,4L,1L,7L,0L,0L,7L,6L,6L,2L,1L,6L,4L,5L,7L,7L,1L,6L,0L,9L,0L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155829Inst : IEnumerable<long>
{
public static readonly long[] Value=A155829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155829.Bytes);
public long this[int i]=>Value[i];

public static A155829Inst Instance=new A155829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155830
{
public static readonly long[] Value={ 1L,3L,6L,1L,7L,2L,7L,8L,3L,6L,0L,1L,7L,5L,9L,2L,8L,7L,8L,8L,6L,7L,7L,7L,7L,1L,1L,2L,2L,5L,1L,1L,8L,9L,5L,4L,9L,6L,9L,7L,5L,1L,1L,0L,3L,4L,3L,3L,6L,0L,9L,6L,1L,8L,8L,2L,7L,5L,6L,0L,5L,4L,8L,6L,6L,1L,4L,6L,8L,8L,6L,3L,6L,3L,9L,6L,8L,0L,6L,4L,7L,2L,6L,7L,3L,5L,8L,4L,1L,9L,0L,8L,2L,7L,2L,1L,4L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155830Inst : IEnumerable<long>
{
public static readonly long[] Value=A155830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155830.Bytes);
public long this[int i]=>Value[i];

public static A155830Inst Instance=new A155830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155831
{
public static readonly long[] Value={ 1L,3L,0L,7L,6L,0L,2L,6L,5L,1L,1L,6L,5L,8L,2L,5L,4L,9L,8L,4L,7L,8L,5L,0L,6L,0L,7L,3L,6L,4L,2L,6L,2L,7L,3L,6L,2L,1L,7L,7L,2L,9L,3L,7L,7L,3L,6L,1L,2L,0L,7L,4L,7L,3L,1L,3L,9L,9L,1L,7L,6L,4L,6L,7L,8L,5L,1L,2L,1L,6L,2L,5L,7L,0L,3L,7L,0L,3L,4L,5L,4L,5L,0L,7L,7L,2L,3L,6L,8L,1L,3L,0L,6L,3L,7L,5L,1L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155831Inst : IEnumerable<long>
{
public static readonly long[] Value=A155831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155831.Bytes);
public long this[int i]=>Value[i];

public static A155831Inst Instance=new A155831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155832
{
public static readonly long[] Value={ 1L,2L,6L,1L,8L,1L,5L,6L,9L,6L,8L,5L,7L,9L,2L,9L,9L,4L,5L,6L,1L,3L,0L,1L,4L,0L,4L,4L,9L,9L,2L,0L,3L,3L,9L,8L,3L,2L,6L,4L,3L,4L,2L,5L,8L,7L,5L,0L,1L,4L,9L,9L,3L,1L,3L,9L,8L,6L,4L,2L,7L,6L,8L,2L,9L,3L,4L,3L,9L,2L,7L,3L,7L,0L,6L,1L,9L,3L,1L,5L,4L,6L,3L,8L,7L,2L,5L,0L,4L,2L,8L,0L,6L,3L,7L,3L,2L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155832Inst : IEnumerable<long>
{
public static readonly long[] Value=A155832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155832.Bytes);
public long this[int i]=>Value[i];

public static A155832Inst Instance=new A155832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155833
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,31L,41L,43L,53L,61L,71L,73L,83L,97L,131L,151L,181L,191L,211L,241L,251L,271L,281L,311L,331L,353L,373L,383L,421L,431L,433L,443L,461L,463L,491L,521L,541L,563L,571L,593L,631L,641L,643L,653L,661L,673L,683L,691L,733L,743L,751L,761L,773L,787L,797L,811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155833Inst : IEnumerable<long>
{
public static readonly long[] Value=A155833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155833.Bytes);
public long this[int i]=>Value[i];

public static A155833Inst Instance=new A155833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155834
{
public static readonly long[] Value={ 1L,1L,6L,16L,6L,22L,127L,127L,22L,64L,701L,1436L,701L,64L,163L,3117L,11503L,11503L,3117L,163L,382L,12088L,74122L,131494L,74122L,12088L,382L,848L,42890L,413612L,1193930L,1193930L,413612L,42890L,848L,1816L,143562L,2094588L,9280734L,14992440L,9280734L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155834Inst : IEnumerable<long>
{
public static readonly long[] Value=A155834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155834.Bytes);
public long this[int i]=>Value[i];

public static A155834Inst Instance=new A155834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155835
{
public static readonly long[] Value={ 4L,3L,3L,7L,8L,7L,6L,10L,10L,6L,15L,23L,28L,23L,15L,8L,20L,31L,31L,20L,8L,21L,43L,74L,90L,74L,43L,21L,10L,28L,61L,93L,93L,61L,28L,10L,27L,59L,132L,228L,276L,228L,132L,59L,27L,12L,36L,91L,187L,269L,269L,187L,91L,36L,12L,33L,75L,186L,410L,684L,814L,684L,410L,186L,75L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155835Inst : IEnumerable<long>
{
public static readonly long[] Value=A155835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155835.Bytes);
public long this[int i]=>Value[i];

public static A155835Inst Instance=new A155835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155836
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,4L,4L,0L,4L,6L,3L,4L,9L,2L,1L,0L,1L,16L,4L,16L,4L,16L,3L,16L,21L,16L,13L,16L,16L,16L,8L,0L,4L,18L,11L,16L,33L,16L,22L,16L,37L,16L,4L,20L,31L,6L,21L,16L,4L,16L,1L,16L,42L,52L,36L,16L,28L,54L,20L,16L,57L,16L,4L,0L,61L,16L,21L,52L,64L,16L,12L,16L,4L,16L,31L,24L,4L,16L,73L,16L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155836Inst : IEnumerable<long>
{
public static readonly long[] Value=A155836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155836.Bytes);
public long this[int i]=>Value[i];

public static A155836Inst Instance=new A155836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155837
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,3L,9L,0L,3L,4L,4L,4L,2L,4L,8L,3L,6L,0L,2L,1L,5L,3L,1L,6L,0L,2L,6L,3L,7L,0L,8L,4L,7L,2L,5L,5L,6L,5L,0L,9L,5L,4L,9L,1L,6L,1L,3L,9L,2L,0L,8L,7L,7L,6L,5L,0L,1L,1L,0L,3L,9L,4L,2L,6L,0L,3L,0L,0L,1L,9L,1L,9L,9L,7L,8L,2L,6L,0L,3L,9L,8L,5L,9L,5L,1L,3L,4L,5L,7L,8L,9L,2L,8L,1L,1L,6L,1L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155837Inst : IEnumerable<long>
{
public static readonly long[] Value=A155837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155837.Bytes);
public long this[int i]=>Value[i];

public static A155837Inst Instance=new A155837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155838
{
public static readonly long[] Value={ 2L,5L,13L,61681L,1235573L,27544452149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155838Inst : IEnumerable<long>
{
public static readonly long[] Value=A155838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155838.Bytes);
public long this[int i]=>Value[i];

public static A155838Inst Instance=new A155838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155839
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,2L,3L,0L,1L,0L,4L,7L,6L,0L,1L,0L,8L,18L,16L,10L,0L,1L,0L,16L,45L,51L,30L,15L,0L,1L,0L,32L,110L,152L,115L,50L,21L,0L,1L,0L,64L,264L,436L,396L,225L,77L,28L,0L,1L,0L,128L,624L,1212L,1300L,876L,399L,112L,36L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155839Inst : IEnumerable<long>
{
public static readonly long[] Value=A155839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155839.Bytes);
public long this[int i]=>Value[i];

public static A155839Inst Instance=new A155839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155840
{
public static readonly long[] Value={ 1L,1L,8L,8L,1L,1L,1L,4L,4L,4L,4L,7L,0L,3L,1L,2L,1L,8L,3L,0L,4L,5L,2L,3L,6L,7L,3L,1L,6L,5L,9L,5L,7L,0L,5L,8L,6L,9L,7L,4L,4L,1L,9L,1L,9L,2L,1L,8L,4L,0L,8L,8L,1L,4L,6L,7L,8L,5L,1L,6L,3L,4L,5L,8L,9L,3L,2L,4L,0L,0L,6L,0L,1L,9L,8L,6L,8L,4L,6L,7L,1L,5L,1L,0L,7L,0L,1L,3L,7L,4L,2L,2L,8L,7L,0L,5L,7L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155840Inst : IEnumerable<long>
{
public static readonly long[] Value=A155840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155840.Bytes);
public long this[int i]=>Value[i];

public static A155840Inst Instance=new A155840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155841
{
public static readonly BigInteger[] Value={ 17L,47L,149L,2081L,8231L,140737488355469L,BigInteger.Parse("300613450595050653169853516389035139504087366260264943450533244356122755214669880763353471793250393988087678029") };
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
public class A155841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155841Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155841.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155841Inst Instance=new A155841Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155842
{
public static readonly BigInteger[] Value={ 23L,163L,137438953657L,2305843009213694257L,BigInteger.Parse("862718293348820473429344482784628181556388621521298319395315527976057"),BigInteger.Parse("19239260838083241802870625048898248928261591440656956380834127638791856333738872368854622194768025215237611325257") };
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
public class A155842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155842Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155842.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155842Inst Instance=new A155842Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155843
{
public static readonly BigInteger[] Value={ 191L,536871173L,2199023255921L,BigInteger.Parse("10384593717069655257060992658441209") };
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
public class A155843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155843Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155843.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155843Inst Instance=new A155843Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155844
{
public static readonly BigInteger[] Value={ 47L,97L,131293L,140737488355939L,BigInteger.Parse("2361183241434822607771") };
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
public class A155844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155844Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155844.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155844Inst Instance=new A155844Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155845
{
public static readonly BigInteger[] Value={ -2L,17L,107L,524231L,8388539L,BigInteger.Parse("162259276829213363391578010287807") };
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
public class A155845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155845Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155845.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155845Inst Instance=new A155845Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155846
{
public static readonly long[] Value={ -7L,7L,1993L,130987L,536870767L,9007199254740727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155846Inst : IEnumerable<long>
{
public static readonly long[] Value=A155846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155846.Bytes);
public long this[int i]=>Value[i];

public static A155846Inst Instance=new A155846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155847
{
public static readonly long[] Value={ -13L,-3L,79L,8101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155847Inst : IEnumerable<long>
{
public static readonly long[] Value=A155847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155847.Bytes);
public long this[int i]=>Value[i];

public static A155847Inst Instance=new A155847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155848
{
public static readonly BigInteger[] Value={ -19L,-13L,1949L,BigInteger.Parse("2535301200456458802993406409843") };
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
public class A155848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155848Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155848.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155848Inst Instance=new A155848Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155849
{
public static readonly BigInteger[] Value={ -37L,-43L,23L,130817L,BigInteger.Parse("2535301200456458802993406409237"),BigInteger.Parse("36499524940977561749129372845602330599145828057988479444633540143194201337669419092047302490538971198229138476588755258485509637771003503986021290557777713506015957394882119600662993537972820563") };
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
public class A155849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155849Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155849.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155849Inst Instance=new A155849Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155850
{
public static readonly long[] Value={ 2L,4L,3L,5L,7L,15L,17L,31L,65L,129L,127L,449L,511L,2561L,1025L,7937L,12799L,20481L,8191L,28673L,65537L,131071L,458751L,360449L,966655L,524287L,4194303L,2097151L,29360129L,34865153L,67108865L,134217729L,33554431L,608174081L,268435457L,536870911L,4831838207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155850Inst : IEnumerable<long>
{
public static readonly long[] Value=A155850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155850.Bytes);
public long this[int i]=>Value[i];

public static A155850Inst Instance=new A155850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155851
{
public static readonly long[] Value={ 5L,23L,53L,233L,563L,1259L,2579L,2909L,12713L,22543L,28099L,31729L,39607L,41017L,42463L,87511L,110359L,115279L,117787L,138863L,141671L,213533L,242243L,257353L,265117L,269069L,289171L,310019L,318557L,327193L,331603L,354097L,372607L,441101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155851Inst : IEnumerable<long>
{
public static readonly long[] Value=A155851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155851.Bytes);
public long this[int i]=>Value[i];

public static A155851Inst Instance=new A155851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155852
{
public static readonly long[] Value={ 3L,509L,146749L,26444543L,187206119L,735187721L,1662266153L,2146936021L,2844048943L,4335869143L,5539721989L,5990371801L,6145377247L,6788645863L,10092092897L,19122368737L,20186509381L,25745240897L,32732349829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155852Inst : IEnumerable<long>
{
public static readonly long[] Value=A155852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155852.Bytes);
public long this[int i]=>Value[i];

public static A155852Inst Instance=new A155852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155853
{
public static readonly long[] Value={ 0L,2L,8L,16L,20L,28L,32L,40L,46L,50L,58L,62L,68L,76L,82L,98L,100L,106L,110L,112L,116L,128L,130L,140L,146L,152L,160L,166L,170L,172L,188L,190L,196L,208L,218L,232L,250L,256L,266L,272L,278L,280L,296L,298L,302L,308L,316L,326L,338L,340L,358L,368L,370L,380L,382L,386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155853Inst : IEnumerable<long>
{
public static readonly long[] Value=A155853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155853.Bytes);
public long this[int i]=>Value[i];

public static A155853Inst Instance=new A155853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155854
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,7L,9L,10L,11L,12L,13L,14L,15L,17L,18L,19L,21L,22L,23L,24L,25L,26L,27L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,47L,48L,49L,51L,52L,53L,54L,55L,56L,57L,59L,60L,61L,63L,64L,65L,66L,67L,69L,70L,71L,72L,73L,74L,75L,77L,78L,79L,80L,81L,83L,84L,85L,86L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155854Inst : IEnumerable<long>
{
public static readonly long[] Value=A155854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155854.Bytes);
public long this[int i]=>Value[i];

public static A155854Inst Instance=new A155854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155855
{
public static readonly long[] Value={ 1L,1L,5L,7L,8L,4L,1L,9L,8L,3L,3L,7L,7L,1L,7L,8L,3L,8L,5L,3L,5L,4L,7L,6L,4L,9L,2L,1L,7L,2L,0L,4L,3L,3L,9L,0L,0L,0L,5L,1L,9L,9L,6L,2L,0L,2L,6L,3L,8L,2L,4L,8L,1L,2L,7L,8L,1L,9L,8L,3L,3L,6L,9L,2L,4L,3L,6L,0L,8L,5L,8L,6L,3L,2L,8L,7L,7L,3L,4L,6L,3L,5L,9L,7L,6L,4L,9L,4L,8L,8L,4L,4L,3L,8L,2L,0L,5L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155855Inst : IEnumerable<long>
{
public static readonly long[] Value=A155855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155855.Bytes);
public long this[int i]=>Value[i];

public static A155855Inst Instance=new A155855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155856
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,6L,10L,6L,1L,24L,42L,30L,10L,1L,120L,216L,168L,70L,15L,1L,720L,1320L,1080L,504L,140L,21L,1L,5040L,9360L,7920L,3960L,1260L,252L,28L,1L,40320L,75600L,65520L,34320L,11880L,2772L,420L,36L,1L,362880L,685440L,604800L,327600L,120120L,30888L,5544L,660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155856Inst : IEnumerable<long>
{
public static readonly long[] Value=A155856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155856.Bytes);
public long this[int i]=>Value[i];

public static A155856Inst Instance=new A155856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155857
{
public static readonly long[] Value={ 1L,2L,6L,23L,107L,590L,3786L,27821L,230869L,2137978L,21873854L,245151555L,2987967551L,39358156310L,557259550034L,8440866957273L,136211005966889L,2333068710452146L,42276699542130166L,808068680469402095L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155857Inst : IEnumerable<long>
{
public static readonly long[] Value=A155857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155857.Bytes);
public long this[int i]=>Value[i];

public static A155857Inst Instance=new A155857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155858
{
public static readonly long[] Value={ 1L,1L,3L,9L,35L,168L,967L,6538L,50831L,446919L,4383861L,47451921L,561715093L,7217604520L,100031995789L,1487319385140L,23613262336093L,398673670050021L,7132188802005991L,134766129577134553L,2681929390235577831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155858Inst : IEnumerable<long>
{
public static readonly long[] Value=A155858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155858.Bytes);
public long this[int i]=>Value[i];

public static A155858Inst Instance=new A155858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155859
{
public static readonly BigInteger[] Value={ 4L,38L,377L,3766L,37655L,376544L,3765433L,37654322L,376543211L,3765432100L,37654320989L,376543209878L,3765432098767L,37654320987656L,376543209876545L,3765432098765434L,37654320987654323L,376543209876543212L,3765432098765432101L,BigInteger.Parse("37654320987654320990") };
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
public class A155859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155859Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155859.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155859Inst Instance=new A155859Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155860
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,2L,2L,3L,4L,5L,3L,5L,7L,4L,7L,9L,5L,6L,9L,5L,7L,11L,6L,6L,12L,5L,9L,13L,8L,10L,12L,4L,11L,15L,6L,10L,15L,5L,9L,16L,9L,9L,17L,8L,8L,17L,8L,10L,16L,8L,11L,13L,10L,10L,20L,7L,12L,23L,10L,10L,21L,9L,11L,18L,11L,8L,18L,9L,11L,20L,9L,13L,17L,9L,12L,19L,9L,13L,22L,6L,13L,21L,10L,10L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155860Inst : IEnumerable<long>
{
public static readonly long[] Value=A155860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155860.Bytes);
public long this[int i]=>Value[i];

public static A155860Inst Instance=new A155860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155861
{
public static readonly long[] Value={ 1L,2L,8L,26L,68L,134L,228L,352L,510L,704L,934L,1204L,1514L,1866L,2260L,2702L,3188L,3722L,4304L,4936L,5620L,6354L,7140L,7980L,8872L,9822L,10826L,11888L,13006L,14182L,15416L,16712L,18066L,19480L,20956L,22494L,24096L,25760L,27486L,29278L,31134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155861Inst : IEnumerable<long>
{
public static readonly long[] Value=A155861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155861.Bytes);
public long this[int i]=>Value[i];

public static A155861Inst Instance=new A155861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155862
{
public static readonly long[] Value={ 1L,4L,22L,130L,790L,4870L,30274L,189202L,1186702L,7461982L,47007034L,296527162L,1872479350L,11833642006L,74833075570L,473463268642L,2996771766046L,18974162475598L,120167557286314L,761214481604554L,4822871486667526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155862Inst : IEnumerable<long>
{
public static readonly long[] Value=A155862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155862.Bytes);
public long this[int i]=>Value[i];

public static A155862Inst Instance=new A155862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155863
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,24L,24L,1L,1L,60L,120L,60L,1L,1L,120L,360L,360L,120L,1L,1L,210L,840L,1260L,840L,210L,1L,1L,336L,1680L,3360L,3360L,1680L,336L,1L,1L,504L,3024L,7560L,10080L,7560L,3024L,504L,1L,1L,720L,5040L,15120L,25200L,25200L,15120L,5040L,720L,1L,1L,990L,7920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155863Inst : IEnumerable<long>
{
public static readonly long[] Value=A155863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155863.Bytes);
public long this[int i]=>Value[i];

public static A155863Inst Instance=new A155863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155864
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,6L,6L,1L,1L,12L,24L,12L,1L,1L,20L,60L,60L,20L,1L,1L,30L,120L,180L,120L,30L,1L,1L,42L,210L,420L,420L,210L,42L,1L,1L,56L,336L,840L,1120L,840L,336L,56L,1L,1L,72L,504L,1512L,2520L,2520L,1512L,504L,72L,1L,1L,90L,720L,2520L,5040L,6300L,5040L,2520L,720L,90L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155864Inst : IEnumerable<long>
{
public static readonly long[] Value=A155864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155864.Bytes);
public long this[int i]=>Value[i];

public static A155864Inst Instance=new A155864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155865
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,3L,6L,3L,1L,1L,4L,12L,12L,4L,1L,1L,5L,20L,30L,20L,5L,1L,1L,6L,30L,60L,60L,30L,6L,1L,1L,7L,42L,105L,140L,105L,42L,7L,1L,1L,8L,56L,168L,280L,280L,168L,56L,8L,1L,1L,9L,72L,252L,504L,630L,504L,252L,72L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155865Inst : IEnumerable<long>
{
public static readonly long[] Value=A155865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155865.Bytes);
public long this[int i]=>Value[i];

public static A155865Inst Instance=new A155865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155866
{
public static readonly long[] Value={ 1L,2L,6L,22L,91L,413L,2032L,10754L,60832L,365815L,2327835L,15612872L,109992442L,811500784L,6253327841L,50211976959L,419239644142L,3632891419054L,32616077413970L,302915722319509L,2906047810600157L,28761123170398258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155866Inst : IEnumerable<long>
{
public static readonly long[] Value=A155866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155866.Bytes);
public long this[int i]=>Value[i];

public static A155866Inst Instance=new A155866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155867
{
public static readonly long[] Value={ 1L,3L,13L,65L,355L,2061L,12501L,78323L,503033L,3294373L,21916883L,147708777L,1006330457L,6919474163L,47956087733L,334658965641L,2349535729811L,16583609673797L,117608812053277L,837626242775875L,5988634758319665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155867Inst : IEnumerable<long>
{
public static readonly long[] Value=A155867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155867.Bytes);
public long this[int i]=>Value[i];

public static A155867Inst Instance=new A155867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155868
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,6L,6L,1L,1L,36L,121L,36L,1L,1L,240L,1750L,1750L,240L,1L,1L,1800L,23290L,50625L,23290L,1800L,1L,1L,15120L,308700L,1193640L,1193640L,308700L,15120L,1L,1L,141120L,4207896L,25738720L,45819361L,25738720L,4207896L,141120L,1L,1L,1451520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155868Inst : IEnumerable<long>
{
public static readonly long[] Value=A155868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155868.Bytes);
public long this[int i]=>Value[i];

public static A155868Inst Instance=new A155868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155869
{
public static readonly long[] Value={ 2L,1L,1L,1L,1L,1L,1L,6L,6L,1L,1L,28L,84L,28L,1L,1L,120L,792L,792L,120L,1L,1L,495L,6435L,12870L,6435L,495L,1L,1L,2002L,48620L,167960L,167960L,48620L,2002L,1L,1L,8008L,352716L,1961256L,3268760L,1961256L,352716L,8008L,1L,1L,31824L,2496144L,21474180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155869Inst : IEnumerable<long>
{
public static readonly long[] Value=A155869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155869.Bytes);
public long this[int i]=>Value[i];

public static A155869Inst Instance=new A155869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155870
{
public static readonly long[] Value={ 1L,10L,2200L,44440000L,8888888800000000L,77777770000000L,5555500000L,18L,2209L,44440010L,8888888800000011L,77777770000012L,5555500013L,24L,2215L,44440016L,8888888800000017L,77777770000018L,5555500019L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155870Inst : IEnumerable<long>
{
public static readonly long[] Value=A155870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155870.Bytes);
public long this[int i]=>Value[i];

public static A155870Inst Instance=new A155870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155871
{
public static readonly long[] Value={ 1L,1L,-16L,-110L,-16L,-117L,-1322L,-1322L,-117L,-512L,-9703L,-22288L,-9703L,-512L,-1843L,-58977L,-256363L,-256363L,-58977L,-1843L,-6048L,-328588L,-2477728L,-4664934L,-2477728L,-328588L,-6048L,-18953L,-1751300L,-21692852L,-69388094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155871Inst : IEnumerable<long>
{
public static readonly long[] Value=A155871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155871.Bytes);
public long this[int i]=>Value[i];

public static A155871Inst Instance=new A155871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155872
{
public static readonly long[] Value={ 2L,21L,221L,2331L,24641L,261051L,2771561L,29487171L,314358881L,3357947691L,35937424601L,385311670611L,4138428376721L,44522712143931L,479749833583241L,5177248169415651L,55949729863572161L,605447028499293771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155872Inst : IEnumerable<long>
{
public static readonly long[] Value=A155872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155872.Bytes);
public long this[int i]=>Value[i];

public static A155872Inst Instance=new A155872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155873
{
public static readonly long[] Value={ 2L,3L,5L,7L,23L,37L,59L,73L,233L,373L,593L,739L,2339L,3733L,5939L,7393L,23399L,37337L,59393L,73939L,233993L,373379L,593933L,739391L,2339933L,3733799L,5939333L,7393913L,23399339L,37337999L,59393339L,73939133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155873Inst : IEnumerable<long>
{
public static readonly long[] Value=A155873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155873.Bytes);
public long this[int i]=>Value[i];

public static A155873Inst Instance=new A155873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155874
{
public static readonly long[] Value={ 4L,8L,4L,6L,4L,4L,4L,8L,4L,6L,4L,4L,4L,8L,4L,6L,4L,4L,4L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155874Inst : IEnumerable<long>
{
public static readonly long[] Value=A155874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155874.Bytes);
public long this[int i]=>Value[i];

public static A155874Inst Instance=new A155874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155875
{
public static readonly long[] Value={ 4L,9L,6L,9L,8L,9L,10L,15L,12L,15L,14L,15L,16L,21L,18L,21L,20L,21L,22L,25L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155875Inst : IEnumerable<long>
{
public static readonly long[] Value=A155875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155875.Bytes);
public long this[int i]=>Value[i];

public static A155875Inst Instance=new A155875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155876
{
public static readonly long[] Value={ 1L,1L,3L,0L,8L,9L,0L,4L,8L,9L,0L,1L,4L,2L,5L,3L,2L,1L,8L,0L,7L,3L,5L,3L,7L,0L,6L,1L,0L,4L,0L,6L,6L,7L,2L,1L,1L,1L,2L,4L,7L,0L,6L,2L,8L,1L,3L,6L,0L,6L,3L,8L,7L,6L,4L,8L,7L,3L,6L,1L,0L,9L,3L,3L,0L,0L,3L,6L,9L,4L,5L,3L,6L,3L,9L,0L,6L,9L,1L,1L,7L,4L,0L,2L,7L,6L,8L,8L,6L,3L,1L,4L,6L,5L,5L,2L,2L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155876Inst : IEnumerable<long>
{
public static readonly long[] Value=A155876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155876.Bytes);
public long this[int i]=>Value[i];

public static A155876Inst Instance=new A155876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155877
{
public static readonly long[] Value={ 9L,11L,13L,15L,23L,25L,27L,37L,39L,51L,263L,265L,267L,277L,279L,291L,517L,519L,531L,771L,65543L,65545L,65547L,65557L,65559L,65571L,65797L,65799L,65811L,66051L,131077L,131079L,131091L,131331L,196611L,4294967303L,4294967305L,4294967307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155877Inst : IEnumerable<long>
{
public static readonly long[] Value=A155877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155877.Bytes);
public long this[int i]=>Value[i];

public static A155877Inst Instance=new A155877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155878
{
public static readonly long[] Value={ 4L,8L,10L,12L,14L,15L,16L,18L,20L,21L,22L,24L,26L,27L,28L,30L,32L,33L,34L,35L,36L,39L,40L,42L,44L,45L,46L,48L,49L,51L,52L,54L,55L,57L,58L,60L,62L,63L,64L,65L,66L,69L,70L,72L,74L,75L,76L,77L,78L,80L,82L,84L,86L,87L,88L,90L,91L,93L,94L,95L,96L,98L,99L,102L,104L,105L,106L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155878Inst : IEnumerable<long>
{
public static readonly long[] Value=A155878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155878.Bytes);
public long this[int i]=>Value[i];

public static A155878Inst Instance=new A155878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155879
{
public static readonly long[] Value={ 4L,9L,10L,12L,14L,15L,16L,21L,22L,24L,25L,26L,27L,28L,30L,33L,34L,35L,36L,39L,40L,42L,44L,45L,46L,49L,50L,51L,52L,54L,55L,56L,57L,58L,60L,62L,63L,64L,65L,66L,68L,69L,70L,75L,76L,77L,78L,80L,81L,82L,84L,85L,86L,87L,88L,90L,91L,92L,93L,94L,95L,96L,98L,99L,100L,104L,105L,106L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155879Inst : IEnumerable<long>
{
public static readonly long[] Value=A155879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155879.Bytes);
public long this[int i]=>Value[i];

public static A155879Inst Instance=new A155879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155880
{
public static readonly long[] Value={ 1L,1L,0L,6L,6L,9L,1L,8L,8L,4L,8L,5L,4L,7L,3L,1L,1L,5L,5L,3L,9L,4L,5L,0L,5L,4L,9L,0L,5L,8L,6L,0L,0L,3L,2L,1L,0L,4L,0L,1L,7L,3L,4L,2L,2L,5L,0L,8L,2L,2L,6L,0L,3L,1L,2L,2L,0L,0L,9L,6L,2L,1L,4L,5L,3L,4L,9L,7L,8L,8L,7L,5L,5L,7L,8L,6L,5L,3L,4L,2L,6L,0L,0L,6L,1L,8L,2L,5L,0L,4L,1L,5L,1L,8L,2L,8L,0L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155880Inst : IEnumerable<long>
{
public static readonly long[] Value=A155880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155880.Bytes);
public long this[int i]=>Value[i];

public static A155880Inst Instance=new A155880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155881
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,2L,3L,5L,8L,24L,43L,67L,121L,188L,409L,708L,1228L,1946L,4131L,6241L,10525L,17866L,29428L,58369L,87881L,156261L,255242L,412545L,767846L,1280460L,2059307L,3343656L,5510186L,9861418L,16472261L,26422596L,43917688L,73697381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155881Inst : IEnumerable<long>
{
public static readonly long[] Value=A155881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155881.Bytes);
public long this[int i]=>Value[i];

public static A155881Inst Instance=new A155881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155882
{
public static readonly long[] Value={ 5L,11L,17L,31L,41L,53L,61L,83L,89L,103L,131L,137L,157L,167L,179L,199L,227L,233L,271L,281L,293L,307L,317L,331L,367L,383L,401L,409L,431L,439L,463L,503L,509L,547L,557L,563L,577L,599L,619L,643L,653L,661L,673L,701L,709L,733L,821L,829L,859L,887L,911L,967L,983L,991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155882Inst : IEnumerable<long>
{
public static readonly long[] Value=A155882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155882.Bytes);
public long this[int i]=>Value[i];

public static A155882Inst Instance=new A155882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155883
{
public static readonly long[] Value={ 1L,33L,173L,505L,1113L,2081L,3493L,5433L,7985L,11233L,15261L,20153L,25993L,32865L,40853L,50041L,60513L,72353L,85645L,100473L,116921L,135073L,155013L,176825L,200593L,226401L,254333L,284473L,316905L,351713L,388981L,428793L,471233L,516385L,564333L,615161L,668953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155883Inst : IEnumerable<long>
{
public static readonly long[] Value=A155883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155883.Bytes);
public long this[int i]=>Value[i];

public static A155883Inst Instance=new A155883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155884
{
public static readonly long[] Value={ 41L,43L,47L,53L,61L,71L,83L,97L,113L,131L,151L,173L,197L,223L,251L,281L,313L,347L,383L,421L,461L,503L,547L,593L,641L,691L,743L,797L,853L,911L,971L,1033L,1097L,1163L,1231L,1301L,1373L,1447L,1523L,1601L,41L,43L,1847L,1933L,61L,2111L,2203L,2297L,2393L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155884Inst : IEnumerable<long>
{
public static readonly long[] Value=A155884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155884.Bytes);
public long this[int i]=>Value[i];

public static A155884Inst Instance=new A155884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155885
{
public static readonly long[] Value={ 22L,3233L,424344L,52535455L,6263646566L,727374757677L,82838485868788L,9293949596979899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155885Inst : IEnumerable<long>
{
public static readonly long[] Value=A155885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155885.Bytes);
public long this[int i]=>Value[i];

public static A155885Inst Instance=new A155885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155886
{
public static readonly long[] Value={ 1L,3L,14L,11L,6L,1941491L,10L,83L,31L,13L,123L,35L,71L,27L,34913L,241L,18L,8059L,34L,349L,44L,25L,39L,100867561L,76L,231L,253L,66203L,57L,227L,139L,45L,184L,37L,111L,97L,55L,41L,103L,1099L,81L,66791L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155886Inst : IEnumerable<long>
{
public static readonly long[] Value=A155886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155886.Bytes);
public long this[int i]=>Value[i];

public static A155886Inst Instance=new A155886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155887
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,5L,4L,1L,0L,15L,14L,6L,1L,0L,51L,50L,27L,8L,1L,0L,188L,187L,113L,44L,10L,1L,0L,731L,730L,468L,212L,65L,12L,1L,0L,2950L,2949L,1956L,970L,355L,90L,14L,1L,0L,12235L,12234L,8291L,4356L,1785L,550L,119L,16L,1L,0L,51822L,51821L,35643L,19474L,8612L,3021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155887Inst : IEnumerable<long>
{
public static readonly long[] Value=A155887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155887.Bytes);
public long this[int i]=>Value[i];

public static A155887Inst Instance=new A155887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155888
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,43L,143L,506L,1870L,7107L,27474L,107274L,421268L,1659725L,6551041L,25884007L,102330007L,404682554L,1600678795L,6331951858L,25049290301L,99098453901L,392054049162L,1551062360070L,6136418173129L,24277388110318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155888Inst : IEnumerable<long>
{
public static readonly long[] Value=A155888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155888.Bytes);
public long this[int i]=>Value[i];

public static A155888Inst Instance=new A155888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155889
{
public static readonly long[] Value={ 1L,0L,8L,4L,8L,0L,6L,5L,5L,0L,3L,5L,5L,7L,9L,3L,6L,8L,2L,9L,4L,4L,6L,5L,0L,9L,3L,7L,3L,2L,8L,0L,9L,7L,4L,8L,9L,0L,6L,4L,8L,7L,3L,9L,3L,2L,7L,6L,7L,5L,1L,2L,3L,0L,2L,4L,7L,9L,7L,7L,8L,3L,8L,7L,6L,5L,2L,7L,0L,4L,2L,0L,4L,5L,3L,8L,0L,4L,7L,0L,7L,6L,2L,3L,5L,1L,7L,5L,5L,8L,5L,7L,8L,3L,2L,0L,8L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155889Inst : IEnumerable<long>
{
public static readonly long[] Value=A155889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155889.Bytes);
public long this[int i]=>Value[i];

public static A155889Inst Instance=new A155889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155890
{
public static readonly long[] Value={ 2L,12L,21L,102L,120L,201L,210L,1002L,1020L,1200L,2001L,2010L,2100L,10002L,10020L,10200L,12000L,20001L,20010L,20100L,21000L,100002L,100020L,100200L,102000L,120000L,200001L,200010L,200100L,201000L,210000L,1000002L,1000020L,1000200L,1002000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155890Inst : IEnumerable<long>
{
public static readonly long[] Value=A155890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155890.Bytes);
public long this[int i]=>Value[i];

public static A155890Inst Instance=new A155890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155891
{
public static readonly long[] Value={ 1L,2L,3L,7L,6L,3L,5L,20L,7L,14L,6L,4L,10L,12L,5L,20L,27L,50L,7L,14L,23L,6L,13L,4L,25L,30L,10L,12L,51L,5L,63L,24L,20L,36L,27L,50L,59L,11L,7L,14L,26L,75L,23L,9L,6L,13L,49L,71L,144L,31L,25L,30L,199L,19L,10L,46L,12L,51L,83L,5L,28L,73L,63L,62L,24L,54L,20L,36L,67L,27L,40L,74L,50L,59L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155891Inst : IEnumerable<long>
{
public static readonly long[] Value=A155891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155891.Bytes);
public long this[int i]=>Value[i];

public static A155891Inst Instance=new A155891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155892
{
public static readonly long[] Value={ 1L,2L,12L,5L,13L,3L,19L,4L,31L,18L,12L,21L,5L,33L,17L,13L,34L,8L,38L,7L,19L,92L,24L,4L,11L,6L,46L,39L,31L,22L,18L,77L,12L,55L,32L,75L,21L,52L,74L,5L,15L,33L,61L,122L,166L,17L,47L,13L,65L,54L,49L,148L,34L,71L,8L,117L,107L,60L,38L,51L,10L,7L,111L,25L,19L,92L,123L,128L,29L,24L,56L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155892Inst : IEnumerable<long>
{
public static readonly long[] Value=A155892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155892.Bytes);
public long this[int i]=>Value[i];

public static A155892Inst Instance=new A155892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155893
{
public static readonly long[] Value={ 1L,2L,4L,16L,13L,3L,46L,27L,7L,14L,6L,32L,10L,39L,5L,20L,86L,50L,11L,26L,121L,18L,38L,4L,31L,199L,34L,12L,139L,28L,63L,62L,61L,67L,60L,125L,59L,16L,37L,58L,47L,108L,23L,21L,41L,13L,112L,71L,194L,56L,25L,30L,302L,19L,166L,46L,55L,150L,83L,116L,219L,73L,90L,140L,164L,54L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155893Inst : IEnumerable<long>
{
public static readonly long[] Value=A155893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155893.Bytes);
public long this[int i]=>Value[i];

public static A155893Inst Instance=new A155893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155894
{
public static readonly long[] Value={ 1L,2L,10L,36L,9L,3L,5L,24L,8L,43L,82L,25L,30L,46L,64L,62L,60L,68L,7L,14L,70L,18L,13L,4L,31L,272L,19L,12L,97L,35L,161L,140L,20L,86L,27L,74L,131L,11L,502L,234L,47L,181L,386L,21L,6L,996L,52L,232L,144L,32L,393L,189L,199L,281L,10L,490L,39L,154L,83L,22L,28L,577L,63L,65L,88L,61L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155894Inst : IEnumerable<long>
{
public static readonly long[] Value=A155894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155894.Bytes);
public long this[int i]=>Value[i];

public static A155894Inst Instance=new A155894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155895
{
public static readonly long[] Value={ 1L,2L,17L,4L,6L,3L,29L,7L,10L,19L,31L,8L,18L,14L,37L,61L,81L,17L,33L,11L,63L,94L,9L,4L,13L,24L,16L,6L,27L,22L,52L,152L,28L,21L,143L,45L,35L,29L,67L,7L,62L,15L,247L,181L,193L,10L,105L,48L,12L,97L,19L,167L,36L,72L,146L,75L,31L,391L,69L,40L,186L,486L,133L,8L,57L,46L,18L,103L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155895Inst : IEnumerable<long>
{
public static readonly long[] Value=A155895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155895.Bytes);
public long this[int i]=>Value[i];

public static A155895Inst Instance=new A155895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155896
{
public static readonly long[] Value={ 1L,2L,5L,4L,8L,3L,9L,26L,52L,18L,25L,10L,33L,53L,32L,15L,13L,20L,30L,5L,17L,42L,7L,4L,23L,43L,78L,50L,28L,113L,8L,44L,19L,334L,59L,100L,195L,27L,22L,14L,91L,172L,371L,16L,93L,9L,12L,102L,66L,26L,46L,95L,279L,303L,69L,331L,272L,52L,286L,79L,264L,298L,18L,21L,190L,104L,47L,138L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155896Inst : IEnumerable<long>
{
public static readonly long[] Value=A155896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155896.Bytes);
public long this[int i]=>Value[i];

public static A155896Inst Instance=new A155896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155897
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155897Inst : IEnumerable<long>
{
public static readonly long[] Value=A155897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155897.Bytes);
public long this[int i]=>Value[i];

public static A155897Inst Instance=new A155897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155898
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155898Inst : IEnumerable<long>
{
public static readonly long[] Value=A155898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155898.Bytes);
public long this[int i]=>Value[i];

public static A155898Inst Instance=new A155898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155899
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155899Inst : IEnumerable<long>
{
public static readonly long[] Value=A155899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155899.Bytes);
public long this[int i]=>Value[i];

public static A155899Inst Instance=new A155899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155900
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,13L,16L,17L,19L,27L,31L,32L,49L,61L,89L,107L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155900Inst : IEnumerable<long>
{
public static readonly long[] Value=A155900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155900.Bytes);
public long this[int i]=>Value[i];

public static A155900Inst Instance=new A155900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155901
{
public static readonly long[] Value={ 2L,8L,5L,12L,5L,14L,8L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155901Inst : IEnumerable<long>
{
public static readonly long[] Value=A155901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155901.Bytes);
public long this[int i]=>Value[i];

public static A155901Inst Instance=new A155901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155902
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,7L,8L,10L,11L,12L,14L,15L,17L,18L,20L,21L,22L,24L,25L,27L,28L,30L,31L,32L,34L,35L,37L,38L,40L,41L,43L,44L,45L,47L,48L,50L,51L,53L,54L,55L,57L,58L,60L,61L,63L,64L,65L,67L,68L,70L,71L,73L,74L,76L,77L,78L,80L,81L,83L,84L,86L,87L,88L,90L,91L,93L,94L,96L,97L,98L,100L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155902Inst : IEnumerable<long>
{
public static readonly long[] Value=A155902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155902.Bytes);
public long this[int i]=>Value[i];

public static A155902Inst Instance=new A155902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155903
{
public static readonly long[] Value={ 13L,37L,151L,1453L,12697L,106033L,151687L,362953L,712891L,1040503L,5767381L,7004353L,7004353L,13709041L,18260617L,31955503L,46397161L,59015191L,98184703L,102065653L,127516537L,208879507L,286625461L,441290203L,866431387L,916441453L,1299786853L,1574390317L,1830772297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155903Inst : IEnumerable<long>
{
public static readonly long[] Value=A155903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155903.Bytes);
public long this[int i]=>Value[i];

public static A155903Inst Instance=new A155903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155904
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,2L,2L,2L,2L,4L,3L,5L,6L,4L,5L,4L,4L,6L,5L,6L,7L,7L,5L,7L,11L,5L,10L,8L,5L,10L,7L,5L,8L,8L,7L,6L,10L,6L,8L,13L,9L,12L,10L,8L,14L,10L,7L,13L,12L,7L,10L,10L,9L,10L,17L,8L,11L,11L,9L,16L,12L,7L,13L,8L,10L,7L,8L,10L,11L,14L,5L,14L,14L,10L,17L,12L,7L,11L,12L,10L,12L,10L,12L,13L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155904Inst : IEnumerable<long>
{
public static readonly long[] Value=A155904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155904.Bytes);
public long this[int i]=>Value[i];

public static A155904Inst Instance=new A155904Inst();

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